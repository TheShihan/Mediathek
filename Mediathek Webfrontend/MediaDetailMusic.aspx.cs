using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using BusinessLogic.Common;
using BusinessLogic.Exceptions;
using DataAccess;

namespace Mediathek_Webfrontend
{
    public partial class MediaDetailMusic : System.Web.UI.Page
    {

        #region Fields

        /// <summary>
        /// Business logic handler instance
        /// </summary>
        private BusinessLogicHandler bl = new BusinessLogicHandler();

        /// <summary>
        /// The ID of the currently displayed media
        /// </summary>
        private int mediaId;

        #endregion

        /// <summary>
        /// On page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (int.TryParse(Request.QueryString["mediaId"], out mediaId))
            {
                FillMediaData();

                SessionInfo session = (SessionInfo)Session[Constants.SessionInfo];

                if (bl.IsReservationOpen(mediaId, session.UserId))
                {
                    this.ButReservation.Visible = false;
                    this.LblAlreadyRes.Visible = true;
                }
            }
            else
            {
                Response.Redirect("MediaTypeSelection.aspx");
            }
        }

        /// <summary>
        /// Get media data and display it in the page controls
        /// </summary>
        private void FillMediaData()
        {
            MediaMusic media = bl.GetMediaMusicById(mediaId);

            this.LblTitle.Text = media.Title;
            this.LblDesc.Text = media.Description;
            this.LblTag.Text = media.Tag;
            this.LblCat.Text = media.Category.Name;
            this.LblCreationDate.Text = media.CreationDate.ToShortDateString();
            this.LblState.Text = media.MediaState.StateName;
            this.LblArtist .Text = media.Artist;
            this.LblGenre.Text = media.Genre;
            this.LblTrackList.Text = media.Tracklist;

            // display image
            if (media.Image != null)
            {
                this.ImgMedia.ImageUrl = "ShowMediaImage.ashx?mediaId=" + mediaId;
            }
            else
            {
                this.ImgMedia.Visible = false;
            }
        }

        /// <summary>
        /// Button "reservation" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButReservation_Click(object sender, EventArgs e)
        {
            SessionInfo session = (SessionInfo)Session[Constants.SessionInfo];

            if (session != null && mediaId > 0)
            {
                try
                {
                    // add new reservation
                    bl.CreateReservation(mediaId, session.UserId);

                    // refresh page to show reservation state
                    Response.Redirect(Request.UrlReferrer.AbsolutePath + "?mediaId=" + mediaId);
                }
                catch (ConditionException ex)
                {
                    this.LblError.Text = ex.Message;
                    this.LblError.Visible = true;
                }
            }
        }

    }
}
