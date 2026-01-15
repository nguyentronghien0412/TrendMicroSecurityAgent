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
using System.Xml;

namespace TrendMicroSecurityAgent
{
    public partial class frmSetting : DevExpress.XtraEditors.XtraForm
    {
        int Top_xBegin, Top_yBegin;
        bool Top_mouseDown = false;

        int Right_xBegin, Right_yBegin;
        bool Right_mouseDown = false;

        public frmSetting()
        {
            InitializeComponent();
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

        private void btnOK_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstImgOK.Images.Count == 0)
                return;

            btnOK.ImageOptions.Image = lstImgOK.Images[1];
        }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            if (lstImgOK.Images.Count == 0)
                return;

            btnOK.ImageOptions.Image = lstImgOK.Images[0];
        }

        private void btnCancel_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstImgCancel.Images.Count == 0)
                return;

            btnCancel.ImageOptions.Image = lstImgCancel.Images[1];
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            if (lstImgCancel.Images.Count == 0)
                return;

            btnCancel.ImageOptions.Image = lstImgCancel.Images[0];
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string rs = settings();
            if (rs != "SUCCESS")
            {
                MessageBox.Show(rs,"Security Agent");
                return;
            }

            this.Close();
        }

        private bool checkValid(TextEdit txt)
        {
            try
            {
                if (txt.Text.Trim() == "")
                    return false;
                int days = int.Parse(txt.Text.Trim());
                if (days < 1 || days > 99)
                    return false;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private string settings()
        {
            try
            {
                if (!checkValid(txt01))
                {
                    txt01.Text = "";
                    txt01.Focus();
                    return "Enter a number between 1 to 99.";
                }
                if (!checkValid(txt02))
                {
                    txt02.Text = "";
                    txt02.Focus();
                    return "Enter a number between 1 to 99.";
                }
                if (!checkValid(txt03))
                {
                    txt03.Text = "";
                    txt03.Focus();
                    return "Enter a number between 1 to 99.";
                }
                if (!checkValid(txt04))
                {
                    txt04.Text = "";
                    txt04.Focus();
                    return "Enter a number between 1 to 99.";
                }
                if (!checkValid(txt05))
                {
                    txt05.Text = "";
                    txt05.Focus();
                    return "Enter a number between 1 to 99.";
                }
                if (!checkValid(txt06))
                {
                    txt06.Text = "";
                    txt06.Focus();
                    return "Enter a number between 1 to 99.";
                }
                if (!checkValid(txt07))
                {
                    txt07.Text = "";
                    txt07.Focus();
                    return "Enter a number between 1 to 99.";
                }
                if (!checkValid(txt08))
                {
                    txt08.Text = "";
                    txt08.Focus();
                    return "Enter a number between 1 to 99.";
                }
                if (!checkValid(txt09))
                {
                    txt09.Text = "";
                    txt09.Focus();
                    return "Enter a number between 1 to 99.";
                }

                XmlDocument doc = new XmlDocument();
                doc.Load(string.Format("{0}\\SystemConfig.xml", Application.StartupPath));
                XmlNode node = doc.SelectSingleNode("Root//Value");
                
                node.Attributes["Value1"].Value = txt01.Text;
                node.Attributes["Value2"].Value = txt02.Text;
                node.Attributes["Value3"].Value = txt03.Text;
                node.Attributes["Value4"].Value = txt04.Text;
                node.Attributes["Value5"].Value = txt05.Text;
                node.Attributes["Value6"].Value = txt06.Text;
                node.Attributes["Value7"].Value = txt07.Text;
                node.Attributes["Value8"].Value = txt08.Text;
                node.Attributes["Value9"].Value = txt09.Text;

                doc.Save(string.Format("{0}\\SystemConfig.xml", Application.StartupPath));

                return "SUCCESS";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private void picTop_MouseDown(object sender, MouseEventArgs e)
        {
            Top_mouseDown = true;
            Top_xBegin = e.X;
            Top_yBegin = e.Y;
        }

        private void picTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (Top_mouseDown)
            {
                int xMove = e.X - Top_xBegin;
                int yMove = e.Y - Top_yBegin;
                this.Location = new Point(this.Location.X + xMove, this.Location.Y + yMove);
            }
        }

        private void picTop_MouseUp(object sender, MouseEventArgs e)
        {
            Top_mouseDown = false;
        }

        private void picHelp1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.trendmicro.com/en-us/wfbs-svc/client/v6.7/agent_log_maintain/");
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (btnApply.Tag == null)
                return;

            if (btnApply.Tag.ToString() == "0")
            {

            }
            else if (btnApply.Tag.ToString() == "1")
            {
                string rs = settings();
                if (rs != "SUCCESS")
                {
                    MessageBox.Show(rs);
                    return;
                }

                btnApply.Tag = 0;
                btnApply.AllowFocus = false;
                btnApply.ImageOptions.Image = lstImgApply.Images[2];
                btnOK.Focus();
            }
        }

        private void txt01_TextChanged(object sender, EventArgs e)
        {
            btnApply.ImageOptions.Image = lstImgApply.Images[0];
            btnApply.Tag = 1;
            btnApply.AllowFocus = true;
        }

        private void txt02_TextChanged(object sender, EventArgs e)
        {
            btnApply.ImageOptions.Image = lstImgApply.Images[0];
            btnApply.Tag = 1;
            btnApply.AllowFocus = true;
        }

        private void txt03_TextChanged(object sender, EventArgs e)
        {
            btnApply.ImageOptions.Image = lstImgApply.Images[0];
            btnApply.Tag = 1;
            btnApply.AllowFocus = true;
        }

        private void txt04_TextChanged(object sender, EventArgs e)
        {
            btnApply.ImageOptions.Image = lstImgApply.Images[0];
            btnApply.Tag = 1;
            btnApply.AllowFocus = true;
        }

        private void txt05_TextChanged(object sender, EventArgs e)
        {
            btnApply.ImageOptions.Image = lstImgApply.Images[0];
            btnApply.Tag = 1;
            btnApply.AllowFocus = true;
        }

        private void txt06_TextChanged(object sender, EventArgs e)
        {
            btnApply.ImageOptions.Image = lstImgApply.Images[0];
            btnApply.Tag = 1;
            btnApply.AllowFocus = true;
        }

        private void txt07_TextChanged(object sender, EventArgs e)
        {
            btnApply.ImageOptions.Image = lstImgApply.Images[0];
            btnApply.Tag = 1;
            btnApply.AllowFocus = true;
        }

        private void txt08_TextChanged(object sender, EventArgs e)
        {
            btnApply.ImageOptions.Image = lstImgApply.Images[0];
            btnApply.Tag = 1;
            btnApply.AllowFocus = true;
        }

        private void txt09_TextChanged(object sender, EventArgs e)
        {
            btnApply.ImageOptions.Image = lstImgApply.Images[0];
            btnApply.Tag = 1;
            btnApply.AllowFocus = true;
        }

        private void btnApply_MouseDown(object sender, MouseEventArgs e)
        {
            if (btnApply.Tag == null)
                return;

            if (btnApply.Tag.ToString() == "0")
            {

            }
            else if (btnApply.Tag.ToString() == "1")
            {
                if (lstImgApply.Images.Count == 0)
                    return;

                btnApply.ImageOptions.Image = lstImgApply.Images[1];
            }
        }

        private void btnApply_MouseLeave(object sender, EventArgs e)
        {
            if (btnApply.Tag == null)
                return;

            if (btnApply.Tag.ToString() == "1")
            {
                if (lstImgApply.Images.Count == 0)
                    return;

                btnApply.ImageOptions.Image = lstImgApply.Images[0];
            }
        }

        private void btnLogMaintenance_Click(object sender, EventArgs e)
        {
            xtraScrollableControl1.Location = new Point(12, 36);
            xtraScrollableControl1.Size = new Size(446, 305);
            xtraScrollableControl1.Visible = true;
            pnMain2.Visible = false;
            picHelp2.Visible = false;
        }

        private void btnAlerts_Click(object sender, EventArgs e)
        {
            xtraScrollableControl1.Visible = false;
            pnMain2.Visible = true;
            picHelp2.Visible = true;
        }

        private void btnAlerts_MouseHover(object sender, EventArgs e)
        {
            if (btnAlerts.Tag != null && btnAlerts.Tag.ToString() == "0")
                btnAlerts.BackgroundImage = lstImgAlerts_NoClick.Images[1];
        }

        private void btnAlerts_MouseLeave(object sender, EventArgs e)
        {
            if (btnAlerts.Tag != null && btnAlerts.Tag.ToString() == "0")
                btnAlerts.BackgroundImage = lstImgAlerts_NoClick.Images[0];
        }

        private void btnAlerts_MouseDown(object sender, MouseEventArgs e)
        {
            btnLogMaintenance.BackgroundImage = lstImgLogMaintenance_NoClick.Images[0];
            btnLogMaintenance.Tag = 0;
            btnLogMaintenance.Location = new Point(10, 10);
            btnLogMaintenance.Size = new Size(102, 24);

            btnAlerts.BackgroundImage = lstImgAlerts_Clicked.Images[0];
            btnAlerts.Tag = 1;
            btnAlerts.Location = new Point(126 - 12, 10);
            btnAlerts.Size = new Size(54, 24);
        }

        private void btnLogMaintenance_MouseDown(object sender, MouseEventArgs e)
        {
            btnLogMaintenance.BackgroundImage = lstImgLogMaintenance_Clicked.Images[0];
            btnLogMaintenance.Tag = 1;
            btnLogMaintenance.Location = new Point(10, 10);
            btnLogMaintenance.Size = new Size(114, 24);

            btnAlerts.BackgroundImage = lstImgAlerts_NoClick.Images[0];
            btnAlerts.Tag = 0;
            btnAlerts.Location = new Point(126, 10);
            btnAlerts.Size = new Size(49, 24);
        }

        private void btnLogMaintenance_MouseHover(object sender, EventArgs e)
        {
            if (btnLogMaintenance.Tag != null && btnLogMaintenance.Tag.ToString() == "0")
                btnLogMaintenance.BackgroundImage = lstImgLogMaintenance_NoClick.Images[1];
        }

        private void btnLogMaintenance_MouseLeave(object sender, EventArgs e)
        {
            if (btnLogMaintenance.Tag != null && btnLogMaintenance.Tag.ToString() == "0")
                btnLogMaintenance.BackgroundImage = lstImgLogMaintenance_NoClick.Images[0];
        }

        private void picHelp2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.trendmicro.com/en-us/smb/worry-free-business-security-services-67-security-agent-help/customizable-setting/wfbssvc-configuring-.aspx");
        }

        private void pnRight_MouseUp(object sender, MouseEventArgs e)
        {
            Right_mouseDown = false;
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(string.Format("{0}\\SystemConfig.xml", Application.StartupPath));
                XmlNode node = doc.SelectSingleNode("Root//Value");
                if (node != null)
                {
                    if (node.Attributes["Value1"].Value != null)
                        txt01.Text = node.Attributes["Value1"].Value;
                    if (node.Attributes["Value2"].Value != null)
                        txt02.Text = node.Attributes["Value2"].Value;
                    if (node.Attributes["Value3"].Value != null)
                        txt03.Text = node.Attributes["Value3"].Value;
                    if (node.Attributes["Value4"].Value != null)
                        txt04.Text = node.Attributes["Value4"].Value;
                    if (node.Attributes["Value5"].Value != null)
                        txt05.Text = node.Attributes["Value5"].Value;
                    if (node.Attributes["Value6"].Value != null)
                        txt06.Text = node.Attributes["Value6"].Value;
                    if (node.Attributes["Value7"].Value != null)
                        txt07.Text = node.Attributes["Value7"].Value;
                    if (node.Attributes["Value8"].Value != null)
                        txt08.Text = node.Attributes["Value8"].Value;
                    if (node.Attributes["Value9"].Value != null)
                        txt09.Text = node.Attributes["Value9"].Value;
                }

                btnClose.ImageOptions.Image = lstImgClose.Images[0];
                btnHelp.ImageOptions.Image = lstImgHelp.Images[0];
                btnOK.ImageOptions.Image = lstImgOK.Images[0];
                btnCancel.ImageOptions.Image = lstImgCancel.Images[0];
                btnApply.ImageOptions.Image = lstImgApply.Images[2];
                btnApply.Tag = 0;
                btnApply.AllowFocus = false;

                btnLogMaintenance.BackgroundImage = lstImgLogMaintenance_Clicked.Images[0];
                btnLogMaintenance.Tag = 1;

                btnAlerts.BackgroundImage = lstImgAlerts_NoClick.Images[0];
                btnAlerts.Tag = 0;

                xtraScrollableControl1.Location = new Point(12, 36);
                xtraScrollableControl1.Size = new Size(446, 305);
                xtraScrollableControl1.Visible = true;
                pnMain2.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}