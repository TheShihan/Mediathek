namespace MediathekClient.Forms
{
    partial class FrmSearchCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchCustomer));
            this.gbSearchParams = new System.Windows.Forms.GroupBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.butOk = new System.Windows.Forms.Button();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryIsoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceResult = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceUser = new System.Windows.Forms.BindingSource(this.components);
            this.butClose = new System.Windows.Forms.Button();
            this.gbSearchParams.SuspendLayout();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearchParams
            // 
            this.gbSearchParams.Controls.Add(this.butSearch);
            this.gbSearchParams.Controls.Add(this.txtLastname);
            this.gbSearchParams.Controls.Add(this.lblSurname);
            this.gbSearchParams.Controls.Add(this.txtFirstname);
            this.gbSearchParams.Controls.Add(this.lblFirstname);
            this.gbSearchParams.Controls.Add(this.txtUserId);
            this.gbSearchParams.Controls.Add(this.lblUserId);
            resources.ApplyResources(this.gbSearchParams, "gbSearchParams");
            this.gbSearchParams.Name = "gbSearchParams";
            this.gbSearchParams.TabStop = false;
            // 
            // butSearch
            // 
            resources.ApplyResources(this.butSearch, "butSearch");
            this.butSearch.Name = "butSearch";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
            // 
            // txtLastname
            // 
            resources.ApplyResources(this.txtLastname, "txtLastname");
            this.txtLastname.Name = "txtLastname";
            // 
            // lblSurname
            // 
            resources.ApplyResources(this.lblSurname, "lblSurname");
            this.lblSurname.Name = "lblSurname";
            // 
            // txtFirstname
            // 
            resources.ApplyResources(this.txtFirstname, "txtFirstname");
            this.txtFirstname.Name = "txtFirstname";
            // 
            // lblFirstname
            // 
            resources.ApplyResources(this.lblFirstname, "lblFirstname");
            this.lblFirstname.Name = "lblFirstname";
            // 
            // txtUserId
            // 
            resources.ApplyResources(this.txtUserId, "txtUserId");
            this.txtUserId.Name = "txtUserId";
            // 
            // lblUserId
            // 
            resources.ApplyResources(this.lblUserId, "lblUserId");
            this.lblUserId.Name = "lblUserId";
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.butOk);
            this.gbResult.Controls.Add(this.dgvResult);
            this.gbResult.Controls.Add(this.butClose);
            resources.ApplyResources(this.gbResult, "gbResult");
            this.gbResult.Name = "gbResult";
            this.gbResult.TabStop = false;
            // 
            // butOk
            // 
            resources.ApplyResources(this.butOk, "butOk");
            this.butOk.Name = "butOk";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.butOk_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.AllowUserToOrderColumns = true;
            this.dgvResult.AutoGenerateColumns = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.zipDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.countryIsoDataGridViewTextBoxColumn});
            this.dgvResult.DataSource = this.bindingSourceResult;
            resources.ApplyResources(this.dgvResult, "dgvResult");
            this.dgvResult.MultiSelect = false;
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellDoubleClick);
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            resources.ApplyResources(this.userIdDataGridViewTextBoxColumn, "userIdDataGridViewTextBoxColumn");
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            resources.ApplyResources(this.firstnameDataGridViewTextBoxColumn, "firstnameDataGridViewTextBoxColumn");
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            resources.ApplyResources(this.surnameDataGridViewTextBoxColumn, "surnameDataGridViewTextBoxColumn");
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            resources.ApplyResources(this.emailDataGridViewTextBoxColumn, "emailDataGridViewTextBoxColumn");
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            resources.ApplyResources(this.streetDataGridViewTextBoxColumn, "streetDataGridViewTextBoxColumn");
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zipDataGridViewTextBoxColumn
            // 
            this.zipDataGridViewTextBoxColumn.DataPropertyName = "Zip";
            resources.ApplyResources(this.zipDataGridViewTextBoxColumn, "zipDataGridViewTextBoxColumn");
            this.zipDataGridViewTextBoxColumn.Name = "zipDataGridViewTextBoxColumn";
            this.zipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            resources.ApplyResources(this.cityDataGridViewTextBoxColumn, "cityDataGridViewTextBoxColumn");
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryIsoDataGridViewTextBoxColumn
            // 
            this.countryIsoDataGridViewTextBoxColumn.DataPropertyName = "CountryIso";
            resources.ApplyResources(this.countryIsoDataGridViewTextBoxColumn, "countryIsoDataGridViewTextBoxColumn");
            this.countryIsoDataGridViewTextBoxColumn.Name = "countryIsoDataGridViewTextBoxColumn";
            this.countryIsoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceResult
            // 
            this.bindingSourceResult.DataSource = this.bindingSourceUser;
            // 
            // bindingSourceUser
            // 
            this.bindingSourceUser.DataSource = typeof(DataAccess.User);
            // 
            // butClose
            // 
            this.butClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.butClose, "butClose");
            this.butClose.Name = "butClose";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // FrmSearchCustomer
            // 
            this.AcceptButton = this.butSearch;
            resources.ApplyResources(this, "$this");
            this.CancelButton = this.butClose;
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gbSearchParams);
            this.Name = "FrmSearchCustomer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSearchCustomer_FormClosed);
            this.gbSearchParams.ResumeLayout(false);
            this.gbSearchParams.PerformLayout();
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchParams;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.BindingSource bindingSourceResult;
        private System.Windows.Forms.BindingSource bindingSourceUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryIsoDataGridViewTextBoxColumn;
    }
}
