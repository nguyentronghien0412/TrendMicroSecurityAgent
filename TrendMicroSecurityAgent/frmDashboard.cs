using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrendMicroSecurityAgent
{
    public partial class frmDashboard : DevExpress.XtraEditors.XtraForm 
    {
        int xBegin, yBegin;
        bool mouseDown = false;
        string _MyApp = "TrendMicroSecurityAgent";

        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public frmDashboard()
        {
            InitializeComponent();
        }

        private string GetDayOfWeek(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Sunday:
                    return "Sun";
                case DayOfWeek.Monday:
                    return "Mon";
                case DayOfWeek.Tuesday:
                    return "Tue";
                case DayOfWeek.Wednesday:
                    return "Wed";
                case DayOfWeek.Thursday:
                    return "Thu";
                case DayOfWeek.Friday:
                    return "Fri";
                case DayOfWeek.Saturday:
                    return "Sat";
                default:
                    return "N/A";
            }
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            rkApp.SetValue(_MyApp, Application.ExecutablePath.ToString());

            btnClose.ImageOptions.Image = lstImgClose.Images[0];
            btnHide.ImageOptions.Image = lstImgHide.Images[0];
            btnHelp.ImageOptions.Image = lstImgHelp.Images[0];
            btnLogs.ImageOptions.Image = lstImgLogs.Images[0];
            btnSettings.ImageOptions.Image = lstImgSettings.Images[0];
            btnTools.ImageOptions.Image = lstImgTools.Images[0];

            lnkVirus.LinkColor = Color.Black;
            lnkVirus_Qty.LinkColor = Color.RoyalBlue;

            btnStatus.Visible = true;
            btnStatus2.Visible = false;


            labelControl2.Text = "Since " + DateTime.Now.AddDays(-2).ToString("dd/MM/yyyy") + " (" + GetDayOfWeek(DateTime.Now.AddDays(-2).DayOfWeek) + ") " + DateTime.Now.AddHours(-2).ToString("HH:mm");
            labelControl3.Text = "Since " + DateTime.Now.AddDays(-5).ToString("dd/MM/yyyy") + " (" + GetDayOfWeek(DateTime.Now.AddDays(-5).DayOfWeek) + ") " + DateTime.Now.AddHours(-1).AddMinutes(2).ToString("HH:mm");
            labelControl7.Text = "Last update " + DateTime.Now.AddDays(-3).ToString("dd/MM/yyyy") + " (" + GetDayOfWeek(DateTime.Now.AddDays(-3).DayOfWeek) + ") " + DateTime.Now.AddHours(-5).AddMinutes(7).ToString("HH:mm");

            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void frmDashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown && e.Y <= 34)
            {
                int xMove = e.X - xBegin;
                int yMove = e.Y - yBegin;
                this.Location = new Point(this.Location.X + xMove, this.Location.Y + yMove);
            }
        }

        private void frmDashboard_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.ImageOptions.Image = lstImgClose.Images[1];
            btnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ImageOptions.Image = lstImgClose.Images[0];
            btnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnHide_MouseHover(object sender, EventArgs e)
        {
            btnHide.ImageOptions.Image = lstImgHide.Images[1];
            btnHide.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnHide_MouseLeave(object sender, EventArgs e)
        {
            btnHide.ImageOptions.Image = lstImgHide.Images[0];
            btnHide.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
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

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
            this.BringToFront();
        }

        private void btnLogs_MouseHover(object sender, EventArgs e)
        {
            btnLogs.Location = new Point(12, 380);
            btnLogs.Size = new Size(46, 40);
            btnLogs.ImageOptions.Image = lstImgLogs.Images[1];
            btnLogs.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnLogs_MouseLeave(object sender, EventArgs e)
        {
            btnLogs.Location = new Point(12, 386);
            btnLogs.Size = new Size(46, 37);
            btnLogs.ImageOptions.Image = lstImgLogs.Images[0];
            btnLogs.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnSettings_MouseHover(object sender, EventArgs e)
        {
            btnSettings.Location = new Point(64, 380);
            btnSettings.Size = new Size(46, 40);
            btnSettings.ImageOptions.Image = lstImgSettings.Images[1];
            btnSettings.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.Location = new Point(64, 386);
            btnSettings.Size = new Size(46, 37);
            btnSettings.ImageOptions.Image = lstImgSettings.Images[0];
            btnSettings.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnTools_MouseHover(object sender, EventArgs e)
        {
            btnTools.Location = new Point(116, 380);
            btnTools.Size = new Size(46, 40);
            btnTools.ImageOptions.Image = lstImgTools.Images[1];
            btnTools.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnTools_MouseLeave(object sender, EventArgs e)
        {
            btnTools.Location = new Point(116, 386);
            btnTools.Size = new Size(46, 37);
            btnTools.ImageOptions.Image = lstImgTools.Images[0];
            btnTools.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void lnkVirus_MouseHover(object sender, EventArgs e)
        {
            lnkVirus.LinkColor = Color.DodgerBlue;
            lnkVirus_Qty.LinkColor = Color.DodgerBlue;
        }

        private void lnkVirus_MouseLeave(object sender, EventArgs e)
        {
            lnkVirus.LinkColor = Color.Black;
            lnkVirus_Qty.LinkColor = Color.RoyalBlue;
        }

        private void lnkVirus_Qty_MouseHover(object sender, EventArgs e)
        {
            lnkVirus.LinkColor = Color.DodgerBlue;
            lnkVirus_Qty.LinkColor = Color.DodgerBlue;
        }

        private void lnkVirus_Qty_MouseLeave(object sender, EventArgs e)
        {
            lnkVirus.LinkColor = Color.Black;
            lnkVirus_Qty.LinkColor = Color.RoyalBlue;
        }

        private void lnkSpyware_MouseHover(object sender, EventArgs e)
        {
            lnkSpyware.LinkColor = Color.DodgerBlue;
            lnkSpyware_Qty.LinkColor = Color.DodgerBlue;
        }

        private void lnkSpyware_MouseLeave(object sender, EventArgs e)
        {
            lnkSpyware.LinkColor = Color.Black;
            lnkSpyware_Qty.LinkColor = Color.RoyalBlue;
        }

        private void lnkSpyware_Qty_MouseHover(object sender, EventArgs e)
        {
            lnkSpyware.LinkColor = Color.DodgerBlue;
            lnkSpyware_Qty.LinkColor = Color.DodgerBlue;
        }

        private void lnkSpyware_Qty_MouseLeave(object sender, EventArgs e)
        {
            lnkSpyware.LinkColor = Color.Black;
            lnkSpyware_Qty.LinkColor = Color.RoyalBlue;
        }

        private void lnkScheduled_MouseHover(object sender, EventArgs e)
        {
            lnkScheduled_Status.LinkColor = Color.DodgerBlue;
        }

        private void lnkScheduled_MouseLeave(object sender, EventArgs e)
        {
            lnkScheduled_Status.LinkColor = Color.RoyalBlue;
        }

        private void lnkScheduled_Status_MouseHover(object sender, EventArgs e)
        {
            lnkScheduled_Status.LinkColor = Color.DodgerBlue;
        }

        private void lnkScheduled_Status_MouseLeave(object sender, EventArgs e)
        {
            lnkScheduled_Status.LinkColor = Color.RoyalBlue;
        }

        private void lnkPattern_MouseHover(object sender, EventArgs e)
        {
            lnkPattern.LinkColor = Color.DodgerBlue;
            lnkPattern_Qty.LinkColor = Color.DodgerBlue;
        }

        private void lnkPattern_MouseLeave(object sender, EventArgs e)
        {
            lnkPattern.LinkColor = Color.Black;
            lnkPattern_Qty.LinkColor = Color.RoyalBlue;
        }

        private void lnkPattern_Qty_MouseHover(object sender, EventArgs e)
        {
            lnkPattern.LinkColor = Color.DodgerBlue;
            lnkPattern_Qty.LinkColor = Color.DodgerBlue;
        }

        private void lnkPattern_Qty_MouseLeave(object sender, EventArgs e)
        {
            lnkPattern.LinkColor = Color.Black;
            lnkPattern_Qty.LinkColor = Color.RoyalBlue;
        }

        private void btnScan_MouseHover(object sender, EventArgs e)
        {
            btnScan.Image = lstImgScan.Images[1];
        }

        private void btnScan_MouseLeave(object sender, EventArgs e)
        {
            btnScan.Image = lstImgScan.Images[0];
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.Image = lstImgUpdate.Images[1];
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.Image = lstImgUpdate.Images[0];
        }

        private void btnStatus_MouseHover(object sender, EventArgs e)
        {
            btnStatus.Visible = false;
            btnStatus2.Visible = true;
        }

        private void btnStatus2_MouseLeave(object sender, EventArgs e)
        {
            btnStatus.Visible = true;
            btnStatus2.Visible = false;
        }

        private void btnLogs_MouseClick(object sender, MouseEventArgs e)
        {
            bool flagOpened = false;
            foreach (Form frm in Application.OpenForms)
                if (frm.Name == "frmLogs")
                {
                    frm.Focus();
                    flagOpened = true;
                    break;
                }

            if (!flagOpened)
            {
                frmLogs frmShow = new frmLogs();
                frmShow.Show();
            }
        }

        private void lnkVirus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool flagOpened = false;
            foreach (Form frm in Application.OpenForms)
                if (frm.Name == "frmLogs")
                {
                    frm.Focus();
                    flagOpened = true;
                    break;
                }
            
            if (!flagOpened)
            {
                frmLogs frmShow = new frmLogs();
                frmShow.Show();
            }
        }

        private void lnkSpyware_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool flagOpened = false;
            foreach (Form frm in Application.OpenForms)
                if (frm.Name == "frmLogs")
                {
                    frm.Focus();
                    flagOpened = true;
                    break;
                }

            if (!flagOpened)
            {
                frmLogs frmShow = new frmLogs();
                frmShow.Show();
            }
        }

        private void lnkVirus_Qty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool flagOpened = false;
            foreach (Form frm in Application.OpenForms)
                if (frm.Name == "frmLogs")
                {
                    frm.Focus();
                    flagOpened = true;
                    break;
                }

            if (!flagOpened)
            {
                frmLogs frmShow = new frmLogs();
                frmShow.Show();
            }
        }

        private void lnkSpyware_Qty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool flagOpened = false;
            foreach (Form frm in Application.OpenForms)
                if (frm.Name == "frmLogs")
                {
                    frm.Focus();
                    flagOpened = true;
                    break;
                }

            if (!flagOpened)
            {
                frmLogs frmShow = new frmLogs();
                frmShow.Show();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://helpcenter.trendmicro.com/en-us/");
        }

        private void btnSettings_MouseClick(object sender, MouseEventArgs e)
        {
            bool flagOpened = false;
            foreach (Form frm in Application.OpenForms)
                if (frm.Name == "frmSetting")
                {
                    frm.Focus();
                    flagOpened = true;
                    break;
                }

            if (!flagOpened)
            {
                frmSetting frmShow = new frmSetting();
                frmShow.Show();
            }
        }

        private void btnTools_MouseClick(object sender, MouseEventArgs e)
        {
            bool flagOpened = false;
            foreach (Form frm in Application.OpenForms)
                if (frm.Name == "frmTools")
                {
                    frm.Focus();
                    flagOpened = true;
                    break;
                }

            if (!flagOpened)
            {
                frmTools frmShow = new frmTools();
                frmShow.Show();
            }
        }

        private void lnkPattern_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool flagOpened = false;
            foreach (Form frm in Application.OpenForms)
                if (frm.Name == "frmComponent")
                {
                    frm.Focus();
                    flagOpened = true;
                    break;
                }

            if (!flagOpened)
            {
                frmComponent frmShow = new frmComponent();
                frmShow.Show();
            }
        }

        private void lnkPattern_Qty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool flagOpened = false;
            foreach (Form frm in Application.OpenForms)
                if (frm.Name == "frmComponent")
                {
                    frm.Focus();
                    flagOpened = true;
                    break;
                }

            if (!flagOpened)
            {
                frmComponent frmShow = new frmComponent();
                frmShow.Show();
            }
        }

        private void btnUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            bool flagOpened = false;
            foreach (Form frm in Application.OpenForms)
                if (frm.Name == "frmUpdate")
                {
                    frm.Focus();
                    flagOpened = true;
                    break;
                }

            if (!flagOpened)
            {
                frmUpdate frmShow = new frmUpdate();
                frmShow.Show();
            }
        }

        private void btnScan_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                //Thread.Sleep(2000);
                foreach (Form frm in Application.OpenForms)
                    if (frm.Name == "frmScan_InProgess")
                        return;

                bool flagOpened = false;
                foreach (Form frm in Application.OpenForms)
                    if (frm.Name == "frmScan")
                    {
                        frm.Focus();
                        flagOpened = true;
                        break;
                    }

                if (!flagOpened)
                {
                    frmScan frmShow = new frmScan();
                    frmShow.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void itemComponent_Click(object sender, EventArgs e)
        {
            lnkPattern_Qty_LinkClicked(null, null);
        }

        private void itemUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate_MouseClick(null, null);
        }

        private void itemScan_Click(object sender, EventArgs e)
        {
            btnScan_MouseClick(null, null);
        }

        private void itemOpen_Click(object sender, EventArgs e)
        {
            notifyIcon1_MouseDoubleClick(null, null);
        }

        private void itemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void frmDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Y > 34)
                return;

            mouseDown = true;
            xBegin = e.X;
            yBegin = e.Y;
        }
    }
}
