namespace MediathekClient.Forms
{
    /// <summary>
    /// Media return
    /// </summary>
    partial class FrmMediaReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMediaReturn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.butSearchCustomer = new System.Windows.Forms.Button();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.gbMedia = new System.Windows.Forms.GroupBox();
            this.dgvMedia = new System.Windows.Forms.DataGridView();
            this.clmMediaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMark = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmCheckOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsResult = new System.Windows.Forms.BindingSource(this.components);
            this.bsMedia = new System.Windows.Forms.BindingSource(this.components);
            this.butReturn = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.gbCustomer.SuspendLayout();
            this.gbMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.butSearchCustomer);
            this.gbCustomer.Controls.Add(this.txtCustomer);
            resources.ApplyResources(this.gbCustomer, "gbCustomer");
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.TabStop = false;
            // 
            // butSearchCustomer
            // 
            resources.ApplyResources(this.butSearchCustomer, "butSearchCustomer");
            this.butSearchCustomer.Name = "butSearchCustomer";
            this.butSearchCustomer.UseVisualStyleBackColor = true;
            this.butSearchCustomer.Click += new System.EventHandler(this.butSearchCustomer_Click);
            // 
            // txtCustomer
            // 
            resources.ApplyResources(this.txtCustomer, "txtCustomer");
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            // 
            // gbMedia
            // 
            this.gbMedia.Controls.Add(this.dgvMedia);
            resources.ApplyResources(this.gbMedia, "gbMedia");
            this.gbMedia.Name = "gbMedia";
            this.gbMedia.TabStop = false;
            // 
            // dgvMedia
            // 
            this.dgvMedia.AllowUserToAddRows = false;
            this.dgvMedia.AllowUserToDeleteRows = false;
            this.dgvMedia.AutoGenerateColumns = false;
            this.dgvMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMediaId,
            this.clmMark,
            this.clmCheckOutDate,
            this.clmTitle,
            this.clmTag,
            this.clmType});
            this.dgvMedia.DataSource = this.bsResult;
            resources.ApplyResources(this.dgvMedia, "dgvMedia");
            this.dgvMedia.MultiSelect = false;
            this.dgvMedia.Name = "dgvMedia";
            this.dgvMedia.ReadOnly = true;
            this.dgvMedia.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvMedia_RowPrePaint);
            this.dgvMedia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedia_CellContentClick);
            // 
            // clmMediaId
            // 
            this.clmMediaId.DataPropertyName = "MediaId";
            resources.ApplyResources(this.clmMediaId, "clmMediaId");
            this.clmMediaId.Name = "clmMediaId";
            this.clmMediaId.ReadOnly = true;
            // 
            // clmMark
            // 
            resources.ApplyResources(this.clmMark, "clmMark");
            this.clmMark.Name = "clmMark";
            this.clmMark.ReadOnly = true;
            this.clmMark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmMark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clmCheckOutDate
            // 
            this.clmCheckOutDate.DataPropertyName = "CheckOutDate";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.clmCheckOutDate.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.clmCheckOutDate, "clmCheckOutDate");
            this.clmCheckOutDate.Name = "clmCheckOutDate";
            this.clmCheckOutDate.ReadOnly = true;
            // 
            // clmTitle
            // 
            resources.ApplyResources(this.clmTitle, "clmTitle");
            this.clmTitle.Name = "clmTitle";
            this.clmTitle.ReadOnly = true;
            // 
            // clmTag
            // 
            resources.ApplyResources(this.clmTag, "clmTag");
            this.clmTag.Name = "clmTag";
            this.clmTag.ReadOnly = true;
            // 
            // clmType
            // 
            resources.ApplyResources(this.clmType, "clmType");
            this.clmType.Name = "clmType";
            this.clmType.ReadOnly = true;
            // 
            // bsResult
            // 
            this.bsResult.DataSource = this.bsMedia;
            // 
            // bsMedia
            // 
            this.bsMedia.DataSource = typeof(DataAccess.MediaRenting);
            // 
            // butReturn
            // 
            resources.ApplyResources(this.butReturn, "butReturn");
            this.butReturn.Name = "butReturn";
            this.butReturn.UseVisualStyleBackColor = true;
            this.butReturn.Click += new System.EventHandler(this.butReturn_Click);
            // 
            // butClose
            // 
            this.butClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.butClose, "butClose");
            this.butClose.Name = "butClose";
            this.butClose.UseVisualStyleBackColor = true;
            // 
            // FrmMediaReturn
            // 
            this.AcceptButton = this.butSearchCustomer;
            resources.ApplyResources(this, "$this");
            this.CancelButton = this.butClose;
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butReturn);
            this.Controls.Add(this.gbMedia);
            this.Controls.Add(this.gbCustomer);
            this.Name = "FrmMediaReturn";
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbMedia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Button butSearchCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.GroupBox gbMedia;
        private System.Windows.Forms.Button butReturn;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.DataGridView dgvMedia;
        private System.Windows.Forms.BindingSource bsResult;
        private System.Windows.Forms.BindingSource bsMedia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMediaId;
        private System.Windows.Forms.DataGridViewButtonColumn clmMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCheckOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
    }
}
