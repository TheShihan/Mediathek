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
    /// <summary>
    /// The start page of the web frontend
    /// </summary>
    public partial class Default : System.Web.UI.Page
    {

        /// <summary>
        /// Business logic handler instance
        /// </summary>
        BusinessLogicHandler bl = new BusinessLogicHandler();

        /// <summary>
        /// On page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Form.DefaultButton = this.ButOk.UniqueID;
            Page.Form.DefaultFocus = this.TxtUsername.UniqueID;
            this.TxtUsername.Focus();
        }

        /// <summary>
        /// Button "OK" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButOk_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (bl.CheckUserLogin(this.TxtUsername.Text, this.TxtPassword.Text))
                {
                    // login is correct
                    SessionInfo session =
                        bl.CreateSessionForUser(this.TxtUsername.Text);

                    // add session info object to session
                    Session.Add(Constants.SessionInfo, session);

                    Response.Redirect("Home.aspx");
                }
                else
                {
                    // incorrect login
                    this.LblLoginError.Visible = true;
                }
            }
        }

        /// <summary>
        /// Button "reset" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButReset_Click(object sender, EventArgs e)
        {
            this.TxtUsername.Text = string.Empty;
            this.TxtPassword.Text = string.Empty;
            this.LblLoginError.Visible = false;
            this.TxtUsername.Focus();
        }

        /// <summary>
        /// Text changed inside a logon field text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void TxtLoginField_TextChanged(object sender, EventArgs e)
        {
            // clear logon error message
            this.LblLoginError.Visible = false;
        }

    }
}
