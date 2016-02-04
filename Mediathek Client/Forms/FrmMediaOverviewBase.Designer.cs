namespace MediathekClient.Forms
{
    /// <summary>
    /// Media overview base
    /// </summary>
    partial class FrmMediaOverviewBase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMediaOverviewBase));
            this.gbCategories = new System.Windows.Forms.GroupBox();
            this.tvCategories = new System.Windows.Forms.TreeView();
            this.gbMedia = new System.Windows.Forms.GroupBox();
            this.pnlMediaSearch = new System.Windows.Forms.Panel();
            this.butSearchClear = new System.Windows.Forms.Button();
            this.butSearchOk = new System.Windows.Forms.Button();
            this.bsResult = new System.Windows.Forms.BindingSource(this.components);
            this.bsMedia = new System.Windows.Forms.BindingSource(this.components);
            this.pnlControlButtons = new System.Windows.Forms.Panel();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbCategories.SuspendLayout();
            this.gbMedia.SuspendLayout();
            this.pnlMediaSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCategories
            // 
            resources.ApplyResources(this.gbCategories, "gbCategories");
            this.gbCategories.Controls.Add(this.tvCategories);
            this.gbCategories.Name = "gbCategories";
            this.gbCategories.TabStop = false;
            // 
            // tvCategories
            // 
            resources.ApplyResources(this.tvCategories, "tvCategories");
            this.tvCategories.Name = "tvCategories";
            this.tvCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvCategories_AfterSelect);
            this.tvCategories.Leave += new System.EventHandler(this.tvCategories_Leave);
            // 
            // gbMedia
            // 
            resources.ApplyResources(this.gbMedia, "gbMedia");
            this.gbMedia.Controls.Add(this.pnlMediaSearch);
            this.gbMedia.Name = "gbMedia";
            this.gbMedia.TabStop = false;
            // 
            // pnlMediaSearch
            // 
            resources.ApplyResources(this.pnlMediaSearch, "pnlMediaSearch");
            this.pnlMediaSearch.Controls.Add(this.butSearchClear);
            this.pnlMediaSearch.Controls.Add(this.butSearchOk);
            this.pnlMediaSearch.Name = "pnlMediaSearch";
            // 
            // butSearchClear
            // 
            resources.ApplyResources(this.butSearchClear, "butSearchClear");
            this.butSearchClear.Name = "butSearchClear";
            this.butSearchClear.UseVisualStyleBackColor = true;
            // 
            // butSearchOk
            // 
            resources.ApplyResources(this.butSearchOk, "butSearchOk");
            this.butSearchOk.Name = "butSearchOk";
            this.butSearchOk.UseVisualStyleBackColor = true;
            // 
            // bsResult
            // 
            this.bsResult.DataSource = this.bsMedia;
            this.bsResult.DataSourceChanged += new System.EventHandler(this.bsResult_DataSourceChanged);
            // 
            // pnlControlButtons
            // 
            resources.ApplyResources(this.pnlControlButtons, "pnlControlButtons");
            this.pnlControlButtons.Name = "pnlControlButtons";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(DataAccess.Category);
            // 
            // FrmMediaOverviewBase
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.pnlControlButtons);
            this.Controls.Add(this.gbMedia);
            this.Controls.Add(this.gbCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "FrmMediaOverviewBase";
            this.gbCategories.ResumeLayout(false);
            this.gbMedia.ResumeLayout(false);
            this.pnlMediaSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategories;
        private System.Windows.Forms.TreeView tvCategories;
        /// <summary>
        /// Media search panel
        /// </summary>
        protected System.Windows.Forms.Panel pnlMediaSearch;
        /// <summary>
        /// Binding source for media
        /// </summary>
        protected System.Windows.Forms.BindingSource bsMedia;
        /// <summary>
        /// Binding source for the result
        /// </summary>
        protected System.Windows.Forms.BindingSource bsResult;
        /// <summary>
        /// Group box media
        /// </summary>
        protected System.Windows.Forms.GroupBox gbMedia;
        /// <summary>
        /// Panel for the control buttons
        /// </summary>
        protected System.Windows.Forms.Panel pnlControlButtons;
        /// <summary>
        /// Search clearing button
        /// </summary>
        protected System.Windows.Forms.Button butSearchClear;
        /// <summary>
        /// Search OK button
        /// </summary>
        protected System.Windows.Forms.Button butSearchOk;
        /// <summary>
        /// Binding source for categories
        /// </summary>
        protected System.Windows.Forms.BindingSource categoryBindingSource;
    }
}
