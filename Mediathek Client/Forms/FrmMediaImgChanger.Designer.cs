namespace MediathekClient.Forms
{
    partial class FrmMediaImgChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMediaImgChanger));
            this.pnlPictureBox = new System.Windows.Forms.Panel();
            this.pbMediaImg = new System.Windows.Forms.PictureBox();
            this.butOk = new System.Windows.Forms.Button();
            this.butSelImg = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.butReset = new System.Windows.Forms.Button();
            this.pnlPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMediaImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPictureBox
            // 
            resources.ApplyResources(this.pnlPictureBox, "pnlPictureBox");
            this.pnlPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPictureBox.Controls.Add(this.pbMediaImg);
            this.pnlPictureBox.Name = "pnlPictureBox";
            // 
            // pbMediaImg
            // 
            resources.ApplyResources(this.pbMediaImg, "pbMediaImg");
            this.pbMediaImg.Name = "pbMediaImg";
            this.pbMediaImg.TabStop = false;
            // 
            // butOk
            // 
            resources.ApplyResources(this.butOk, "butOk");
            this.butOk.Name = "butOk";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // butSelImg
            // 
            resources.ApplyResources(this.butSelImg, "butSelImg");
            this.butSelImg.Name = "butSelImg";
            this.butSelImg.UseVisualStyleBackColor = true;
            this.butSelImg.Click += new System.EventHandler(this.butSelImg_Click);
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.butCancel, "butCancel");
            this.butCancel.Name = "butCancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            resources.ApplyResources(this.openFileDialog, "openFileDialog");
            // 
            // butReset
            // 
            resources.ApplyResources(this.butReset, "butReset");
            this.butReset.Name = "butReset";
            this.butReset.UseVisualStyleBackColor = true;
            this.butReset.Click += new System.EventHandler(this.butReset_Click);
            // 
            // FrmMediaImgChanger
            // 
            this.AcceptButton = this.butOk;
            resources.ApplyResources(this, "$this");
            this.CancelButton = this.butCancel;
            this.Controls.Add(this.butReset);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butSelImg);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.pnlPictureBox);
            this.Name = "FrmMediaImgChanger";
            this.Load += new System.EventHandler(this.FrmMediaImgChanger_Load);
            this.pnlPictureBox.ResumeLayout(false);
            this.pnlPictureBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMediaImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPictureBox;
        private System.Windows.Forms.PictureBox pbMediaImg;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butSelImg;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button butReset;
    }
}
