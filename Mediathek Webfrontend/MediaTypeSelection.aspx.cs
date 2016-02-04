using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic.Common;
using DataAccess;

namespace Mediathek_Webfrontend
{
    /// <summary>
    /// Media type selection page
    /// </summary>
    public partial class MediaTypeSelection : System.Web.UI.Page
    {

        /// <summary>
        /// On page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            this.TxtTitle.Focus();
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
        /// Button "OK" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButTypeSelOk_Click(object sender, EventArgs e)
        {
            // open media search for type
            // get selected ID
            if (this.DropDownListMediaType.SelectedItem != null)
            {
                int mediaTypeId =
                    Convert.ToInt32(this.DropDownListMediaType.SelectedValue);

                switch (mediaTypeId)
                {
                    case 1:
                        // books, literature
                        Response.Redirect("MediaSearchBooks.aspx?typeId=1");
                        break;
                    case 2:
                        // music
                        Response.Redirect("MediaSearchMusic.aspx?typeId=2");
                        break;
                    case 3:
                        // videos
                        Response.Redirect("MediaSearchVideos.aspx?typeId=3");
                        break;
                    case 4:
                        // general media
                        Response.Redirect("MediaSearchGeneral.aspx?typeId=4");
                        break;
                }
            }
        }
    }

}
