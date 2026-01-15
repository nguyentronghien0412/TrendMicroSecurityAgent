
namespace TrendMicroSecurityAgent
{
    partial class frmLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogs));
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lstImgClose = new System.Windows.Forms.ImageList(this.components);
            this.lstImgMinimize = new System.Windows.Forms.ImageList(this.components);
            this.lstImgHelp = new System.Windows.Forms.ImageList(this.components);
            this.lkTypeDetail = new DevExpress.XtraEditors.LookUpEdit();
            this.lkType = new DevExpress.XtraEditors.LookUpEdit();
            this.lkRange = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnClosed = new DevExpress.XtraEditors.SimpleButton();
            this.btnHelp = new DevExpress.XtraEditors.SimpleButton();
            this.btnMinimize = new DevExpress.XtraEditors.SimpleButton();
            this.lstImgbtnClose = new System.Windows.Forms.ImageList(this.components);
            this.lstImgMaximize = new System.Windows.Forms.ImageList(this.components);
            this.pnTop = new DevExpress.XtraEditors.PanelControl();
            this.pnRight = new DevExpress.XtraEditors.PanelControl();
            this.btnMaximize = new DevExpress.XtraEditors.SimpleButton();
            this.picTopCenter = new System.Windows.Forms.PictureBox();
            this.pnTopLeft = new DevExpress.XtraEditors.PanelControl();
            this.lstImgTopLeft = new System.Windows.Forms.ImageList(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnMid2 = new System.Windows.Forms.Panel();
            this.pnMid1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.lkTypeDetail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkRange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnTop)).BeginInit();
            this.pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnRight)).BeginInit();
            this.pnRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnTopLeft)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClose.Location = new System.Drawing.Point(84, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 17);
            this.btnClose.TabIndex = 0;
            this.btnClose.ToolTip = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // lstImgClose
            // 
            this.lstImgClose.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgClose.ImageStream")));
            this.lstImgClose.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgClose.Images.SetKeyName(0, "Close.jpg");
            this.lstImgClose.Images.SetKeyName(1, "Close2.jpg");
            // 
            // lstImgMinimize
            // 
            this.lstImgMinimize.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgMinimize.ImageStream")));
            this.lstImgMinimize.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgMinimize.Images.SetKeyName(0, "Hide.jpg");
            this.lstImgMinimize.Images.SetKeyName(1, "Hide2.jpg");
            // 
            // lstImgHelp
            // 
            this.lstImgHelp.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgHelp.ImageStream")));
            this.lstImgHelp.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgHelp.Images.SetKeyName(0, "help.jpg");
            this.lstImgHelp.Images.SetKeyName(1, "help2.jpg");
            // 
            // lkTypeDetail
            // 
            this.lkTypeDetail.Location = new System.Drawing.Point(218, 33);
            this.lkTypeDetail.Name = "lkTypeDetail";
            this.lkTypeDetail.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkTypeDetail.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lkTypeDetail.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Name1", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name2")});
            this.lkTypeDetail.Properties.DropDownRows = 10;
            this.lkTypeDetail.Properties.NullText = "";
            this.lkTypeDetail.Properties.PopupSizeable = false;
            this.lkTypeDetail.Properties.ShowFooter = false;
            this.lkTypeDetail.Properties.ShowHeader = false;
            this.lkTypeDetail.Size = new System.Drawing.Size(125, 20);
            this.lkTypeDetail.TabIndex = 4;
            this.lkTypeDetail.Visible = false;
            // 
            // lkType
            // 
            this.lkType.Location = new System.Drawing.Point(52, 33);
            this.lkType.Name = "lkType";
            this.lkType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.lkType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkType.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lkType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Name1", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name2")});
            this.lkType.Properties.DropDownRows = 10;
            this.lkType.Properties.NullText = "";
            this.lkType.Properties.PopupSizeable = false;
            this.lkType.Properties.ShowFooter = false;
            this.lkType.Properties.ShowHeader = false;
            this.lkType.Size = new System.Drawing.Size(163, 20);
            this.lkType.TabIndex = 3;
            this.lkType.EditValueChanged += new System.EventHandler(this.lkType_EditValueChanged);
            // 
            // lkRange
            // 
            this.lkRange.Location = new System.Drawing.Point(52, 8);
            this.lkRange.Name = "lkRange";
            this.lkRange.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkRange.Properties.Appearance.Options.UseFont = true;
            this.lkRange.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkRange.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lkRange.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Name1", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name2")});
            this.lkRange.Properties.NullText = "";
            this.lkRange.Properties.ShowHeader = false;
            this.lkRange.Size = new System.Drawing.Size(85, 20);
            this.lkRange.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Type:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Range:";
            // 
            // btnClosed
            // 
            this.btnClosed.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnClosed.Appearance.Options.UseBackColor = true;
            this.btnClosed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClosed.BackgroundImage")));
            this.btnClosed.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClosed.ImageOptions.Image")));
            this.btnClosed.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClosed.Location = new System.Drawing.Point(3, 3);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(80, 23);
            this.btnClosed.TabIndex = 1;
            this.btnClosed.ToolTip = "Close";
            this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
            this.btnClosed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClosed_MouseDown);
            this.btnClosed.MouseLeave += new System.EventHandler(this.btnClosed_MouseLeave);
            // 
            // btnHelp
            // 
            this.btnHelp.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnHelp.Appearance.Options.UseBackColor = true;
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.ImageOptions.Image")));
            this.btnHelp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnHelp.Location = new System.Drawing.Point(4, 5);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(27, 17);
            this.btnHelp.TabIndex = 10;
            this.btnHelp.ToolTip = "Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseLeave += new System.EventHandler(this.btnHelp_MouseLeave);
            this.btnHelp.MouseHover += new System.EventHandler(this.btnHelp_MouseHover);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.Appearance.Options.UseBackColor = true;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.ImageOptions.Image")));
            this.btnMinimize.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnMinimize.Location = new System.Drawing.Point(31, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 17);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.ToolTip = "Minimize";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            this.btnMinimize.MouseHover += new System.EventHandler(this.btnMinimize_MouseHover);
            // 
            // lstImgbtnClose
            // 
            this.lstImgbtnClose.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgbtnClose.ImageStream")));
            this.lstImgbtnClose.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgbtnClose.Images.SetKeyName(0, "Close.jpg");
            this.lstImgbtnClose.Images.SetKeyName(1, "Close2.jpg");
            // 
            // lstImgMaximize
            // 
            this.lstImgMaximize.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgMaximize.ImageStream")));
            this.lstImgMaximize.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgMaximize.Images.SetKeyName(0, "Maximize.jpg");
            this.lstImgMaximize.Images.SetKeyName(1, "Maximize2.jpg");
            this.lstImgMaximize.Images.SetKeyName(2, "RestoreDown1.jpg");
            this.lstImgMaximize.Images.SetKeyName(3, "RestoreDown2.jpg");
            // 
            // pnTop
            // 
            this.pnTop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnTop.Controls.Add(this.pnRight);
            this.pnTop.Controls.Add(this.picTopCenter);
            this.pnTop.Controls.Add(this.pnTopLeft);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(719, 33);
            this.pnTop.TabIndex = 7;
            // 
            // pnRight
            // 
            this.pnRight.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnRight.ContentImage = ((System.Drawing.Image)(resources.GetObject("pnRight.ContentImage")));
            this.pnRight.ContentImageAlignment = System.Drawing.ContentAlignment.TopRight;
            this.pnRight.Controls.Add(this.btnHelp);
            this.pnRight.Controls.Add(this.btnMaximize);
            this.pnRight.Controls.Add(this.btnMinimize);
            this.pnRight.Controls.Add(this.btnClose);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(588, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(131, 33);
            this.pnRight.TabIndex = 9;
            this.pnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnRight_MouseDown);
            this.pnRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnRight_MouseMove);
            this.pnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnRight_MouseUp);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnMaximize.Appearance.Options.UseBackColor = true;
            this.btnMaximize.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.ImageOptions.Image")));
            this.btnMaximize.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnMaximize.Location = new System.Drawing.Point(58, 5);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(25, 17);
            this.btnMaximize.TabIndex = 13;
            this.btnMaximize.ToolTip = "Maximize";
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            this.btnMaximize.MouseLeave += new System.EventHandler(this.btnMaximize_MouseLeave);
            this.btnMaximize.MouseHover += new System.EventHandler(this.btnMaximize_MouseHover);
            // 
            // picTopCenter
            // 
            this.picTopCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTopCenter.Image = ((System.Drawing.Image)(resources.GetObject("picTopCenter.Image")));
            this.picTopCenter.Location = new System.Drawing.Point(152, 0);
            this.picTopCenter.Name = "picTopCenter";
            this.picTopCenter.Size = new System.Drawing.Size(567, 33);
            this.picTopCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTopCenter.TabIndex = 9;
            this.picTopCenter.TabStop = false;
            this.picTopCenter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picTopCenter_MouseDown);
            this.picTopCenter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picTopCenter_MouseMove);
            this.picTopCenter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picTopCenter_MouseUp);
            // 
            // pnTopLeft
            // 
            this.pnTopLeft.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnTopLeft.ContentImage = ((System.Drawing.Image)(resources.GetObject("pnTopLeft.ContentImage")));
            this.pnTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnTopLeft.Location = new System.Drawing.Point(0, 0);
            this.pnTopLeft.Name = "pnTopLeft";
            this.pnTopLeft.Size = new System.Drawing.Size(152, 33);
            this.pnTopLeft.TabIndex = 8;
            this.pnTopLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTopLeft_MouseDown);
            this.pnTopLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTopLeft_MouseMove);
            this.pnTopLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnTopLeft_MouseUp);
            // 
            // lstImgTopLeft
            // 
            this.lstImgTopLeft.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgTopLeft.ImageStream")));
            this.lstImgTopLeft.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgTopLeft.Images.SetKeyName(0, "TopLeft1.jpg");
            this.lstImgTopLeft.Images.SetKeyName(1, "TopLeft2.jpg");
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 419);
            this.panel5.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(716, 33);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3, 419);
            this.panel6.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(3, 449);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(713, 3);
            this.panel7.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.Controls.Add(this.lkTypeDetail);
            this.panel8.Controls.Add(this.lkRange);
            this.panel8.Controls.Add(this.lkType);
            this.panel8.Controls.Add(this.labelControl1);
            this.panel8.Controls.Add(this.labelControl2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(3, 33);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(713, 65);
            this.panel8.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 30);
            this.panel1.TabIndex = 13;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.Controls.Add(this.btnClosed);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(618, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(95, 30);
            this.panel9.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 298);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(711, 21);
            this.panel3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "(log data only kept for 15 days)";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(6, 3);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(88, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Maintenance";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.MouseLeave += new System.EventHandler(this.linkLabel1_MouseLeave);
            this.linkLabel1.MouseHover += new System.EventHandler(this.linkLabel1_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pnMid2);
            this.panel2.Controls.Add(this.pnMid1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 321);
            this.panel2.TabIndex = 14;
            // 
            // pnMid2
            // 
            this.pnMid2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMid2.BackgroundImage")));
            this.pnMid2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnMid2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMid2.Location = new System.Drawing.Point(0, 136);
            this.pnMid2.Name = "pnMid2";
            this.pnMid2.Size = new System.Drawing.Size(711, 126);
            this.pnMid2.TabIndex = 12;
            // 
            // pnMid1
            // 
            this.pnMid1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMid1.BackgroundImage")));
            this.pnMid1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMid1.Location = new System.Drawing.Point(0, 0);
            this.pnMid1.Name = "pnMid1";
            this.pnMid1.Size = new System.Drawing.Size(711, 136);
            this.pnMid1.TabIndex = 11;
            // 
            // frmLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 452);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnTop);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmLogs.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logs - Security Agent";
            this.Load += new System.EventHandler(this.frmLogs_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogs_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLogs_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmLogs_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.lkTypeDetail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkRange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnTop)).EndInit();
            this.pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnRight)).EndInit();
            this.pnRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTopCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnTopLeft)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.ImageList lstImgClose;
        private System.Windows.Forms.ImageList lstImgMinimize;
        private System.Windows.Forms.ImageList lstImgHelp;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lkRange;
        private DevExpress.XtraEditors.LookUpEdit lkType;
        private System.Windows.Forms.ImageList lstImgbtnClose;
        private DevExpress.XtraEditors.SimpleButton btnClosed;
        private DevExpress.XtraEditors.LookUpEdit lkTypeDetail;
        private System.Windows.Forms.ImageList lstImgMaximize;
        private DevExpress.XtraEditors.SimpleButton btnHelp;
        private DevExpress.XtraEditors.SimpleButton btnMinimize;
        private DevExpress.XtraEditors.PanelControl pnTop;
        private System.Windows.Forms.ImageList lstImgTopLeft;
        private DevExpress.XtraEditors.PanelControl pnRight;
        private DevExpress.XtraEditors.SimpleButton btnMaximize;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnMid2;
        private System.Windows.Forms.Panel pnMid1;
        private DevExpress.XtraEditors.PanelControl pnTopLeft;
        private System.Windows.Forms.PictureBox picTopCenter;
    }
}