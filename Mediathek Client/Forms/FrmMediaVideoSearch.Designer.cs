namespace MediathekClient.Forms
{
    /// <summary>
    /// Media vido search
    /// </summary>
    partial class FrmMediaVideoSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMediaVideoSearch));
            this.butOk = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
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
            this.pnlControlButtons.Controls.Add(this.butClose);
            this.pnlControlButtons.Controls.Add(this.butOk);
            // 
            // butOk
            // 
            resources.ApplyResources(this.butOk, "butOk");
            this.butOk.Name = "butOk";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // butClose
            // 
            this.butClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.butClose, "butClose");
            this.butClose.Name = "butClose";
            this.butClose.UseVisualStyleBackColor = true;
            // 
            // FrmMediaVideoSearch
            // 
            resources.ApplyResources(this, "$this");
            this.CancelButton = this.butClose;
            this.Name = "FrmMediaVideoSearch";
            this.Load += new System.EventHandler(this.FrmMediaSearch_Load);
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

        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butClose;
    }
}
