using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic.Common;

namespace Mediathek_Webfrontend
{
    /// <summary>
    /// Logout page
    /// </summary>
    public partial class Logout : System.Web.UI.Page
    {

        /// <summary>
        /// On page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[Constants.SessionInfo] == null)
            {
                // user wasn't logged in, directly redirect to logon page
                Response.Redirect("Default.aspx");
            }
            else
            {
                // clear session data
                Session.RemoveAll();
            }
        }

    }
}
