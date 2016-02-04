using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogic.Common;
using BusinessLogic;

namespace MediathekClient.Forms
{
    public partial class FrmMediaOverviewBase : FrmDlgBase
    {

        #region Fields

        /// <summary>
        /// The current session
        /// </summary>
        protected SessionInfo session = null;

        /// <summary>
        /// Bussines logic handler class
        /// </summary>
        protected BusinessLogicHandler bl = new BusinessLogicHandler();

        /// <summary>
        /// The media type ID that is being handled
        /// </summary>
        protected int mediaTypeId;

        /// <summary>
        /// List which stores row indizes of rows that have been changed
        /// </summary>
        protected List<int> changedRows = new List<int>();

        ///// <summary>
        ///// Event that shall be fired when a media has been selected (on OK/Select)
        ///// </summary>
        //public event IntTakerDelegate MediaSelected = null;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmMediaOverviewBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="session">The current session</param>
        /// <param name="mediaTypeId">The ID of the media type</param>
        public FrmMediaOverviewBase(SessionInfo session, int mediaTypeId)
            : this()
        {
            this.session = session;
            this.mediaTypeId = mediaTypeId;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Fill the categories for a specified media type
        /// </summary>
        protected void FillCategories()
        {
            Helper.FillCategories(this.tvCategories, this.mediaTypeId);

            this.tvCategories.ExpandAll();
        }

        /// <summary>
        /// Add row index to list of changed rows
        /// </summary>
        /// <param name="row">Row that has been changed</param>
        protected void AddChangedRow(DataGridViewRow row)
        {
            AddChangedRow(row.Index);
        }

        /// <summary>
        /// Add row index to list of changed rows
        /// </summary>
        /// <param name="rowIndex">Index of changed row</param>
        protected void AddChangedRow(int rowIndex)
        {
            if (this.changedRows == null)
            {
                this.changedRows = new List<int>();
            }

            // add only when not already in list
            if (!this.changedRows.Contains(rowIndex))
            {
                this.changedRows.Add(rowIndex);
            }
        }

        /// <summary>
        /// Set all changed rows as handled
        /// </summary>
        protected void ChangedRowsHandled()
        {
            this.changedRows.Clear();
        }

        ///// <summary>
        ///// Event raiser, when customer has been selected
        ///// </summary>
        //protected virtual void RaiseCustomerSelectedEvent(int mediaId)
        //{
        //    // Raise the event by using the () operator.
        //    if (MediaSelected != null)
        //    {
        //        MediaSelected(this, mediaId);
        //    }
        //}

        /// <summary>
        /// Shows dialog to add a new media to the database
        /// </summary>
        protected int AddNewMedia()
        {
            if (this.session != null)
            {
                GenericIntItem mediaIdContainer = new GenericIntItem(0);

                FrmMediaAdd frmMediaAdd = new FrmMediaAdd(this.session, this.mediaTypeId, mediaIdContainer);
                frmMediaAdd.Owner = this;

                if (frmMediaAdd.ShowDialog(this) == DialogResult.OK)
                {
                    return mediaIdContainer.IntVal;
                }
            }

            return -1;
        }

        #endregion

        /// <summary>
        /// Node has been selected in TreeView
        /// </summary>cat
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvCategories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e != null)
            {
                TreeNode tn = e.Node;

                if (tn != null)
                {
                    // get category ID
                    int catId = e.Node.SelectedImageIndex; // we used a trick to store cat ID

                    // fill media according to category (and mediaType)
                    switch (this.mediaTypeId)
                    {
                        case 1:
                            // books
                            this.bsResult.DataSource = bl.GetMediaBooksByCatId(catId);
                            break;
                        case 2:
                            // music
                            this.bsResult.DataSource = bl.GetMediaMusicByCatId(catId);
                            break;
                        case 3:
                            // videos
                            this.bsResult.DataSource = bl.GetMediaVideoByCatId(catId);
                            break;
                        case 4:
                            // misc
                            this.bsResult.DataSource = bl.GetMediaMiscByCatId(catId);
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// TreeView lost focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvCategories_Leave(object sender, EventArgs e)
        {
            // deselect node to make sure the category search is always refreshed
            this.tvCategories.SelectedNode = null;
        }

        /// <summary>
        /// Data source has changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bsResult_DataSourceChanged(object sender, EventArgs e)
        {
            // clear flags for changed rows
            ChangedRowsHandled();
        }

    }
}
