using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Common;
using BusinessLogic;
using DataAccess;
using MediathekClient.Forms;

namespace MediathekClient
{
    public partial class FrmMain : FrmDlgBase
    {

        #region Fields

        /// <summary>
        /// The current session
        /// </summary>
        private SessionInfo session = null;

        /// <summary>
        /// Bussines logic handler class
        /// </summary>
        private BusinessLogicHandler bl = new BusinessLogicHandler();

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor (default)
        /// </summary>
        private FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor with session initialization
        /// </summary>
        /// <param name="session">The current session</param>
        public FrmMain(SessionInfo session) : this()
        {
            if (session == null) throw new ArgumentNullException("session");

            this.session = session;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Opens a new admin manager form and displays it.
        /// </summary>
        private void ShowAdminManager()
        {
            new FrmAdminManager(this.session).ShowDialog(this);
        }

        /// <summary>
        /// Opens a new customer manager form and displays it.
        /// </summary>
        private void ShowCustomerManager()
        {
            new FrmCustomerManager(this.session).ShowDialog(this);
        }

        /// <summary>
        /// Opens the form to perform media tasks (rent/reservation)
        /// </summary>
        private void ShowMediaTasksForm()
        {
            new FrmMediaTasks(this.session).ShowDialog(this);
        }

        /// <summary>
        /// Opens the form to return media
        /// </summary>
        private void ShowMediaReturnForm()
        {
            new FrmMediaReturn(this.session).ShowDialog(this);
        }

        /// <summary>
        /// Opens the form to return media
        /// </summary>
        private void ShowMediaReservationsForm()
        {
            new FrmMediaReservations(this.session).ShowDialog(this);
        }

        /// <summary>
        /// Set the user information according to the currently 
        /// logged in user.
        /// </summary>
        private void SetUserInfo()
        {
            string username = null;

            if (session != null &&
                session.AccountType == UserType.Administrator)
            {
                try
                {
                    username =
                        ((Administrator)bl.GetAccountFromSession(session)).Username;
                }
                catch
                {
                    // ignore
                }
            }

            if (!string.IsNullOrEmpty(username))
            {
                tsLblUserInfo.Text =
                    string.Format(Common.Localization.CtrlLblLogonInfo, username);
            }
            else
            {
                tsLblUserInfo.Text = string.Empty;
            }
        }

        /// <summary>
        /// Handles the closing of the form
        /// </summary>
        private void CloseOperation()
        {
            this.Close();
        }

        #endregion

        #region Event handlers

        /// <summary>
        /// The form is loading
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event args</param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetUserInfo();
        }
            
        /// <summary>
        /// The form has been closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            // exit the whole application
            Application.Exit();
        }

        /// <summary>
        /// Button "close" has been clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butClose_Click(object sender, EventArgs e)
        {
            CloseOperation();
        }

        /// <summary>
        /// Button "manage admins" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butManageAdmins_Click(object sender, EventArgs e)
        {
            ShowAdminManager();
        }

        /// <summary>
        /// Button "manage customers" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butManageCustomers_Click(object sender, EventArgs e)
        {
            ShowCustomerManager();
        }

        /// <summary>
        /// Button "rent media" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butMediaRent_Click(object sender, EventArgs e)
        {
            ShowMediaTasksForm();
        }

        /// <summary>
        /// Button "return media" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butReturnMedia_Click(object sender, EventArgs e)
        {
            ShowMediaReturnForm();
        }

        /// <summary>
        /// Button "media reservations" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butMediaReservations_Click(object sender, EventArgs e)
        {
            ShowMediaReservationsForm();
        }

        /// <summary>
        /// Button "media manager" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butMedia_Click(object sender, EventArgs e)
        {
            new FrmMediaTypeSelector(this.session, FormMode.Manager).ShowDialog(this);
        }

        /// <summary>
        /// Info menu item clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog(this);
        }

        /// <summary>
        /// "Close" menu item clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseOperation();
        }

        #endregion

    }
}
