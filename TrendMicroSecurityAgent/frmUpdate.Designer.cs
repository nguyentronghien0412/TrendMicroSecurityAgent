
namespace TrendMicroSecurityAgent
{
    partial class frmUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdate));
            this.btnHelp = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lstImgbtnClose = new System.Windows.Forms.ImageList(this.components);
            this.lstImgHelp = new System.Windows.Forms.ImageList(this.components);
            this.lstImgClose = new System.Windows.Forms.ImageList(this.components);
            this.pn1 = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.pn2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnClosed = new DevExpress.XtraEditors.SimpleButton();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.pn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnHelp.Appearance.Options.UseBackColor = true;
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.ImageOptions.Image")));
            this.btnHelp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnHelp.Location = new System.Drawing.Point(261, 2);
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
            this.btnClose.Location = new System.Drawing.Point(287, 2);
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
            // lstImgClose
            // 
            this.lstImgClose.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgClose.ImageStream")));
            this.lstImgClose.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgClose.Images.SetKeyName(0, "Close.jpg");
            this.lstImgClose.Images.SetKeyName(1, "Close2.jpg");
            // 
            // pn1
            // 
            this.pn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn1.BackgroundImage")));
            this.pn1.Controls.Add(this.lbTime);
            this.pn1.Location = new System.Drawing.Point(5, 32);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(325, 121);
            this.pn1.TabIndex = 15;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(93, 62);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(51, 13);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "00:00:00";
            // 
            // pn2
            // 
            this.pn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn2.BackgroundImage")));
            this.pn2.Location = new System.Drawing.Point(12, 159);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(93, 40);
            this.pn2.TabIndex = 16;
            this.pn2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnClosed
            // 
            this.btnClosed.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnClosed.Appearance.Options.UseBackColor = true;
            this.btnClosed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClosed.BackgroundImage")));
            this.btnClosed.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClosed.ImageOptions.Image")));
            this.btnClosed.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClosed.Location = new System.Drawing.Point(241, 269);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(78, 21);
            this.btnClosed.TabIndex = 17;
            this.btnClosed.ToolTip = "Close";
            this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
            this.btnClosed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClosed_MouseDown);
            this.btnClosed.MouseLeave += new System.EventHandler(this.btnClosed_MouseLeave);
            // 
            // btnStop
            // 
            this.btnStop.AllowFocus = false;
            this.btnStop.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnStop.Appearance.Options.UseBackColor = true;
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.ImageOptions.Image")));
            this.btnStop.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnStop.Location = new System.Drawing.Point(241, 269);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(78, 21);
            this.btnStop.TabIndex = 18;
            this.btnStop.ToolTip = "Stop";
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(335, 300);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnClosed);
            this.Controls.Add(this.pn2);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClose);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmUpdate.IconOptions.Image")));
            this.Name = "frmUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update - Security Agent";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmUpdate_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmUpdate_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmUpdate_MouseUp);
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHelp;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.ImageList lstImgbtnClose;
        private System.Windows.Forms.ImageList lstImgHelp;
        private System.Windows.Forms.ImageList lstImgClose;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer2;
        private DevExpress.XtraEditors.SimpleButton btnClosed;
        private DevExpress.XtraEditors.SimpleButton btnStop;
    }
}