using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BusinessLogic;

namespace Mediathek_Webfrontend
{
    /// <summary>
    /// Summary description for $codebehindclassname$
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class MediaImageHandler : IHttpHandler
    {

        #region Fields

        /// <summary>
        /// Business logic handler instance
        /// </summary>
        BusinessLogicHandler bl = new BusinessLogicHandler();

        #endregion

        /// <summary>
        /// Process request
        /// </summary>
        /// <param name="context"></param>
        public void ProcessRequest(HttpContext context)
        {
            //get the image id from the url
            int mediaId;
            if (int.TryParse(context.Request.QueryString["mediaId"], out mediaId))
            {
                // get image
                byte[] img = bl.GetMediaImage(mediaId);

                context.Response.BinaryWrite(img);
            }
        }

        /// <summary>
        /// Get if reusable
        /// </summary>
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
