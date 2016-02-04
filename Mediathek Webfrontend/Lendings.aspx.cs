using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using BusinessLogic.Common;

namespace Mediathek_Webfrontend
{
    public partial class Lendings : System.Web.UI.Page
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
        /// Selected index changed in grid view "lendings"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridViewLendings_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowMediaDetailForSelection(this.GridViewLendings);
        }

        /// <summary>
        /// Show media details for the selected lending in the given grid view.
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
                    int mediaId;
                    if (Int32.TryParse(row.Cells[0].Text, out mediaId) && mediaId > 0)
                    {
                        Response.Redirect("MediaDetail.aspx?mediaId=" + mediaId.ToString());
                    }
                }
            }
        }

    }
}
