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
    public partial class FrmMediaReturn : FrmDlgBase
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

        /// <summary>
        /// List to store marked rows in
        /// </summary>
        private List<int> markedRows = new List<int>();

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmMediaReturn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="session">The current session</param>
        public FrmMediaReturn(SessionInfo session)
            : this()
        {
            this.session = session;

            this.frmCustomerSearch = new FrmSearchCustomer(this.session);
            this.frmCustomerSearch.Owner = this;

            // attach event handlers
            this.frmCustomerSearch.CustomerSelected += CustomerSearch_CustomerSelected;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Change the current customer
        /// </summary>
        /// <param name="customerId">ID of the new customer</param>
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

                // fill grid with user related data
                FillDataGridWithMedia();
            }
            catch (Exception ex)
            {
                Tools.ShowMessageBoxException(ex, this);
            }
        }

        /// <summary>
        /// Fills the DataGridView with media belongig to the current user
        /// </summary>
        private void FillDataGridWithMedia()
        {
            // cleanup
            this.dgvMedia.Rows.Clear();
            this.markedRows.Clear();
            
            if (this.currentUserId > 0)
            {
                this.bsResult.DataSource = bl.GetOpenLendingsByUser(this.currentUserId);

                if (this.bsResult.Count < 1)
                {
                    Tools.ShowMessageBox(MessageBoxType.Info,
                        Localization.MsgMediaUserHasNoOpenLendings,
                        this);
                }
            }
        }

        /// <summary>
        /// Saves the selected media as returned
        /// </summary>
        private void ReturnMedia()
        {
            if (this.markedRows.Count > 0)
            {
                // return media
                foreach (int rowIx in this.markedRows)
                {
                    DataGridViewRow row = this.dgvMedia.Rows[rowIx];

                    int mediaId = (int)row.Cells[clmMediaId.Index].Value;
                    DateTime checkOutDate = (DateTime)row.Cells[clmCheckOutDate.Index].Value;

                    bl.ReturnMedia(this.currentUserId, mediaId, checkOutDate);
                }

                // cleanup
                this.dgvMedia.Rows.Clear();
                this.markedRows.Clear();

                // success msg
                Tools.ShowMessageBox(MessageBoxType.Info,
                    Localization.MsgMediaReturnSuccess,
                    this);
            }
            else
            {
                Tools.ShowMessageBox(MessageBoxType.Info,
                    Localization.MsgCommonErrorNothingSelected,
                    this);
            }
        }

        /// <summary>
        /// Marks/unmarks all rows according to the user's selection
        /// </summary>
        private void HandleRowMark()
        {
            if (this.session != null)
            {
                DataGridViewCellStyle csDef =
                    new DataGridViewCellStyle(this.dgvMedia.DefaultCellStyle);

                DataGridViewCellStyle csSelected =
                    new DataGridViewCellStyle(csDef);
                csSelected.BackColor = Color.LightGreen;

                foreach (DataGridViewRow dgvRow in this.dgvMedia.Rows)
                {
                    if (this.markedRows.Contains(dgvRow.Index))
                    {
                        // mark row
                        dgvRow.DefaultCellStyle = csSelected;
                    }
                    else
                    {
                        // clear row mark
                        dgvRow.DefaultCellStyle = csDef;
                    }
                }
            }
        }

        #endregion

        #region Event handlers

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
        /// Row pre painting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMedia_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // select the correct category for databound media
            if (dgvMedia.Rows[e.RowIndex].DataBoundItem != null)
            {
                //get a reference to the reservation currently being painted
                var rentEntry = (MediaRenting)(dgvMedia.Rows[e.RowIndex].DataBoundItem);

                // fill values
                var grid = dgvMedia;
                grid.Rows[e.RowIndex].Cells[clmTitle.Index].Value = rentEntry.Media.Title;
                grid.Rows[e.RowIndex].Cells[clmType.Index].Value = rentEntry.Media.MediaType.TypeName;
            }
        }

        /// <summary>
        /// Button "return" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butReturn_Click(object sender, EventArgs e)
        {
            ReturnMedia();
        }

        /// <summary>
        /// Cell content clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMedia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.ColumnIndex == this.clmMark.Index)
                {
                    // mark selected column and add to selection list
                    if (this.markedRows.Contains(e.RowIndex))
                    {
                        this.markedRows.Remove(e.RowIndex);
                    }
                    else
                    {
                        this.markedRows.Add(e.RowIndex);
                    }

                    // highlight selected media
                    HandleRowMark();
                }
            }
        }

        #endregion

    }
}
