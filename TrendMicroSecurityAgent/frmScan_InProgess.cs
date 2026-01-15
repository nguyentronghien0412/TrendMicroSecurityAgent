using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrendMicroSecurityAgent
{
    public partial class frmScan_InProgess : DevExpress.XtraEditors.XtraForm
    {
        int xBegin, yBegin;
        bool mouseDown = false;

        DateTime dateRun = new DateTime(2022, 07, 07, 0, 0, 0);
        DateTime dateNow = DateTime.Now;

        public List<string> folderScan = new List<string>();
        decimal totalFile = 0;

        public frmScan_InProgess()
        {
            InitializeComponent();
        }

        private void frmScan_InProgess_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Y > 34)
                return;

            mouseDown = true;
            xBegin = e.X;
            yBegin = e.Y;
        }

        private void frmScan_InProgess_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown && e.Y <= 34)
            {
                int xMove = e.X - xBegin;
                int yMove = e.Y - yBegin;
                this.Location = new Point(this.Location.X + xMove, this.Location.Y + yMove);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://helpcenter.trendmicro.com/en-us/");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {          
            this.Close();
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

        private void frmScan_InProgess_Load(object sender, EventArgs e)
        {
            pnComplete.Visible = false;

            btnClose.ImageOptions.Image = lstImgClose.Images[0];
            btnHelp.ImageOptions.Image = lstImgHelp.Images[0];

            btnPause.Location = new Point(304, 419);
            btnStop.Location = new Point(387, 419);
            btnClosed.Visible = false;

            DataTable dtType = new DataTable();
            dtType.Columns.Add("ID", typeof(int));
            dtType.Columns.Add("Name");
            dtType.Rows.Add(1, "All Results (0)");
            dtType.Rows.Add(2, "Cleaned (0)");
            dtType.Rows.Add(3, "Delete (0)");
            dtType.Rows.Add(4, "Quarantined (0)");
            dtType.Rows.Add(5, "Renamed (0)");
            dtType.Rows.Add(6, "Passed (0)");
            dtType.Rows.Add(7, "Action required (0)");

            lkType.Properties.ValueMember = "ID";
            lkType.Properties.DisplayMember = "Name";
            lkType.Properties.DataSource = dtType;
            lkType.EditValue = 1;

            dateRun = new DateTime(2022, 07, 07, 0, 0, 0);
            dateNow = DateTime.Now;

            timer2.Interval = 2000;
            timer2.Enabled = true;
            timer2.Start();
        }

        private void countT()
        {
            TimeSpan ts = DateTime.Now - dateNow;
            AppendMessageTime(dateRun.AddSeconds(ts.TotalSeconds).ToString("HH:mm:ss"));
        }

        int percentTotal = 20;
        int percentC = 40;
        int percentScan = 40;

        int widthC = 0;
        int widthScan = 0;

        private void LoadFile()
        {
            countT();

            bool flag = false;
            string[] drives = Environment.GetLogicalDrives();
            foreach (string drive in drives)
            {
                countT();

                if (drive.ToUpper().Contains("C:"))
                {
                    flag = true;
                    break;
                }
            }

            int width = panelControl1.Width - panelControl2.Width;
            widthC = width / 2;
            widthScan = width / 2;

            if (flag)
            {
                countT();

                string[] files = Directory.GetFiles(@"C:\");
                foreach (string item in files)
                {
                    countT();
                    AppendMessagePath(item);
                }

                string[] dirs = Directory.GetDirectories(@"C:\");

                foreach (string dir in dirs)
                {
                    percentTotal = percentTotal + (percentC / dirs.Length);
                    AppendMessagePercent("Scanning... " + percentTotal + "%");
                    AppendPanel(widthC / dirs.Length, false);
                    LoadFile_Detail(dir);
                }
            }
            else
            {
                percentScan = percentScan + percentC;
                widthScan = widthScan + widthC;
            }

            foreach (string dir in folderScan)
            {
                percentTotal = percentTotal + (percentScan / folderScan.Count);
                AppendMessagePercent("Scanning... " + percentTotal + "%");
                AppendPanel(widthScan / folderScan.Count, false);
                LoadFile_Detail(dir);
            }

            AppendMessagePercent("Scan complete 100%");
            AppendPanel(470, true);
            AppendPanelVisible();
            AppendMessagePath("");
            AppendCheckbox();

            if (chkShutdown.Checked)
                Process.Start("shutdown", "/s /f /t 0");
        }

        private void LoadFile_Detail(string FolderName)
        {
            try
            {
                countT();

                if (HasWritePermission(FolderName))
                {
                    string[] files = Directory.GetFiles(FolderName);
                    foreach (string item in files)
                    {
                        totalFile = totalFile + 1;

                        countT();
                        AppendMessagePath(item);
                    }

                    string[] dirs = Directory.GetDirectories(FolderName);
                    countT();
                    foreach (string dir in dirs)
                        LoadFile_Detail(dir);
                }
            }
            catch (Exception ex)
            {
                return;
            }
           
        }

        private bool HasWritePermission(string tempfilepath)
        {
            try
            {
                System.IO.File.Create(tempfilepath + "\\temp.txt").Close();
                System.IO.File.Delete(tempfilepath + "\\temp.txt");
            }
            catch (System.UnauthorizedAccessException ex)
            {
                return false;
            }

            return true;
        }

        Thread t;

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            timer2.Dispose();
            timer2.Enabled = false;
            countT();

            totalFile = 0;
            t = new Thread(() => { LoadFile(); });
            t.Start();
        }

        public void AppendMessagePath(string Message)
        {
            if (lbPath.IsDisposed)
                return;

            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendMessagePath), new object[] { Message });
                return;
            }

            lbPath.Text = Message;
        }

        public void AppendMessageTime(string Message)
        {
            if (lbTime.IsDisposed)
                return;

            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendMessageTime), new object[] { Message });
                return;
            }

            lbTime.Text = Message;
            lbTotalFile.Text = totalFile.ToString();
        }

        public void AppendMessagePercent(string Message)
        {
            if (lbPercent.IsDisposed)
                return;

            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendMessagePercent), new object[] { Message });
                return;
            }

            lbPercent.Text = Message;
        }

        public void AppendPanel(int width, bool full)
        {
            if (panelControl2.IsDisposed)
                return;
            panelControl2.Invoke((MethodInvoker)delegate
            {
                if (full)
                    panelControl2.Width = width;
                else
                    panelControl2.Width = panelControl2.Width + width;
            });
        }

        public void AppendPanelVisible()
        {
            if (pnComplete.IsDisposed)
                return;

            pnComplete.Invoke((MethodInvoker)delegate
            {
                pnComplete.Visible = true;
            });
        }

        public void AppendCheckbox()
        {
            if (chkShutdown.IsDisposed)
                return;

            chkShutdown.Invoke((MethodInvoker)delegate
            {
                chkShutdown.ReadOnly = true;
                chkShutdown.Properties.AllowFocused = false;
            });
        }

        private void frmScan_InProgess_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (t != null && t.IsAlive && t.ThreadState != System.Threading.ThreadState.Suspended)
                t.Abort();
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClosed_MouseHover(object sender, EventArgs e)
        {
            btnClosed.ImageOptions.Image = lstImgClosed.Images[1];
            btnClosed.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnClosed_MouseLeave(object sender, EventArgs e)
        {
            if (lstImgClosed.Images.Count == 0)
                return;
            btnClosed.ImageOptions.Image = lstImgClosed.Images[0];
            btnClosed.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnClosed_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstImgClosed.Images.Count == 0)
                return;

            btnClosed.ImageOptions.Image = lstImgClosed.Images[2];
        }

        private void btnStop_MouseHover(object sender, EventArgs e)
        {
            btnStop.ImageOptions.Image = lstImgStop.Images[1];
            btnStop.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnStop_MouseLeave(object sender, EventArgs e)
        {
            if (lstImgStop.Images.Count == 0)
                return;
            btnStop.ImageOptions.Image = lstImgStop.Images[0];
            btnStop.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnStop_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstImgStop.Images.Count == 0)
                return;

            btnStop.ImageOptions.Image = lstImgStop.Images[2];
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The scan has not yet finished. Do you really want to stop now?", "Security Agent",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Thread.Sleep(2000);

                btnPause.Location = new Point(221, 419);
                btnPause.Enabled = false;

                btnStop.Location = new Point(304, 419);
                btnStop.Enabled = false;

                btnClosed.Location = new Point(387, 419);
                btnClosed.Enabled = true;
                btnClosed.Visible = true;

                if (t != null && t.IsAlive && t.ThreadState != System.Threading.ThreadState.Suspended)
                    t.Abort();

                AppendMessagePercent("Scan complete 100%");
                AppendPanel(470, true);
                AppendPanelVisible();
                AppendMessagePath("");
                AppendCheckbox();

                lbPath.Text = "";
                lbPath.Refresh();
            }
        }

        string typeButton = "PAUSE";

        [Obsolete]
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (typeButton == "PAUSE")
            {
                if (t != null && t.IsAlive)
                    t.Suspend();

                typeButton = "RESUME";
                btnPause.ImageOptions.Image = lstImgResume.Images[0];
                btnPause.ToolTip = "Resume";
            }
            else
            {
                if (t != null && t.IsAlive)
                    t.Resume();

                typeButton = "PAUSE";
                btnPause.ImageOptions.Image = lstImgPause.Images[0];
                btnPause.ToolTip = "Pause";
            }
        }

        private void btnPause_MouseHover(object sender, EventArgs e)
        {
            if (typeButton == "PAUSE")
            {
                btnPause.ImageOptions.Image = lstImgPause.Images[1];
                btnPause.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            }
            else
            {
                btnPause.ImageOptions.Image = lstImgResume.Images[1];
                btnPause.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            }
        }

        private void btnPause_MouseLeave(object sender, EventArgs e)
        {
            if (typeButton == "PAUSE")
            {
                if (lstImgPause.Images.Count == 0)
                    return;
                btnPause.ImageOptions.Image = lstImgPause.Images[0];
                btnPause.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            }
            else
            {
                if (lstImgResume.Images.Count == 0)
                    return;
                btnPause.ImageOptions.Image = lstImgResume.Images[0];
                btnPause.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            }
        }

        private void btnPause_MouseDown(object sender, MouseEventArgs e)
        {
            if (typeButton == "PAUSE")
            {
                if (lstImgPause.Images.Count == 0)
                    return;

                btnPause.ImageOptions.Image = lstImgPause.Images[2];
            }
            else
            {
                if (lstImgResume.Images.Count == 0)
                    return;

                btnPause.ImageOptions.Image = lstImgResume.Images[2];
            }
        }

        private void frmScan_InProgess_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}