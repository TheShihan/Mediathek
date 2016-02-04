namespace MediathekClient.Forms
{
    /// <summary>
    /// Customer manager
    /// </summary>
    partial class FrmCustomerManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerManager));
            this.butClose = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.butNew = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTitles = new System.Windows.Forms.ComboBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblAdminUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblAdminEmail = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblAdminPassword = new System.Windows.Forms.Label();
            this.gbAdmins = new System.Windows.Forms.GroupBox();
            this.ButSearchCustomer = new System.Windows.Forms.Button();
            this.lbCustomers = new System.Windows.Forms.ListBox();
            this.titleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbData.SuspendLayout();
            this.gbAdmins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // butClose
            // 
            this.butClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.butClose, "butClose");
            this.butClose.Name = "butClose";
            this.butClose.UseVisualStyleBackColor = true;
            // 
            // butDelete
            // 
            resources.ApplyResources(this.butDelete, "butDelete");
            this.butDelete.Name = "butDelete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
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
            // gbData
            // 
            this.gbData.Controls.Add(this.label5);
            this.gbData.Controls.Add(this.cbTitles);
            this.gbData.Controls.Add(this.txtCountry);
            this.gbData.Controls.Add(this.label4);
            this.gbData.Controls.Add(this.txtCity);
            this.gbData.Controls.Add(this.txtZip);
            this.gbData.Controls.Add(this.label3);
            this.gbData.Controls.Add(this.txtStreet);
            this.gbData.Controls.Add(this.label2);
            this.gbData.Controls.Add(this.txtEmail);
            this.gbData.Controls.Add(this.label1);
            this.gbData.Controls.Add(this.txtFirstname);
            this.gbData.Controls.Add(this.lblAdminUsername);
            this.gbData.Controls.Add(this.txtPassword);
            this.gbData.Controls.Add(this.lblAdminEmail);
            this.gbData.Controls.Add(this.txtSurname);
            this.gbData.Controls.Add(this.lblAdminPassword);
            resources.ApplyResources(this.gbData, "gbData");
            this.gbData.Name = "gbData";
            this.gbData.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // cbTitles
            // 
            this.cbTitles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTitles.FormattingEnabled = true;
            resources.ApplyResources(this.cbTitles, "cbTitles");
            this.cbTitles.Name = "cbTitles";
            // 
            // txtCountry
            // 
            resources.ApplyResources(this.txtCountry, "txtCountry");
            this.txtCountry.Name = "txtCountry";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtCity
            // 
            resources.ApplyResources(this.txtCity, "txtCity");
            this.txtCity.Name = "txtCity";
            // 
            // txtZip
            // 
            resources.ApplyResources(this.txtZip, "txtZip");
            this.txtZip.Name = "txtZip";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtStreet
            // 
            resources.ApplyResources(this.txtStreet, "txtStreet");
            this.txtStreet.Name = "txtStreet";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtFirstname
            // 
            resources.ApplyResources(this.txtFirstname, "txtFirstname");
            this.txtFirstname.Name = "txtFirstname";
            // 
            // lblAdminUsername
            // 
            resources.ApplyResources(this.lblAdminUsername, "lblAdminUsername");
            this.lblAdminUsername.Name = "lblAdminUsername";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // lblAdminEmail
            // 
            resources.ApplyResources(this.lblAdminEmail, "lblAdminEmail");
            this.lblAdminEmail.Name = "lblAdminEmail";
            // 
            // txtSurname
            // 
            resources.ApplyResources(this.txtSurname, "txtSurname");
            this.txtSurname.Name = "txtSurname";
            // 
            // lblAdminPassword
            // 
            resources.ApplyResources(this.lblAdminPassword, "lblAdminPassword");
            this.lblAdminPassword.Name = "lblAdminPassword";
            // 
            // gbAdmins
            // 
            this.gbAdmins.Controls.Add(this.ButSearchCustomer);
            this.gbAdmins.Controls.Add(this.lbCustomers);
            resources.ApplyResources(this.gbAdmins, "gbAdmins");
            this.gbAdmins.Name = "gbAdmins";
            this.gbAdmins.TabStop = false;
            // 
            // ButSearchCustomer
            // 
            resources.ApplyResources(this.ButSearchCustomer, "ButSearchCustomer");
            this.ButSearchCustomer.Name = "ButSearchCustomer";
            this.ButSearchCustomer.UseVisualStyleBackColor = true;
            this.ButSearchCustomer.Click += new System.EventHandler(this.ButSearchCustomer_Click);
            // 
            // lbCustomers
            // 
            this.lbCustomers.FormattingEnabled = true;
            resources.ApplyResources(this.lbCustomers, "lbCustomers");
            this.lbCustomers.Name = "lbCustomers";
            this.lbCustomers.SelectedIndexChanged += new System.EventHandler(this.lbCustomers_SelectedIndexChanged);
            // 
            // titleBindingSource
            // 
            this.titleBindingSource.DataSource = typeof(DataAccess.Title);
            // 
            // FrmCustomerManager
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
            this.Name = "FrmCustomerManager";
            this.Load += new System.EventHandler(this.FrmCustomerManager_Load);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.gbAdmins.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.titleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butNew;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblAdminUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblAdminEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblAdminPassword;
        private System.Windows.Forms.GroupBox gbAdmins;
        private System.Windows.Forms.ListBox lbCustomers;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTitles;
        private System.Windows.Forms.BindingSource titleBindingSource;
        private System.Windows.Forms.Button ButSearchCustomer;
    }
}
