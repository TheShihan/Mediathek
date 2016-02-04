namespace MediathekClient.Forms
{
    partial class FrmMediaTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMediaTasks));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbReservation = new System.Windows.Forms.ListBox();
            this.butCreateReservations = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbMedia = new System.Windows.Forms.ListBox();
            this.butDeleteSelected = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbRent = new System.Windows.Forms.ListBox();
            this.butCreateLendings = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.butSearchCustomer = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.butMediaSearch = new System.Windows.Forms.Button();
            this.butMedia2Rs = new System.Windows.Forms.Button();
            this.butRes2Media = new System.Windows.Forms.Button();
            this.butRent2Media = new System.Windows.Forms.Button();
            this.butMedia2Rent = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbReservation);
            this.groupBox1.Controls.Add(this.butCreateReservations);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lbReservation
            // 
            this.lbReservation.FormattingEnabled = true;
            resources.ApplyResources(this.lbReservation, "lbReservation");
            this.lbReservation.Name = "lbReservation";
            this.lbReservation.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            // 
            // butCreateReservations
            // 
            resources.ApplyResources(this.butCreateReservations, "butCreateReservations");
            this.butCreateReservations.Name = "butCreateReservations";
            this.butCreateReservations.UseVisualStyleBackColor = true;
            this.butCreateReservations.Click += new System.EventHandler(this.butCreateReservations_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbMedia);
            this.groupBox2.Controls.Add(this.butDeleteSelected);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // lbMedia
            // 
            this.lbMedia.FormattingEnabled = true;
            resources.ApplyResources(this.lbMedia, "lbMedia");
            this.lbMedia.Name = "lbMedia";
            this.lbMedia.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            // 
            // butDeleteSelected
            // 
            resources.ApplyResources(this.butDeleteSelected, "butDeleteSelected");
            this.butDeleteSelected.Name = "butDeleteSelected";
            this.butDeleteSelected.UseVisualStyleBackColor = true;
            this.butDeleteSelected.Click += new System.EventHandler(this.butDeleteSelected_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbRent);
            this.groupBox3.Controls.Add(this.butCreateLendings);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // lbRent
            // 
            this.lbRent.FormattingEnabled = true;
            resources.ApplyResources(this.lbRent, "lbRent");
            this.lbRent.Name = "lbRent";
            this.lbRent.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            // 
            // butCreateLendings
            // 
            resources.ApplyResources(this.butCreateLendings, "butCreateLendings");
            this.butCreateLendings.Name = "butCreateLendings";
            this.butCreateLendings.UseVisualStyleBackColor = true;
            this.butCreateLendings.Click += new System.EventHandler(this.butCreateLendings_Click);
            // 
            // lblCustomer
            // 
            resources.ApplyResources(this.lblCustomer, "lblCustomer");
            this.lblCustomer.Name = "lblCustomer";
            // 
            // txtCustomer
            // 
            resources.ApplyResources(this.txtCustomer, "txtCustomer");
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            // 
            // butSearchCustomer
            // 
            resources.ApplyResources(this.butSearchCustomer, "butSearchCustomer");
            this.butSearchCustomer.Name = "butSearchCustomer";
            this.butSearchCustomer.UseVisualStyleBackColor = true;
            this.butSearchCustomer.Click += new System.EventHandler(this.butSearchCustomer_Click);
            // 
            // lblMedia
            // 
            resources.ApplyResources(this.lblMedia, "lblMedia");
            this.lblMedia.Name = "lblMedia";
            // 
            // butMediaSearch
            // 
            resources.ApplyResources(this.butMediaSearch, "butMediaSearch");
            this.butMediaSearch.Name = "butMediaSearch";
            this.butMediaSearch.UseVisualStyleBackColor = true;
            this.butMediaSearch.Click += new System.EventHandler(this.butMediaSearch_Click);
            // 
            // butMedia2Rs
            // 
            this.butMedia2Rs.Image = global::MediathekClient.Properties.Resources.arrow_left;
            resources.ApplyResources(this.butMedia2Rs, "butMedia2Rs");
            this.butMedia2Rs.Name = "butMedia2Rs";
            this.butMedia2Rs.UseVisualStyleBackColor = true;
            this.butMedia2Rs.Click += new System.EventHandler(this.butMedia2Rs_Click);
            // 
            // butRes2Media
            // 
            this.butRes2Media.Image = global::MediathekClient.Properties.Resources.arrow_right;
            resources.ApplyResources(this.butRes2Media, "butRes2Media");
            this.butRes2Media.Name = "butRes2Media";
            this.butRes2Media.UseVisualStyleBackColor = true;
            this.butRes2Media.Click += new System.EventHandler(this.butRes2Media_Click);
            // 
            // butRent2Media
            // 
            this.butRent2Media.Image = global::MediathekClient.Properties.Resources.arrow_left;
            resources.ApplyResources(this.butRent2Media, "butRent2Media");
            this.butRent2Media.Name = "butRent2Media";
            this.butRent2Media.UseVisualStyleBackColor = true;
            this.butRent2Media.Click += new System.EventHandler(this.butRent2Media_Click);
            // 
            // butMedia2Rent
            // 
            this.butMedia2Rent.Image = global::MediathekClient.Properties.Resources.arrow_right;
            resources.ApplyResources(this.butMedia2Rent, "butMedia2Rent");
            this.butMedia2Rent.Name = "butMedia2Rent";
            this.butMedia2Rent.UseVisualStyleBackColor = true;
            this.butMedia2Rent.Click += new System.EventHandler(this.butMedia2Rent_Click);
            // 
            // butClose
            // 
            this.butClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.butClose, "butClose");
            this.butClose.Name = "butClose";
            this.butClose.UseVisualStyleBackColor = true;
            // 
            // FrmMediaTasks
            // 
            resources.ApplyResources(this, "$this");
            this.CancelButton = this.butClose;
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butRent2Media);
            this.Controls.Add(this.butMedia2Rent);
            this.Controls.Add(this.butRes2Media);
            this.Controls.Add(this.butMedia2Rs);
            this.Controls.Add(this.butMediaSearch);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.butSearchCustomer);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMediaTasks";
            this.Load += new System.EventHandler(this.FrmMediaTasks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Button butSearchCustomer;
        private System.Windows.Forms.Button butCreateReservations;
        private System.Windows.Forms.Button butDeleteSelected;
        private System.Windows.Forms.Button butCreateLendings;
        private System.Windows.Forms.ListBox lbReservation;
        private System.Windows.Forms.ListBox lbMedia;
        private System.Windows.Forms.ListBox lbRent;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Button butMediaSearch;
        private System.Windows.Forms.Button butMedia2Rs;
        private System.Windows.Forms.Button butRes2Media;
        private System.Windows.Forms.Button butRent2Media;
        private System.Windows.Forms.Button butMedia2Rent;
        private System.Windows.Forms.Button butClose;
    }
}
