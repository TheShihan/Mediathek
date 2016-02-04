using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Common;
using BusinessLogic;
using MediathekClient.Common;
using DataAccess;

namespace MediathekClient.Forms
{
    /// <summary>
    /// Media task form
    /// </summary>
    public partial class FrmMediaTasks : FrmDlgBase
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

        /// <summary>
        /// The ID of the customer/user that is currently handled
        /// </summary>
        private int currentUserId = 0;

        /// <summary>
        /// The customer search form
        /// </summary>
        private FrmSearchCustomer frmCustomerSearch = null;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmMediaTasks()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="session">The current session</param>
        public FrmMediaTasks(SessionInfo session)
            : this()
        {
            this.session = session;

            this.frmCustomerSearch = new FrmSearchCustomer(this.session);
            this.frmCustomerSearch.Owner = this;

            // attach event handlers
            this.frmCustomerSearch.CustomerSelected += CustomerSearch_CustomerSelected;
            this.session.MediaBasketContentChanged += Session_MediaBasketContentChanged;
        }

        #endregion

        #region Methods

        private void ChangeCurrentCustomer(int customerId)
        {
            // clear old customer
            this.currentUserId = 0;
            this.txtCustomer.Clear();

            // get customer for ID and update view
            try
            {
                User cust = bl.GetUserById(customerId);

                this.currentUserId = cust.UserId;
                this.txtCustomer.Text =
                    string.Format("({2}) {0}, {1}",
                    cust.Surname,
                    cust.Firstname,
                    cust.UserId);
            }
            catch (Exception ex)
            {
                Tools.ShowMessageBoxException(ex, this);
            }
        }

        /// <summary>
        /// Add current media in MediaBasket to media listbox
        /// </summary>
        private void ListMediaAccordingToBasket()
        {
            // remove all old entries
            this.lbMedia.Items.Clear();


            if (this.session != null)
            {
                // add new entries
                List<GenericIntStringItem> mediaList = new List<GenericIntStringItem>();

                foreach (int mediaId in this.session.MediaBasket)
                {
                    try
                    {
                        mediaList.Add(CreateMediaInfoItem(mediaId));
                    }
                    catch (Exception ex)
                    {
                        Tools.ShowMessageBoxException(ex, this);
                    }
                }

                mediaList.Sort();

                this.lbMedia.Items.AddRange(mediaList.ToArray());
            }
        }

        /// <summary>
        /// Generate media Item for listboxes
        /// </summary>
        /// <param name="mediaId">The ID of the media</param>
        /// <returns>Item representing media</returns>
        private GenericIntStringItem CreateMediaInfoItem(int mediaId)
        {
            if (mediaId < 1)
            {
                string exMsg = string.Format(Localization.MsgCommonArgumentException,
                    mediaId.ToString(),
                    mediaId);

                throw new ArgumentException(exMsg);
            }
            
            Media media = bl.GetMediaById(mediaId);
            string mediaDesc =
                media.Description.Length > 15 ?
                    string.Format("{0}{1}", media.Description.Substring(0, 12), "...") :
                    media.Description;
            string mediaTag = media.Tag == null ? "-" : media.Tag;
            return new GenericIntStringItem(mediaId, string.Format("({0}) {1}, {2}", mediaTag, media.Title, mediaDesc));
        }
        
        /// <summary>
        /// Move selected media from one listbox to another
        /// </summary>
        /// <param name="source">Source listbox</param>
        /// <param name="target">Target listbox</param>
        private void MoveMediaInfoItem(ListBox source, ListBox target)
        {
            if (source != null &&
                target != null &&
                source.SelectedItems.Count > 0)
            {
                List<object> selItems = new List<object>();
                List<int> mediaToRemove = new List<int>();

                foreach (object item in source.SelectedItems)
                {
                    selItems.Add(item);
                }

                foreach (object item in selItems)
                {
                    if (item is GenericIntStringItem)
                    {
                        GenericIntStringItem miItem =
                            (GenericIntStringItem)item;

                        if (source == this.lbMedia &&
                            this.session != null)
                        {
                            mediaToRemove.Add(miItem.IntVal);
                        }

                        source.Items.Remove(miItem);

                        target.Items.Add(miItem);
                    }
                }

                // update basket (remove items from basket)
                if (this.session != null && mediaToRemove.Count > 0)
                {
                    this.session.RemoveMediaFromBasket(mediaToRemove);
                }
            }
        }

        /// <summary>
        /// Reserve the media that is currently in the "reservation" listbox
        /// </summary>
        private void ReserveMedia()
        {
            if (this.currentUserId > 0)
            {
                if (this.lbReservation.Items.Count > 0)
                {
                    List<int> mediaForRes = new List<int>();

                    foreach (GenericIntStringItem item in this.lbReservation.Items)
                    {
                        mediaForRes.Add(item.IntVal);    
                    }

                    // create reservations
                    if (mediaForRes.Count > 0)
                    {
                        bl.CreateReservation(mediaForRes, this.currentUserId);
                    }

                    // cleanup
                    this.lbReservation.Items.Clear();

                    // success message
                    Tools.ShowMessageBox(MessageBoxType.Info,
                        Localization.MsgMediaReservationsCreateSuccess,
                        this);
                }
                else
                {
                    // no media to reserve
                    Tools.ShowMessageBox(MessageBoxType.Error,
                        Localization.MsgCommonNoMediaSelected,
                        this);
                }
            }
            else
            {
                // no user selected
                Tools.ShowMessageBox(MessageBoxType.Error,
                    Localization.MsgCommonNoUserSelected,
                    this);
            }
        }

