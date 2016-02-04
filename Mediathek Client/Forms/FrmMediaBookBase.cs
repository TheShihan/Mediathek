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
    public partial class FrmMediaBookBase : FrmMediaOverviewBase
    {

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        public FrmMediaBookBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="session">The current session</param>
        /// <param name="mediaTypeId">The media type that is being handled</param>
        public FrmMediaBookBase(SessionInfo session, int mediaTypeId)
            : base(session, mediaTypeId)
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Marks/unmarks all media according to the current media basket
        /// </summary>
        protected void MarkSelectedMedias()
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
                    if (dgvRow.Cells[clmMediaId.Name].Value != null)
                    {
                        // get media ID
                        int mediaId = (int)dgvRow.Cells[clmMediaId.Name].Value;

                        if (this.session.MediaBasket.Contains(mediaId))
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
        }

        /// <summary>
        /// Starts the search and populates the datagrid with result that
        /// matches the criterias
        /// </summary>
        private void StartSearch()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                // search
                int? publishingYear = null;
                if (!string.IsNullOrEmpty(this.txtPublishingYear.Text))
                {
                    int pubYear;
                    if (int.TryParse(this.txtPublishingYear.Text, out pubYear))
                    {
                        publishingYear = pubYear;
                    }
                }

                this.bsResult.DataSource = bl.SearchBooks(this.txtTitle.Text,
                                    this.txtDesc.Text,
                                    this.txtAuthor.Text,
                                    this.txtPublisher.Text,
                                    publishingYear,
                                    this.txtTag.Text);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Clear the content of the search related fields
        /// </summary>
        private void ClearSearchFields()
        {
            this.txtAuthor.Clear();
            this.txtDesc.Clear();
            this.txtPublisher.Clear();
            this.txtPublishingYear.Clear();
            this.txtTag.Clear();
            this.txtTitle.Clear();
        }

        /// <summary>
        /// Get category ID value from a given row
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        protected int GetCategoryIdFromRow(DataGridViewRow row)
        {
            if (row == null) throw new ArgumentNullException("row");

            return (int)row.Cells[clmCategoryUnbound.Index].Value;
        }

        /// <summary>
        /// Shows a media by it's ID
        /// </summary>
        /// <param name="mediaId"></param>
        protected void ShowMediaById(int mediaId)
        {
            this.bsResult.DataSource = bl.GetMediaBookById(mediaId);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Get or set if the "AddToBasket" column is visible
        /// </summary>
        public bool IsAddToBasketClmVisible
        {
            set
            {
                this.clmAddToBasket.Visible = value;
            }
            get
            {
                return this.clmAddToBasket.Visible;
            }
        }

        #endregion

        #region Event handlers

        /// <summary>
        /// On form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMediaBase_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                FillCategories();

                // set categories
                this.categoryBindingSource.DataSource = bl.GetCategoriesByMediaTypeId(this.mediaTypeId);

                MarkSelectedMedias();
            }
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
                int mediaId = (int)this.dgvMedia[clmMediaId.Index, e.RowIndex].Value;

                if (e.ColumnIndex == clmImageChg.Index)
                {
                    // image change button clicked
                    if (mediaId > 0)
                    {
                        new FrmMediaImgChanger(this.session, mediaId).ShowDialog(this);
                    }
                    else
                    {
                        // media image can only be shown for already saved media
                        Tools.ShowMessageBox(MessageBoxType.Info,
                            Localization.MsgMediaImageNotShowable,
                            this);
                    }
                }
                else if (e.ColumnIndex == clmAddToBasket.Index && this.session != null)
                {
                    // add selected item to basket
                    if (!this.session.MediaBasket.Contains(mediaId))
                    {
                        // add to basket
                        this.session.AddMediaToBasket(mediaId);
                    }
                    else
                    {
                        // remove from basket
                        this.session.RemoveMediaFromBasket(mediaId);
                    }

                    // highlight selected media
                    MarkSelectedMedias();
                }
            }
        }

        /// <summary>
        /// Button "search" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSearchOk_Click(object sender, EventArgs e)
        {
            StartSearch();
        }

        /// <summary>
        /// Button "clear filter" clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSearchClear_Click(object sender, EventArgs e)
        {
            ClearSearchFields();
        }



        private void dgvMedia_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // select the correct category for databound media
            if (dgvMedia.Rows[e.RowIndex].DataBoundItem != null)
            {
                //get a reference to the reservation currently being painted
                var media = (MediaBook)(dgvMedia.Rows[e.RowIndex].DataBoundItem);

                //push the categories's navigation properties into the correct cells
                var grid = dgvMedia;

                DataGridViewComboBoxCell cbCell =
                    (DataGridViewComboBoxCell)grid.Rows[e.RowIndex].Cells[clmCategoryUnbound.Index];

                cbCell.Value = media.CategoryReference.EntityKey.EntityKeyValues[0].Value;
            }
        }

        /// <summary>
        /// DGV DataBinding completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMedia_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // set the correct category name
            foreach (DataGridViewRow row in this.dgvMedia.Rows)
            {
                // select the correct category for databound media
                if (row.DataBoundItem != null)
                {
                    //get a reference to the reservation currently being painted
                    var media = (MediaBook)row.DataBoundItem;

                    //push the categories's navigation properties into the correct cells
                    var grid = dgvMedia;

                    DataGridViewComboBoxCell cbCell =
                        (DataGridViewComboBoxCell)row.Cells[clmCategoryUnbound.Index];

                    cbCell.Value = media.CategoryReference.EntityKey.EntityKeyValues[0].Value;
                }
            }
        }

        /// <summary>
        /// BS result, data source changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bsResult_DataSourceChanged(object sender, EventArgs e)
        {
            // refresh marked items
            MarkSelectedMedias();
        }

        /// <summary>
        /// DGV cell begin init
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMedia_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (this.dgvMedia != null &&
                this.dgvMedia.Rows.Count > 0 &&
                e.RowIndex >= 0)
            {
                AddChangedRow(e.RowIndex);
            }
        }

        #endregion

    }
}
