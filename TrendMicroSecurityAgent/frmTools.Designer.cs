
namespace TrendMicroSecurityAgent
{
    partial class frmTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTools));
            this.btnHelp = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnClosed = new DevExpress.XtraEditors.SimpleButton();
            this.lstImgbtnClose = new System.Windows.Forms.ImageList(this.components);
            this.lstImgHelp = new System.Windows.Forms.ImageList(this.components);
            this.lstImgClose = new System.Windows.Forms.ImageList(this.components);
            this.lbDetails = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            this.btnHelp.TabIndex = 12;
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
            this.btnClose.TabIndex = 11;
            this.btnClose.ToolTip = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // btnClosed
            // 
            this.btnClosed.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnClosed.Appearance.Options.UseBackColor = true;
            this.btnClosed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClosed.BackgroundImage")));
            this.btnClosed.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClosed.ImageOptions.Image")));
            this.btnClosed.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClosed.Location = new System.Drawing.Point(385, 418);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(80, 23);
            this.btnClosed.TabIndex = 13;
            this.btnClosed.ToolTip = "Close";
            this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
            this.btnClosed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClosed_MouseDown);
            this.btnClosed.MouseLeave += new System.EventHandler(this.btnClosed_MouseLeave);
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
            // lbDetails
            // 
            this.lbDetails.AutoSize = true;
            this.lbDetails.BackColor = System.Drawing.Color.Transparent;
            this.lbDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDetails.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetails.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbDetails.Location = new System.Drawing.Point(2, 3);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Size = new System.Drawing.Size(39, 13);
            this.lbDetails.TabIndex = 14;
            this.lbDetails.Text = "Details";
            this.lbDetails.Click += new System.EventHandler(this.lbDetails_Click);
            this.lbDetails.MouseLeave += new System.EventHandler(this.lbDetails_MouseLeave);
            this.lbDetails.MouseHover += new System.EventHandler(this.lbDetails_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.lbDetails);
            this.panel1.Location = new System.Drawing.Point(89, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 22);
            this.panel1.TabIndex = 15;
            // 
            // frmTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClosed);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClose);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmTools.IconOptions.Image")));
            this.Name = "frmTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tools - Security Agent";
            this.Load += new System.EventHandler(this.frmTools_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmTools_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmTools_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmTools_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHelp;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnClosed;
        private System.Windows.Forms.ImageList lstImgbtnClose;
        private System.Windows.Forms.ImageList lstImgHelp;
        private System.Windows.Forms.ImageList lstImgClose;
        private System.Windows.Forms.Label lbDetails;
        private System.Windows.Forms.Panel panel1;
    }
}