        /// <summary>
        /// Rent media that is currently in the "rent" listbox
        /// </summary>
        private void RentMedia()
        {
            if (this.currentUserId > 0)
            {
                if (this.lbRent.Items.Count > 0)
                {
                    List<GenericIntStringItem> mediaUnavaiable = new List<GenericIntStringItem>();
                    List<int> mediaAvaiable = new List<int>();

                    foreach (GenericIntStringItem item in this.lbRent.Items)
                    {
                        // get media that is longer reserved by another user and not already rented
                        if (bl.IsMediaAvailableForRenting(item.IntVal, this.currentUserId))
                        {
                            mediaAvaiable.Add(item.IntVal);
                        }
                        else
                        {
                            mediaUnavaiable.Add(item);
                        }
                    }

                    // remove media from list that have reservations
                    if (mediaUnavaiable.Count > 0)
                    {
                        StringBuilder sb = new StringBuilder();

                        foreach (GenericIntStringItem item in mediaUnavaiable)
                        {
                            sb.Append(string.Format("{0}{1}", item.StringVal, Environment.NewLine));

                            this.lbRent.Items.Remove(item);
                            
                            // add to reservation list box (how convenient)
                            this.lbReservation.Items.Add(item);
                        }

                        // show information/warning message
                        string mediaAlrdyResMsg =
                            string.Format(Localization.MsgMediaRentAlreadyLongerReservations, sb.ToString());
                        Tools.ShowMessageBox(MessageBoxType.Info,
                            mediaAlrdyResMsg,
                            this);
                    }

                    // rent the rest of the media
                    int createdLendings = bl.CreateLending(mediaAvaiable, this.currentUserId);

                    // cleanup
                    this.lbRent.Items.Clear();

                    if (createdLendings > 0)
                    {
                        // success message
                        Tools.ShowMessageBox(MessageBoxType.Info,
                            Localization.MsgMediaLendingsCreateSuccess,
                            this);
                    }
                    else
                    {
                        // nothing done
                        Tools.ShowMessageBox(MessageBoxType.Error,
                            Localization.MsgMediaLendingsCreateFailure,
                            this);
                    }
                }
                else
                {
                    // no media to rent
                    Tools.ShowMessageBox(MessageBoxType.Error,
                        Localization.MsgCommonNoMediaSelected,
                        this);
                }
            }
            else
            {
                // no user selected
                Tools.ShowMessageBox(MessageBoxType.Error,
                    Localization.MsgCommonNoUserSelected,
                    this);
            }
        }

        #endregion

        /// <summary>
        /// Button "search customer" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSearchCustomer_Click(object sender, EventArgs e)
        {
            if (this.frmCustomerSearch != null)
            {
                this.frmCustomerSearch.ShowDialog(this);
            }
        }

        /// <summary>
        /// A customer has been selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="intVal"></param>
        private void CustomerSearch_CustomerSelected(object sender, int intVal)
        {
            ChangeCurrentCustomer(intVal);
        }

        /// <summary>
        /// Content of media basket has changed
        /// (in user session)
        /// </summary>
        /// <param name="sender"></param>
        private void Session_MediaBasketContentChanged(object sender)
        {
            ListMediaAccordingToBasket();
        }

        /// <summary>
        /// Button "search media" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butMediaSearch_Click(object sender, EventArgs e)
        {
            new FrmMediaTypeSelector(this.session, FormMode.Selector).ShowDialog(this);
        }

        /// <summary>
        /// On form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMediaTasks_Load(object sender, EventArgs e)
        {
            ListMediaAccordingToBasket();
        }

        /// <summary>
        /// Button media to reservation clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butMedia2Rs_Click(object sender, EventArgs e)
        {
            MoveMediaInfoItem(this.lbMedia, this.lbReservation);
        }

        /// <summary>
        /// Button reservation to media clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butRes2Media_Click(object sender, EventArgs e)
        {
            MoveMediaInfoItem(this.lbReservation, this.lbMedia);
        }

        /// <summary>
        /// Button media to rent clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butMedia2Rent_Click(object sender, EventArgs e)
        {
            MoveMediaInfoItem(this.lbMedia, this.lbRent);
        }

        /// <summary>
        /// Button rent to media clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butRent2Media_Click(object sender, EventArgs e)
        {
            MoveMediaInfoItem(this.lbRent, this.lbMedia);
        }

        /// <summary>
        /// Delete media from media list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butDeleteSelected_Click(object sender, EventArgs e)
        {
            if (this.lbMedia.SelectedIndex >= 0 &&
                this.lbMedia.SelectedItem != null &&
                this.session != null)
            {
                // get item
                int mediaId = ((GenericIntStringItem)this.lbMedia.SelectedItem).IntVal;

                // delete from session, this will trigger an update for the view
                this.session.RemoveMediaFromBasket(mediaId);
            }
        }

        /// <summary>
        /// Button "create reservations" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butCreateReservations_Click(object sender, EventArgs e)
        {
            ReserveMedia();
        }

        /// <summary>
        /// Button "rent media" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butCreateLendings_Click(object sender, EventArgs e)
        {
            RentMedia();
        }

    }
}
