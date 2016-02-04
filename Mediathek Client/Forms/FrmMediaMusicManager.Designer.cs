namespace MediathekClient
{
    partial class FrmMediaMusicManager
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
            this.butCancel.Location = new System.Drawing.Point(347, 20);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(108, 23);
            this.butCancel.TabIndex = 8;
            this.butCancel.Text = "&Abbrechen";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // butDelRows
            // 
            this.butDelRows.Location = new System.Drawing.Point(233, 20);
            this.butDelRows.Name = "butDelRows";
            this.butDelRows.Size = new System.Drawing.Size(108, 23);
            this.butDelRows.TabIndex = 7;
            this.butDelRows.Text = "&Zeilen löschen";
            this.butDelRows.UseVisualStyleBackColor = true;
            this.butDelRows.Click += new System.EventHandler(this.butDelRows_Click);
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(119, 20);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(108, 23);
            this.butSave.TabIndex = 6;
            this.butSave.Text = "&Speichern";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butNew
            // 
            this.butNew.Location = new System.Drawing.Point(6, 20);
            this.butNew.Name = "butNew";
            this.butNew.Size = new System.Drawing.Size(108, 23);
            this.butNew.TabIndex = 4;
            this.butNew.Text = "&Neu";
            this.butNew.UseVisualStyleBackColor = true;
            this.butNew.Click += new System.EventHandler(this.butNew_Click);
            // 
            // FrmMediaMusicManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.butCancel;
            this.ClientSize = new System.Drawing.Size(966, 592);
            this.Name = "FrmMediaMusicManager";
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
