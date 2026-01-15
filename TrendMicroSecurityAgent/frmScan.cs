using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace TrendMicroSecurityAgent
{
    public partial class frmScan : DevExpress.XtraEditors.XtraForm
    {
        int xBegin, yBegin;
        bool mouseDown = false;

        List<string> lstPath = new List<string>();

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbFileInfo, uint uFlags);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            public string szDisplayName;
            public string szTypeName;
        };       

        public frmScan()
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnScan_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstImgScan.Images.Count == 0)
                return;

            btnScan.ImageOptions.Image = lstImgScan.Images[1];
        }

        private void btnScan_MouseLeave(object sender, EventArgs e)
        {
            if (lstImgScan.Images.Count == 0)
                return;

            btnScan.ImageOptions.Image = lstImgScan.Images[0];
        }

        private Bitmap getIcon(string pathIcon)
        {
            try
            {
                SHFILEINFO shinfo = new SHFILEINFO();
                SHGetFileInfo(pathIcon, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), 0x000000100); //SHGFI_ICON
                Icon icon = Icon.FromHandle(shinfo.hIcon);

                Bitmap b = icon.ToBitmap();
                //b.SetResolution(600, 600);

                return b;
            }
            catch (Exception ex)
            {
                return null;
            }
           
        }


        private void frmScan_Load(object sender, EventArgs e)
        {
            try
            {
                TreeNode nodeMyComputer = new TreeNode("My Computer", lstImgIconFolder.Images.Count - 1, lstImgIconFolder.Images.Count - 1);
                nodeMyComputer.Tag = "My Computer";
                tvCategories.Nodes.Add(nodeMyComputer);

                int countIcon = 1;
                string[] drives = Environment.GetLogicalDrives();
                foreach (string drive in drives)
                {
                    DriveInfo di = new DriveInfo(drive);
                    lstImgIconFolder.Images.Add(getIcon(di.Name));

                    TreeNode node = new TreeNode(di.VolumeLabel + "(" + di.Name.Substring(0, 2) + ")", countIcon, countIcon);
                    node.Tag = drive;

                    countIcon = countIcon + 1;

                    if (di.IsReady == true)
                        node.Nodes.Add("...");

                    nodeMyComputer.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmScan_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Y > 34)
                return;

            mouseDown = true;
            xBegin = e.X;
            yBegin = e.Y;
        }

        private void frmScan_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown && e.Y <= 34)
            {
                int xMove = e.X - xBegin;
                int yMove = e.Y - yBegin;
                this.Location = new Point(this.Location.X + xMove, this.Location.Y + yMove);
            }
        }

        private void frmScan_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void CheckNodes(TreeNode node, bool value)
        {
            if (node.Checked != value)
                node.Checked = value;

            foreach (TreeNode n in node.Nodes)
                CheckNodes(n, value);
        }

        private void tvCategories_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null)
                return;

            CheckNodes(e.Node, e.Node.Checked);
        }

        void LookupChecks(TreeNode node)
        {
            if (node.Checked && node.Tag != null)
                if (Directory.Exists(node.Tag.ToString()))
                    lstPath.Add(node.Tag.ToString());

            foreach (TreeNode n in node.Nodes)
                LookupChecks(n);
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (TreeNode node in tvCategories.Nodes)
                    LookupChecks(node);

                bool flagOpened = false;
                foreach (Form frm in Application.OpenForms)
                    if (frm.Name == "frmScan_InProgess")
                    {
                        frmScan_InProgess frmShow = (frmScan_InProgess)frm;
                        frmShow.folderScan = lstPath;
                        frmShow.Focus();
                        flagOpened = true;
                        break;
                    }

                if (!flagOpened)
                {
                    frmScan_InProgess frmShow = new frmScan_InProgess();
                    frmShow.folderScan = lstPath;
                    frmShow.Show();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tvCategories_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                if (e.Node.Nodes.Count > 0)
                {
                    if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                    {
                        e.Node.Nodes.Clear();

                        //get the list of sub direcotires
                        string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());
                        foreach (string dir in dirs)
                        {
                            DirectoryInfo di = new DirectoryInfo(dir);
                            lstImgIconFolder.Images.Add(getIcon(di.FullName));

                            TreeNode node = new TreeNode(di.Name, lstImgIconFolder.Images.Count - 1, lstImgIconFolder.Images.Count - 1);

                            try
                            {
                                //keep the directory's full path in the tag for use later
                                node.Tag = dir;

                                //if the directory has sub directories add the place holder
                                if (di.GetDirectories().Count() > 0)
                                    node.Nodes.Add(null, "...", 0, 0);
                            }
                            catch (UnauthorizedAccessException)
                            {
                                //display a locked folder icon
                                //node.ImageIndex = 12;
                                //node.SelectedImageIndex = 12;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "DirectoryLister",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                if (node == null)
                                    node = null;

                                e.Node.Nodes.Add(node);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}