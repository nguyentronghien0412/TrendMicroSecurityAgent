
namespace TrendMicroSecurityAgent
{
    partial class frmScan_InProgess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScan_InProgess));
            this.btnHelp = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lstImgHelp = new System.Windows.Forms.ImageList(this.components);
            this.lstImgClose = new System.Windows.Forms.ImageList(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lbPercent = new DevExpress.XtraEditors.LabelControl();
            this.lbTime = new DevExpress.XtraEditors.LabelControl();
            this.lbPath = new DevExpress.XtraEditors.LabelControl();
            this.lbTotalFile = new DevExpress.XtraEditors.LabelControl();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnComplete = new DevExpress.XtraEditors.PanelControl();
            this.lkType = new DevExpress.XtraEditors.LookUpEdit();
            this.chkShutdown = new DevExpress.XtraEditors.CheckEdit();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.btnClosed = new DevExpress.XtraEditors.SimpleButton();
            this.btnPause = new DevExpress.XtraEditors.SimpleButton();
            this.lstImgStop = new System.Windows.Forms.ImageList(this.components);
            this.lstImgPause = new System.Windows.Forms.ImageList(this.components);
            this.lstImgClosed = new System.Windows.Forms.ImageList(this.components);
            this.lstImgResume = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnComplete)).BeginInit();
            this.pnComplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShutdown.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnHelp.Appearance.Options.UseBackColor = true;
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.ImageOptions.Image")));
            this.btnHelp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnHelp.Location = new System.Drawing.Point(406, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(27, 17);
            this.btnHelp.TabIndex = 16;
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
            this.btnClose.Location = new System.Drawing.Point(432, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 17);
            this.btnClose.TabIndex = 15;
            this.btnClose.ToolTip = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // lstImgHelp
            // 
            this.lstImgHelp.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgHelp.ImageStream")));
            this.lstImgHelp.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgHelp.Images.SetKeyName(0, "help.jpg");
            this.lstImgHelp.Images.SetKeyName(1, "help2.jpg");
            // 
            // lstImgClose
            // 
            this.lstImgClose.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgClose.ImageStream")));
            this.lstImgClose.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgClose.Images.SetKeyName(0, "Close.jpg");
            this.lstImgClose.Images.SetKeyName(1, "Close2.jpg");
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl1.ContentImage")));
            this.panelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Location = new System.Drawing.Point(5, 32);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(470, 32);
            this.panelControl1.TabIndex = 17;
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.ContentImage = ((System.Drawing.Image)(resources.GetObject("panelControl2.ContentImage")));
            this.panelControl2.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelControl2.Controls.Add(this.lbPercent);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(107, 32);
            this.panelControl2.TabIndex = 18;
            // 
            // lbPercent
            // 
            this.lbPercent.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbPercent.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbPercent.Appearance.Options.UseFont = true;
            this.lbPercent.Appearance.Options.UseForeColor = true;
            this.lbPercent.Location = new System.Drawing.Point(8, 8);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(94, 16);
            this.lbPercent.TabIndex = 18;
            this.lbPercent.Text = "Scanning... 20%";
            // 
            // lbTime
            // 
            this.lbTime.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Appearance.Options.UseFont = true;
            this.lbTime.Location = new System.Drawing.Point(99, 108);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(36, 14);
            this.lbTime.TabIndex = 18;
            this.lbTime.Text = "0:00:00";
            // 
            // lbPath
            // 
            this.lbPath.Location = new System.Drawing.Point(15, 67);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(9, 13);
            this.lbPath.TabIndex = 19;
            this.lbPath.Text = "   ";
            // 
            // lbTotalFile
            // 
            this.lbTotalFile.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalFile.Appearance.Options.UseFont = true;
            this.lbTotalFile.Location = new System.Drawing.Point(99, 94);
            this.lbTotalFile.Name = "lbTotalFile";
            this.lbTotalFile.Size = new System.Drawing.Size(6, 14);
            this.lbTotalFile.TabIndex = 20;
            this.lbTotalFile.Text = "0";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pnComplete
            // 
            this.pnComplete.ContentImage = ((System.Drawing.Image)(resources.GetObject("pnComplete.ContentImage")));
            this.pnComplete.Controls.Add(this.lkType);
            this.pnComplete.Location = new System.Drawing.Point(15, 128);
            this.pnComplete.Name = "pnComplete";
            this.pnComplete.Size = new System.Drawing.Size(450, 250);
            this.pnComplete.TabIndex = 21;
            // 
            // lkType
            // 
            this.lkType.Location = new System.Drawing.Point(5, 26);
            this.lkType.Name = "lkType";
            this.lkType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkType.Properties.Appearance.Options.UseFont = true;
            this.lkType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkType.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.lkType.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "Name1", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name2")});
            this.lkType.Properties.NullText = "";
            this.lkType.Properties.ShowHeader = false;
            this.lkType.Size = new System.Drawing.Size(132, 20);
            this.lkType.TabIndex = 3;
            // 
            // chkShutdown
            // 
            this.chkShutdown.Location = new System.Drawing.Point(15, 391);
            this.chkShutdown.Name = "chkShutdown";
            this.chkShutdown.Properties.Caption = "Shut down computer after completing scan";
            this.chkShutdown.Size = new System.Drawing.Size(275, 20);
            this.chkShutdown.TabIndex = 22;
            // 
            // btnStop
            // 
            this.btnStop.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnStop.Appearance.Options.UseBackColor = true;
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.ImageOptions.Image")));
            this.btnStop.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnStop.Location = new System.Drawing.Point(304, 419);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 23);
            this.btnStop.TabIndex = 24;
            this.btnStop.ToolTip = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnStop_MouseDown);
            this.btnStop.MouseLeave += new System.EventHandler(this.btnStop_MouseLeave);
            this.btnStop.MouseHover += new System.EventHandler(this.btnStop_MouseHover);
            // 
            // btnClosed
            // 
            this.btnClosed.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnClosed.Appearance.Options.UseBackColor = true;
            this.btnClosed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClosed.BackgroundImage")));
            this.btnClosed.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClosed.ImageOptions.Image")));
            this.btnClosed.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClosed.Location = new System.Drawing.Point(387, 419);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(80, 23);
            this.btnClosed.TabIndex = 23;
            this.btnClosed.ToolTip = "Close";
            this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
            this.btnClosed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClosed_MouseDown);
            this.btnClosed.MouseLeave += new System.EventHandler(this.btnClosed_MouseLeave);
            this.btnClosed.MouseHover += new System.EventHandler(this.btnClosed_MouseHover);
            // 
            // btnPause
            // 
            this.btnPause.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnPause.Appearance.Options.UseBackColor = true;
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.ImageOptions.Image")));
            this.btnPause.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPause.Location = new System.Drawing.Point(221, 419);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(80, 23);
            this.btnPause.TabIndex = 25;
            this.btnPause.ToolTip = "Pause";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            this.btnPause.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPause_MouseDown);
            this.btnPause.MouseLeave += new System.EventHandler(this.btnPause_MouseLeave);
            this.btnPause.MouseHover += new System.EventHandler(this.btnPause_MouseHover);
            // 
            // lstImgStop
            // 
            this.lstImgStop.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgStop.ImageStream")));
            this.lstImgStop.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgStop.Images.SetKeyName(0, "Stop1.jpg");
            this.lstImgStop.Images.SetKeyName(1, "Stop2.jpg");
            this.lstImgStop.Images.SetKeyName(2, "Stop3.jpg");
            // 
            // lstImgPause
            // 
            this.lstImgPause.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgPause.ImageStream")));
            this.lstImgPause.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgPause.Images.SetKeyName(0, "Pause1.jpg");
            this.lstImgPause.Images.SetKeyName(1, "Pause2.jpg");
            this.lstImgPause.Images.SetKeyName(2, "Pause3.jpg");
            // 
            // lstImgClosed
            // 
            this.lstImgClosed.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgClosed.ImageStream")));
            this.lstImgClosed.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgClosed.Images.SetKeyName(0, "Close1.jpg");
            this.lstImgClosed.Images.SetKeyName(1, "Close2.jpg");
            this.lstImgClosed.Images.SetKeyName(2, "Close3.jpg");
            // 
            // lstImgResume
            // 
            this.lstImgResume.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgResume.ImageStream")));
            this.lstImgResume.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgResume.Images.SetKeyName(0, "Resume1.jpg");
            this.lstImgResume.Images.SetKeyName(1, "Resume2.jpg");
            this.lstImgResume.Images.SetKeyName(2, "Resume3.jpg");
            // 
            // frmScan_InProgess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnClosed);
            this.Controls.Add(this.chkShutdown);
            this.Controls.Add(this.pnComplete);
            this.Controls.Add(this.lbTotalFile);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClose);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmScan_InProgess.IconOptions.Image")));
            this.Name = "frmScan_InProgess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual Scan - Security Agent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmScan_InProgess_FormClosed);
            this.Load += new System.EventHandler(this.frmScan_InProgess_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmScan_InProgess_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmScan_InProgess_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmScan_InProgess_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnComplete)).EndInit();
            this.pnComplete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lkType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShutdown.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHelp;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.ImageList lstImgHelp;
        private System.Windows.Forms.ImageList lstImgClose;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lbPercent;
        private DevExpress.XtraEditors.LabelControl lbTime;
        private DevExpress.XtraEditors.LabelControl lbPath;
        private DevExpress.XtraEditors.LabelControl lbTotalFile;
        private System.Windows.Forms.Timer timer2;
        private DevExpress.XtraEditors.PanelControl pnComplete;
        private DevExpress.XtraEditors.LookUpEdit lkType;
        private DevExpress.XtraEditors.CheckEdit chkShutdown;
        private DevExpress.XtraEditors.SimpleButton btnStop;
        private DevExpress.XtraEditors.SimpleButton btnClosed;
        private DevExpress.XtraEditors.SimpleButton btnPause;
        private System.Windows.Forms.ImageList lstImgStop;
        private System.Windows.Forms.ImageList lstImgPause;
        private System.Windows.Forms.ImageList lstImgClosed;
        private System.Windows.Forms.ImageList lstImgResume;
    }
}