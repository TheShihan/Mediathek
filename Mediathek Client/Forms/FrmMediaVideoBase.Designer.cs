namespace MediathekClient.Forms
{
    /// <summary>
    /// Media video base
    /// </summary>
    partial class FrmMediaVideoBase
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
            this.dgvMedia = new System.Windows.Forms.DataGridView();
            this.clmMediaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddToBasket = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDirector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmActors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlaytime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCategoryUnbound = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clmImageChg = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.lblTag = new System.Windows.Forms.Label();
            this.txtPlaytime = new System.Windows.Forms.TextBox();
            this.lblPlaytime = new System.Windows.Forms.Label();
            this.txtActors = new System.Windows.Forms.TextBox();
            this.lblActors = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.lblDirector = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.pnlMediaSearch.Controls.Add(this.txtPlaytime);
            this.pnlMediaSearch.Controls.Add(this.lblPlaytime);
            this.pnlMediaSearch.Controls.Add(this.txtActors);
            this.pnlMediaSearch.Controls.Add(this.lblActors);
            this.pnlMediaSearch.Controls.Add(this.txtDirector);
            this.pnlMediaSearch.Controls.Add(this.lblDirector);
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
            this.pnlMediaSearch.Controls.SetChildIndex(this.lblDirector, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.txtDirector, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.lblActors, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.txtActors, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.lblPlaytime, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.txtPlaytime, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.lblTag, 0);
            this.pnlMediaSearch.Controls.SetChildIndex(this.txtTag, 0);
            // 
            // bsMedia
            // 
            this.bsMedia.DataSource = typeof(DataAccess.MediaVideo);
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
            this.dgvMedia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedia.AutoGenerateColumns = false;
            this.dgvMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMediaId,
            this.clmAddToBasket,
            this.clmTitle,
            this.clmDesc,
            this.clmDirector,
            this.clmActors,
            this.clmPlaytime,
            this.clmTag,
            this.clmCategoryUnbound,
            this.clmImageChg});
            this.dgvMedia.DataSource = this.bsResult;
            this.dgvMedia.Location = new System.Drawing.Point(6, 138);
            this.dgvMedia.Name = "dgvMedia";
            this.dgvMedia.ReadOnly = true;
            this.dgvMedia.Size = new System.Drawing.Size(702, 369);
            this.dgvMedia.TabIndex = 2;
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
            this.clmTitle.Name = "clmTitle";
            this.clmTitle.ReadOnly = true;
            // 
            // clmDesc
            // 
            this.clmDesc.DataPropertyName = "Description";
            this.clmDesc.HeaderText = "Beschreibung";
            this.clmDesc.Name = "clmDesc";
            this.clmDesc.ReadOnly = true;
            // 
            // clmDirector
            // 
            this.clmDirector.DataPropertyName = "Director";
            this.clmDirector.HeaderText = "Regisseur";
            this.clmDirector.Name = "clmDirector";
            this.clmDirector.ReadOnly = true;
            // 
            // clmActors
            // 
            this.clmActors.DataPropertyName = "Actors";
            this.clmActors.HeaderText = "Schauspieler";
            this.clmActors.Name = "clmActors";
            this.clmActors.ReadOnly = true;
            // 
            // clmPlaytime
            // 
            this.clmPlaytime.DataPropertyName = "Length";
            this.clmPlaytime.HeaderText = "Laufzeit (Min.)";
            this.clmPlaytime.Name = "clmPlaytime";
            this.clmPlaytime.ReadOnly = true;
            // 
            // clmTag
            // 
            this.clmTag.DataPropertyName = "Tag";
            this.clmTag.HeaderText = "Tag";
            this.clmTag.Name = "clmTag";
            this.clmTag.ReadOnly = true;
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
            // clmImageChg
            // 
            this.clmImageChg.HeaderText = "Bild";
            this.clmImageChg.Name = "clmImageChg";
            this.clmImageChg.ReadOnly = true;
            this.clmImageChg.Text = "";
            this.clmImageChg.Width = 30;
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(586, 40);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(100, 20);
            this.txtTag.TabIndex = 25;
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Location = new System.Drawing.Point(472, 43);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(29, 13);
            this.lblTag.TabIndex = 24;
            this.lblTag.Text = "Tag:";
            // 
            // txtPlaytime
            // 
            this.txtPlaytime.Location = new System.Drawing.Point(586, 14);
            this.txtPlaytime.Name = "txtPlaytime";
            this.txtPlaytime.Size = new System.Drawing.Size(100, 20);
            this.txtPlaytime.TabIndex = 23;
            // 
            // lblPlaytime
            // 
            this.lblPlaytime.AutoSize = true;
            this.lblPlaytime.Location = new System.Drawing.Point(472, 17);
            this.lblPlaytime.Name = "lblPlaytime";
            this.lblPlaytime.Size = new System.Drawing.Size(47, 13);
            this.lblPlaytime.TabIndex = 22;
            this.lblPlaytime.Text = "Laufzeit:";
            // 
            // txtActors
            // 
            this.txtActors.Location = new System.Drawing.Point(352, 40);
            this.txtActors.Name = "txtActors";
            this.txtActors.Size = new System.Drawing.Size(100, 20);
            this.txtActors.TabIndex = 21;
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.Location = new System.Drawing.Point(238, 43);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(71, 13);
            this.lblActors.TabIndex = 20;
            this.lblActors.Text = "Schauspieler:";
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(352, 14);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(100, 20);
            this.txtDirector.TabIndex = 19;
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(238, 17);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(57, 13);
            this.lblDirector.TabIndex = 18;
            this.lblDirector.Text = "Regisseur:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(121, 40);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 17;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(7, 43);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(75, 13);
            this.lblDesc.TabIndex = 16;
            this.lblDesc.Text = "Beschreibung:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(121, 14);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 15;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(7, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Titel:";
            // 
            // FrmMediaVideoBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(966, 592);
            this.Name = "FrmMediaVideoBase";
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
        private System.Windows.Forms.TextBox txtPlaytime;
        private System.Windows.Forms.Label lblPlaytime;
        private System.Windows.Forms.TextBox txtActors;
        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMediaId;
        private System.Windows.Forms.DataGridViewButtonColumn clmAddToBasket;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDirector;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmActors;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlaytime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTag;
        private System.Windows.Forms.DataGridViewComboBoxColumn clmCategoryUnbound;
        private System.Windows.Forms.DataGridViewButtonColumn clmImageChg;

    }
}
