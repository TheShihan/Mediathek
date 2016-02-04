using System;
using BusinessLogic;
using MediathekClient.Common;
using System.Windows.Forms;

namespace MediathekClient.Forms
{
    /// <summary>
    /// Offers a form for the administrative user to log on to the system.
    /// </summary>
    public partial class FrmLogin : FrmDlgBase
    {
        #region Fields

        /// <summary>
        /// Bussines logic handler class
        /// </summary>
        private BusinessLogicHandler bl = new BusinessLogicHandler();

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmLogin()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Try to log the administrator on to the system.
        /// </summary>
        private void Logon()
        {
            if (!string.IsNullOrEmpty(txtPassword.Text) &&
                !string.IsNullOrEmpty(txtUsername.Text))
            {
                if (bl.CheckAdministratorLogin(txtUsername.Text, txtPassword.Text))
                {
                    // logon credentials are OK
                    new FrmMain(bl.CreateSessionForAdministrator(txtUsername.Text)).Show();
                    this.Visible = false;
                }
                else
                {
                    // bad logon credentials
                    Tools.ShowMessageBox(MessageBoxType.Error, Localization.MsgLogonInvalid, this);
                }
            }
        }

        #endregion

        #region Event handlers

        /// <summary>
        /// Login/OK button has been clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butLogin_Click(object sender, EventArgs e)
        {
            Logon();
        }

        /// <summary>
        /// Cancel button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Text changed inside the logon fields
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="e">Event args</param>
        private void txtLogonFields_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled =
                !string.IsNullOrEmpty(txtPassword.Text) &&
                !string.IsNullOrEmpty(txtUsername.Text);
        }

        /// <summary>
        /// Form has been closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            // close the whole application
            Application.Exit();
        }

        #endregion

    }
}
