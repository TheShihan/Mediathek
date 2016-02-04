namespace MediathekClient.Forms
{
    partial class FrmMediaReservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMediaReservations));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.clmMark = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clmReservationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMediaTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMediaTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsResult = new System.Windows.Forms.BindingSource(this.components);
            this.bsReservations = new System.Windows.Forms.BindingSource(this.components);
            this.butDelete = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvReservations);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.AutoGenerateColumns = false;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMark,
            this.clmReservationId,
            this.clmUserNo,
            this.clmUserDesc,
            this.clmMediaTitle,
            this.clmMediaTag,
            this.clmCreationDate});
            this.dgvReservations.DataSource = this.bsResult;
            resources.ApplyResources(this.dgvReservations, "dgvReservations");
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvReservations_RowPrePaint);
            this.dgvReservations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservations_CellContentClick);
            // 
            // clmMark
            // 
            resources.ApplyResources(this.clmMark, "clmMark");
            this.clmMark.Name = "clmMark";
            this.clmMark.ReadOnly = true;
            // 
            // clmReservationId
            // 
            this.clmReservationId.DataPropertyName = "ReservationId";
            resources.ApplyResources(this.clmReservationId, "clmReservationId");
            this.clmReservationId.Name = "clmReservationId";
            this.clmReservationId.ReadOnly = true;
            // 
            // clmUserNo
            // 
            resources.ApplyResources(this.clmUserNo, "clmUserNo");
            this.clmUserNo.Name = "clmUserNo";
            this.clmUserNo.ReadOnly = true;
            // 
            // clmUserDesc
            // 
            resources.ApplyResources(this.clmUserDesc, "clmUserDesc");
            this.clmUserDesc.Name = "clmUserDesc";
            this.clmUserDesc.ReadOnly = true;
            // 
            // clmMediaTitle
            // 
            resources.ApplyResources(this.clmMediaTitle, "clmMediaTitle");
            this.clmMediaTitle.Name = "clmMediaTitle";
            this.clmMediaTitle.ReadOnly = true;
            // 
            // clmMediaTag
            // 
            resources.ApplyResources(this.clmMediaTag, "clmMediaTag");
            this.clmMediaTag.Name = "clmMediaTag";
            this.clmMediaTag.ReadOnly = true;
            // 
            // clmCreationDate
            // 
            this.clmCreationDate.DataPropertyName = "CreationDate";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.clmCreationDate.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.clmCreationDate, "clmCreationDate");
            this.clmCreationDate.Name = "clmCreationDate";
            this.clmCreationDate.ReadOnly = true;
            // 
            // bsResult
            // 
            this.bsResult.DataSource = this.bsReservations;
            // 
            // bsReservations
            // 
            this.bsReservations.DataSource = typeof(DataAccess.Reservation);
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
            // FrmMediaReservations
            // 
            this.AcceptButton = this.butDelete;
            resources.ApplyResources(this, "$this");
            this.CancelButton = this.butClose;
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMediaReservations";
            this.Load += new System.EventHandler(this.FrmMediaReservations_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReservations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.BindingSource bsResult;
        private System.Windows.Forms.BindingSource bsReservations;
        private System.Windows.Forms.DataGridViewButtonColumn clmMark;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReservationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMediaTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMediaTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCreationDate;
    }
}
