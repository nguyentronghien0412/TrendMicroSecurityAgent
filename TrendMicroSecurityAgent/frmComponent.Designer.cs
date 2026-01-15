
namespace TrendMicroSecurityAgent
{
    partial class frmComponent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComponent));
            this.btnHelp = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.lstImgHelp = new System.Windows.Forms.ImageList(this.components);
            this.lstImgbtnClose = new System.Windows.Forms.ImageList(this.components);
            this.lstImgClose = new System.Windows.Forms.ImageList(this.components);
            this.btnClosed = new DevExpress.XtraEditors.SimpleButton();
            this.gcData = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colComponent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastedUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnHelp.Appearance.Options.UseBackColor = true;
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.ImageOptions.Image")));
            this.btnHelp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnHelp.Location = new System.Drawing.Point(405, 3);
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
            this.btnClose.Location = new System.Drawing.Point(431, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 17);
            this.btnClose.TabIndex = 13;
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
            // lstImgbtnClose
            // 
            this.lstImgbtnClose.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgbtnClose.ImageStream")));
            this.lstImgbtnClose.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgbtnClose.Images.SetKeyName(0, "Close.jpg");
            this.lstImgbtnClose.Images.SetKeyName(1, "Close2.jpg");
            // 
            // lstImgClose
            // 
            this.lstImgClose.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImgClose.ImageStream")));
            this.lstImgClose.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImgClose.Images.SetKeyName(0, "Close.jpg");
            this.lstImgClose.Images.SetKeyName(1, "Close2.jpg");
            // 
            // btnClosed
            // 
            this.btnClosed.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnClosed.Appearance.Options.UseBackColor = true;
            this.btnClosed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClosed.BackgroundImage")));
            this.btnClosed.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClosed.ImageOptions.Image")));
            this.btnClosed.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClosed.Location = new System.Drawing.Point(388, 465);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(80, 23);
            this.btnClosed.TabIndex = 15;
            this.btnClosed.ToolTip = "Close";
            this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
            this.btnClosed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClosed_MouseDown);
            this.btnClosed.MouseLeave += new System.EventHandler(this.btnClosed_MouseLeave);
            // 
            // gcData
            // 
            this.gcData.Location = new System.Drawing.Point(46, 379);
            this.gcData.MainView = this.gridView1;
            this.gcData.Name = "gcData";
            this.gcData.Size = new System.Drawing.Size(79, 57);
            this.gcData.TabIndex = 16;
            this.gcData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcData.Visible = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colComponent,
            this.colVersion,
            this.colLastedUpdate});
            this.gridView1.GridControl = this.gcData;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // colComponent
            // 
            this.colComponent.Caption = "gridColumn1";
            this.colComponent.FieldName = "Component";
            this.colComponent.Name = "colComponent";
            this.colComponent.Visible = true;
            this.colComponent.VisibleIndex = 0;
            this.colComponent.Width = 173;
            // 
            // colVersion
            // 
            this.colVersion.Caption = "gridColumn2";
            this.colVersion.FieldName = "Version";
            this.colVersion.Name = "colVersion";
            this.colVersion.Visible = true;
            this.colVersion.VisibleIndex = 1;
            this.colVersion.Width = 103;
            // 
            // colLastedUpdate
            // 
            this.colLastedUpdate.Caption = "gridColumn3";
            this.colLastedUpdate.FieldName = "LastedUpdate";
            this.colLastedUpdate.Name = "colLastedUpdate";
            this.colLastedUpdate.Visible = true;
            this.colLastedUpdate.VisibleIndex = 2;
            this.colLastedUpdate.Width = 172;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.panel1);
            this.xtraScrollableControl1.Location = new System.Drawing.Point(16, 158);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(447, 211);
            this.xtraScrollableControl1.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 247);
            this.panel1.TabIndex = 0;
            // 
            // frmComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(480, 500);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Controls.Add(this.gcData);
            this.Controls.Add(this.btnClosed);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClose);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmComponent.IconOptions.Image")));
            this.Name = "frmComponent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Component Versions - Security Agent";
            this.Load += new System.EventHandler(this.frmComponent_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmComponent_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmComponent_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmComponent_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.gcData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHelp;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.ImageList lstImgHelp;
        private System.Windows.Forms.ImageList lstImgbtnClose;
        private System.Windows.Forms.ImageList lstImgClose;
        private DevExpress.XtraEditors.SimpleButton btnClosed;
        private DevExpress.XtraGrid.GridControl gcData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colComponent;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colLastedUpdate;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private System.Windows.Forms.Panel panel1;
    }
}