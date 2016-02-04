using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic.Common;
using BusinessLogic;
using DataAccess;

namespace Mediathek_Webfrontend
{
    public partial class MediaSearchGeneral : System.Web.UI.Page
    {

        #region Fields

        /// <summary>
        /// Business logic handler instance
        /// </summary>
        BusinessLogicHandler bl = new BusinessLogicHandler();

        #endregion

        /// <summary>
        /// On page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // fill category treeview
                string typeIdStr = Request.QueryString["typeId"];
                int typeId;
                if (int.TryParse(typeIdStr, out typeId))
                {
                    WebHelper.FillCategories(TreeViewCategories, typeId);
                }
                else
                {
                    // some bad chars submitted as query string, user has to select correctly
                    Response.Redirect("MediaTypeSelection.aspx");
                }
            }
        }

        /// <summary>
        /// GridView, selected index changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridViewMedia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // open detail page for selected mediaId
            GridViewRow row = GridViewMedia.SelectedRow;

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
