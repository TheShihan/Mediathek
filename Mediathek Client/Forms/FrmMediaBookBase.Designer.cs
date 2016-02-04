namespace MediathekClient.Forms
{
    /// <summary>
    /// Media book base
    /// </summary>
    partial class FrmMediaBookBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishingYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentingsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMedia = new System.Windows.Forms.DataGridView();
            this.clmMediaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddToBasket = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPublisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPublishingYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategory = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmCategoryUnbound = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImageChg = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmMediaType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishingYearDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.categoryDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentingsDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaStateDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationsDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaTypeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishingYearDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.categoryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentingsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaStateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtPublishingYear = new System.Windows.Forms.TextBox();
            this.lblPublishingYear = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.pnlMediaSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).BeginInit();
            this.gbMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMediaSearch
            // 
            this.pnlMediaSearch.Controls.Add(this.txtTag);
            this.pnlMediaSearch.Controls.Add(this.lblTag);
            this.pnlMediaSearch.Controls.Add(this.txtPublishingYear);
            this.pnlMediaSearch.Controls.Add(this.lblPublishingYear);
            this.pnlMediaSearch.Controls.Add(this.txtPublisher);
            this.pnlMediaSearch.Controls.Add(this.lblPublisher);
            this.pnlMediaSearch.Controls.Add(this.txtAuthor);
            this.pnlMediaSearch.Controls.Add(this.lblAuthor);
            this.pnlMediaSearch.Controls.Add(this.txtDesc);
            this.pnlMediaSearch.Controls.Add(this.lblDesc);
            this.pnlMediaSearch.Controls.Add(this.txtTitle);
            this.pnlMediaSearch.Controls.Add(this.lblTitle);
            this.pnlMediaSearch.Controls.SetChildIndex(this.lblTitle, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.txtTitle, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.butSearchOk, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.butSearchClear, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.lblDesc, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.txtDesc, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.lblAuthor, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.txtAuthor, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.lblPublisher, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.txtPublisher, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.lblPublishingYear, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.txtPublishingYear, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.lblTag, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.txtTag, 0);
            // 
            // bsMedia
            // 
            this.bsMedia.DataSource = typeof(DataAccess.MediaBook);
            // 
            // bsResult
            // 
            this.bsResult.DataSourceChanged += new System.EventHandler(this.bsResult_DataSourceChanged);
            // 
            // gbMedia
            // 
            this.gbMedia.Controls.Add(this.dgvMedia);
            this.gbMedia.Controls.SetChildIndex(this.dgvMedia, 0);
            this.gbMedia.Controls.SetChildIndex(this.pnlMediaSearch, 0);
            // 
            // butSearchClear
            // 
            this.butSearchClear.Click += new System.EventHandler(this.butSearchClear_Click);
            // 
            // butSearchOk
            // 
            this.butSearchOk.Click += new System.EventHandler(this.butSearchOk_Click);
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // publishingYearDataGridViewTextBoxColumn
            // 
            this.publishingYearDataGridViewTextBoxColumn.DataPropertyName = "PublishingYear";
            this.publishingYearDataGridViewTextBoxColumn.HeaderText = "PublishingYear";
            this.publishingYearDataGridViewTextBoxColumn.Name = "publishingYearDataGridViewTextBoxColumn";
            // 
            // mediaIdDataGridViewTextBoxColumn
            // 
            this.mediaIdDataGridViewTextBoxColumn.DataPropertyName = "MediaId";
            this.mediaIdDataGridViewTextBoxColumn.HeaderText = "MediaId";
            this.mediaIdDataGridViewTextBoxColumn.Name = "mediaIdDataGridViewTextBoxColumn";
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.HeaderText = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "Tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "Tag";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // rentingsDataGridViewTextBoxColumn
            // 
            this.rentingsDataGridViewTextBoxColumn.DataPropertyName = "Rentings";
            this.rentingsDataGridViewTextBoxColumn.HeaderText = "Rentings";
            this.rentingsDataGridViewTextBoxColumn.Name = "rentingsDataGridViewTextBoxColumn";
            // 
            // mediaStateDataGridViewTextBoxColumn
            // 
            this.mediaStateDataGridViewTextBoxColumn.DataPropertyName = "MediaState";
            this.mediaStateDataGridViewTextBoxColumn.HeaderText = "MediaState";
            this.mediaStateDataGridViewTextBoxColumn.Name = "mediaStateDataGridViewTextBoxColumn";
            // 
            // reservationsDataGridViewTextBoxColumn
            // 
            this.reservationsDataGridViewTextBoxColumn.DataPropertyName = "Reservations";
            this.reservationsDataGridViewTextBoxColumn.HeaderText = "Reservations";
            this.reservationsDataGridViewTextBoxColumn.Name = "reservationsDataGridViewTextBoxColumn";
            // 
            // mediaTypeDataGridViewTextBoxColumn
            // 
            this.mediaTypeDataGridViewTextBoxColumn.DataPropertyName = "MediaType";
            this.mediaTypeDataGridViewTextBoxColumn.HeaderText = "MediaType";
            this.mediaTypeDataGridViewTextBoxColumn.Name = "mediaTypeDataGridViewTextBoxColumn";
            // 
            // dgvMedia
            // 
            this.dgvMedia.AllowUserToAddRows = false;
            this.dgvMedia.AllowUserToDeleteRows = false;
            this.dgvMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedia.AutoGenerateColumns = false;
            this.dgvMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMediaId,
            this.clmAddToBasket,
            this.clmTitle,
            this.clmDescription,
            this.clmAuthor,
            this.clmPublisher,
            this.clmPublishingYear,
            this.clmTag,
            this.clmCategory,
            this.clmCategoryUnbound,
            this.clmCreationDate,
            this.clmImageChg,
            this.clmMediaType});
            this.dgvMedia.DataSource = this.bsResult;
            this.dgvMedia.Location = new System.Drawing.Point(6, 138);
            this.dgvMedia.Name = "dgvMedia";
            this.dgvMedia.ReadOnly = true;
            this.dgvMedia.Size = new System.Drawing.Size(702, 369);
            this.dgvMedia.TabIndex = 1;
            this.dgvMedia.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvMedia_CellBeginEdit);
            this.dgvMedia.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMedia_DataBindingComplete);
            this.dgvMedia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedia_CellContentClick);
            // 
            // clmMediaId
            // 
            this.clmMediaId.DataPropertyName = "MediaId";
            this.clmMediaId.HeaderText = "MediaId";
            this.clmMediaId.Name = "clmMediaId";
            this.clmMediaId.ReadOnly = true;
            this.clmMediaId.Visible = false;
            // 
            // clmAddToBasket
            // 
            this.clmAddToBasket.HeaderText = "Auswählen";
            this.clmAddToBasket.Name = "clmAddToBasket";
            this.clmAddToBasket.ReadOnly = true;
            this.clmAddToBasket.Visible = false;
            // 
            // clmTitle
            // 
            this.clmTitle.DataPropertyName = "Title";
            this.clmTitle.HeaderText = "Titel";
            this.clmTitle.MaxInputLength = 100;
            this.clmTitle.Name = "clmTitle";
            this.clmTitle.ReadOnly = true;
            // 
            // clmDescription
            // 
            this.clmDescription.DataPropertyName = "Description";
            this.clmDescription.HeaderText = "Beschreibung";
            this.clmDescription.MaxInputLength = 5000;
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.ReadOnly = true;
            // 
            // clmAuthor
            // 
            this.clmAuthor.DataPropertyName = "Author";
            this.clmAuthor.HeaderText = "Autor";
            this.clmAuthor.MaxInputLength = 100;
            this.clmAuthor.Name = "clmAuthor";
            this.clmAuthor.ReadOnly = true;
            // 
            // clmPublisher
            // 
            this.clmPublisher.DataPropertyName = "Publisher";
            this.clmPublisher.HeaderText = "Verlag";
            this.clmPublisher.MaxInputLength = 50;
            this.clmPublisher.Name = "clmPublisher";
            this.clmPublisher.ReadOnly = true;
            // 
            // clmPublishingYear
            // 
            this.clmPublishingYear.DataPropertyName = "PublishingYear";
            this.clmPublishingYear.HeaderText = "Erscheinungsjahr";
            this.clmPublishingYear.MaxInputLength = 4;
            this.clmPublishingYear.Name = "clmPublishingYear";
            this.clmPublishingYear.ReadOnly = true;
            // 
            // clmTag
            // 
            this.clmTag.DataPropertyName = "Tag";
            this.clmTag.HeaderText = "Tag";
            this.clmTag.MaxInputLength = 255;
            this.clmTag.Name = "clmTag";
            this.clmTag.ReadOnly = true;
            // 
            // clmCategory
            // 
            this.clmCategory.DataPropertyName = "Category";
            this.clmCategory.HeaderText = "Kat. (Bound)";
            this.clmCategory.Name = "clmCategory";
            this.clmCategory.ReadOnly = true;
            this.clmCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmCategory.Visible = false;
            // 
            // clmCategoryUnbound
            // 
            this.clmCategoryUnbound.DataSource = this.categoryBindingSource;
            this.clmCategoryUnbound.DisplayMember = "Name";
            this.clmCategoryUnbound.HeaderText = "Kategorie";
            this.clmCategoryUnbound.Name = "clmCategoryUnbound";
            this.clmCategoryUnbound.ReadOnly = true;
            this.clmCategoryUnbound.ValueMember = "CategoryId";
            // 
            // clmCreationDate
            // 
            this.clmCreationDate.DataPropertyName = "CreationDate";
            this.clmCreationDate.HeaderText = "Erstell-Datum";
            this.clmCreationDate.Name = "clmCreationDate";
            this.clmCreationDate.ReadOnly = true;
            this.clmCreationDate.Visible = false;
            // 
            // clmImageChg
            // 
            this.clmImageChg.HeaderText = "Bild";
            this.clmImageChg.Name = "clmImageChg";
            this.clmImageChg.ReadOnly = true;
            this.clmImageChg.Text = "";
            this.clmImageChg.Width = 30;
            // 
            // clmMediaType
            // 
            this.clmMediaType.DataPropertyName = "MediaType";
            this.clmMediaType.HeaderText = "Medien-Typ";
            this.clmMediaType.Name = "clmMediaType";
            this.clmMediaType.ReadOnly = true;
            this.clmMediaType.Visible = false;
            // 
            // authorDataGridViewTextBoxColumn2
            // 
            this.authorDataGridViewTextBoxColumn2.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn2.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn2.Name = "authorDataGridViewTextBoxColumn2";
            // 
            // publisherDataGridViewTextBoxColumn2
            // 
            this.publisherDataGridViewTextBoxColumn2.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn2.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn2.Name = "publisherDataGridViewTextBoxColumn2";
            // 
            // publishingYearDataGridViewTextBoxColumn2
            // 
            this.publishingYearDataGridViewTextBoxColumn2.DataPropertyName = "PublishingYear";
            this.publishingYearDataGridViewTextBoxColumn2.HeaderText = "PublishingYear";
            this.publishingYearDataGridViewTextBoxColumn2.Name = "publishingYearDataGridViewTextBoxColumn2";
            // 
            // mediaIdDataGridViewTextBoxColumn2
            // 
            this.mediaIdDataGridViewTextBoxColumn2.DataPropertyName = "MediaId";
            this.mediaIdDataGridViewTextBoxColumn2.HeaderText = "MediaId";
            this.mediaIdDataGridViewTextBoxColumn2.Name = "mediaIdDataGridViewTextBoxColumn2";
            // 
            // creationDateDataGridViewTextBoxColumn2
            // 
            this.creationDateDataGridViewTextBoxColumn2.DataPropertyName = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn2.HeaderText = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn2.Name = "creationDateDataGridViewTextBoxColumn2";
            // 
            // titleDataGridViewTextBoxColumn2
            // 
            this.titleDataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn2.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn2.Name = "titleDataGridViewTextBoxColumn2";
            // 
            // tagDataGridViewTextBoxColumn2
            // 
            this.tagDataGridViewTextBoxColumn2.DataPropertyName = "Tag";
            this.tagDataGridViewTextBoxColumn2.HeaderText = "Tag";
            this.tagDataGridViewTextBoxColumn2.Name = "tagDataGridViewTextBoxColumn2";
            // 
            // descriptionDataGridViewTextBoxColumn2
            // 
            this.descriptionDataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn2.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn2.Name = "descriptionDataGridViewTextBoxColumn2";
            // 
            // imageDataGridViewImageColumn2
            // 
            this.imageDataGridViewImageColumn2.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn2.HeaderText = "Image";
            this.imageDataGridViewImageColumn2.Name = "imageDataGridViewImageColumn2";
            // 
            // categoryDataGridViewTextBoxColumn2
            // 
            this.categoryDataGridViewTextBoxColumn2.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn2.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn2.Name = "categoryDataGridViewTextBoxColumn2";
            // 
            // rentingsDataGridViewTextBoxColumn2
            // 
            this.rentingsDataGridViewTextBoxColumn2.DataPropertyName = "Rentings";
            this.rentingsDataGridViewTextBoxColumn2.HeaderText = "Rentings";
            this.rentingsDataGridViewTextBoxColumn2.Name = "rentingsDataGridViewTextBoxColumn2";
            // 
            // mediaStateDataGridViewTextBoxColumn2
            // 
            this.mediaStateDataGridViewTextBoxColumn2.DataPropertyName = "MediaState";
            this.mediaStateDataGridViewTextBoxColumn2.HeaderText = "MediaState";
            this.mediaStateDataGridViewTextBoxColumn2.Name = "mediaStateDataGridViewTextBoxColumn2";
            // 
            // reservationsDataGridViewTextBoxColumn2
            // 
            this.reservationsDataGridViewTextBoxColumn2.DataPropertyName = "Reservations";
            this.reservationsDataGridViewTextBoxColumn2.HeaderText = "Reservations";
            this.reservationsDataGridViewTextBoxColumn2.Name = "reservationsDataGridViewTextBoxColumn2";
            // 
            // mediaTypeDataGridViewTextBoxColumn2
            // 
            this.mediaTypeDataGridViewTextBoxColumn2.DataPropertyName = "MediaType";
            this.mediaTypeDataGridViewTextBoxColumn2.HeaderText = "MediaType";
            this.mediaTypeDataGridViewTextBoxColumn2.Name = "mediaTypeDataGridViewTextBoxColumn2";
            // 
            // authorDataGridViewTextBoxColumn1
            // 
            this.authorDataGridViewTextBoxColumn1.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn1.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn1.Name = "authorDataGridViewTextBoxColumn1";
            // 
            // publisherDataGridViewTextBoxColumn1
            // 
            this.publisherDataGridViewTextBoxColumn1.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn1.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn1.Name = "publisherDataGridViewTextBoxColumn1";
            // 
            // publishingYearDataGridViewTextBoxColumn1
            // 
            this.publishingYearDataGridViewTextBoxColumn1.DataPropertyName = "PublishingYear";
            this.publishingYearDataGridViewTextBoxColumn1.HeaderText = "PublishingYear";
            this.publishingYearDataGridViewTextBoxColumn1.Name = "publishingYearDataGridViewTextBoxColumn1";
            // 
            // mediaIdDataGridViewTextBoxColumn1
            // 
            this.mediaIdDataGridViewTextBoxColumn1.DataPropertyName = "MediaId";
            this.mediaIdDataGridViewTextBoxColumn1.HeaderText = "MediaId";
            this.mediaIdDataGridViewTextBoxColumn1.Name = "mediaIdDataGridViewTextBoxColumn1";
            // 
            // creationDateDataGridViewTextBoxColumn1
            // 
            this.creationDateDataGridViewTextBoxColumn1.DataPropertyName = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn1.HeaderText = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn1.Name = "creationDateDataGridViewTextBoxColumn1";
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            // 
            // tagDataGridViewTextBoxColumn1
            // 
            this.tagDataGridViewTextBoxColumn1.DataPropertyName = "Tag";
            this.tagDataGridViewTextBoxColumn1.HeaderText = "Tag";
            this.tagDataGridViewTextBoxColumn1.Name = "tagDataGridViewTextBoxColumn1";
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            // 
            // imageDataGridViewImageColumn1
            // 
            this.imageDataGridViewImageColumn1.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn1.HeaderText = "Image";
            this.imageDataGridViewImageColumn1.Name = "imageDataGridViewImageColumn1";
            // 
            // categoryDataGridViewTextBoxColumn1
            // 
            this.categoryDataGridViewTextBoxColumn1.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn1.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn1.Name = "categoryDataGridViewTextBoxColumn1";
            // 
            // rentingsDataGridViewTextBoxColumn1
            // 
            this.rentingsDataGridViewTextBoxColumn1.DataPropertyName = "Rentings";
            this.rentingsDataGridViewTextBoxColumn1.HeaderText = "Rentings";
            this.rentingsDataGridViewTextBoxColumn1.Name = "rentingsDataGridViewTextBoxColumn1";
            // 
            // mediaStateDataGridViewTextBoxColumn1
            // 
            this.mediaStateDataGridViewTextBoxColumn1.DataPropertyName = "MediaState";
            this.mediaStateDataGridViewTextBoxColumn1.HeaderText = "MediaState";
            this.mediaStateDataGridViewTextBoxColumn1.Name = "mediaStateDataGridViewTextBoxColumn1";
            // 
            // reservationsDataGridViewTextBoxColumn1
            // 
            this.reservationsDataGridViewTextBoxColumn1.DataPropertyName = "Reservations";
            this.reservationsDataGridViewTextBoxColumn1.HeaderText = "Reservations";
            this.reservationsDataGridViewTextBoxColumn1.Name = "reservationsDataGridViewTextBoxColumn1";
            // 
            // mediaTypeDataGridViewTextBoxColumn1
            // 
            this.mediaTypeDataGridViewTextBoxColumn1.DataPropertyName = "MediaType";
            this.mediaTypeDataGridViewTextBoxColumn1.HeaderText = "MediaType";
            this.mediaTypeDataGridViewTextBoxColumn1.Name = "mediaTypeDataGridViewTextBoxColumn1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(3, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Titel:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(117, 14);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(117, 40);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 5;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(3, 43);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(75, 13);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "Beschreibung:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(348, 14);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 7;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(234, 17);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(35, 13);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Autor:";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(348, 40);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(100, 20);
            this.txtPublisher.TabIndex = 9;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(234, 43);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(40, 13);
            this.lblPublisher.TabIndex = 8;
            this.lblPublisher.Text = "Verlag:";
            // 
            // txtPublishingYear
            // 
            this.txtPublishingYear.Location = new System.Drawing.Point(582, 14);
            this.txtPublishingYear.Name = "txtPublishingYear";
            this.txtPublishingYear.Size = new System.Drawing.Size(100, 20);
            this.txtPublishingYear.TabIndex = 11;
            // 
            // lblPublishingYear
            // 
            this.lblPublishingYear.AutoSize = true;
            this.lblPublishingYear.Location = new System.Drawing.Point(468, 17);
            this.lblPublishingYear.Name = "lblPublishingYear";
            this.lblPublishingYear.Size = new System.Drawing.Size(91, 13);
            this.lblPublishingYear.TabIndex = 10;
            this.lblPublishingYear.Text = "Erscheinungsjahr:";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(582, 40);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(100, 20);
            this.txtTag.TabIndex = 13;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(468, 43);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(29, 13);
            this.lblTag.TabIndex = 12;
            this.lblTag.Text = "Tag:";
            // 
            // FrmMediaBookBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(966, 592);
            this.Name = "FrmMediaBookBase";
            this.Load += new System.EventHandler(this.FrmMediaBase_Load);
            this.pnlMediaSearch.ResumeLayout(false);
            this.pnlMediaSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).EndInit();
            this.gbMedia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishingYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentingsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishingYearDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentingsDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaStateDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationsDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaTypeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishingYearDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentingsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaStateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.TextBox txtPublishingYear;
        private System.Windows.Forms.Label lblPublishingYear;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        /// <summary>
        /// DataGridView for media
        /// </summary>
        protected System.Windows.Forms.DataGridView dgvMedia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMediaId;
        private System.Windows.Forms.DataGridViewButtonColumn clmAddToBasket;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPublisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPublishingYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTag;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmCategory;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmCategoryUnbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCreationDate;
        private System.Windows.Forms.DataGridViewButtonColumn clmImageChg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMediaType;
    }
}
