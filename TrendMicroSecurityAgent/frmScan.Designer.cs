
namespace TrendMicroSecurityAgent
{
    partial class frmScan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScan));
            this.btnHelp = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lstImgbtnClose = new System.Windows.Forms.ImageList(this.components);
            this.lstImgHelp = new System.Windows.Forms.ImageList(this.components);
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lstImgCancel = new System.Windows.Forms.ImageList(this.components);
            this.lstImgClose = new System.Windows.Forms.ImageList(this.components);
            this.btnScan = new DevExpress.XtraEditors.SimpleButton();
            this.lstImgScan = new System.Windows.Forms.ImageList(this.components);
            this.xtraFolderBrowserDialog1 = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.xtraSaveFileDialog1 = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.tvCategories = new System.Windows.Forms.TreeView();
            this.lstImgIconFolder = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnHelp.Appearance.Options.UseBackColor = true;
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.ImageOptions.Image")));
            this.btnHelp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnHelp.Location = new System.Drawing.Point(407, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(27, 17);
            this.btnHelp.TabIndex = 14;
            this.btnHelp.ToolTip = "Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseLeave += new System.EventHandler(this.btnHelp_MouseLeave);
            this.btnHelp.MouseHover += new System.EventHandler(this.btnHelp_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClose.Location = new System.Drawing.Point(433, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 17);
            this.btnClose.TabIndex = 13;
            this.btnClose.ToolTip = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // lstImgbtnClose
            // 
            this.lstImgbtnClose.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgbtnClose.ImageStream")));
            this.lstImgbtnClose.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgbtnClose.Images.SetKeyName(0, "Close.jpg");
            this.lstImgbtnClose.Images.SetKeyName(1, "Close2.jpg");
            // 
            // lstImgHelp
            // 
            this.lstImgHelp.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgHelp.ImageStream")));
            this.lstImgHelp.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgHelp.Images.SetKeyName(0, "help.jpg");
            this.lstImgHelp.Images.SetKeyName(1, "help2.jpg");
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCancel.Location = new System.Drawing.Point(385, 418);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.ToolTip = "Close";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCancel_MouseDown);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // lstImgCancel
            // 
            this.lstImgCancel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgCancel.ImageStream")));
            this.lstImgCancel.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgCancel.Images.SetKeyName(0, "Cancel1.jpg");
            this.lstImgCancel.Images.SetKeyName(1, "Cancel2.jpg");
            // 
            // lstImgClose
            // 
            this.lstImgClose.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgClose.ImageStream")));
            this.lstImgClose.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgClose.Images.SetKeyName(0, "Close.jpg");
            this.lstImgClose.Images.SetKeyName(1, "Close2.jpg");
            // 
            // btnScan
            // 
            this.btnScan.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnScan.Appearance.Options.UseBackColor = true;
            this.btnScan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScan.BackgroundImage")));
            this.btnScan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnScan.ImageOptions.Image")));
            this.btnScan.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnScan.Location = new System.Drawing.Point(300, 418);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(80, 23);
            this.btnScan.TabIndex = 16;
            this.btnScan.ToolTip = "Close";
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            this.btnScan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnScan_MouseDown);
            this.btnScan.MouseLeave += new System.EventHandler(this.btnScan_MouseLeave);
            // 
            // lstImgScan
            // 
            this.lstImgScan.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgScan.ImageStream")));
            this.lstImgScan.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgScan.Images.SetKeyName(0, "2.jpg");
            this.lstImgScan.Images.SetKeyName(1, "3.jpg");
            // 
            // xtraFolderBrowserDialog1
            // 
            this.xtraFolderBrowserDialog1.SelectedPath = "xtraFolderBrowserDialog1";
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            this.xtraOpenFileDialog1.Multiselect = true;
            // 
            // xtraSaveFileDialog1
            // 
            this.xtraSaveFileDialog1.FileName = "xtraSaveFileDialog1";
            // 
            // tvCategories
            // 
            this.tvCategories.CheckBoxes = true;
            this.tvCategories.ImageIndex = 0;
            this.tvCategories.ImageList = this.lstImgIconFolder;
            this.tvCategories.Location = new System.Drawing.Point(12, 87);
            this.tvCategories.Name = "tvCategories";
            this.tvCategories.SelectedImageIndex = 0;
            this.tvCategories.Size = new System.Drawing.Size(453, 256);
            this.tvCategories.TabIndex = 18;
            this.tvCategories.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvCategories_AfterCheck);
            this.tvCategories.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvCategories_BeforeExpand);
            // 
            // lstImgIconFolder
            // 
            this.lstImgIconFolder.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgIconFolder.ImageStream")));
            this.lstImgIconFolder.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgIconFolder.Images.SetKeyName(0, "ThisPC.jpg");
            // 
            // frmScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.tvCategories);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClose);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmScan.IconOptions.Image")));
            this.Name = "frmScan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual Scan - Security Agent";
            this.Load += new System.EventHandler(this.frmScan_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmScan_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmScan_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmScan_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHelp;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.ImageList lstImgbtnClose;
        private System.Windows.Forms.ImageList lstImgHelp;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.ImageList lstImgCancel;
        private System.Windows.Forms.ImageList lstImgClose;
        private DevExpress.XtraEditors.SimpleButton btnScan;
        private System.Windows.Forms.ImageList lstImgScan;
        private DevExpress.XtraEditors.XtraFolderBrowserDialog xtraFolderBrowserDialog1;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog1;
        private System.Windows.Forms.TreeView tvCategories;
        private System.Windows.Forms.ImageList lstImgIconFolder;
    }
}