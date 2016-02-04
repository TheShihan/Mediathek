namespace MediathekClient.Forms
{
    partial class FrmMediaAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMediaAdd));
            this.gbData = new System.Windows.Forms.GroupBox();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtMediaType = new System.Windows.Forms.TextBox();
            this.lblMediaType = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.txtDesc);
            this.gbData.Controls.Add(this.lblCategory);
            this.gbData.Controls.Add(this.cbCategory);
            this.gbData.Controls.Add(this.lblDesc);
            this.gbData.Controls.Add(this.txtTitle);
            this.gbData.Controls.Add(this.lblTitle);
            this.gbData.Controls.Add(this.txtMediaType);
            this.gbData.Controls.Add(this.lblMediaType);
            resources.ApplyResources(this.gbData, "gbData");
            this.gbData.Name = "gbData";
            this.gbData.TabStop = false;
            // 
            // txtDesc
            // 
            resources.ApplyResources(this.txtDesc, "txtDesc");
            this.txtDesc.Name = "txtDesc";
            // 
            // lblCategory
            // 
            resources.ApplyResources(this.lblCategory, "lblCategory");
            this.lblCategory.Name = "lblCategory";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            resources.ApplyResources(this.cbCategory, "cbCategory");
            this.cbCategory.Name = "cbCategory";
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
            // txtMediaType
            // 
            resources.ApplyResources(this.txtMediaType, "txtMediaType");
            this.txtMediaType.Name = "txtMediaType";
            this.txtMediaType.ReadOnly = true;
            // 
            // lblMediaType
            // 
            resources.ApplyResources(this.lblMediaType, "lblMediaType");
            this.lblMediaType.Name = "lblMediaType";
            // 
            // butAdd
            // 
            resources.ApplyResources(this.butAdd, "butAdd");
            this.butAdd.Name = "butAdd";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butCancel
            // 
            this.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.butCancel, "butCancel");
            this.butCancel.Name = "butCancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // FrmMediaAdd
            // 
            resources.ApplyResources(this, "$this");
            this.CancelButton = this.butCancel;
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.gbData);
            this.Name = "FrmMediaAdd";
            this.Load += new System.EventHandler(this.FrmMediaAdd_Load);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtMediaType;
        private System.Windows.Forms.Label lblMediaType;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.RichTextBox txtDesc;
    }
}
