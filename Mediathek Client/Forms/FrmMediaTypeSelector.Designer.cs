namespace MediathekClient.Forms
{
    partial class FrmMediaTypeSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMediaTypeSelector));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butOk = new System.Windows.Forms.Button();
            this.cbMediaType = new System.Windows.Forms.ComboBox();
            this.mediaTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.butClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butClose);
            this.groupBox1.Controls.Add(this.butOk);
            this.groupBox1.Controls.Add(this.cbMediaType);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // butOk
            // 
            resources.ApplyResources(this.butOk, "butOk");
            this.butOk.Name = "butOk";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // cbMediaType
            // 
            this.cbMediaType.DataSource = this.mediaTypeBindingSource;
            this.cbMediaType.DisplayMember = "TypeName";
            this.cbMediaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMediaType.FormattingEnabled = true;
            resources.ApplyResources(this.cbMediaType, "cbMediaType");
            this.cbMediaType.Name = "cbMediaType";
            this.cbMediaType.ValueMember = "MediaTypeId";
            // 
            // mediaTypeBindingSource
            // 
            this.mediaTypeBindingSource.DataSource = typeof(DataAccess.MediaType);
            // 
            // butClose
            // 
            this.butClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.butClose, "butClose");
            this.butClose.Name = "butClose";
            this.butClose.UseVisualStyleBackColor = true;
            // 
            // FrmMediaTypeSelector
            // 
            this.AcceptButton = this.butOk;
            resources.ApplyResources(this, "$this");
            this.CancelButton = this.butClose;
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMediaTypeSelector";
            this.Load += new System.EventHandler(this.FrmMediaManager_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMediaType;
        private System.Windows.Forms.BindingSource mediaTypeBindingSource;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butClose;
    }
}
