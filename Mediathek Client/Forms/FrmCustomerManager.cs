using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Common;
using BusinessLogic;
using DataAccess;
using MediathekClient.Common;
using BusinessLogic.Exceptions;

namespace MediathekClient.Forms
{
    public partial class FrmCustomerManager : FrmDlgBase
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
        /// Constructor
        /// </summary>
        public FrmCustomerManager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor with session initalization
        /// </summary>
        /// <param name="session">The current session</param>
        public FrmCustomerManager(SessionInfo session)
            : this()
        {
            this.session = session;
        } 

        #endregion

        #region Methods

        /// <summary>
        /// Fill the listbox with all users that are not deleted
        /// </summary>
        private void FillCustomerList()
        {
            // cleanup
            lbCustomers.Items.Clear();

            // get new items
            IList<User> customerList =
                bl.GetUsersNotDeleted();

            foreach (User customer in customerList)
            {
                lbCustomers.Items.Add(customer.UserId);
            }
        }

        /// <summary>
        /// Displays the data for the currently selected customer
        /// </summary>
        private void DisplaySelectedCustomer()
        {
            // clear old data
            ClearCustomerData();

            // load new data by selected ID
            if (lbCustomers.SelectedItems.Count == 1)
            {
                int customerId = (int)this.lbCustomers.SelectedItem;

                try
                {
                    User customer =
                        bl.GetUserByIdIncludeTitle(customerId);

                    // select correct title
                    foreach (GenericIntStringItem item in this.cbTitles.Items)
                    {
                        if (customer.Title != null &&
                            item.IntVal == customer.Title.TitleId)
                        {
                            this.cbTitles.SelectedItem = item;
                            break;
                        }
                    }

                    // fill properties
                    this.txtCity.Text = customer.City;
                    this.txtCountry.Text = customer.CountryIso;
                    this.txtEmail.Text = customer.Email;
                    this.txtFirstname.Text = customer.Firstname;
                    this.txtPassword.Text = customer.Password;
                    this.txtStreet.Text = customer.Street;
                    this.txtSurname.Text = customer.Surname;
                    this.txtZip.Text = customer.Zip;
                }
                catch
                {
                    // user couldn't be loaded
                    Tools.ShowMessageBox(MessageBoxType.Error,
                        Localization.MsgCommonErrorNoDataFound,
                        this);
                }
            }
        }

        /// <summary>
        /// Creates a new customer account with the data that is currently
        /// displayed in the data section.
        /// </summary>
        private void CreateCustomer()
        {
            try
            {
                int? titleId = ((GenericIntStringItem)cbTitles.SelectedItem).IntVal;
                if (titleId <= 0)
                {
                    titleId = null;
                }

                // save to DB
                int userId = bl.CreateUser(this.txtFirstname.Text,
                        this.txtSurname.Text,
                        this.txtStreet.Text,
                        this.txtZip.Text,
                        this.txtCity.Text,
                        this.txtCountry.Text,
                        this.txtEmail.Text,
                        this.txtPassword.Text,
                        titleId);

                // update customer list
                FillCustomerList();

                // select the newly created customer
                this.lbCustomers.Text = userId.ToString();

                this.cbTitles.Select();
            }
            catch (Exception ex)
            {
                Tools.ShowMessageBoxException(ex, this);
            }
        }

        /// <summary>
        /// Updates the data of the currently selected customer 
        /// account to the database.
        /// </summary>
        private void SaveCustomer()
        {
            if (lbCustomers.SelectedItems.Count == 1)
            {
                try
                {
                    int customerId = (int)lbCustomers.SelectedItem;

                    int? titleId = ((GenericIntStringItem)cbTitles.SelectedItem).IntVal;
                    if (titleId <= 0)
                    {
                        titleId = null;
                    }

                    // save changes
                    bl.UpdateUser(customerId,
                        this.txtFirstname.Text,
                        this.txtSurname.Text,
                        this.txtStreet.Text,
                        this.txtZip.Text,
                        this.txtCity.Text,
                        this.txtCountry.Text,
                        this.txtEmail.Text,
                        this.txtPassword.Text,
                        titleId);

                    // info on success
                    Tools.ShowMessageBox(MessageBoxType.Info,
                        Localization.MsgCommonInfoSaveSuccess,
                        this);
                }
                catch (Exception)
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
        /// Deletes the selected customer
        /// </summary>
        private void DeleteCustomer()
        {
            if (lbCustomers.SelectedItems.Count == 1)
            {
                try
                {
                    // mark as deleted
                    bl.DeleteUser((int)lbCustomers.SelectedItem);

                    ClearCustomerData();

                    // reload admin list
                    FillCustomerList();

                    // inform about success
                    Tools.ShowMessageBox(MessageBoxType.Info,
                        Localization.MsgCommonInfoDeletionSuccess,
                        this);
                }
                catch (ConditionException ex)
                {
                    Tools.ShowMessageBoxException(ex, this);
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
                // nothing selected
                Tools.ShowMessageBox(MessageBoxType.Error,
                    Localization.MsgCommonErrorNothingSelected,
                    this);
            }
        }

        /// <summary>
        /// Clears all customer related data from the view
        /// </summary>
        private void ClearCustomerData()
        {
            this.cbTitles.Text = Constants.ComboBoxDefaultItemText;
            this.txtCity.Clear();
            this.txtCountry.Clear();
            this.txtEmail.Clear();
            this.txtFirstname.Clear();
            this.txtPassword.Clear();
            this.txtStreet.Clear();
            this.txtSurname.Clear();
            this.txtZip.Clear();
        }

        /// <summary>
        /// Fill title combobox with titles
        /// </summary>
        private void FillTitles()
        {
            // cleanup
            this.cbTitles.Items.Clear();

            foreach (GenericIntStringItem item in bl.GetTitleListForComboBox())
            {
                this.cbTitles.Items.Add(item);
            }

            // select default entry
            if (this.cbTitles.Items.Count > 0)
            {
                this.cbTitles.Text = Constants.ComboBoxDefaultItemText;
            }
        }

        /// <summary>
        /// Open the customer search
        /// </summary>
        private void OpenCustomerSearch()
        {
            using (FrmSearchCustomer frmCstmSearch = new FrmSearchCustomer(this.session))
            {
                frmCstmSearch.Owner = this;

                frmCstmSearch.CustomerSelected += CustomerSearch_CustomerSelected;

                // show
                frmCstmSearch.ShowDialog(this);

                frmCstmSearch.CustomerSelected -= CustomerSearch_CustomerSelected;
            }
        }
        
        #endregion

        #region Event handlers

        /// <summary>
        /// On form load
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void FrmCustomerManager_Load(object sender, EventArgs e)
        {
            FillTitles();

            FillCustomerList();
        }

        /// <summary>
        /// Listbox "customers", selected index changed
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void lbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedCustomer();
        }

        /// <summary>
        /// Button "new" clicked
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void butNew_Click(object sender, EventArgs e)
        {
            CreateCustomer();
        }

        /// <summary>
        /// Button "save" clicked
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void butSave_Click(object sender, EventArgs e)
        {
            SaveCustomer();
        }

        /// <summary>
        /// Button "delete" clicked
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event args</param>
        private void butDelete_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }

        /// <summary>
        /// Button "search customer" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButSearchCustomer_Click(object sender, EventArgs e)
        {
            OpenCustomerSearch();
        }

        /// <summary>
        /// On customer selection in customer search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="customerId"></param>
        private void CustomerSearch_CustomerSelected(object sender, int customerId)
        {
            this.lbCustomers.Text = customerId.ToString();
        }

        #endregion

    }
}
