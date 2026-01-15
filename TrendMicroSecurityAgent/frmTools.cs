using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrendMicroSecurityAgent
{
    public partial class frmTools : DevExpress.XtraEditors.XtraForm
    {
        int xBegin, yBegin;
        bool mouseDown = false;

        private void frmTools_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Y > 34)
                return;

            mouseDown = true;
            xBegin = e.X;
            yBegin = e.Y;
        }

        private void frmTools_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown && e.Y <= 34)
            {
                int xMove = e.X - xBegin;
                int yMove = e.Y - yBegin;
                this.Location = new Point(this.Location.X + xMove, this.Location.Y + yMove);
            }
        }

        private void frmTools_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClosed_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstImgbtnClose.Images.Count == 0)
                return;

            btnClosed.ImageOptions.Image = lstImgbtnClose.Images[1];
            btnClosed.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnClosed_MouseLeave(object sender, EventArgs e)
        {
            if (lstImgbtnClose.Images.Count == 0)
                return;

            btnClosed.ImageOptions.Image = lstImgbtnClose.Images[0];
            btnClosed.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://helpcenter.trendmicro.com/en-us/");
        }

        private void btnHelp_MouseHover(object sender, EventArgs e)
        {
            btnHelp.ImageOptions.Image = lstImgHelp.Images[1];
            btnHelp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnHelp_MouseLeave(object sender, EventArgs e)
        {
            btnHelp.ImageOptions.Image = lstImgHelp.Images[0];
            btnHelp.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.ImageOptions.Image = lstImgClose.Images[1];
            btnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            if (lstImgClose.Images.Count == 0)
                return;

            btnClose.ImageOptions.Image = lstImgClose.Images[0];
            btnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbDetails_MouseHover(object sender, EventArgs e)
        {
            lbDetails.Font = new Font(lbDetails.Font.Name, lbDetails.Font.SizeInPoints, FontStyle.Underline);
        }

        private void lbDetails_MouseLeave(object sender, EventArgs e)
        {
            lbDetails.Font = new Font(lbDetails.Font.Name, lbDetails.Font.SizeInPoints, FontStyle.Regular);
        }

        private void lbDetails_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://success.trendmicro.com/dcx/s/solution/1112119-using-the-case-diagnostic-tool-cdt-in-worry-free-business-security-wfbs?language=en_US");
        }

        private void frmTools_Load(object sender, EventArgs e)
        {
            btnClose.ImageOptions.Image = lstImgClose.Images[0];
            btnHelp.ImageOptions.Image = lstImgHelp.Images[0];
        }

        public frmTools()
        {
            InitializeComponent();
        }
    }
}