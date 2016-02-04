using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic.Common;
using BusinessLogic;

namespace Mediathek_Webfrontend
{
    public partial class Reservations : System.Web.UI.Page
    {
        #region Fields

        /// <summary>
        /// Business logic handler instance
        /// </summary>
        private BusinessLogicHandler bl = new BusinessLogicHandler();

        #endregion

        /// <summary>
        /// On page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionInfo session = (SessionInfo)Session[Constants.SessionInfo];

            if (session != null)
            {
                this.HiddenFieldUserId.Value = session.UserId.ToString();
            }
        }

        /// <summary>
        /// Row in "open reservations" GridView deleted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridViewOpenReservations_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            // refresh
            Response.Redirect("Reservations.aspx", true);
        }

        /// <summary>
        /// Grid view "open reservations" selected index changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridViewOpenReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowMediaDetailForSelection(this.GridViewOpenReservations);
        }

        /// <summary>
        /// Grid view "closed reservations" selected index changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridViewClosedReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowMediaDetailForSelection(this.GridViewClosedReservations);
        }

        /// <summary>
        /// Show media details for the selected reservation in the given grid view.
        /// </summary>
        /// <param name="gv">The GridView</param>
        private void ShowMediaDetailForSelection(GridView gv)
        {
            if (gv != null)
            {
                // show media in detail
                GridViewRow row = gv.SelectedRow;

                if (row != null)
                {
                    int reservationId;
                    if (Int32.TryParse(row.Cells[0].Text, out reservationId) && reservationId > 0)
                    {
                        // get media ID
                        int mediaId = bl.GetMediaIdFromReservation(reservationId);

                        if (mediaId > 0)
                        {
                            Response.Redirect("MediaDetail.aspx?mediaId=" + mediaId.ToString());
                        }
                    }
                } 
            }
        }

    }

}
