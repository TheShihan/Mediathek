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
    public partial class MediaDetail : System.Web.UI.Page
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
            int mediaId;
            if (int.TryParse(Request.QueryString["mediaId"], out mediaId))
            {
                // get media type and redirect to corresponding page
                int mediaTypeId = bl.GetMediaTypeByMediaId(mediaId);

                switch (mediaTypeId)
                {
                    case 1:
                        Response.Redirect("MediaDetailBook.aspx?mediaId=" + mediaId);
                        break;
                    case 2:
                        Response.Redirect("MediaDetailMusic.aspx?mediaId=" + mediaId);
                        break;
                    case 3:
                        Response.Redirect("MediaDetailVideo.aspx?mediaId=" + mediaId);
                        break;
                    case 4:
                        Response.Redirect("MediaDetailGeneral.aspx?mediaId=" + mediaId);
                        break;
                }
            }

            // bad query string or media type not handled:
            Response.Redirect("MediaTypeSelection.aspx", true);
        }

    }
}
