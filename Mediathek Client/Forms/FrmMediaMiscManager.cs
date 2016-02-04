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
using BusinessLogic.Exceptions;

namespace MediathekClient.Forms
{
    /// <summary>
    /// Media misc manager
    /// </summary>
    public partial class FrmMediaMiscManager : MediathekClient.Forms.FrmMediaMiscBase
    {

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmMediaMiscManager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="session">The current session</param>
        /// <param name="mediaTypeId">The media type that is being handled</param>
        public FrmMediaMiscManager(SessionInfo session, int mediaTypeId)
            : base(session, mediaTypeId)
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Process for adding new media
        /// </summary>
        private void AddNewMediaProcess()
        {
            int mediaId = AddNewMedia();

            if (mediaId > 0)
            {
                ShowMediaById(mediaId);
            }
        }

        /// <summary>
        /// Save grid rows back to database.
        /// Updates existing medias, inserts new media.
        /// </summary>
        private void Save()
        {
            foreach (int rIx in this.changedRows)
            {
                DataGridViewRow row = this.dgvMedia.Rows[rIx];

                if (row != null && !row.IsNewRow)
                {
                    if (row.DataBoundItem != null)
                    {
                        MediaMisc curMedia = (MediaMisc)row.DataBoundItem;

                        if (curMedia.MediaId > 0)
                        {
                            // update
                            bl.UpdateMediaMisc(curMedia.MediaId,
                                curMedia.Title,
                                curMedia.Description,
                                curMedia.ShortDescription,
                                curMedia.Tag,
                                GetCategoryIdFromRow(row));
                        }
                        else
                        {
                            // insert
                            bl.CreateMediaMisc(curMedia.Title,
                                curMedia.Description,
                                curMedia.ShortDescription,
                                curMedia.Tag,
                                GetCategoryIdFromRow(row));
                        }
                    }
                }
            }

            // mark all changes as handled
            ChangedRowsHandled();

            // refresh data (all media for type)
            this.bsResult.DataSource = bl.GetMediaMiscByCatId(-1);
        }

        /// <summary>
        /// Delete rows from grid and direclty deletes media from the database
        /// (flags as deleted)
        /// </summary>
        private void DeleteSelectedRows()
        {
            if (Tools.ShowMessageBox(MessageBoxType.Question,
                Localization.MsgCommonCommonDeleteConfirmation,
                this) == DialogResult.Yes)
            {
                List<DataGridViewRow> delList = new List<DataGridViewRow>();

                foreach (DataGridViewCell selCell in this.dgvMedia.SelectedCells)
                {
                    DataGridViewRow row = selCell.OwningRow;

                    if (!delList.Contains(row) && !row.IsNewRow && row.DataBoundItem != null)
                    {
                        try
                        {
                            bl.FlagMediaAsDeleted(((MediaMisc)row.DataBoundItem).MediaId);
                            delList.Add(row);
                        }
                        catch (ConditionException ex)
                        {
                            Tools.ShowMessageBoxException(ex, this);
                        }
                    }
                }

                // del rows in grid to represent database status
                if (delList.Count > 0)
                {
                    for (int ii = 0; ii < delList.Count; ii++)
                    {
                        this.dgvMedia.Rows.Remove(delList[ii]);
                    }
                }
            }
        }

        #endregion

        /// <summary>
        /// On form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMediaManager_Load(object sender, EventArgs e)
        {
            // enable media insert and editing
            this.dgvMedia.ReadOnly = false;
            //this.dgvMedia.AllowUserToAddRows = true;
        }

        /// <summary>
        /// Button "save" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        /// <summary>
        /// Button "del rows" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butDelRows_Click(object sender, EventArgs e)
        {
            DeleteSelectedRows();
        }

        /// <summary>
        /// "Add media" button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butNew_Click(object sender, EventArgs e)
        {
            AddNewMediaProcess();
        }

    }
}
