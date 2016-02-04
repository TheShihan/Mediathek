using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mediathek_Webfrontend
{
    public partial class MediaSearch : System.Web.UI.Page
    {

        /// <summary>
        /// On page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.TxtTitle.Text = Request.QueryString["title"];
                this.TxtDesc.Text = Request.QueryString["desc"];
            }
            
            HandleNoData();
        }

        /// <summary>
        /// Show error text when no data found and hide data grid.
        /// Else show grid.
        /// </summary>
        private void HandleNoData()
        {
            if (this.GridViewMedia.Rows.Count > 0)
            {
                this.GridViewMedia.Visible = true;
                this.LblNoData.Visible = false;
            }
            else
            {
                this.GridViewMedia.Visible = false;
                this.LblNoData.Visible = true;
            }
        }

        /// <summary>
        /// Button "search" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButSearch_Click(object sender, EventArgs e)
        {
            string srchUrl =
                string.Format("MediaSearch.aspx?title={0}&desc={1}", this.TxtTitle.Text, this.TxtDesc.Text);
            Response.Redirect(srchUrl);
        }

        /// <summary>
        /// Selected index changed in GridView "media"
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
