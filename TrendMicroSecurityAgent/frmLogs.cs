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
    public partial class frmLogs : DevExpress.XtraEditors.XtraForm 
    {
        int xBegin, yBegin;
        bool mouseDown = false;

        int TopCenter_xBegin, TopCenter_yBegin;
        bool TopCenter_mouseDown = false;

        int TopLeft_xBegin, TopLeft_yBegin;
        bool TopLeft_mouseDown = false;

        int Right_xBegin, Right_yBegin;
        bool Right_mouseDown = false;

        public frmLogs()
        {
            InitializeComponent();
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

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.ImageOptions.Image = lstImgMaximize.Images[2];
                btnMaximize.ToolTip = "Restore Down";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximize.ImageOptions.Image = lstImgMaximize.Images[0];
                btnMaximize.ToolTip = "Maximize";
            }

            pnMid1.Visible = false;
            pnMid2.Visible = true;
        }

        private void btnMaximize_MouseHover(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                btnMaximize.ImageOptions.Image = lstImgMaximize.Images[1];
            }
            else
            {
                btnMaximize.ImageOptions.Image = lstImgMaximize.Images[3];
            }
        }

        private void btnMaximize_MouseLeave(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) 
                btnMaximize.ImageOptions.Image = lstImgMaximize.Images[0];
            else
                btnMaximize.ImageOptions.Image = lstImgMaximize.Images[2];
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            btnMinimize.ImageOptions.Image = lstImgMinimize.Images[1];
            btnMinimize.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.ImageOptions.Image = lstImgMinimize.Images[0];
            btnMinimize.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
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

        private void btnClosed_MouseLeave(object sender, EventArgs e)
        {
            if (lstImgbtnClose.Images.Count == 0)
                return;

            btnClosed.ImageOptions.Image = lstImgbtnClose.Images[0];
            btnClosed.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnClosed_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstImgbtnClose.Images.Count == 0)
                return;

            btnClosed.ImageOptions.Image = lstImgbtnClose.Images[1];
            btnClosed.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Red;
        }

        private void linkLabel1_MouseLeave(object sender, EventArgs e)
        {
            linkLabel1.LinkColor = Color.Black;
        }

        private void lkType_EditValueChanged(object sender, EventArgs e)
        {
            if (lkType.EditValue == null || lkType.EditValue.ToString() == "")
            {
                lkTypeDetail.Visible = false;
                return;
            }

            if (int.Parse(lkType.EditValue.ToString()) == 1 ||
                int.Parse(lkType.EditValue.ToString()) == 2 ||
                int.Parse(lkType.EditValue.ToString()) == 3 ||
                int.Parse(lkType.EditValue.ToString()) == 6 ||
                int.Parse(lkType.EditValue.ToString()) == 8
                )
            {
                lkTypeDetail.Visible = true;

                DataTable dtDetail = new DataTable();
                dtDetail.Columns.Add("ID", typeof(int));
                dtDetail.Columns.Add("Name", typeof(string));

                if (int.Parse(lkType.EditValue.ToString()) == 1)
                {
                    dtDetail.Rows.Add(1, "All results (0)");
                    dtDetail.Rows.Add(2, "Cleaned (0)");
                    dtDetail.Rows.Add(3, "Deleted (0)");
                    dtDetail.Rows.Add(4, "Quarantined (0)");
                    dtDetail.Rows.Add(5, "Access denied (0)");
                    dtDetail.Rows.Add(6, "Passed (0)");
                    dtDetail.Rows.Add(7, "Renamed (0)");
                    dtDetail.Rows.Add(8, "Action required (0)");
                    lkTypeDetail.Properties.DropDownRows = 8;
                }
                else if (int.Parse(lkType.EditValue.ToString()) == 2)
                {
                    dtDetail.Rows.Add(1, "All results (0)");
                    dtDetail.Rows.Add(2, "Cleaned (0)");
                    dtDetail.Rows.Add(5, "Access denied (0)");
                    dtDetail.Rows.Add(6, "Passed (0)");
                    dtDetail.Rows.Add(8, "Action required (0)");
                    lkTypeDetail.Properties.DropDownRows = 5;
                }
                else if (int.Parse(lkType.EditValue.ToString()) == 3)
                {
                    dtDetail.Rows.Add(9, "Both directions (0)");
                    dtDetail.Rows.Add(10, "Outgoing (0)");
                    dtDetail.Rows.Add(11, "Incoming (0)");
                    lkTypeDetail.Properties.DropDownRows = 3;
                }
                else if (int.Parse(lkType.EditValue.ToString()) == 6)
                {
                    dtDetail.Rows.Add(1, "All results (0)");
                    dtDetail.Rows.Add(12, "File (0)");
                    dtDetail.Rows.Add(13, "Process (0)");
                    lkTypeDetail.Properties.DropDownRows = 3;
                }
                else
                {
                    dtDetail.Rows.Add(1, "All results (0)");
                    dtDetail.Rows.Add(12, "USB storage devices (0)");
                    dtDetail.Rows.Add(13, "USB autorun (0)");
                    lkTypeDetail.Properties.DropDownRows = 3;
                }

                lkTypeDetail.Properties.ValueMember = "ID";
                lkTypeDetail.Properties.DisplayMember = "Name";
                lkTypeDetail.Properties.DataSource = dtDetail;
                lkTypeDetail.EditValue = dtDetail.Rows[0]["ID"];
            }
            else
            {
                lkTypeDetail.Visible = false;
            }
        }

        private void frmLogs_Load(object sender, EventArgs e)
        {
            btnClose.ImageOptions.Image = lstImgClose.Images[0];
            btnMinimize.ImageOptions.Image = lstImgMinimize.Images[0];
            btnMaximize.ImageOptions.Image = lstImgMaximize.Images[0];
            btnHelp.ImageOptions.Image = lstImgHelp.Images[0];

            DataTable dtRange = new DataTable();
            dtRange.Columns.Add("ID", typeof(int));
            dtRange.Columns.Add("Name", typeof(string));

            dtRange.Rows.Add(1, "Last 7 days");
            dtRange.Rows.Add(2, "All available");
            //dtRange.Rows.Add(3, "Custom");

            lkRange.Properties.ValueMember = "ID";
            lkRange.Properties.DisplayMember = "Name";
            lkRange.Properties.DataSource = dtRange;
            lkRange.EditValue = 1;

            DataTable dtType = new DataTable();
            dtType.Columns.Add("ID", typeof(int));
            dtType.Columns.Add("Name", typeof(string));

            dtType.Rows.Add(1, "Virus/Malware");
            dtType.Rows.Add(2, "Spyware/Grayware");
            dtType.Rows.Add(3, "Firewall/Network Virus");
            dtType.Rows.Add(4, "Web Reputation");
            dtType.Rows.Add(5, "URL Filtering");
            dtType.Rows.Add(6, "Predictive Machine Learning");
            dtType.Rows.Add(7, "Behavior Monitoring");
            dtType.Rows.Add(8, "Device Control");
            dtType.Rows.Add(9, "Data Loss Prevention");
            dtType.Rows.Add(10, "Application Control");

            lkType.Properties.ValueMember = "ID";
            lkType.Properties.DisplayMember = "Name";
            lkType.Properties.DataSource = dtType;
            lkType.EditValue = 1;

            pnMid1.Visible = true;
            pnMid2.Visible = false;
        }

        private void frmLogs_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            xBegin = e.X;
            yBegin = e.Y;
        }

        private void frmLogs_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int xMove = e.X - xBegin;
                int yMove = e.Y - yBegin;
                this.Location = new Point(this.Location.X + xMove, this.Location.Y + yMove);
            }
        }

        private void frmLogs_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void pnTopLeft_MouseDown(object sender, MouseEventArgs e)
        {
            TopLeft_mouseDown = true;
            TopLeft_xBegin = e.X;
            TopLeft_yBegin = e.Y;
        }

        private void pnTopLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (TopLeft_mouseDown)
            {
                int xMove = e.X - TopLeft_xBegin;
                int yMove = e.Y - TopLeft_yBegin;
                this.Location = new Point(this.Location.X + xMove, this.Location.Y + yMove);
            }
        }

        private void pnTopLeft_MouseUp(object sender, MouseEventArgs e)
        {
            TopLeft_mouseDown = false;
        }

        private void picTopCenter_MouseDown(object sender, MouseEventArgs e)
        {
            TopCenter_mouseDown = true;
            TopCenter_xBegin = e.X;
            TopCenter_yBegin = e.Y;
        }

        private void picTopCenter_MouseMove(object sender, MouseEventArgs e)
        {
            if (TopCenter_mouseDown)
            {
                int xMove = e.X - TopCenter_xBegin;
                int yMove = e.Y - TopCenter_yBegin;
                this.Location = new Point(this.Location.X + xMove, this.Location.Y + yMove);
            }
        }

        private void picTopCenter_MouseUp(object sender, MouseEventArgs e)
        {
            TopCenter_mouseDown = false;
        }

        private void pnRight_MouseDown(object sender, MouseEventArgs e)
        {
            Right_mouseDown = true;
            Right_xBegin = e.X;
            Right_yBegin = e.Y;
        }

        private void pnRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (Right_mouseDown)
            {
                int xMove = e.X - Right_xBegin;
                int yMove = e.Y - Right_yBegin;
                this.Location = new Point(this.Location.X + xMove, this.Location.Y + yMove);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void pnRight_MouseUp(object sender, MouseEventArgs e)
        {
            Right_mouseDown = false;
        }
    }
}
