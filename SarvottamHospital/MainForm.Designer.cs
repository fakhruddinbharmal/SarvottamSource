namespace SarvottamHospital
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.nicApp = new System.Windows.Forms.NotifyIcon(this.components);
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmForgotMe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMyProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEmp = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imMailSmall = new System.Windows.Forms.ImageList(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblWorkSpace = new System.Windows.Forms.Label();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsEntities = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lsvBottom = new System.Windows.Forms.ListView();
            this.imlSmall = new System.Windows.Forms.ImageList(this.components);
            this.imlLarge = new System.Windows.Forms.ImageList(this.components);
            this.clhDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlpRefresh = new System.Windows.Forms.TableLayoutPanel();
            this.lsvData = new System.Windows.Forms.ListView();
            this.tlpDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.scMainSplitter = new System.Windows.Forms.SplitContainer();
            this.tlpBottom = new System.Windows.Forms.TableLayoutPanel();
            this.tbpDashboard = new System.Windows.Forms.TabPage();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.picAppLogo = new System.Windows.Forms.PictureBox();
            this.picUserPhoto = new System.Windows.Forms.PictureBox();
            this.lineTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.cmsEmp.SuspendLayout();
            this.tlpRefresh.SuspendLayout();
            this.tlpDashboard.SuspendLayout();
            this.scMainSplitter.Panel1.SuspendLayout();
            this.scMainSplitter.Panel2.SuspendLayout();
            this.scMainSplitter.SuspendLayout();
            this.tlpBottom.SuspendLayout();
            this.tbpDashboard.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPhoto)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // nicApp
            // 
            this.nicApp.BalloonTipText = "HMS 1.0.0.0";
            this.nicApp.Text = "HMS 1.0.0.0";
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(168, 22);
            this.tsmExit.Text = "E&xit";
            // 
            // tsmLogout
            // 
            this.tsmLogout.Name = "tsmLogout";
            this.tsmLogout.Size = new System.Drawing.Size(168, 22);
            this.tsmLogout.Text = "&Logout";
            // 
            // tsmForgotMe
            // 
            this.tsmForgotMe.Name = "tsmForgotMe";
            this.tsmForgotMe.Size = new System.Drawing.Size(168, 22);
            this.tsmForgotMe.Text = "&Forgot Me";
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(168, 22);
            this.tsmChangePassword.Text = "&Change Password";
            // 
            // tsmMyProfile
            // 
            this.tsmMyProfile.Name = "tsmMyProfile";
            this.tsmMyProfile.Size = new System.Drawing.Size(168, 22);
            this.tsmMyProfile.Text = "&My Profile";
            // 
            // cmsEmp
            // 
            this.cmsEmp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMyProfile,
            this.tsmChangePassword,
            this.tsmForgotMe,
            this.tsmLogout,
            this.tsmExit});
            this.cmsEmp.Name = "cmsEmp";
            this.cmsEmp.Size = new System.Drawing.Size(169, 114);
            // 
            // imMailSmall
            // 
            this.imMailSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imMailSmall.ImageSize = new System.Drawing.Size(16, 16);
            this.imMailSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(2, 20);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.UseMnemonic = false;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lblWorkSpace
            // 
            this.lblWorkSpace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWorkSpace.AutoSize = true;
            this.lblWorkSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkSpace.Location = new System.Drawing.Point(11, 6);
            this.lblWorkSpace.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lblWorkSpace.Name = "lblWorkSpace";
            this.lblWorkSpace.Size = new System.Drawing.Size(130, 13);
            this.lblWorkSpace.TabIndex = 11;
            this.lblWorkSpace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 112;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 400;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "From";
            this.columnHeader1.Width = 150;
            // 
            // cmsEntities
            // 
            this.cmsEntities.Name = "cmsEntities";
            this.cmsEntities.Size = new System.Drawing.Size(61, 4);
            // 
            // lsvBottom
            // 
            this.lsvBottom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvBottom.HideSelection = false;
            this.lsvBottom.LabelWrap = false;
            this.lsvBottom.Location = new System.Drawing.Point(3, 35);
            this.lsvBottom.MultiSelect = false;
            this.lsvBottom.Name = "lsvBottom";
            this.lsvBottom.ShowItemToolTips = true;
            this.lsvBottom.Size = new System.Drawing.Size(144, 8);
            this.lsvBottom.TabIndex = 4;
            this.lsvBottom.UseCompatibleStateImageBehavior = false;
            this.lsvBottom.View = System.Windows.Forms.View.Details;
            // 
            // imlSmall
            // 
            this.imlSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlSmall.ImageStream")));
            this.imlSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imlSmall.Images.SetKeyName(0, "default");
            // 
            // imlLarge
            // 
            this.imlLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlLarge.ImageStream")));
            this.imlLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imlLarge.Images.SetKeyName(0, "default");
            // 
            // clhName
            // 
            this.clhName.Text = "Name";
            this.clhName.Width = 200;
            // 
            // tlpRefresh
            // 
            this.tlpRefresh.ColumnCount = 2;
            this.tlpRefresh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.18238F));
            this.tlpRefresh.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.81762F));
            this.tlpRefresh.Controls.Add(this.btnRefresh, 0, 0);
            this.tlpRefresh.Controls.Add(this.lblWorkSpace, 1, 0);
            this.tlpRefresh.Location = new System.Drawing.Point(3, 3);
            this.tlpRefresh.Name = "tlpRefresh";
            this.tlpRefresh.RowCount = 1;
            this.tlpRefresh.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpRefresh.Size = new System.Drawing.Size(144, 26);
            this.tlpRefresh.TabIndex = 5;
            // 
            // lsvData
            // 
            this.lsvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhName,
            this.clhDesc});
            this.lsvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvData.HideSelection = false;
            this.lsvData.LargeImageList = this.imlLarge;
            this.lsvData.Location = new System.Drawing.Point(3, 6);
            this.lsvData.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.lsvData.MultiSelect = false;
            this.lsvData.Name = "lsvData";
            this.lsvData.ShowItemToolTips = true;
            this.lsvData.Size = new System.Drawing.Size(653, 313);
            this.lsvData.SmallImageList = this.imlSmall;
            this.lsvData.TabIndex = 0;
            this.lsvData.TileSize = new System.Drawing.Size(300, 36);
            this.lsvData.UseCompatibleStateImageBehavior = false;
            this.lsvData.View = System.Windows.Forms.View.Tile;
            // 
            // tlpDashboard
            // 
            this.tlpDashboard.ColumnCount = 1;
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDashboard.Controls.Add(this.lsvData, 0, 0);
            this.tlpDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDashboard.Location = new System.Drawing.Point(0, 0);
            this.tlpDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.tlpDashboard.Name = "tlpDashboard";
            this.tlpDashboard.RowCount = 1;
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDashboard.Size = new System.Drawing.Size(659, 325);
            this.tlpDashboard.TabIndex = 2;
            // 
            // scMainSplitter
            // 
            this.scMainSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMainSplitter.Location = new System.Drawing.Point(3, 3);
            this.scMainSplitter.Name = "scMainSplitter";
            this.scMainSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMainSplitter.Panel1
            // 
            this.scMainSplitter.Panel1.Controls.Add(this.tlpDashboard);
            // 
            // scMainSplitter.Panel2
            // 
            this.scMainSplitter.Panel2.Controls.Add(this.tlpBottom);
            this.scMainSplitter.Panel2Collapsed = true;
            this.scMainSplitter.Size = new System.Drawing.Size(659, 325);
            this.scMainSplitter.SplitterDistance = 149;
            this.scMainSplitter.SplitterWidth = 2;
            this.scMainSplitter.TabIndex = 0;
            // 
            // tlpBottom
            // 
            this.tlpBottom.ColumnCount = 1;
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBottom.Controls.Add(this.lsvBottom, 0, 1);
            this.tlpBottom.Controls.Add(this.tlpRefresh, 0, 0);
            this.tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBottom.Location = new System.Drawing.Point(0, 0);
            this.tlpBottom.Name = "tlpBottom";
            this.tlpBottom.RowCount = 2;
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBottom.Size = new System.Drawing.Size(150, 46);
            this.tlpBottom.TabIndex = 0;
            // 
            // tbpDashboard
            // 
            this.tbpDashboard.Controls.Add(this.scMainSplitter);
            this.tbpDashboard.ImageKey = "default";
            this.tbpDashboard.Location = new System.Drawing.Point(4, 28);
            this.tbpDashboard.Name = "tbpDashboard";
            this.tbpDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDashboard.Size = new System.Drawing.Size(665, 331);
            this.tbpDashboard.TabIndex = 0;
            this.tbpDashboard.Text = "Dashboard";
            this.tbpDashboard.UseVisualStyleBackColor = true;
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tbpDashboard);
            this.tabMain.ImageList = this.imlSmall;
            this.tabMain.ItemSize = new System.Drawing.Size(93, 24);
            this.tabMain.Location = new System.Drawing.Point(12, 53);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.ShowToolTips = true;
            this.tabMain.Size = new System.Drawing.Size(673, 363);
            this.tabMain.TabIndex = 5;
            // 
            // picAppLogo
            // 
            this.picAppLogo.BackColor = System.Drawing.Color.Transparent;
            this.picAppLogo.ErrorImage = null;
            this.picAppLogo.Image = global::SarvottamHospital.Properties.Resources.AppLogo;
            this.picAppLogo.InitialImage = null;
            this.picAppLogo.Location = new System.Drawing.Point(12, 0);
            this.picAppLogo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.picAppLogo.Name = "picAppLogo";
            this.picAppLogo.Size = new System.Drawing.Size(48, 48);
            this.picAppLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAppLogo.TabIndex = 25;
            this.picAppLogo.TabStop = false;
            // 
            // picUserPhoto
            // 
            this.picUserPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picUserPhoto.BackColor = System.Drawing.Color.Transparent;
            this.picUserPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUserPhoto.BackgroundImage")));
            this.picUserPhoto.ErrorImage = null;
            this.picUserPhoto.InitialImage = null;
            this.picUserPhoto.Location = new System.Drawing.Point(637, 0);
            this.picUserPhoto.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.picUserPhoto.Name = "picUserPhoto";
            this.picUserPhoto.Size = new System.Drawing.Size(48, 48);
            this.picUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picUserPhoto.TabIndex = 24;
            this.picUserPhoto.TabStop = false;
            // 
            // lineTitle
            // 
            this.lineTitle.BackColor = System.Drawing.Color.Transparent;
            this.lineTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lineTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lineTitle.Location = new System.Drawing.Point(0, 48);
            this.lineTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lineTitle.Name = "lineTitle";
            this.lineTitle.Size = new System.Drawing.Size(696, 2);
            this.lineTitle.TabIndex = 2;
            this.lineTitle.UseMnemonic = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Location = new System.Drawing.Point(66, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(565, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Application Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.UseMnemonic = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.White;
            this.pnlTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTitle.Controls.Add(this.picAppLogo);
            this.pnlTitle.Controls.Add(this.picUserPhoto);
            this.pnlTitle.Controls.Add(this.lineTitle);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(696, 50);
            this.pnlTitle.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(696, 447);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.pnlTitle);
            this.Name = "MainForm";
            this.Text = "Application Title";
            this.cmsEmp.ResumeLayout(false);
            this.tlpRefresh.ResumeLayout(false);
            this.tlpRefresh.PerformLayout();
            this.tlpDashboard.ResumeLayout(false);
            this.scMainSplitter.Panel1.ResumeLayout(false);
            this.scMainSplitter.Panel2.ResumeLayout(false);
            this.scMainSplitter.ResumeLayout(false);
            this.tlpBottom.ResumeLayout(false);
            this.tbpDashboard.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAppLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPhoto)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon nicApp;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem tsmLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmForgotMe;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmMyProfile;
        private System.Windows.Forms.ContextMenuStrip cmsEmp;
        private System.Windows.Forms.ImageList imMailSmall;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblWorkSpace;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ContextMenuStrip cmsEntities;
        private System.Windows.Forms.ListView lsvBottom;
        private System.Windows.Forms.ImageList imlSmall;
        private System.Windows.Forms.ImageList imlLarge;
        private System.Windows.Forms.ColumnHeader clhDesc;
        private System.Windows.Forms.ColumnHeader clhName;
        private System.Windows.Forms.TableLayoutPanel tlpRefresh;
        private System.Windows.Forms.ListView lsvData;
        private System.Windows.Forms.TableLayoutPanel tlpDashboard;
        private System.Windows.Forms.SplitContainer scMainSplitter;
        private System.Windows.Forms.TableLayoutPanel tlpBottom;
        private System.Windows.Forms.TabPage tbpDashboard;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.PictureBox picAppLogo;
        private System.Windows.Forms.PictureBox picUserPhoto;
        private System.Windows.Forms.Label lineTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlTitle;
    }
}