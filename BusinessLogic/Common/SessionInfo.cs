using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Common
{
    /// <summary>
    /// Stores session information
    /// </summary>
    public class SessionInfo
    {

        #region Fields

        /// <summary>
        /// The time the user has logged on to the system
        /// </summary>
        private DateTime logonTime;

        /// <summary>
        /// The account type of the user
        /// </summary>
        private UserType accountType;

        /// <summary>
        /// The ID of the user/administrator that is loging on
        /// </summary>
        private int userId;

        /// <summary>
        /// Basket for media IDs, useful to store medias, eg for mass reservation etc.
        /// </summary>
        private List<int> mediaBasket = new List<int>();

        /// <summary>
        /// Event that shall be fired when content of the media basket has been changed
        /// </summary>
        public event BasicDelegate MediaBasketContentChanged = null;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor. Initialize the SessionInfo object
        /// </summary>
        /// <param name="accountType">The account type of the user</param>
        /// <param name="userId">The ID of the user/administrator that is loging on</param>
        public SessionInfo(UserType accountType, int userId)
        {
            this.logonTime = DateTime.Now;
            this.accountType = accountType;
            this.userId = userId;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Add a media to the basket.
        /// </summary>
        /// <param name="mediaId"></param>
        public void AddMediaToBasket(int mediaId)
        {
            if (this.mediaBasket == null)
            {
                this.mediaBasket = new List<int>();
            }

            if (!this.mediaBasket.Contains(mediaId))
            {
                this.mediaBasket.Add(mediaId);

                RaiseMediaBasketContentChangedEvent(this);
            }
        }

        /// <summary>
        /// Remove media from the basket.
        /// </summary>
        /// <param name="mediaId"></param>
        public void RemoveMediaFromBasket(int mediaId)
        {
            if (this.mediaBasket.Contains(mediaId))
            {
                this.mediaBasket.Remove(mediaId);

                RaiseMediaBasketContentChangedEvent(this);
            }
        }

        /// <summary>
        /// Remove media from the basket.
        /// </summary>
        /// <param name="mediaList">The media id list</param>
        public void RemoveMediaFromBasket(List<int> mediaList)
        {
            bool basketChanged = false;

            if (mediaList != null)
            {
                foreach (int mediaId in mediaList)
                {
                    if (this.mediaBasket.Contains(mediaId))
                    {
                        this.mediaBasket.Remove(mediaId);
                        basketChanged = true;
                    }
                }
            }

            if (basketChanged)
            {
                RaiseMediaBasketContentChangedEvent(this);
            }
        }

        /// <summary>
        /// Clears the whole basket
        /// </summary>
        public void ClearMediaToBasket()
        {
            this.mediaBasket.Clear();

            RaiseMediaBasketContentChangedEvent(this);
        }

        /// <summary>
        /// Event raiser, when basket content has been changed
        /// </summary>
        protected virtual void RaiseMediaBasketContentChangedEvent(object sender)
        {
            // Raise the event by using the () operator.
            if (MediaBasketContentChanged != null)
            {
                MediaBasketContentChanged(this);
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get the logon time
        /// </summary>
        public DateTime LogonTime
        {
            get { return logonTime; }
        }

        /// <summary>
        /// Get the type of the account
        /// </summary>
        public UserType AccountType
        {
            get { return accountType; }
        }

        /// <summary>
        /// Get the current user ID
        /// </summary>
        public int UserId
        {
            get { return userId; }
        }

        /// <summary>
        /// Get the media basket
        /// </summary>
        public List<int> MediaBasket
        {
            get { return this.mediaBasket; }
        }

        #endregion

    }
}
