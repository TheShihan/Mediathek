namespace MediathekClient.Forms
{
    partial class FrmAdminManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminManager));
            this.gbAdmins = new System.Windows.Forms.GroupBox();
            this.lbAdmins = new System.Windows.Forms.ListBox();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.txtAdminUsername = new System.Windows.Forms.TextBox();
            this.lblAdminUsername = new System.Windows.Forms.Label();
            this.txtAdminEmail = new System.Windows.Forms.TextBox();
            this.lblAdminEmail = new System.Windows.Forms.Label();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.butNew = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.gbAdmins.SuspendLayout();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAdmins
            // 
            this.gbAdmins.Controls.Add(this.lbAdmins);
            resources.ApplyResources(this.gbAdmins, "gbAdmins");
            this.gbAdmins.Name = "gbAdmins";
            this.gbAdmins.TabStop = false;
            // 
            // lbAdmins
            // 
            this.lbAdmins.FormattingEnabled = true;
            resources.ApplyResources(this.lbAdmins, "lbAdmins");
            this.lbAdmins.Name = "lbAdmins";
            this.lbAdmins.SelectedIndexChanged += new System.EventHandler(this.lbAdmins_SelectedIndexChanged);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.txtAdminUsername);
            this.gbData.Controls.Add(this.lblAdminUsername);
            this.gbData.Controls.Add(this.txtAdminEmail);
            this.gbData.Controls.Add(this.lblAdminEmail);
            this.gbData.Controls.Add(this.txtAdminPassword);
            this.gbData.Controls.Add(this.lblAdminPassword);
            resources.ApplyResources(this.gbData, "gbData");
            this.gbData.Name = "gbData";
            this.gbData.TabStop = false;
            // 
            // txtAdminUsername
            // 
            resources.ApplyResources(this.txtAdminUsername, "txtAdminUsername");
            this.txtAdminUsername.Name = "txtAdminUsername";
            this.txtAdminUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdminUsername_Validating);
            // 
            // lblAdminUsername
            // 
            resources.ApplyResources(this.lblAdminUsername, "lblAdminUsername");
            this.lblAdminUsername.Name = "lblAdminUsername";
            // 
            // txtAdminEmail
            // 
            resources.ApplyResources(this.txtAdminEmail, "txtAdminEmail");
            this.txtAdminEmail.Name = "txtAdminEmail";
            this.txtAdminEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdminEmail_Validating);
            // 
            // lblAdminEmail
            // 
            resources.ApplyResources(this.lblAdminEmail, "lblAdminEmail");
            this.lblAdminEmail.Name = "lblAdminEmail";
            // 
            // txtAdminPassword
            // 
            resources.ApplyResources(this.txtAdminPassword, "txtAdminPassword");
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdminPassword_Validating);
            // 
            // lblAdminPassword
            // 
            resources.ApplyResources(this.lblAdminPassword, "lblAdminPassword");
            this.lblAdminPassword.Name = "lblAdminPassword";
            // 
            // butNew
            // 
            resources.ApplyResources(this.butNew, "butNew");
            this.butNew.Name = "butNew";
            this.butNew.UseVisualStyleBackColor = true;
            this.butNew.Click += new System.EventHandler(this.butNew_Click);
            // 
            // butSave
            // 
            resources.ApplyResources(this.butSave, "butSave");
            this.butSave.Name = "butSave";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butDelete
            // 
            resources.ApplyResources(this.butDelete, "butDelete");
            this.butDelete.Name = "butDelete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butClose
            // 
            this.butClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.butClose, "butClose");
            this.butClose.Name = "butClose";
            this.butClose.UseVisualStyleBackColor = true;
            // 
            // FrmAdminManager
            // 
            this.AcceptButton = this.butSave;
            resources.ApplyResources(this, "$this");
            this.CancelButton = this.butClose;
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butSave);
            this.Controls.Add(this.butNew);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbAdmins);
            this.Name = "FrmAdminManager";
            this.Load += new System.EventHandler(this.FrmAdminManager_Load);
            this.gbAdmins.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAdmins;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Button butNew;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.ListBox lbAdmins;
        private System.Windows.Forms.TextBox txtAdminUsername;
        private System.Windows.Forms.Label lblAdminUsername;
        private System.Windows.Forms.TextBox txtAdminEmail;
        private System.Windows.Forms.Label lblAdminEmail;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.Label lblAdminPassword;
    }
}
