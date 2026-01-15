
namespace TrendMicroSecurityAgent
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnHide = new DevExpress.XtraEditors.SimpleButton();
            this.btnHelp = new DevExpress.XtraEditors.SimpleButton();
            this.lstImgClose = new System.Windows.Forms.ImageList(this.components);
            this.lstImgHide = new System.Windows.Forms.ImageList(this.components);
            this.lstImgHelp = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemComponent = new System.Windows.Forms.ToolStripMenuItem();
            this.itemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemScan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.itemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogs = new DevExpress.XtraEditors.SimpleButton();
            this.toolTipController_Logs = new DevExpress.Utils.ToolTipController(this.components);
            this.lstImgLogs = new System.Windows.Forms.ImageList(this.components);
            this.btnSettings = new DevExpress.XtraEditors.SimpleButton();
            this.lstImgSettings = new System.Windows.Forms.ImageList(this.components);
            this.lstImgTools = new System.Windows.Forms.ImageList(this.components);
            this.btnTools = new DevExpress.XtraEditors.SimpleButton();
            this.lnkVirus = new System.Windows.Forms.LinkLabel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lnkVirus_Qty = new System.Windows.Forms.LinkLabel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lnkSpyware_Qty = new System.Windows.Forms.LinkLabel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lnkSpyware = new System.Windows.Forms.LinkLabel();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lnkScheduled_Status = new System.Windows.Forms.LinkLabel();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lnkScheduled = new System.Windows.Forms.LinkLabel();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lnkPattern_Qty = new System.Windows.Forms.LinkLabel();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.lnkPattern = new System.Windows.Forms.LinkLabel();
            this.lstImgScan = new System.Windows.Forms.ImageList(this.components);
            this.btnScan = new DevExpress.XtraEditors.PictureEdit();
            this.lstImgUpdate = new System.Windows.Forms.ImageList(this.components);
            this.btnUpdate = new DevExpress.XtraEditors.PictureEdit();
            this.btnStatus = new DevExpress.XtraEditors.PictureEdit();
            this.btnStatus2 = new DevExpress.XtraEditors.PictureEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnScan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStatus2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClose.Location = new System.Drawing.Point(451, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 17);
            this.btnClose.TabIndex = 0;
            this.btnClose.ToolTip = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // btnHide
            // 
            this.btnHide.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnHide.Appearance.Options.UseBackColor = true;
            this.btnHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHide.BackgroundImage")));
            this.btnHide.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHide.ImageOptions.Image")));
            this.btnHide.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnHide.Location = new System.Drawing.Point(426, 1);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(25, 17);
            this.btnHide.TabIndex = 1;
            this.btnHide.ToolTip = "Minimize";
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            this.btnHide.MouseLeave += new System.EventHandler(this.btnHide_MouseLeave);
            this.btnHide.MouseHover += new System.EventHandler(this.btnHide_MouseHover);
            // 
            // btnHelp
            // 
            this.btnHelp.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnHelp.Appearance.Options.UseBackColor = true;
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.ImageOptions.Image")));
            this.btnHelp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnHelp.Location = new System.Drawing.Point(400, 1);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(27, 17);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.ToolTip = "Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseLeave += new System.EventHandler(this.btnHelp_MouseLeave);
            this.btnHelp.MouseHover += new System.EventHandler(this.btnHelp_MouseHover);
            // 
            // lstImgClose
            // 
            this.lstImgClose.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgClose.ImageStream")));
            this.lstImgClose.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgClose.Images.SetKeyName(0, "Close.jpg");
            this.lstImgClose.Images.SetKeyName(1, "Close2.jpg");
            // 
            // lstImgHide
            // 
            this.lstImgHide.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgHide.ImageStream")));
            this.lstImgHide.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgHide.Images.SetKeyName(0, "Hide.jpg");
            this.lstImgHide.Images.SetKeyName(1, "Hide2.jpg");
            // 
            // lstImgHelp
            // 
            this.lstImgHelp.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgHelp.ImageStream")));
            this.lstImgHelp.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgHelp.Images.SetKeyName(0, "help.jpg");
            this.lstImgHelp.Images.SetKeyName(1, "help2.jpg");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Trend Micro Security Agent(Offline)";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemComponent,
            this.itemUpdate,
            this.toolStripSeparator1,
            this.itemScan,
            this.toolStripSeparator2,
            this.itemOpen,
            this.toolStripSeparator3,
            this.itemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(237, 132);
            // 
            // itemComponent
            // 
            this.itemComponent.Name = "itemComponent";
            this.itemComponent.Size = new System.Drawing.Size(236, 22);
            this.itemComponent.Text = "Component versions";
            this.itemComponent.Click += new System.EventHandler(this.itemComponent_Click);
            // 
            // itemUpdate
            // 
            this.itemUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.itemUpdate.Name = "itemUpdate";
            this.itemUpdate.Size = new System.Drawing.Size(236, 22);
            this.itemUpdate.Text = "Update Now";
            this.itemUpdate.Click += new System.EventHandler(this.itemUpdate_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // itemScan
            // 
            this.itemScan.Name = "itemScan";
            this.itemScan.Size = new System.Drawing.Size(236, 22);
            this.itemScan.Text = "Scan Now";
            this.itemScan.Click += new System.EventHandler(this.itemScan_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(233, 6);
            // 
            // itemOpen
            // 
            this.itemOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.itemOpen.Name = "itemOpen";
            this.itemOpen.Size = new System.Drawing.Size(236, 22);
            this.itemOpen.Text = "Open Security Agent Console";
            this.itemOpen.Click += new System.EventHandler(this.itemOpen_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(233, 6);
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(236, 22);
            this.itemExit.Text = "Exit Security Agent";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.AllowFocus = false;
            this.btnLogs.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLogs.Appearance.Options.UseFont = true;
            this.btnLogs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogs.ImageOptions.Image")));
            this.btnLogs.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLogs.Location = new System.Drawing.Point(15, 386);
            this.btnLogs.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(46, 37);
            this.btnLogs.TabIndex = 4;
            this.btnLogs.ToolTip = "Logs";
            this.btnLogs.ToolTipController = this.toolTipController_Logs;
            this.btnLogs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLogs_MouseClick);
            this.btnLogs.MouseLeave += new System.EventHandler(this.btnLogs_MouseLeave);
            this.btnLogs.MouseHover += new System.EventHandler(this.btnLogs_MouseHover);
            // 
            // toolTipController_Logs
            // 
            this.toolTipController_Logs.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolTipController_Logs.Appearance.BackColor2 = System.Drawing.Color.White;
            this.toolTipController_Logs.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolTipController_Logs.Appearance.Options.UseBackColor = true;
            this.toolTipController_Logs.Appearance.Options.UseFont = true;
            this.toolTipController_Logs.AppearanceTitle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.toolTipController_Logs.AppearanceTitle.Options.UseFont = true;
            this.toolTipController_Logs.ShowShadow = false;
            this.toolTipController_Logs.ToolTipLocation = DevExpress.Utils.ToolTipLocation.BottomCenter;
            this.toolTipController_Logs.ToolTipStyle = DevExpress.Utils.ToolTipStyle.WindowsXP;
            this.toolTipController_Logs.ToolTipType = DevExpress.Utils.ToolTipType.Standard;
            // 
            // lstImgLogs
            // 
            this.lstImgLogs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgLogs.ImageStream")));
            this.lstImgLogs.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgLogs.Images.SetKeyName(0, "Logs.jpg");
            this.lstImgLogs.Images.SetKeyName(1, "Logs2.jpg");
            // 
            // btnSettings
            // 
            this.btnSettings.AllowFocus = false;
            this.btnSettings.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSettings.Appearance.Options.UseFont = true;
            this.btnSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.ImageOptions.Image")));
            this.btnSettings.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSettings.Location = new System.Drawing.Point(63, 386);
            this.btnSettings.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(46, 37);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.ToolTip = "Settings";
            this.btnSettings.ToolTipController = this.toolTipController_Logs;
            this.btnSettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSettings_MouseClick);
            this.btnSettings.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
            this.btnSettings.MouseHover += new System.EventHandler(this.btnSettings_MouseHover);
            // 
            // lstImgSettings
            // 
            this.lstImgSettings.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgSettings.ImageStream")));
            this.lstImgSettings.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgSettings.Images.SetKeyName(0, "Settings.jpg");
            this.lstImgSettings.Images.SetKeyName(1, "Settings2.jpg");
            // 
            // lstImgTools
            // 
            this.lstImgTools.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgTools.ImageStream")));
            this.lstImgTools.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgTools.Images.SetKeyName(0, "Tools.jpg");
            this.lstImgTools.Images.SetKeyName(1, "Tools2.jpg");
            // 
            // btnTools
            // 
            this.btnTools.AllowFocus = false;
            this.btnTools.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnTools.Appearance.Options.UseFont = true;
            this.btnTools.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTools.ImageOptions.Image")));
            this.btnTools.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnTools.Location = new System.Drawing.Point(113, 386);
            this.btnTools.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(46, 37);
            this.btnTools.TabIndex = 6;
            this.btnTools.ToolTip = "Tools";
            this.btnTools.ToolTipController = this.toolTipController_Logs;
            this.btnTools.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTools_MouseClick);
            this.btnTools.MouseLeave += new System.EventHandler(this.btnTools_MouseLeave);
            this.btnTools.MouseHover += new System.EventHandler(this.btnTools_MouseHover);
            // 
            // lnkVirus
            // 
            this.lnkVirus.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkVirus.AutoSize = true;
            this.lnkVirus.BackColor = System.Drawing.Color.Transparent;
            this.lnkVirus.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.lnkVirus.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkVirus.LinkColor = System.Drawing.Color.Black;
            this.lnkVirus.Location = new System.Drawing.Point(11, 186);
            this.lnkVirus.Name = "lnkVirus";
            this.lnkVirus.Size = new System.Drawing.Size(104, 16);
            this.lnkVirus.TabIndex = 7;
            this.lnkVirus.TabStop = true;
            this.lnkVirus.Text = "Virus/Malware";
            this.lnkVirus.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkVirus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVirus_LinkClicked);
            this.lnkVirus.MouseLeave += new System.EventHandler(this.lnkVirus_MouseLeave);
            this.lnkVirus.MouseHover += new System.EventHandler(this.lnkVirus_MouseHover);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 199);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(309, 11);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "................................................................................." +
    "......................";
            // 
            // lnkVirus_Qty
            // 
            this.lnkVirus_Qty.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkVirus_Qty.BackColor = System.Drawing.Color.Transparent;
            this.lnkVirus_Qty.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkVirus_Qty.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkVirus_Qty.LinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkVirus_Qty.Location = new System.Drawing.Point(220, 186);
            this.lnkVirus_Qty.Name = "lnkVirus_Qty";
            this.lnkVirus_Qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lnkVirus_Qty.Size = new System.Drawing.Size(104, 17);
            this.lnkVirus_Qty.TabIndex = 9;
            this.lnkVirus_Qty.TabStop = true;
            this.lnkVirus_Qty.Text = "0";
            this.lnkVirus_Qty.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkVirus_Qty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkVirus_Qty_LinkClicked);
            this.lnkVirus_Qty.MouseLeave += new System.EventHandler(this.lnkVirus_Qty_MouseLeave);
            this.lnkVirus_Qty.MouseHover += new System.EventHandler(this.lnkVirus_Qty_MouseHover);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 211);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(144, 13);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Since 21/06/2022 (Tue) 09:35";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 260);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(144, 13);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "Since 21/06/2022 (Tue) 09:35";
            // 
            // lnkSpyware_Qty
            // 
            this.lnkSpyware_Qty.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkSpyware_Qty.BackColor = System.Drawing.Color.Transparent;
            this.lnkSpyware_Qty.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSpyware_Qty.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkSpyware_Qty.LinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkSpyware_Qty.Location = new System.Drawing.Point(221, 231);
            this.lnkSpyware_Qty.Name = "lnkSpyware_Qty";
            this.lnkSpyware_Qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lnkSpyware_Qty.Size = new System.Drawing.Size(104, 17);
            this.lnkSpyware_Qty.TabIndex = 13;
            this.lnkSpyware_Qty.TabStop = true;
            this.lnkSpyware_Qty.Text = "0";
            this.lnkSpyware_Qty.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkSpyware_Qty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSpyware_Qty_LinkClicked);
            this.lnkSpyware_Qty.MouseLeave += new System.EventHandler(this.lnkSpyware_Qty_MouseLeave);
            this.lnkSpyware_Qty.MouseHover += new System.EventHandler(this.lnkSpyware_Qty_MouseHover);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(13, 248);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(309, 11);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "................................................................................." +
    "......................";
            // 
            // lnkSpyware
            // 
            this.lnkSpyware.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkSpyware.AutoSize = true;
            this.lnkSpyware.BackColor = System.Drawing.Color.Transparent;
            this.lnkSpyware.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSpyware.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkSpyware.LinkColor = System.Drawing.Color.Black;
            this.lnkSpyware.Location = new System.Drawing.Point(11, 231);
            this.lnkSpyware.Name = "lnkSpyware";
            this.lnkSpyware.Size = new System.Drawing.Size(136, 16);
            this.lnkSpyware.TabIndex = 11;
            this.lnkSpyware.TabStop = true;
            this.lnkSpyware.Text = "Spyware/Grayware";
            this.lnkSpyware.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkSpyware.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSpyware_LinkClicked);
            this.lnkSpyware.MouseLeave += new System.EventHandler(this.lnkSpyware_MouseLeave);
            this.lnkSpyware.MouseHover += new System.EventHandler(this.lnkSpyware_MouseHover);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 308);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(126, 13);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Scheduled scan is disabled";
            // 
            // lnkScheduled_Status
            // 
            this.lnkScheduled_Status.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkScheduled_Status.BackColor = System.Drawing.Color.Transparent;
            this.lnkScheduled_Status.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkScheduled_Status.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkScheduled_Status.LinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkScheduled_Status.Location = new System.Drawing.Point(217, 283);
            this.lnkScheduled_Status.Name = "lnkScheduled_Status";
            this.lnkScheduled_Status.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lnkScheduled_Status.Size = new System.Drawing.Size(104, 17);
            this.lnkScheduled_Status.TabIndex = 17;
            this.lnkScheduled_Status.TabStop = true;
            this.lnkScheduled_Status.Text = "Disabled";
            this.lnkScheduled_Status.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkScheduled_Status.MouseLeave += new System.EventHandler(this.lnkScheduled_Status_MouseLeave);
            this.lnkScheduled_Status.MouseHover += new System.EventHandler(this.lnkScheduled_Status_MouseHover);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(11, 296);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(309, 11);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "................................................................................." +
    "......................";
            // 
            // lnkScheduled
            // 
            this.lnkScheduled.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnkScheduled.AutoSize = true;
            this.lnkScheduled.BackColor = System.Drawing.Color.Transparent;
            this.lnkScheduled.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.lnkScheduled.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkScheduled.LinkColor = System.Drawing.Color.Black;
            this.lnkScheduled.Location = new System.Drawing.Point(10, 283);
            this.lnkScheduled.Name = "lnkScheduled";
            this.lnkScheduled.Size = new System.Drawing.Size(108, 16);
            this.lnkScheduled.TabIndex = 15;
            this.lnkScheduled.TabStop = true;
            this.lnkScheduled.Text = "Scheduled scan";
            this.lnkScheduled.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkScheduled.MouseLeave += new System.EventHandler(this.lnkScheduled_MouseLeave);
            this.lnkScheduled.MouseHover += new System.EventHandler(this.lnkScheduled_MouseHover);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(11, 353);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(178, 13);
            this.labelControl7.TabIndex = 22;
            this.labelControl7.Text = "Last update 20/06/2022 (Mon) 08:00";
            // 
            // lnkPattern_Qty
            // 
            this.lnkPattern_Qty.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkPattern_Qty.BackColor = System.Drawing.Color.Transparent;
            this.lnkPattern_Qty.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkPattern_Qty.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkPattern_Qty.LinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkPattern_Qty.Location = new System.Drawing.Point(219, 328);
            this.lnkPattern_Qty.Name = "lnkPattern_Qty";
            this.lnkPattern_Qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lnkPattern_Qty.Size = new System.Drawing.Size(104, 17);
            this.lnkPattern_Qty.TabIndex = 21;
            this.lnkPattern_Qty.TabStop = true;
            this.lnkPattern_Qty.Tag = "";
            this.lnkPattern_Qty.Text = "17.637.000";
            this.lnkPattern_Qty.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkPattern_Qty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPattern_Qty_LinkClicked);
            this.lnkPattern_Qty.MouseLeave += new System.EventHandler(this.lnkPattern_Qty_MouseLeave);
            this.lnkPattern_Qty.MouseHover += new System.EventHandler(this.lnkPattern_Qty_MouseHover);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(11, 341);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(309, 11);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "................................................................................." +
    "......................";
            // 
            // lnkPattern
            // 
            this.lnkPattern.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkPattern.AutoSize = true;
            this.lnkPattern.BackColor = System.Drawing.Color.Transparent;
            this.lnkPattern.Font = new System.Drawing.Font("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.lnkPattern.ForeColor = System.Drawing.Color.Black;
            this.lnkPattern.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkPattern.LinkColor = System.Drawing.Color.Black;
            this.lnkPattern.Location = new System.Drawing.Point(10, 328);
            this.lnkPattern.Name = "lnkPattern";
            this.lnkPattern.Size = new System.Drawing.Size(95, 16);
            this.lnkPattern.TabIndex = 19;
            this.lnkPattern.TabStop = true;
            this.lnkPattern.Text = "Virus Pattern";
            this.lnkPattern.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkPattern.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPattern_LinkClicked);
            this.lnkPattern.MouseLeave += new System.EventHandler(this.lnkPattern_MouseLeave);
            this.lnkPattern.MouseHover += new System.EventHandler(this.lnkPattern_MouseHover);
            // 
            // lstImgScan
            // 
            this.lstImgScan.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgScan.ImageStream")));
            this.lstImgScan.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgScan.Images.SetKeyName(0, "Scan.png");
            this.lstImgScan.Images.SetKeyName(1, "Scan2.png");
            // 
            // btnScan
            // 
            this.btnScan.EditValue = ((object)(resources.GetObject("btnScan.EditValue")));
            this.btnScan.Location = new System.Drawing.Point(344, 185);
            this.btnScan.Name = "btnScan";
            this.btnScan.Properties.AllowFocused = false;
            this.btnScan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnScan.Properties.ShowEditMenuItem = DevExpress.Utils.DefaultBoolean.False;
            this.btnScan.Properties.ShowMenu = false;
            this.btnScan.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.False;
            this.btnScan.Size = new System.Drawing.Size(135, 38);
            this.btnScan.TabIndex = 25;
            this.btnScan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnScan_MouseClick);
            this.btnScan.MouseLeave += new System.EventHandler(this.btnScan_MouseLeave);
            this.btnScan.MouseHover += new System.EventHandler(this.btnScan_MouseHover);
            // 
            // lstImgUpdate
            // 
            this.lstImgUpdate.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgUpdate.ImageStream")));
            this.lstImgUpdate.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgUpdate.Images.SetKeyName(0, "Update.png");
            this.lstImgUpdate.Images.SetKeyName(1, "Update2.png");
            // 
            // btnUpdate
            // 
            this.btnUpdate.EditValue = ((object)(resources.GetObject("btnUpdate.EditValue")));
            this.btnUpdate.Location = new System.Drawing.Point(344, 282);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Properties.AllowFocused = false;
            this.btnUpdate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnUpdate.Properties.ShowEditMenuItem = DevExpress.Utils.DefaultBoolean.False;
            this.btnUpdate.Properties.ShowMenu = false;
            this.btnUpdate.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.False;
            this.btnUpdate.Size = new System.Drawing.Size(135, 38);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnUpdate_MouseClick);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            this.btnUpdate.MouseHover += new System.EventHandler(this.btnUpdate_MouseHover);
            // 
            // btnStatus
            // 
            this.btnStatus.EditValue = ((object)(resources.GetObject("btnStatus.EditValue")));
            this.btnStatus.Location = new System.Drawing.Point(450, 386);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Properties.AllowFocused = false;
            this.btnStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnStatus.Properties.ShowEditMenuItem = DevExpress.Utils.DefaultBoolean.False;
            this.btnStatus.Properties.ShowMenu = false;
            this.btnStatus.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.False;
            this.btnStatus.Size = new System.Drawing.Size(40, 35);
            this.btnStatus.TabIndex = 27;
            this.btnStatus.MouseHover += new System.EventHandler(this.btnStatus_MouseHover);
            // 
            // btnStatus2
            // 
            this.btnStatus2.EditValue = ((object)(resources.GetObject("btnStatus2.EditValue")));
            this.btnStatus2.Location = new System.Drawing.Point(282, 79);
            this.btnStatus2.Name = "btnStatus2";
            this.btnStatus2.Properties.AllowFocused = false;
            this.btnStatus2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnStatus2.Properties.ShowEditMenuItem = DevExpress.Utils.DefaultBoolean.False;
            this.btnStatus2.Properties.ShowMenu = false;
            this.btnStatus2.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.False;
            this.btnStatus2.Size = new System.Drawing.Size(208, 340);
            this.btnStatus2.TabIndex = 28;
            this.btnStatus2.MouseLeave += new System.EventHandler(this.btnStatus2_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(497, 461);
            this.Controls.Add(this.btnStatus2);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.lnkPattern_Qty);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.lnkPattern);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lnkScheduled_Status);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.lnkScheduled);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lnkSpyware_Qty);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lnkSpyware);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lnkVirus_Qty);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lnkVirus);
            this.Controls.Add(this.btnTools);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnLogs);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmDashboard.IconOptions.Icon")));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmDashboard.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(497, 461);
            this.MinimumSize = new System.Drawing.Size(497, 461);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security Agent";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDashboard_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmDashboard_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmDashboard_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnScan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStatus2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnHide;
        private DevExpress.XtraEditors.SimpleButton btnHelp;
        private System.Windows.Forms.ImageList lstImgClose;
        private System.Windows.Forms.ImageList lstImgHide;
        private System.Windows.Forms.ImageList lstImgHelp;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private DevExpress.XtraEditors.SimpleButton btnLogs;
        private System.Windows.Forms.ImageList lstImgLogs;
        private DevExpress.Utils.ToolTipController toolTipController_Logs;
        private DevExpress.XtraEditors.SimpleButton btnSettings;
        private System.Windows.Forms.ImageList lstImgSettings;
        private System.Windows.Forms.ImageList lstImgTools;
        private DevExpress.XtraEditors.SimpleButton btnTools;
        private System.Windows.Forms.LinkLabel lnkVirus;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.LinkLabel lnkVirus_Qty;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.LinkLabel lnkSpyware_Qty;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.LinkLabel lnkSpyware;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.LinkLabel lnkScheduled_Status;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.LinkLabel lnkScheduled;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.LinkLabel lnkPattern_Qty;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.LinkLabel lnkPattern;
        private System.Windows.Forms.ImageList lstImgScan;
        private DevExpress.XtraEditors.PictureEdit btnScan;
        private System.Windows.Forms.ImageList lstImgUpdate;
        private DevExpress.XtraEditors.PictureEdit btnUpdate;
        private DevExpress.XtraEditors.PictureEdit btnStatus;
        private DevExpress.XtraEditors.PictureEdit btnStatus2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemComponent;
        private System.Windows.Forms.ToolStripMenuItem itemUpdate;
        private System.Windows.Forms.ToolStripMenuItem itemScan;
        private System.Windows.Forms.ToolStripMenuItem itemOpen;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Timer timer1;
    }
}