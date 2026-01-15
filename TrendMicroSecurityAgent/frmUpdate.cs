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
    public partial class frmUpdate : DevExpress.XtraEditors.XtraForm
    {
        int xBegin, yBegin;
        bool mouseDown = false;

        DateTime dateRun = new DateTime(2022, 07, 07, 0, 0, 0);
        public frmUpdate()
        {
            InitializeComponent();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            btnClose.ImageOptions.Image = lstImgClose.Images[0];
            btnHelp.ImageOptions.Image = lstImgHelp.Images[0];

            btnStop.Visible = true;
            btnClosed.Visible = false;

            int value = DateTime.Now.Second;
            if (value < 10)
                value = 10;

            timer1.Interval = 1000 * value;
            timer1.Enabled = true;
            timer1.Start();

            dateRun = new DateTime(2022, 07, 07, 0, 0, 1);
            timer2.Interval = 1000;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            timer1.Dispose();

            timer2.Stop();
            timer2.Enabled = false;
            timer2.Dispose();

            pn1.BackgroundImage = pn2.BackgroundImage;
            btnStop.Visible = false;
            btnClosed.Visible = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            dateRun = dateRun.AddSeconds(1);
            lbTime.Text = dateRun.ToString("HH:mm:ss");
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

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Y > 34)
                return;

            mouseDown = true;
            xBegin = e.X;
            yBegin = e.Y;
        }

        private void frmUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown && e.Y <= 34)
            {
                int xMove = e.X - xBegin;
                int yMove = e.Y - yBegin;
                this.Location = new Point(this.Location.X + xMove, this.Location.Y + yMove);
            }
        }

        private void frmUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}