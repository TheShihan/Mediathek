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

namespace MediathekClient.Forms
{
    /// <summary>
    /// Media reservations form
    /// </summary>
    public partial class FrmMediaReservations : FrmDlgBase
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
        /// List to store marked rows in
        /// </summary>
        private List<int> markedRows = new List<int>();

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmMediaReservations()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="session">The current session</param>
        public FrmMediaReservations(SessionInfo session)
            : this()
        {
            this.session = session;
        }

        #endregion

        #region Methos

        /// <summary>
        /// Marks/unmarks all rows according to the user's selection
        /// </summary>
        private void HandleRowMark()
        {
            if (this.session != null)
            {
                DataGridViewCellStyle csDef =
                    new DataGridViewCellStyle(this.dgvReservations.DefaultCellStyle);

                DataGridViewCellStyle csSelected =
                    new DataGridViewCellStyle(csDef);
                csSelected.BackColor = Color.LightGreen;

                foreach (DataGridViewRow dgvRow in this.dgvReservations.Rows)
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

        /// <summary>
        /// Fills the grid with open reservations
        /// </summary>
        private void FillGridData()
        {
            this.bsResult.DataSource = bl.GetOpenReservations();
        }


        /// <summary>
        /// Delete all selected reservations
        /// </summary>
        private void DeleteSelectedReservations()
        {
            if (this.markedRows.Count > 0)
            {
                // delete reservations
                foreach (int rowIx in this.markedRows)
                {
                    DataGridViewRow row = this.dgvReservations.Rows[rowIx];

                    int reservationId = (int)row.Cells[clmReservationId.Index].Value;

                    bl.DeleteReservation(reservationId);
                }

                // cleanup
                this.markedRows.Clear();

                // refresh grid
                FillGridData();

                // success msg
                Tools.ShowMessageBox(MessageBoxType.Info,
                    Localization.MsgCommonInfoDeletionSuccess,
                    this);
            }
            else
            {
                Tools.ShowMessageBox(MessageBoxType.Info,
                    Localization.MsgCommonErrorNothingSelected,
                    this);
            }
        }

        #endregion

        #region Event handlers

        /// <summary>
        /// Button "delete" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedReservations();
        }

        /// <summary>
        /// Row pre paint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvReservations_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            // select the correct category for databound media
            if (dgvReservations.Rows[e.RowIndex].DataBoundItem != null)
            {
                DataGridViewRow row = this.dgvReservations.Rows[e.RowIndex];

                //get a reference to the reservation currently being painted
                var reservation = (Reservation)(row.DataBoundItem);

                // fill values
                row.Cells[clmMediaTitle.Index].Value = reservation.Media.Title;
                row.Cells[clmMediaTag.Index].Value = reservation.Media.Tag;
                row.Cells[clmUserNo.Index].Value = reservation.User.UserId;
                User usr = reservation.User;
                string userDesc = string.Format("{0}, {1}", usr.Surname, usr.Firstname);
                row.Cells[clmUserDesc.Index].Value = userDesc;
            }
        }

        /// <summary>
        /// Cell content clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        /// <summary>
        /// On form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMediaReservations_Load(object sender, EventArgs e)
        {
            FillGridData();
        }

        #endregion

    }
}
