using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using BusinessLogic.Common;
using BusinessLogic.Exceptions;

namespace Mediathek_Webfrontend
{
    /// <summary>
    /// Page where user can change his password
    /// </summary>
    public partial class ChangePassword : System.Web.UI.Page
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
            
        }

        /// <summary>
        /// "OK" button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButOk_Click(object sender, EventArgs e)
        {
            this.LblMessages.Visible = false;

            if (Page.IsValid)
            {
                // try to change password
                SessionInfo session = (SessionInfo)Session[Constants.SessionInfo];

                if (session != null)
                {
                    try
                    {
                        bl.ChangeUserPassword(session.UserId, this.TxtPasswordOld.Text, this.TxtPassword.Text);

                        // success message
                        this.LblMessages.Text = "Das Kennwort wurde geändert.";
                    }
                    catch (ConditionException ex)
                    {
                        this.LblMessages.Text = ex.Message;
                    }

                    this.LblMessages.Visible = true;
                }
            }
        }
    }
}
