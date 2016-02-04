using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using BusinessLogic.Common;
using BusinessLogic.Exceptions;
using System.Drawing;

namespace BusinessLogic
{
    /// <summary>
    /// Handle the business logic
    /// </summary>
    public class BusinessLogicHandler
    {

        #region Methods

        /// <summary>
        /// Get a list of all categories sorted by name
        /// </summary>
        /// <returns>List with categories</returns>
        public List<Category> GetCategories()
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var cat = from c in context.Categories
                          orderby c.Name
                          select c;

                return cat.ToList();
            }
        }

        /// <summary>
        /// Get a category by it's ID
        /// </summary>
        /// <param name="catId">The ID of the category</param>
        /// <returns>Category</returns>
        public Category GetCategoryById(int catId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var cat = from c in context.Categories
                          where c.CategoryId == catId
                          select c;

                return (Category)cat.First();
            }
        }

        /// <summary>
        /// Get a categories by for a given parent category ID ID
        /// </summary>
        /// <param name="parentCatId">The ID of the parent category</param>
        /// <returns>List of categories</returns>
        public List<Category> GetCategoriesByParentId(int parentCatId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var cats = context.Categories
                            .Include("ParentCategory")
                            .Where(c => c.ParentCategory.CategoryId == parentCatId);

                return cats.ToList();
            }
        }

        /// <summary>
        /// Get all categories for a given media type.
        /// Sorted alphabetically by category name
        /// </summary>
        /// <param name="mediaTypeId">The ID of the media type</param>
        /// <returns>List with categories</returns>
        public List<Category> GetCategoriesByMediaTypeId(int mediaTypeId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                List<Category> catList = new List<Category>();

                var mainCat = context.Categories.FirstOrDefault(c => c.CategoryId == mediaTypeId);
                catList.Add(mainCat);

                AddAllChildCategories(catList, mainCat.CategoryId);

                catList.Sort();

                return catList;
            }
        }

        /// <summary>
        /// Adds all child categories and the children of the children to a category list.
        /// </summary>
        /// <param name="catList">List with categories</param>
        /// <param name="parentCatId">The parent category ID</param>
        private void AddAllChildCategories(List<Category> catList, int parentCatId)
        {
            List<Category> cats = GetCategoriesByParentId(parentCatId);

            foreach (Category cat in cats)
            {
                catList.Add(cat);

                // recursion to add the children of this child node
                AddAllChildCategories(catList, cat.CategoryId);
            }
        }

        /// <summary>
        /// Get media type ID for a given media.
        /// </summary>
        /// <param name="mediaId">The ID of the media.</param>
        /// <returns>The media type ID for the given media ID.</returns>
        public int GetMediaTypeByMediaId(int mediaId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var mt =    from m in context.MediaSet.Include("MediaType")
                            where m.MediaId == mediaId
                            select m.MediaType;

                return mt.First().MediaTypeId;
            }
        }

        /// <summary>
        /// Flag a media as deleted
        /// (Media isn't deleted from database, only flagged).
        /// </summary>
        /// <param name="mediaId"></param>
        public void FlagMediaAsDeleted(int mediaId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var media =
                    context.MediaSet.FirstOrDefault(m => m.MediaId == mediaId);

                // check if lendings exists
                media.Rentings.Load();

                var rents = from r in media.Rentings
                            where r.CheckInDate == null
                            select r;

                if (rents.ToList().Count > 0)
                {
                    throw new ConditionException(Localization.MsgMediaInUse);
                }
                else
                {
                    media.Deleted = true;
                    context.SaveChanges();

                    // delete all open reservations
                    DeleteOpenReservationsByMedia(media.MediaId);
                }
            }
        }

        /// <summary>
        /// Create a new media
        /// </summary>
        /// <param name="mediaTypeId">The type ID of the media</param>
        /// <param name="title">The title of the media</param>
        /// <param name="description">The description of the media</param>
        /// <param name="categoryId">The category of the media</param>
        /// <returns>The ID of the created media</returns>
        public int CreateMedia(int mediaTypeId,
            string title,
            string description,
            int categoryId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                Media media = null;

                switch (mediaTypeId)
                {
                    case 1:
                        media = new MediaBook();
                        break;
                    case 2:
                        media = new MediaMusic();
                        break;
                    case 3:
                        media = new MediaVideo();
                        break;
                    case 4:
                        media = new MediaMisc();
                        break;
                    default:
                        throw new ConditionException(Localization.MsgErrorMediaTypeUnknown);
                }

                media.Title = title;
                media.Description = description;
                media.Category = context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
                media.CreationDate = DateTime.Now;

                // set media state to "available"
                media.MediaState = context.MediaStates.FirstOrDefault(s => s.MediaSateId == 1);

                // set media type
                media.MediaType = context.MediaTypes.FirstOrDefault(mt => mt.MediaTypeId == mediaTypeId);

                context.AddToMediaSet(media);
                context.SaveChanges();

                // give back the ID of the created media
                return media.MediaId;
            }
        }

        /// <summary>
        /// Create a new MediaBook in the database
        /// </summary>
        /// <param name="title">The title of the media</param>
        /// <param name="description">The description</param>
        /// <param name="author">The author</param>
        /// <param name="publisher">The publisher</param>
        /// <param name="publishingYear">The publishing year</param>
        /// <param name="tag">The tag</param>
        /// <param name="categoryId">The category ID</param>
        public void CreateMediaBook(string title,
            string description,
            string author,
            string publisher,
            int? publishingYear,
            string tag,
            int categoryId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                MediaBook media = new MediaBook();
                media.Title = title;
                media.Description = description;
                media.Author = author;
                media.Publisher = publisher;
                media.PublishingYear = publishingYear;
                media.Tag = tag;
                media.Category = context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
                media.CreationDate = DateTime.Now;

                // set media state to "available"
                media.MediaState = context.MediaStates.FirstOrDefault(s => s.MediaSateId == 1);

                // set media type
                media.MediaType = context.MediaTypes.FirstOrDefault(mt => mt.MediaTypeId == 1);

                context.AddToMediaSet(media);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Updates an existing MediaBook in the database
        /// </summary>
        /// <param name="mediaId">The ID of the media</param>
        /// <param name="title">The title of the media</param>
        /// <param name="description">The description</param>
        /// <param name="author">The author</param>
        /// <param name="publisher">The publisher</param>
        /// <param name="publishingYear">The publishing year</param>
        /// <param name="tag">The tag</param>
        /// <param name="categoryId">The category ID</param>
        public void UpdateMediaBook(int mediaId,
            string title,
            string description,
            string author,
            string publisher,
            int? publishingYear,
            string tag,
            int categoryId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var media =
                    context.MediaSet.OfType<MediaBook>().FirstOrDefault(m => m.MediaId == mediaId);
                media.Title = title;
                media.Description = description;
                media.Author = author;
                media.Publisher = publisher;
                media.PublishingYear = publishingYear;
                media.Tag = tag;
                media.Category = context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Create a new MediaBook in the database
        /// </summary>
        /// <param name="title">The title of the media</param>
        /// <param name="description">The description</param>
        /// <param name="director">The director</param>
        /// <param name="actors">Actors</param>
        /// <param name="runtime">The runtime of the video</param>
        /// <param name="tag">The tag</param>
        /// <param name="categoryId">The category ID</param>
        public void CreateMediaVideo(string title,
            string description,
            string director,
            string actors,
            int? runtime,
            string tag,
            int categoryId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                MediaVideo media = new MediaVideo();
                media.Title = title;
                media.Description = description;
                media.Director = director;
                media.Actors = actors;
                media.Length = runtime;
                media.Tag = tag;
                media.Category = context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
                media.CreationDate = DateTime.Now;

                // set media state to "available"
                media.MediaState = context.MediaStates.FirstOrDefault(s => s.MediaSateId == 1);

                // set media type
                media.MediaType = context.MediaTypes.FirstOrDefault(mt => mt.MediaTypeId == 3);

                context.AddToMediaSet(media);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Updates an existing MediaBook in the database
        /// </summary>
        /// <param name="mediaId">The ID of the media</param>
        /// <param name="title">The title of the media</param>
        /// <param name="description">The description</param>
        /// <param name="director">The director</param>
        /// <param name="actors">Actors</param>
        /// <param name="runtime">The runtime of the video</param>
        /// <param name="tag">The tag</param>
        /// <param name="categoryId">The category ID</param>
        public void UpdateMediaVideo(int mediaId,
            string title,
            string description,
            string director,
            string actors,
            int? runtime,
            string tag,
            int categoryId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var media =
                    context.MediaSet.OfType<MediaVideo>().FirstOrDefault(m => m.MediaId == mediaId);
                media.Title = title;
                media.Description = description;
                media.Director = director;
                media.Actors = actors;
                media.Length = runtime;
                media.Tag = tag;
                media.Category = context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Create a new MediaMusic in the database
        /// </summary>
        /// <param name="title">The title of the media</param>
        /// <param name="description">The description</param>
        /// <param name="artist">The artist</param>
        /// <param name="genre">The genre</param>
        /// <param name="tracklist">The tracklist</param>
        /// <param name="tag">The tag</param>
        /// <param name="categoryId">The category ID</param>
        public void CreateMediaMusic(string title,
            string description,
            string artist,
            string genre,
            string tracklist,
            string tag,
            int categoryId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                MediaMusic media = new MediaMusic();
                media.Title = title;
                media.Description = description;
                media.Artist = artist;
                media.Genre = genre;
                media.Tracklist = tracklist;
                media.Tag = tag;
                media.Category = context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
                media.CreationDate = DateTime.Now;

                // set media state to "available"
                media.MediaState = context.MediaStates.FirstOrDefault(s => s.MediaSateId == 1);

                // set media type
                media.MediaType = context.MediaTypes.FirstOrDefault(mt => mt.MediaTypeId == 2);

                context.AddToMediaSet(media);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Updates an existing MediaMusic in the database
        /// </summary>
        /// <param name="mediaId">The ID of the media</param>
        /// <param name="title">The title of the media</param>
        /// <param name="description">The description</param>
        /// <param name="artist">The artist</param>
        /// <param name="genre">The genre</param>
        /// <param name="tracklist">The tracklist</param>
        /// <param name="tag">The tag</param>
        /// <param name="categoryId">The category ID</param>
        public void UpdateMediaMusic(int mediaId,
            string title,
            string description,
            string artist,
            string genre,
            string tracklist,
            string tag,
            int categoryId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var media =
                    context.MediaSet.OfType<MediaMusic>().FirstOrDefault(m => m.MediaId == mediaId);
                media.Title = title;
                media.Description = description;
                media.Artist = artist;
                media.Genre = genre;
                media.Tracklist = tracklist;
                media.Tag = tag;
                media.Category = context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Create a new MediaMisc in the database
        /// </summary>
        /// <param name="title">The title of the media</param>
        /// <param name="description">The description</param>
        /// <param name="shortDescription">The short description</param>
        /// <param name="tag">The tag</param>
        /// <param name="categoryId">The category ID</param>
        public void CreateMediaMisc(string title,
            string description,
            string shortDescription,
            string tag,
            int categoryId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                MediaMisc media = new MediaMisc();
                media.Title = title;
                media.Description = description;
                media.ShortDescription = shortDescription;
                media.Tag = tag;
                media.Category = context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
                media.CreationDate = DateTime.Now;

                // set media state to "available"
                media.MediaState = context.MediaStates.FirstOrDefault(s => s.MediaSateId == 1);

                // set media type
                media.MediaType = context.MediaTypes.FirstOrDefault(mt => mt.MediaTypeId == 4);

                context.AddToMediaSet(media);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Updates an existing MediaMisc in the database
        /// </summary>
        /// <param name="mediaId">The ID of the media</param>
        /// <param name="title">The title of the media</param>
        /// <param name="description">The description</param>
        /// <param name="shortDescription">The short description</param>
        /// <param name="tag">The tag</param>
        /// <param name="categoryId">The category ID</param>
        public void UpdateMediaMisc(int mediaId,
            string title,
            string description,
            string shortDescription,
            string tag,
            int categoryId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var media =
                    context.MediaSet.OfType<MediaMisc>().FirstOrDefault(m => m.MediaId == mediaId);
                media.Title = title;
                media.Description = description;
                media.ShortDescription = shortDescription;
                media.Tag = tag;
                media.Category = context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Get media (book) by it's ID.
        /// Includes MediaState and Category.
        /// </summary>
        /// <param name="id">The ID of the media.</param>
        /// <returns>Media item (book)</returns>
        public MediaBook GetMediaBookById(int id)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var media = from m in context.MediaSet.OfType<MediaBook>().Include("MediaState").Include("Category")
                            where m.MediaId == id
                            select m;

                return media.First();
            }
        }

        /// <summary>
        /// Get media (music) by it's ID.
        /// Includes MediaState and Category.
        /// </summary>
        /// <param name="id">The ID of the media.</param>
        /// <returns>Media item (music)</returns>
        public MediaMusic GetMediaMusicById(int id)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var media = from m in context.MediaSet.OfType<MediaMusic>().Include("MediaState").Include("Category")
                            where m.MediaId == id
                            select m;

                return media.First();
            }
        }

        /// <summary>
        /// Get media (video) by it's ID.
        /// Includes MediaState and Category.
        /// </summary>
        /// <param name="id">The ID of the media.</param>
        /// <returns>Media item (video)</returns>
        public MediaVideo GetMediaVideoById(int id)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var media = from m in context.MediaSet.OfType<MediaVideo>().Include("MediaState").Include("Category")
                            where m.MediaId == id
                            select m;

                return media.First();
            }
        }

        /// <summary>
        /// Get media (general/misc) by it's ID.
        /// Includes MediaState and Category.
        /// </summary>
        /// <param name="id">The ID of the media.</param>
        /// <returns>Media item (general/misc)</returns>
        public MediaMisc GetMediaMiscById(int id)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var media = from m in context.MediaSet.OfType<MediaMisc>().Include("MediaState").Include("Category")
                            where m.MediaId == id
                            select m;

                return media.First();
            }
        }

        /// <summary>
        /// Get media (no special type) by it's ID.
        /// </summary>
        /// <param name="mediaId">The ID of the media.</param>
        /// <returns>Media item</returns>
        public Media GetMediaById(int mediaId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var media = from m in context.MediaSet.OfType<Media>()
                            where m.MediaId == mediaId
                            select m;

                return media.First();
            }
        }

        /// <summary>
        /// Get Image for specified media as Image object.
        /// </summary>
        /// <param name="mediaId">The ID of the media</param>
        /// <returns>Image object</returns>
        public Image GetMediaImageAsImg(int mediaId)
        {
            byte[] arr = GetMediaImage(mediaId);

            if (arr != null)
            {
                return Helper.CreateImageFromByteArray(arr);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get the image of a specified media
        /// </summary>
        /// <param name="mediaId">The ID fo the media</param>
        /// <returns>Image as byte array</returns>
        public byte[] GetMediaImage(int mediaId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var media = from m in context.MediaSet
                            where m.MediaId == mediaId
                            select m;

                return ((Media)media.First()).Image;
            }
        }

        /// <summary>
        /// Get the image of a specified media
        /// </summary>
        /// <param name="mediaId">The ID fo the media</param>
        /// <param name="arr">The byte array</param>
        /// <returns>Image as byte array</returns>
        public void SaveMediaImage(int mediaId, byte[] arr)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var media = context.MediaSet.FirstOrDefault(m => m.MediaId == mediaId);
                media.Image = arr;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Mass rent media
        /// </summary>
        /// <param name="listMediaIds">List with media IDs that are being rented</param>
        /// <param name="userId">The ID of the user who is the owner of the lendings</param>
        /// <returns>Number of created entries</returns>
        public int CreateLending(List<int> listMediaIds, int userId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                int createCount = 0;

                foreach (int mediaId in listMediaIds)
                {
                    if (IsMediaAvailableForRenting(mediaId, userId))
                    {
                        MediaRenting mr = new MediaRenting();
                        mr.CheckOutDate = DateTime.Now;
                        mr.Media = context.MediaSet.FirstOrDefault(m => m.MediaId == mediaId);
                        mr.LeasingUser = context.Users.FirstOrDefault(u => u.UserId == userId);

                        // set the media state to "unavaiable"
                        mr.Media.MediaState = context.MediaStates.FirstOrDefault(ms => ms.MediaSateId == 2);

                        context.AddToMediaRentings(mr);
                        createCount++;

                        // if user had open reservation for the current media, we close the reservation
                        var res = from r in context.Reservations
                                  where r.User.UserId == userId &&
                                    r.Media.MediaId == mediaId &&
                                    r.EndDate == null
                                  select r;

                        foreach (Reservation reservation in res)
                        {
                            reservation.EndDate = DateTime.Now;
                        }
                    }
                }

                // save to DB
                context.SaveChanges();

                return createCount;
            }
        }

        /// <summary>
        /// Get all media a user has rented an not yet returned.
        /// </summary>
        /// <param name="userId">The ID of the user</param>
        /// <returns>List with media</returns>
        public List<MediaRenting> GetOpenLendingsByUser(int userId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var media = from m in context.MediaRentings.Include("Media.MediaType")
                            where m.UserId == userId &&
                                m.CheckInDate == null
                            orderby m.CheckOutDate
                            select m;

                return media.ToList();
            }
        }

        /// <summary>
        /// Checks if a given media is available for renting.
        /// This is the case when there are no open lendings and
        /// when there is no other user who has the longest open reservation.
        /// </summary>
        /// <param name="mediaId">The ID of the media</param>
        /// <param name="userId">The ID of the user</param>
        /// <returns>True when media can be rent, else false.</returns>
        public bool IsMediaAvailableForRenting(int mediaId, int userId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                int? reservationUserId = GetUserIdWithOldestReservation(mediaId);

                return (reservationUserId == null ||
                    reservationUserId == userId)
                    &&
                    ((from mr in context.MediaRentings
                         where mr.MediaId == mediaId &&
                             mr.CheckInDate == null
                         select mr).Count() == 0);
            }
        }

        /// <summary>
        /// Flags a media "order" as returned for a given user.
        /// </summary>
        /// <param name="userId">The ID of the user who has rented the media</param>
        /// <param name="mediaId">The ID of the media</param>
        /// <param name="checkOutDate">The checkout date of the media</param>
        public void ReturnMedia(int userId, int mediaId, DateTime checkOutDate)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var mr = (from m in context.MediaRentings.Include("Media")
                            where m.UserId == userId &&
                                m.MediaId == mediaId &&
                                m.CheckOutDate == checkOutDate
                          select m).FirstOrDefault();

                if (mr != null)
                {
                    // set checkin date to flag as returned
                    mr.CheckInDate = DateTime.Now;
                    
                    // set the media's media state to available
                    mr.Media.MediaState = context.MediaStates.FirstOrDefault(ms => ms.MediaSateId == 1);

                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Check if a given user has an open reservation for a given media
        /// </summary>
        /// <param name="mediaId">The ID of the media</param>
        /// <param name="userId">The ID of the user</param>
        /// <returns>True, open reservation exists for the user. False, no open res. found.</returns>
        public bool IsReservationOpen(int mediaId, int userId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var res =   context.Reservations
                            .Include("Media").Include("User")
                            .Where(r => r.EndDate == null &&
                                r.Media.MediaId == mediaId &&
                                r.User.UserId == userId);

                return res.Count() > 0;
            }
        }

        /// <summary>
        /// Get all open reservations.
        /// Sorted by user name.
        /// </summary>
        /// <returns>Number of open reservations for the user.</returns>
        public List<Reservation> GetOpenReservations()
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var res =   from r in context.Reservations.Include("Media").Include("User")
                            where r.EndDate == null
                            orderby r.User.Surname
                            orderby r.User.Firstname
                            select r;

                return res.ToList();
            }
        }

        /// <summary>
        /// Count open reservations for a given user.
        /// </summary>
        /// <param name="userId">The ID of the user</param>
        /// <returns>Number of open reservations for the user.</returns>
        public int OpenReservations(int userId)
        {
            return GetOpenReservations(userId).Count();
        }

        /// <summary>
        /// Mass creation of reservations for a given user ID.
        /// The reservation limit is ignored.
        /// If a reservation already exists, new new reservation will created.
        /// </summary>
        /// <param name="listMediaIds">List with media IDs</param>
        /// <param name="userId">The user ID that gets the reservations</param>
        public void CreateReservation(List<int> listMediaIds, int userId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                foreach (int mediaId in listMediaIds)
                {
                    if (!IsReservationOpen(mediaId, userId))
                    {
                        Reservation res = new Reservation();
                        res.CreationDate = DateTime.Now;
                        //res.Media = new Media() { MediaId = mediaId };
                        //res.User = new User() { UserId = userId };
                        res.Media = context.MediaSet.FirstOrDefault(m => m.MediaId == mediaId);
                        res.User = context.Users.FirstOrDefault(u => u.UserId == userId);

                        context.AddToReservations(res);
                        context.SaveChanges();
                    }
                }
            }
        }

        /// <summary>
        /// Adds/inserts a new reservation for the given user for the given media.
        /// </summary>
        /// <param name="mediaId">The ID of the media</param>
        /// <param name="userId">The ID of the user</param>
        /// <exception cref="ConditionException">ConditionException thrown 
        /// when user has already to many open reservations</exception>
        public void CreateReservation(int mediaId, int userId)
        {
            // check if max. reservation limit reached
            string limitStr = GetSetting(Constants.SettingMaxOpenReservations);
            int limit;
            if (!int.TryParse(limitStr, out limit))
            {
                limit = 10; // set default
            }

            int openReservations = OpenReservations(userId);

            if (openReservations < limit)
            {
                if (!IsReservationOpen(mediaId, userId))
                {
                    using (MediathekEntities context = new MediathekEntities())
                    {
                        Reservation res = new Reservation();
                        res.CreationDate = DateTime.Now;
                        //res.Media = new Media() { MediaId = mediaId };
                        //res.User = new User() { UserId = userId };
                        res.Media = context.MediaSet.FirstOrDefault(m => m.MediaId == mediaId);
                        res.User = context.Users.FirstOrDefault(u => u.UserId == userId);

                        context.AddToReservations(res);
                        context.SaveChanges();
                    }
                }
            }
            else
            {
                throw new ConditionException("Es existieren bereits zu viele offene Reservationen");
            }
        }

        /// <summary>
        /// Get a list with all open reservations for a given user.
        /// Ordered descending by creation date
        /// </summary>
        /// <param name="userId">The ID of the user</param>
        /// <returns>List with reservations</returns>
        public List<Reservation> GetOpenReservations(int userId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var res = context.Reservations
                            .Include("User")
                            .Where(r => r.EndDate == null &&
                                r.User.UserId == userId)
                            .OrderByDescending(r => r.CreationDate);

                return res.ToList();
            }
        }

        /// <summary>
        /// Get a list with all closed reservations for a given user.
        /// Ordered descending by end date (date when reservation has used)
        /// </summary>
        /// <param name="userId">The ID of the user</param>
        /// <returns>List with reservations</returns>
        public List<Reservation> GetClosedReservations(int userId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var res = context.Reservations
                            .Include("User")
                            .Where(r => r.EndDate != null &&
                                r.CreationDate != null &&
                                r.User.UserId == userId)
                            .OrderByDescending(r => r.EndDate);

                return res.ToList();
            }
        }

        /// <summary>
        /// Delete a reservation by its ID.
        /// </summary>
        /// <param name="reservationId">The ID of the reservation</param>
        public void DeleteReservation(int reservationId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var res = from r in context.Reservations
                          where r.ReservationId == reservationId
                          select r;

                context.DeleteObject(res.First());
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Get the ID of the media for the given reservation
        /// </summary>
        /// <param name="reservationId">The ID of the reservation</param>
        /// <returns>The ID of the media</returns>
        public int GetMediaIdFromReservation(int reservationId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var res = from r in context.Reservations.Include("Media")
                          where r.ReservationId == reservationId
                          select r;

                return res.First().Media.MediaId;
            }
        }

        /// <summary>
        /// Get the user ID of the oldest reservation for a given media.
        /// </summary>
        /// <param name="mediaId">The ID of the media</param>
        /// <returns>User ID with oldest reservation, null returned when no user has a reservation</returns>
        public int? GetUserIdWithOldestReservation(int mediaId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var res = from r in context.Reservations.Include("Media").Include("User")
                          where r.Media.MediaId == mediaId
                          orderby r.CreationDate
                          select r;

                List<Reservation> reservations = res.ToList();

                if (res == null || res.ToList().Count == 0)
                {
                    return null;
                }
                else
                {
                    return res.First().User.UserId; // get user id of oldest res
                }
            }
        }

        /// <summary>
        /// Get a setting value for a given setting name
        /// </summary>
        /// <param name="settingName">The setting name</param>
        /// <returns>Value of setting or null when nothing found</returns>
        public string GetSetting(string settingName)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var setting = from s in context.Settings
                              where s.SettingName.Equals(settingName)
                              select s;

                Setting setEntity = (Setting)setting.First();

                return setEntity != null ? setEntity.SettingValue : null;
            }
        }

        /// <summary>
        /// Search media
        /// (Parameters are compared in a "LIKE"-condition way)
        /// </summary>
        /// <param name="title">The title of the media</param>
        /// <param name="description">The description of the media</param>
        /// <returns>List of media matching the criterias</returns>
        public List<Media> SearchMedia(string title, string description)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                    var media = from m in context.MediaSet
                                where (string.IsNullOrEmpty(title) || m.Title.Contains(title)) &&
                                    (string.IsNullOrEmpty(description) || m.Description.Contains(description) &&
                                    !m.Deleted)
                                orderby m.Title
                                select m;

                    return media.ToList();
            }
        }

        /// <summary>
        /// Search books
        /// </summary>
        /// <param name="title">Title of  the book</param>
        /// <param name="description">Description</param>
        /// <param name="author">Author</param>
        /// <param name="publisher">Publisher</param>
        /// <param name="publishingYear">Publishing year</param>
        /// <param name="tag">Tag</param>
        /// <returns>List of media matching the criterias</returns>
        public List<MediaBook> SearchBooks(string title,
            string description,
            string author,
            string publisher,
            int? publishingYear,
            string tag)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var media = from m in context.MediaSet.OfType<MediaBook>()
                            where !m.Deleted &&
                                (string.IsNullOrEmpty(title) || m.Title.Contains(title)) &&
                                (string.IsNullOrEmpty(description) || m.Description.Contains(description)) &&
                                (string.IsNullOrEmpty(author) || m.Author.Contains(author)) &&
                                (string.IsNullOrEmpty(publisher) || m.Publisher.Contains(publisher)) &&
                                (publishingYear == null || m.PublishingYear == publishingYear) &&
                                (string.IsNullOrEmpty(tag) || m.Tag.Contains(tag))
                            orderby m.Title
                            select m;

                return media.ToList();
            }
        }

        /// <summary>
        /// Search videos
        /// </summary>
        /// <param name="title">The title</param>
        /// <param name="description">The description</param>
        /// <param name="director">The director</param>
        /// <param name="actors">The actors</param>
        /// <param name="runtime">The total runtime</param>
        /// <param name="tag">The media's tag</param>
        /// <returns>List of video media</returns>
        public List<MediaVideo> SearchVideos(string title,
            string description,
            string director,
            string actors,
            int? runtime,
            string tag)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var media = from m in context.MediaSet.OfType<MediaVideo>()
                            where !m.Deleted &&
                                (string.IsNullOrEmpty(title) || m.Title.Contains(title)) &&
                                (string.IsNullOrEmpty(description) || m.Description.Contains(description)) &&
                                (string.IsNullOrEmpty(director) || m.Director.Contains(director)) &&
                                (string.IsNullOrEmpty(actors) || m.Actors.Contains(actors)) &&
                                (runtime == null || m.Length == runtime) &&
                                (string.IsNullOrEmpty(tag) || m.Tag.Contains(tag))
                            orderby m.Title
                            select m;

                return media.ToList();
            }
        }

        /// <summary>
        /// Search music
        /// </summary>
        /// <param name="title">The title</param>
        /// <param name="description">The description</param>
        /// <param name="artist">The artist</param>
        /// <param name="genre">The genre</param>
        /// <param name="tracklist">The tracklist</param>
        /// <param name="tag">The media's tag</param>
        /// <returns>List of video media</returns>
        public List<MediaMusic> SearchMusic(string title,
            string description,
            string artist,
            string genre,
            string tracklist,
            string tag)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var media = from m in context.MediaSet.OfType<MediaMusic>()
                            where !m.Deleted &&
                                (string.IsNullOrEmpty(title) || m.Title.Contains(title)) &&
                                (string.IsNullOrEmpty(description) || m.Description.Contains(description)) &&
                                (string.IsNullOrEmpty(artist) || m.Artist.Contains(artist)) &&
                                (string.IsNullOrEmpty(genre) || m.Genre.Contains(genre)) &&
                                (string.IsNullOrEmpty(tracklist) || m.Tracklist.Contains(tracklist)) &&
                                (string.IsNullOrEmpty(tag) || m.Tag.Contains(tag))
                            orderby m.Title
                            select m;

                return media.ToList();
            }
        }

        /// <summary>
        /// Search misc media
        /// </summary>
        /// <param name="title">The title</param>
        /// <param name="description">The description</param>
        /// <param name="shortDescription">The short description</param>
        /// <param name="tag">The media's tag</param>
        /// <returns>List of video media</returns>
        public List<MediaMisc> SearchMisc(string title,
            string description,
            string shortDescription,
            string tag)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var media = from m in context.MediaSet.OfType<MediaMisc>()
                            where !m.Deleted &&
                                (string.IsNullOrEmpty(title) || m.Title.Contains(title)) &&
                                (string.IsNullOrEmpty(description) || m.Description.Contains(description)) &&
                                (string.IsNullOrEmpty(shortDescription) || m.ShortDescription.Contains(shortDescription)) &&
                                (string.IsNullOrEmpty(tag) || m.Tag.Contains(tag))
                            orderby m.Title
                            select m;

                return media.ToList();
            }
        }

        /// <summary>
        /// Search users by criterias.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <param name="firstname">The firstname of the user.</param>
        /// <param name="surname">The surname of the user.</param>
        /// <returns>List of users matching the criterias.</returns>
        public List<User> SearchUser(int? userId, string firstname, string surname)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                    var users = from u in context.Users
                                where (userId == null || u.UserId == userId) &&
                                    (string.IsNullOrEmpty(firstname) || u.Firstname.Contains(firstname)) &&
                                    (string.IsNullOrEmpty(surname) || u.Surname.Contains(surname)) &&
                                    !u.Deleted
                                orderby u.UserId
                                select u;

                    return users.ToList();
            }
        }

        /// <summary>
        /// Get all books for a given category ID.
        /// If category ID bigger equal 4 all books are returned.
        /// </summary>
        /// <returns>List of MediaBook</returns>
        public List<MediaBook> GetMediaBooksByCatId(int categoryId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                if (categoryId > 4)
                {
                    var media = from m in context.MediaSet.OfType<MediaBook>()
                                where m.Category.CategoryId == categoryId &&
                                    !m.Deleted
                                orderby m.Title
                                select m;

                    return media.ToList();
                }
                else
                {
                    var media = from m in context.MediaSet.OfType<MediaBook>()
                                where !m.Deleted
                                orderby m.Title
                                select m;

                    return media.ToList();
                }
            }
        }

        /// <summary>
        /// Get all misc media for a given category ID.
        /// If category ID bigger equal 4 all misc media are returned.
        /// </summary>
        /// <returns>List of MediaMisc</returns>
        public List<MediaMisc> GetMediaMiscByCatId(int categoryId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                if (categoryId > 4)
                {
                    var media = from m in context.MediaSet.OfType<MediaMisc>()
                                where m.Category.CategoryId == categoryId &&
                                    !m.Deleted
                                orderby m.Title
                                select m;

                    return media.ToList();
                }
                else
                {
                    var media = from m in context.MediaSet.OfType<MediaMisc>()
                                where !m.Deleted
                                orderby m.Title
                                select m;

                    return media.ToList();
                }
            }
        }

        /// <summary>
        /// Get all video media for a given category ID.
        /// If category ID bigger equal 4 all video media are returned.
        /// </summary>
        /// <returns>List of MediaVideo</returns>
        public List<MediaVideo> GetMediaVideoByCatId(int categoryId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                if (categoryId > 4)
                {
                    var media = from m in context.MediaSet.OfType<MediaVideo>()
                                where m.Category.CategoryId == categoryId &&
                                    !m.Deleted
                                orderby m.Title
                                select m;

                    return media.ToList();
                }
                else
                {
                    var media = from m in context.MediaSet.OfType<MediaVideo>()
                                where !m.Deleted
                                orderby m.Title
                                select m;

                    return media.ToList();
                }
            }
        }

        /// <summary>
        /// Get all music media for a given category ID.
        /// If category ID bigger equal 4 all music media are returned.
        /// </summary>
        /// <returns>List of MediaMusic</returns>
        public List<MediaMusic> GetMediaMusicByCatId(int categoryId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                if (categoryId > 4)
                {
                    var media = from m in context.MediaSet.OfType<MediaMusic>()
                                where m.Category.CategoryId == categoryId &&
                                    !m.Deleted
                                orderby m.Title
                                select m;

                    return media.ToList();
                }
                else
                {
                    var media = from m in context.MediaSet.OfType<MediaMusic>()
                                where !m.Deleted
                                orderby m.Title
                                select m;

                    return media.ToList();
                }
            }
        }

        /// <summary>
        /// Create a new administrator account
        /// </summary>
        /// <param name="username">The username for the new account</param>
        /// <param name="password">The password for the new account</param>
        /// <param name="email">The email for the new account</param>
        /// <returns>The newly created administrator account</returns>
        public Administrator CreateAdministrator(string username, string password, string email)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var admin = new Administrator();

                admin.Username = username;
                admin.Password = password;
                admin.Email = email;

                context.AddToAdministrators(admin);
                context.SaveChanges();

                return admin;
            }
        }

        /// <summary>
        /// Get administrator account by it's ID.
        /// </summary>
        /// <param name="id">The ID of the administrator account</param>
        /// <returns>Administrator account matching the ID.</returns>
        public Administrator GetAdministratorById(int id)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                return (Administrator)context.Administrators
                        .Where(a => a.AdminId == id)
                        .First();
            }
        }

        /// <summary>
        /// Update the values of an existing administrator account
        /// </summary>
        /// <param name="id">The ID of the account</param>
        /// <param name="username">The new username of the account</param>
        /// <param name="password">The new password of the account</param>
        /// <param name="email">The email of the account</param>
        public void UpdateAdministrator(int id, string username, string password, string email)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var adm = context.Administrators.Where(a => a.AdminId == id);

                Administrator admin = (Administrator)adm.First();

                admin.Username = username;
                admin.Password = password;
                admin.Email = email;

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Delete an administrator account with the given administrator ID.
        /// Account is not realy deleted from database but marked as
        /// "delted".
        /// </summary>
        /// <param name="id">The ID of the administrator</param>
        public void DeleteAdministratorById(int id)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var adm = context.Administrators.Where(a => a.AdminId == id);

                Administrator admin = (Administrator)adm.First();

                // set flag
                admin.Deleted = true;

                // save changes
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Get administrator account by username
        /// </summary>
        /// <param name="username">The username of the administrator</param>
        /// <returns>Administrator account matching the username</returns>
        public Administrator GetAdministratorByUsername(string username)
        {
            
            using (MediathekEntities context = new MediathekEntities())
            {
                return (Administrator)context.Administrators
                        .Where(a => a.Username == username)
                        .First();
            }
        }

        /// <summary>
        /// Get a list of all administrators that are not deleted.
        /// </summary>
        /// <returns></returns>
        public IList<Administrator> GetAdministratorsNotDeleted()
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var admins = from a in context.Administrators
                             where !a.Deleted
                             select a;

                return admins.ToList();
            }
        }

        /// <summary>
        /// Count how many administrator accounts match the given username and password.
        /// </summary>
        /// <param name="username">The username of the administrator</param>
        /// <param name="password">The password that should be associated with the username</param>
        /// <returns>The amount of users matching the given criterias.</returns>
        public int CountAdministratorsNotDeletedByUsernamePassword(string username, string password)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                return (from a in context.Administrators
                        where a.Username == username &&
                            a.Password == password &&
                            !a.Deleted
                        select a).Count();
            }
        }

        /// <summary>
        /// Get user account by it's ID.
        /// </summary>
        /// <param name="id">The ID of the user account</param>
        /// <returns>User account matching the ID.</returns>
        public User GetUserById(int id)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                User user = (User)context.Users
                            .Where(u => u.UserId == id)
                            .First();

                context.Detach(user);

                return user;
            }
        }

        /// <summary>
        /// Get user account by it's ID.
        /// Includes the title of the user.
        /// </summary>
        /// <param name="id">The ID of the user account</param>
        /// <returns>User account matching the ID.</returns>
        public User GetUserByIdIncludeTitle(int id)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                return (User)context.Users
                        .Include("Title")
                        .Where(u => u.UserId == id)
                        .First();
            }
        }

        /// <summary>
        /// Get a list of all users that are not deleted
        /// </summary>
        /// <returns>List with user accounts</returns>
        public IList<User> GetUsersNotDeleted()
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var users = from u in context.Users
                            where !u.Deleted
                            orderby u.UserId
                            select u;

                return users.ToList();
            }
        }

        /// <summary>
        /// Mark a user as deleted
        /// </summary>
        /// <param name="id">The ID of the user</param>
        public void DeleteUserById(int id)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var usr = context.Users.Where(u => u.UserId == id);

                User user = (User)usr.First();

                // set flag
                user.Deleted = true;

                // save changes
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Creates a given user account
        /// </summary>
        /// <param name="firstname">Fristname of new user</param>
        /// <param name="surname">Surname of new user</param>
        /// <param name="street">Street</param>
        /// <param name="zip">Zip</param>
        /// <param name="city">City</param>
        /// <param name="country">The country (ISO code)</param>
        /// <param name="email">Email address</param>
        /// <param name="password">The password of the user</param>
        /// <param name="newTitleId">The users title ID</param>
        /// <returns>ID of new user</returns>
        public int CreateUser(string firstname,
            string surname,
            string street,
            string zip,
            string city,
            string country,
            string email,
            string password,
            int? newTitleId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                User user = new User();

                // set nav properites
                if (newTitleId != null)
                {
                    user.Title = context.Titles.FirstOrDefault(t => t.TitleId == newTitleId);
                }
                else
                {
                    user.Title = null;
                }

                // set normal properties
                user.Firstname = firstname;
                user.Surname = surname;
                user.Street = street;
                user.Zip = zip;
                user.City = city;
                user.CountryIso = country;
                user.Email = email;
                user.Password = password;

                // add to context and save
                context.AddToUsers(user);
                context.SaveChanges();

                return user.UserId;
            }
        }

        /// <summary>
        /// Updates a given user account
        /// </summary>
        /// <param name="userId">The ID of the user</param>
        /// <param name="firstname">Fristname of new user</param>
        /// <param name="surname">Surname of new user</param>
        /// <param name="street">Street</param>
        /// <param name="zip">Zip</param>
        /// <param name="city">City</param>
        /// <param name="country">The country (ISO code)</param>
        /// <param name="email">Email address</param>
        /// <param name="password">The password of the user</param>
        /// <param name="newTitleId">The users title ID</param>
        public void UpdateUser(int userId,
            string firstname,
            string surname,
            string street,
            string zip,
            string city,
            string country,
            string email,
            string password,
            int? newTitleId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                User user = context.Users.FirstOrDefault(u => u.UserId == userId);
                
                // set nav properites
                if (newTitleId != null)
                {
                    user.Title = context.Titles.FirstOrDefault(t => t.TitleId == newTitleId);
                }
                else
                {
                    user.Title = null;
                }

                // set normal properties
                user.Firstname = firstname;
                user.Surname = surname;
                user.Street = street;
                user.Zip = zip;
                user.City = city;
                user.CountryIso = country;
                user.Email = email;
                user.Password = password;

                // save
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Get a list of all avaiable titles a customer can have.
        /// (Ordered by description)
        /// </summary>
        /// <returns>List with titles</returns>
        public IList<Title> GetTitles()
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var titles = from t in context.Titles
                             orderby t.Description
                             select t;

                return titles.ToList();
            }
        }

        /// <summary>
        /// Get a title by a given title ID.
        /// </summary>
        /// <returns>The title or null when nothing found</returns>
        public Title GetTitleById(int titleId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                Title title = (Title)context.Titles
                                .Where(t => t.TitleId == titleId)
                                .First();

                return title;
            }
        }

        /// <summary>
        /// Returns a list of media types, 
        /// ordered alphabetically by type name.
        /// </summary>
        /// <returns>List with media types</returns>
        public List<MediaType> GetMediaTypes()
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var types = from t in context.MediaTypes
                            orderby t.TypeName
                            select t;

                return types.ToList();
            }
        }

        /// <summary>
        /// Get all medias a user has ever rented.
        /// (Includes not yet returned media).
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>List with media.</returns>
        public List<Media> GetRentedMediaByUserId(int userId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var rentings = from r in context.MediaRentings.Include("Media")
                               where r.UserId == userId
                               select r.Media;

                return rentings.ToList();
            }
        }

        /// <summary>
        /// Get all medias a user has currently rented and not yet returned.
        /// </summary>
        /// <param name="userId">The ID of the user.</param>
        /// <returns>List with media.</returns>
        public List<Media> GetReturnedMediaByUserId(int userId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var rentings = from r in context.MediaRentings.Include("Media")
                               where r.UserId == userId && r.CheckInDate == null
                               select r.Media;

                return rentings.ToList();
            }
        }

        /// <summary>
        /// Delete a reservation
        /// </summary>
        /// <param name="reservationId">The ID of the reservation</param>
        public void DeleteOpenReservation(int reservationId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var reservation = from r in context.Reservations
                                  where r.ReservationId == reservationId
                                  select r;

                context.DeleteObject(reservation);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Delete all open reservations for a given media.
        /// </summary>
        /// <param name="mediaId">The ID of the media</param>
        public void DeleteOpenReservationsByMedia(int mediaId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var reservations = context.MediaSet.Where(m => m.MediaId == mediaId)
                                    .SelectMany(m => m.Reservations);

                foreach (Reservation res in reservations)
                {
                    if (res.EndDate == null)
                    {
                        context.DeleteObject(res);
                    }
                }

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Delete all open reservations for a given user.
        /// </summary>
        /// <param name="userId"></param>
        public void DeleteReservationsByUserId(int userId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var reservations = context.Users.Where(u => u.UserId == userId)
                                    .SelectMany(u => u.Reservations);

                foreach (Reservation res in reservations)
                {
                    context.DeleteObject(res);
                }

                context.SaveChanges();
            }
        }

        /// <summary>
        /// Checks the login for a given user ID
        /// </summary>
        /// <param name="userId">The user ID</param>
        /// <param name="password">The password associated with the user ID.</param>
        /// <returns>True, when login found in database, else false.</returns>
        public bool CheckUserLogin(string userId, string password)
        {
            if (userId == null) throw new ArgumentNullException("userId");
            if (password == null) throw new ArgumentNullException("password");

            int userIdInt = Convert.ToInt32(userId);

            using (MediathekEntities context = new MediathekEntities())
            {
                var count = (from u in context.Users
                            where u.UserId == userIdInt &&
                            u.Password == password &&
                            !u.Deleted
                            select u).Count();

                return count > 0;
            }
        }

        /// <summary>
        /// Check the logon credentials for an administrator account
        /// </summary>
        /// <param name="username">The username of the administrator</param>
        /// <param name="password">The password of the administrator</param>
        /// <returns>True, login found, else false.</returns>
        public bool CheckAdministratorLogin(string username, string password)
        {
            if (username == null) throw new ArgumentNullException("username");
            if (password == null) throw new ArgumentNullException("password");

            if (CountAdministratorsNotDeletedByUsernamePassword(username, password) > 0)
            {
                // matching account found
                return true;
            }

            // login failed
            return false;
        }

        /// <summary>
        /// Change the password of a user
        /// </summary>
        /// <param name="userId">The ID of the user</param>
        /// <param name="oldPassword">The user's old password</param>
        /// <param name="newPassword">The user's new password</param>
        public void ChangeUserPassword(int userId, string oldPassword, string newPassword)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                try
                {
                    var user = (from u in context.Users
                               where u.UserId == userId &&
                                   u.Password.Equals(oldPassword)
                               select u).FirstOrDefault();

                    user.Password = newPassword;

                    context.SaveChanges();
                }
                catch (NullReferenceException)
                {
                    throw new ConditionException(Localization.MsgErrorOldPasswordInvalid);
                }
            }
        }        


        /// <summary>
        /// Get account data from a given session.
        /// </summary>
        /// <remarks>
        /// Make sure to cast the obect to either an
        /// Administrators or a User object according
        /// to the AccountType of the session.
        /// </remarks>
        /// <param name="session">The session containing the account information</param>
        /// <returns>User account data as object</returns>
        public object GetAccountFromSession(SessionInfo session)
        {
            if (session == null) throw new ArgumentNullException("session");

            switch (session.AccountType)
            {
                case UserType.Administrator:
                    return GetAdministratorById(session.UserId);
                case UserType.Customer:
                    return GetUserById(session.UserId);
            }

            throw new MissingDataException();
        }

        /// <summary>
        /// Create a new session for a given administrator.
        /// </summary>
        /// <param name="username">The username of the administrator</param>
        /// <returns>The newly created session</returns>
        public SessionInfo CreateSessionForAdministrator(string username)
        {
            if (username == null) throw new ArgumentNullException("username");

            int userId = GetAdministratorByUsername(username).AdminId;
            
            return new SessionInfo(UserType.Administrator, userId);
        }

        /// <summary>
        /// Create a new session for a given administrator.
        /// </summary>
        /// <param name="userId">The user ID of the administrator</param>
        /// <returns>The newly created session</returns>
        public SessionInfo CreateSessionForUser(string userId)
        {
            if (userId == null) throw new ArgumentNullException("userId");

            int userIdInt = Convert.ToInt32(userId);

            return new SessionInfo(UserType.Customer, userIdInt);
        }

        /// <summary>
        /// Delete an customer/user account
        /// (Marks customer account as deleted)
        /// </summary>
        /// <param name="userId">The ID of the customer account</param>
        /// <exception cref="ConditionException">ConditionException</exception>
        public void DeleteUser(int userId)
        {
            /* user can only be delted when he has not rented anything
             * right now */

            if (!UserHasOpenLendings(userId))
            {
                DeleteUserById(userId);

                // delete open reservations
                DeleteReservationsByUserId(userId);
            }
            else
            {
                throw new ConditionException(Localization.MsgErrorOpenRentingsExistsForUser);
            }
        }

        /// <summary>
        /// Gets a list of all avaiable titles, ready for combobox usage.
        /// </summary>
        /// <returns>List with titles and a default item (first in list).</returns>
        public List<GenericIntStringItem> GetTitleListForComboBox()
        {
            List<GenericIntStringItem> cbList =
                new List<GenericIntStringItem>();

            // add default entry
            cbList.Add(new GenericIntStringItem(-1, Constants.ComboBoxDefaultItemText));

            foreach (Title title  in GetTitles())
            {
                cbList.Add(new GenericIntStringItem(title.TitleId, title.Description));
            }

            return cbList;
        }

        /// <summary>
        /// Get all lendings for a given user.
        /// Ordered by check in date descending.
        /// </summary>
        /// <param name="userId">The ID of the user</param>
        /// <returns>List of media lendings.</returns>
        public List<MediaRenting> GetLendingsForUser(int userId)
        {
            using (MediathekEntities context = new MediathekEntities())
            {
                var rent =  from mr in context.MediaRentings
                            where mr.UserId == userId
                            orderby mr.CheckInDate descending
                            select mr;

                return rent.ToList();
            }
        }

        /// <summary>
        /// Check if a user has currently open lendings.
        /// (Rented media but not yet returned).
        /// </summary>
        /// <param name="userId">The ID of the user</param>
        /// <returns>True = user has open rentings, else false.</returns>
        public bool UserHasOpenLendings(int userId)
        {
            try
            {
                List<Media> list = GetRentedMediaByUserId(userId);
                if (list != null && list.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        #endregion

    }
}
