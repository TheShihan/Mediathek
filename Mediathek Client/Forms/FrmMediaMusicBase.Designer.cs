namespace MediathekClient.Forms
{
    /// <summary>
    /// Media music base
    /// </summary>
    partial class FrmMediaMusicBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMediaMusicBase));
            this.dgvMedia = new System.Windows.Forms.DataGridView();
            this.clmMediaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddToBasket = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTrackList = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategoryUnbound = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmImageChg = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTrackList = new System.Windows.Forms.TextBox();
            this.lblTrackList = new System.Windows.Forms.Label();
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
            this.pnlMediaSearch.Controls.Add(this.txtTrackList);
            this.pnlMediaSearch.Controls.Add(this.lblTrackList);
            this.pnlMediaSearch.Controls.Add(this.txtTag);
            this.pnlMediaSearch.Controls.Add(this.lblTag);
            this.pnlMediaSearch.Controls.Add(this.txtGenre);
            this.pnlMediaSearch.Controls.Add(this.lblGenre);
            this.pnlMediaSearch.Controls.Add(this.txtArtist);
            this.pnlMediaSearch.Controls.Add(this.lblArtist);
            this.pnlMediaSearch.Controls.Add(this.txtDesc);
            this.pnlMediaSearch.Controls.Add(this.lblDesc);
            this.pnlMediaSearch.Controls.Add(this.txtTitle);
            this.pnlMediaSearch.Controls.Add(this.lblTitle);
            this.pnlMediaSearch.Controls.SetChildIndex(this.butSearchOk, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.butSearchClear, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.lblTitle, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.txtTitle, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.lblDesc, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.txtDesc, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.lblArtist, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.txtArtist, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.lblGenre, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.txtGenre, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.lblTag, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.txtTag, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.lblTrackList, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.txtTrackList, 0);
            // 
            // bsMedia
            // 
            this.bsMedia.DataSource = typeof(DataAccess.MediaMusic);
            // 
            // bsResult
            // 
            this.bsResult.DataSourceChanged += new System.EventHandler(this.bsResult_DataSourceChanged);
            // 
            // gbMedia
            // 
            this.gbMedia.Controls.Add(this.dgvMedia);
            this.gbMedia.Controls.SetChildIndex(this.pnlMediaSearch, 0);
            this.gbMedia.Controls.SetChildIndex(this.dgvMedia, 0);
            // 
            // butSearchClear
            // 
            this.butSearchClear.Click += new System.EventHandler(this.butSearchClear_Click);
            // 
            // butSearchOk
            // 
            this.butSearchOk.Click += new System.EventHandler(this.butSearchOk_Click);
            // 
            // dgvMedia
            // 
            this.dgvMedia.AllowUserToAddRows = false;
            this.dgvMedia.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dgvMedia, "dgvMedia");
            this.dgvMedia.AutoGenerateColumns = false;
            this.dgvMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMediaId,
            this.clmAddToBasket,
            this.clmTitle,
            this.clmDesc,
            this.clmArtist,
            this.clmGenre,
            this.clmTrackList,
            this.clmTag,
            this.clmCategoryUnbound,
            this.clmImageChg});
            this.dgvMedia.DataSource = this.bsResult;
            this.dgvMedia.Name = "dgvMedia";
            this.dgvMedia.ReadOnly = true;
            this.dgvMedia.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvMedia_CellBeginEdit);
            this.dgvMedia.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvMedia_DataBindingComplete);
            this.dgvMedia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedia_CellContentClick);
            // 
            // clmMediaId
            // 
            this.clmMediaId.DataPropertyName = "MediaId";
            resources.ApplyResources(this.clmMediaId, "clmMediaId");
            this.clmMediaId.Name = "clmMediaId";
            this.clmMediaId.ReadOnly = true;
            // 
            // clmAddToBasket
            // 
            resources.ApplyResources(this.clmAddToBasket, "clmAddToBasket");
            this.clmAddToBasket.Name = "clmAddToBasket";
            this.clmAddToBasket.ReadOnly = true;
            // 
            // clmTitle
            // 
            this.clmTitle.DataPropertyName = "Title";
            resources.ApplyResources(this.clmTitle, "clmTitle");
            this.clmTitle.MaxInputLength = 100;
            this.clmTitle.Name = "clmTitle";
            this.clmTitle.ReadOnly = true;
            // 
            // clmDesc
            // 
            this.clmDesc.DataPropertyName = "Description";
            resources.ApplyResources(this.clmDesc, "clmDesc");
            this.clmDesc.Name = "clmDesc";
            this.clmDesc.ReadOnly = true;
            // 
            // clmArtist
            // 
            this.clmArtist.DataPropertyName = "Artist";
            resources.ApplyResources(this.clmArtist, "clmArtist");
            this.clmArtist.MaxInputLength = 50;
            this.clmArtist.Name = "clmArtist";
            this.clmArtist.ReadOnly = true;
            // 
            // clmGenre
            // 
            this.clmGenre.DataPropertyName = "Genre";
            resources.ApplyResources(this.clmGenre, "clmGenre");
            this.clmGenre.MaxInputLength = 20;
            this.clmGenre.Name = "clmGenre";
            this.clmGenre.ReadOnly = true;
            // 
            // clmTrackList
            // 
            this.clmTrackList.DataPropertyName = "Tracklist";
            resources.ApplyResources(this.clmTrackList, "clmTrackList");
            this.clmTrackList.Name = "clmTrackList";
            this.clmTrackList.ReadOnly = true;
            // 
            // clmTag
            // 
            this.clmTag.DataPropertyName = "Tag";
            resources.ApplyResources(this.clmTag, "clmTag");
            this.clmTag.MaxInputLength = 255;
            this.clmTag.Name = "clmTag";
            this.clmTag.ReadOnly = true;
            // 
            // clmCategoryUnbound
            // 
            this.clmCategoryUnbound.DataSource = this.categoryBindingSource;
            this.clmCategoryUnbound.DisplayMember = "Name";
            resources.ApplyResources(this.clmCategoryUnbound, "clmCategoryUnbound");
            this.clmCategoryUnbound.Name = "clmCategoryUnbound";
            this.clmCategoryUnbound.ReadOnly = true;
            this.clmCategoryUnbound.ValueMember = "CategoryId";
            // 
            // clmImageChg
            // 
            resources.ApplyResources(this.clmImageChg, "clmImageChg");
            this.clmImageChg.Name = "clmImageChg";
            this.clmImageChg.ReadOnly = true;
            this.clmImageChg.Text = "";
            // 
            // txtTag
            // 
            resources.ApplyResources(this.txtTag, "txtTag");
            this.txtTag.Name = "txtTag";
            // 
            // lblTag
            // 
            resources.ApplyResources(this.lblTag, "lblTag");
            this.lblTag.Name = "lblTag";
            // 
            // txtGenre
            // 
            resources.ApplyResources(this.txtGenre, "txtGenre");
            this.txtGenre.Name = "txtGenre";
            // 
            // lblGenre
            // 
            resources.ApplyResources(this.lblGenre, "lblGenre");
            this.lblGenre.Name = "lblGenre";
            // 
            // txtArtist
            // 
            resources.ApplyResources(this.txtArtist, "txtArtist");
            this.txtArtist.Name = "txtArtist";
            // 
            // lblArtist
            // 
            resources.ApplyResources(this.lblArtist, "lblArtist");
            this.lblArtist.Name = "lblArtist";
            // 
            // txtDesc
            // 
            resources.ApplyResources(this.txtDesc, "txtDesc");
            this.txtDesc.Name = "txtDesc";
            // 
            // lblDesc
            // 
            resources.ApplyResources(this.lblDesc, "lblDesc");
            this.lblDesc.Name = "lblDesc";
            // 
            // txtTitle
            // 
            resources.ApplyResources(this.txtTitle, "txtTitle");
            this.txtTitle.Name = "txtTitle";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.Name = "lblTitle";
            // 
            // txtTrackList
            // 
            resources.ApplyResources(this.txtTrackList, "txtTrackList");
            this.txtTrackList.Name = "txtTrackList";
            // 
            // lblTrackList
            // 
            resources.ApplyResources(this.lblTrackList, "lblTrackList");
            this.lblTrackList.Name = "lblTrackList";
            // 
            // FrmMediaMusicBase
            // 
            resources.ApplyResources(this, "$this");
            this.Name = "FrmMediaMusicBase";
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

        /// <summary>
        /// DataGridView for media
        /// </summary>
        protected System.Windows.Forms.DataGridView dgvMedia;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTrackList;
        private System.Windows.Forms.Label lblTrackList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMediaId;
        private System.Windows.Forms.DataGridViewButtonColumn clmAddToBasket;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTrackList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTag;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmCategoryUnbound;
        private System.Windows.Forms.DataGridViewButtonColumn clmImageChg;
    }
}
