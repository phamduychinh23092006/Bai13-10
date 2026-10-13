using StudentManagerApp;
using System;
using System.Windows.Forms;

namespace StudentManagerApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // Thuật toán kiểm tra và mở form con duy nhất (Single Instance MDI Child)
        public void OpenChildForm(Type formType)
        {
            Form existingForm = null;
            foreach (Form child in this.MdiChildren)
            {
                if (child.GetType() == formType)
                {
                    existingForm = child;
                    break;
                }
            }

            if (existingForm != null)
            {
                existingForm.Activate();
                if (existingForm.WindowState == FormWindowState.Minimized)
                {
                    existingForm.WindowState = FormWindowState.Normal;
                }
            }
            else
            {
                Form newChild = (Form)Activator.CreateInstance(formType);
                newChild.MdiParent = this;
                newChild.Show();
            }
        }

        // Nhận thông điệp cập nhật trạng thái từ Form con lên StatusStrip
        public void UpdateStatus(string message)
        {
            lblMessage.Text = " | Trạng thái: " + message;
        }

        private void itemLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void itemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void itemStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm(typeof(FormStudent));
        }

        private void itemProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mở form Quản lý Sản phẩm (đang phát triển)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void itemCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void itemTileH_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void itemTileV_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void btnToolStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm(typeof(FormStudent));
        }
    }
}