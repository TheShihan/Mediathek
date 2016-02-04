namespace MediathekClient.Forms
{
    partial class FrmMediaMiscManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMediaMiscManager));
            this.butCancel = new System.Windows.Forms.Button();
            this.butDelRows = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.butNew = new System.Windows.Forms.Button();
            this.pnlMediaSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).BeginInit();
            this.gbMedia.SuspendLayout();
            this.pnlControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControlButtons
            // 
            this.pnlControlButtons.Controls.Add(this.butNew);
            this.pnlControlButtons.Controls.Add(this.butCancel);
            this.pnlControlButtons.Controls.Add(this.butSave);
            this.pnlControlButtons.Controls.Add(this.butDelRows);
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.butCancel, "butCancel");
            this.butCancel.Name = "butCancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // butDelRows
            // 
            resources.ApplyResources(this.butDelRows, "butDelRows");
            this.butDelRows.Name = "butDelRows";
            this.butDelRows.UseVisualStyleBackColor = true;
            this.butDelRows.Click += new System.EventHandler(this.butDelRows_Click);
            // 
            // butSave
            // 
            resources.ApplyResources(this.butSave, "butSave");
            this.butSave.Name = "butSave";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butNew
            // 
            resources.ApplyResources(this.butNew, "butNew");
            this.butNew.Name = "butNew";
            this.butNew.UseVisualStyleBackColor = true;
            this.butNew.Click += new System.EventHandler(this.butNew_Click);
            // 
            // FrmMediaMiscManager
            // 
            resources.ApplyResources(this, "$this");
            this.CancelButton = this.butCancel;
            this.Name = "FrmMediaMiscManager";
            this.Load += new System.EventHandler(this.FrmMediaManager_Load);
            this.pnlMediaSearch.ResumeLayout(false);
            this.pnlMediaSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).EndInit();
            this.gbMedia.ResumeLayout(false);
            this.pnlControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butDelRows;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butNew;
    }
}
