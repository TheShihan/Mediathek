using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogic.Common;

namespace MediathekClient.Forms
{
    /// <summary>
    /// Customer search form
    /// </summary>
    public partial class FrmSearchCustomer : FrmDlgBase
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
        /// Event that shall be fired when a customer has been selected (on OK)
        /// </summary>
        public event IntTakerDelegate CustomerSelected = null;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmSearchCustomer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="session">The current session</param>
        public FrmSearchCustomer(SessionInfo session)
            : this()
        {
            this.session = session;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Event raiser, when customer has been selected
        /// </summary>
        protected virtual void RaiseCustomerSelectedEvent(int customerId)
        {
            // Raise the event by using the () operator.
            if (CustomerSelected != null)
            {
                CustomerSelected(this, customerId);
            }
        }

        /// <summary>
        /// Search creditor according to the current criteria
        /// </summary>
        private void SearchUser()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                int? userId = null;
                if (!string.IsNullOrEmpty(this.txtUserId.Text))
                {
                    userId = Convert.ToInt32(this.txtUserId.Text);
                }

                this.bindingSourceResult.DataSource =
                    bl.SearchUser(userId, this.txtFirstname.Text, this.txtLastname.Text);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #endregion

        #region Event handlers

        /// <summary>
        /// Button "search" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSearch_Click(object sender, EventArgs e)
        {
            SearchUser();
        }

        /// <summary>
        /// Button "OK" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Button "close" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// The form has been closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSearchCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                if (this.dgvResult != null && this.dgvResult.SelectedRows.Count == 1)
                {
                    DataGridViewCell cell =
                        this.dgvResult.SelectedRows[0].Cells[userIdDataGridViewTextBoxColumn.Name];

                    if (cell != null)
                    {
                        RaiseCustomerSelectedEvent((int)cell.Value);
                    }
                }
            }
        }

        /// <summary>
        /// Cell double click performed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        #endregion

        

    }
}
