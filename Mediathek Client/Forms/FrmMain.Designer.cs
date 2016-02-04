namespace MediathekClient
{
    /// <summary>
    /// Main Form
    /// </summary>
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.butClose = new System.Windows.Forms.Button();
            this.butManageAdmins = new System.Windows.Forms.Button();
            this.gbMedia = new System.Windows.Forms.GroupBox();
            this.butMedia = new System.Windows.Forms.Button();
            this.butManageCustomers = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butReturnMedia = new System.Windows.Forms.Button();
            this.butMediaReservations = new System.Windows.Forms.Button();
            this.butMediaRent = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsLblUserInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbMedia.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // butClose
            // 
            resources.ApplyResources(this.butClose, "butClose");
            this.butClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butClose.Name = "butClose";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butManageAdmins
            // 
            resources.ApplyResources(this.butManageAdmins, "butManageAdmins");
            this.butManageAdmins.Name = "butManageAdmins";
            this.butManageAdmins.UseVisualStyleBackColor = true;
            this.butManageAdmins.Click += new System.EventHandler(this.butManageAdmins_Click);
            // 
            // gbMedia
            // 
            this.gbMedia.Controls.Add(this.butMedia);
            this.gbMedia.Controls.Add(this.butManageCustomers);
            this.gbMedia.Controls.Add(this.butManageAdmins);
            resources.ApplyResources(this.gbMedia, "gbMedia");
            this.gbMedia.Name = "gbMedia";
            this.gbMedia.TabStop = false;
            // 
            // butMedia
            // 
            resources.ApplyResources(this.butMedia, "butMedia");
            this.butMedia.Name = "butMedia";
            this.butMedia.UseVisualStyleBackColor = true;
            this.butMedia.Click += new System.EventHandler(this.butMedia_Click);
            // 
            // butManageCustomers
            // 
            resources.ApplyResources(this.butManageCustomers, "butManageCustomers");
            this.butManageCustomers.Name = "butManageCustomers";
            this.butManageCustomers.UseVisualStyleBackColor = true;
            this.butManageCustomers.Click += new System.EventHandler(this.butManageCustomers_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butReturnMedia);
            this.groupBox2.Controls.Add(this.butMediaReservations);
            this.groupBox2.Controls.Add(this.butMediaRent);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // butReturnMedia
            // 
            resources.ApplyResources(this.butReturnMedia, "butReturnMedia");
            this.butReturnMedia.Name = "butReturnMedia";
            this.butReturnMedia.UseVisualStyleBackColor = true;
            this.butReturnMedia.Click += new System.EventHandler(this.butReturnMedia_Click);
            // 
            // butMediaReservations
            // 
            resources.ApplyResources(this.butMediaReservations, "butMediaReservations");
            this.butMediaReservations.Name = "butMediaReservations";
            this.butMediaReservations.UseVisualStyleBackColor = true;
            this.butMediaReservations.Click += new System.EventHandler(this.butMediaReservations_Click);
            // 
            // butMediaRent
            // 
            resources.ApplyResources(this.butMediaRent, "butMediaRent");
            this.butMediaRent.Name = "butMediaRent";
            this.butMediaRent.UseVisualStyleBackColor = true;
            this.butMediaRent.Click += new System.EventHandler(this.butMediaRent_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblUserInfo});
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.SizingGrip = false;
            // 
            // tsLblUserInfo
            // 
            this.tsLblUserInfo.Name = "tsLblUserInfo";
            resources.ApplyResources(this.tsLblUserInfo, "tsLblUserInfo");
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            resources.ApplyResources(this.infoToolStripMenuItem, "infoToolStripMenuItem");
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            resources.ApplyResources(this.menuToolStripMenuItem, "menuToolStripMenuItem");
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AcceptButton = this.butMediaRent;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butClose;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbMedia);
            this.Controls.Add(this.butClose);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.gbMedia.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butManageAdmins;
        private System.Windows.Forms.GroupBox gbMedia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butMedia;
        private System.Windows.Forms.Button butManageCustomers;
        private System.Windows.Forms.Button butMediaReservations;
        private System.Windows.Forms.Button butMediaRent;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsLblUserInfo;
        private System.Windows.Forms.Button butReturnMedia;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

