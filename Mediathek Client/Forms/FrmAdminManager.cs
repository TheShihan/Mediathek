using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Common;
using DataAccess;
using MediathekClient.Common;
using BusinessLogic;

namespace MediathekClient.Forms
{
    /// <summary>
    /// Admin manager
    /// </summary>
    public partial class FrmAdminManager : FrmDlgBase
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
        /// Default constructor
        /// </summary>
        private FrmAdminManager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor with session initialization
        /// </summary>
        /// <param name="session">The current session</param>
        public FrmAdminManager(SessionInfo session)
            : this()
        {
            this.session = session;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Fill the listbox with all administrators that are not deleted
        /// </summary>
        private void FillAdministratorList()
        {
            // cleanup
            lbAdmins.Items.Clear();

            // get new items
            IList<Administrator> adminList =
                bl.GetAdministratorsNotDeleted();

            foreach (Administrator admin in adminList)
            {
                lbAdmins.Items.Add(admin.AdminId);
            }
        }

        /// <summary>
        /// Displays the data for the currently selected administrator
        /// </summary>
        private void DisplaySelectedAdministrator()
        {
            // clear old data
            ClearAdministratorData();

            // load new data by selected ID
            if (lbAdmins.SelectedItems.Count == 1)
            {
                int adminId = (int)lbAdmins.SelectedItem;

                try
                {
                    Administrator admin =
                        bl.GetAdministratorById(adminId);

                    this.txtAdminUsername.Text = admin.Username;
                    this.txtAdminPassword.Text = admin.Password;
                    this.txtAdminEmail.Text = admin.Email;
                }
                catch
                {
                    // admin couldn't be loaded
                    Tools.ShowMessageBox(MessageBoxType.Error,
                        Localization.MsgCommonErrorNoDataFound,
                        this);
                }
            }
        }

        /// <summary>
        /// Creates a new administrator account with the data that is currently
        /// displayed in the data section.
        /// </summary>
        private void CreateAdministrator()
        {
            try 
	        {	        
		        // create new account in DB
                Administrator admin =
                    bl.CreateAdministrator(this.txtAdminUsername.Text,
                        this.txtAdminPassword.Text,
                        this.txtAdminEmail.Text);

                // update admin list
                FillAdministratorList();

                // select the newly created administrator
                this.lbAdmins.Text = admin.AdminId.ToString();

                this.txtAdminUsername.Select();
	        }
	        catch (Exception ex)
	        {
                Tools.ShowMessageBoxException(ex, this);
	        }
        }

        /// <summary>
        /// Updates the data of the currently selected administrator 
        /// account to the database.
        /// </summary>
        private void SaveAdministrator()
        {
            if (lbAdmins.SelectedItems.Count == 1)
            {
                int adminId = (int)lbAdmins.SelectedItem;

                try
                {
                    // update account
                    bl.UpdateAdministrator(adminId,
                        this.txtAdminUsername.Text,
                        this.txtAdminPassword.Text,
                        this.txtAdminEmail.Text);

                    // info on success
                    Tools.ShowMessageBox(MessageBoxType.Info,
                        Localization.MsgCommonInfoSaveSuccess,
                        this);
                }
                catch
                {
                    // save failed
                    Tools.ShowMessageBox(MessageBoxType.Error,
                        Localization.MsgCommonErrorSaveFailed,
                        this);
                }
            }
            else
            {
                // nothing selected
                Tools.ShowMessageBox(MessageBoxType.Error,
                    Localization.MsgCommonErrorNothingSelected,
                    this);
            }
        }


        /// <summary>
        /// Deletes the selected administrator
        /// </summary>
        private void DeleteAdministrator()
        {
            if (lbAdmins.SelectedItems.Count == 1)
            {
                if (lbAdmins.Items.Count > 1)
                {
                    int adminId = (int)lbAdmins.SelectedItem;

                    if (adminId != this.session.UserId)
                    {
                        try
                        {
                            // mark as deleted
                            bl.DeleteAdministratorById(adminId);

                            ClearAdministratorData();

                            // reload admin list
                            FillAdministratorList();

                            // inform about success
                            Tools.ShowMessageBox(MessageBoxType.Info,
                                Localization.MsgCommonInfoDeletionSuccess,
                                this);
                        }
                        catch
                        {
                            Tools.ShowMessageBox(MessageBoxType.Error,
                                Localization.MsgCommonErrorDeletionFailed,
                                this);
                        }
                    }
                    else
                    {
                        // cannot delete own account
                        Tools.ShowMessageBox(MessageBoxType.Error,
                            Localization.MsgAdminDeletionDelAbortOwnAccount,
                            this);
                    }
                }
                else
                {
                    // cannote delete last administrator account
                    Tools.ShowMessageBox(MessageBoxType.Error,
                        Localization.MsgAdminDeletionDelAbortLastAccount,
                        this);
                }
            }
            else
            {
                // nothing selected
                Tools.ShowMessageBox(MessageBoxType.Error,
                    Localization.MsgCommonErrorNothingSelected,
                    this);
            }
        }

        /// <summary>
        /// Clears all administrator related data from the view
        /// </summary>
        private void ClearAdministratorData()
        {
            this.txtAdminUsername.Clear();
            this.txtAdminPassword.Clear();
            this.txtAdminEmail.Clear();
        }

        #endregion

        #region Event handlers

        /// <summary>
        /// On form load
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
		private void FrmAdminManager_Load(object sender, EventArgs e)
        {
            FillAdministratorList();
        } 

        /// <summary>
        /// Selected index changed in administrator lixt box
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void lbAdmins_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedAdministrator();
        }

        /// <summary>
        /// Button "new" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butNew_Click(object sender, EventArgs e)
        {
            CreateAdministrator();
        }

        /// <summary>
        /// Button "save" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSave_Click(object sender, EventArgs e)
        {
            SaveAdministrator();
        }

        /// <summary>
        /// Button "delete" clicked
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void butDelete_Click(object sender, EventArgs e)
        {
            DeleteAdministrator();
        }

        /// <summary>
        /// Textbox "username" validating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAdminUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtAdminUsername.Text))
            {
                // missing data
                e.Cancel = true;
                Tools.ShowMessageBox(MessageBoxType.Error, Localization.MsgCommonErrorMissingData, this);
            }
        }

        /// <summary>
        /// Textbox "password" validating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAdminPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtAdminPassword.Text))
            {
                // missing data
                e.Cancel = true;
                Tools.ShowMessageBox(MessageBoxType.Error, Localization.MsgCommonErrorMissingData, this);
            }
        }

        /// <summary>
        /// Textbox "email" validating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAdminEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!Validation.IsValidEmail(this.txtAdminEmail.Text))
            {
                // invalid email format
                e.Cancel = true;
                Tools.ShowMessageBox(MessageBoxType.Error, Localization.MsgCommonErrorInvalidFormat, this);
            }
        }

        #endregion

    }
}
