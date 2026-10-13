namespace StudentManagerApp
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.itemStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.itemProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTileH = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTileV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnToolStudent = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystem,
            this.menuCategory,
            this.menuWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSystem
            // 
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemLogout,
            this.itemExit});
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Size = new System.Drawing.Size(72, 20);
            this.menuSystem.Text = "Hệ thống";
            // 
            // itemLogout
            // 
            this.itemLogout.Name = "itemLogout";
            this.itemLogout.Size = new System.Drawing.Size(128, 22);
            this.itemLogout.Text = "Đăng xuất";
            this.itemLogout.Click += new System.EventHandler(this.itemLogout_Click);
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(128, 22);
            this.itemExit.Text = "Thoát";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // menuCategory
            // 
            this.menuCategory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemStudent,
            this.itemProduct});
            this.menuCategory.Name = "menuCategory";
            this.menuCategory.Size = new System.Drawing.Size(74, 20);
            this.menuCategory.Text = "Danh mục";
            // 
            // itemStudent
            // 
            this.itemStudent.Name = "itemStudent";
            this.itemStudent.Size = new System.Drawing.Size(167, 22);
            this.itemStudent.Text = "Quản lý Sinh viên";
            this.itemStudent.Click += new System.EventHandler(this.itemStudent_Click);
            // 
            // itemProduct
            // 
            this.itemProduct.Name = "itemProduct";
            this.itemProduct.Size = new System.Drawing.Size(167, 22);
            this.itemProduct.Text = "Quản lý Sản phẩm";
            this.itemProduct.Click += new System.EventHandler(this.itemProduct_Click);
            // 
            // menuWindow
            // 
            this.menuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCascade,
            this.itemTileH,
            this.itemTileV});
            this.menuWindow.Name = "menuWindow";
            this.menuWindow.Size = new System.Drawing.Size(58, 20);
            this.menuWindow.Text = "Cửa sổ";
            // 
            // itemCascade
            // 
            this.itemCascade.Name = "itemCascade";
            this.itemCascade.Size = new System.Drawing.Size(180, 22);
            this.itemCascade.Text = "Sắp xếp Cascade";
            this.itemCascade.Click += new System.EventHandler(this.itemCascade_Click);
            // 
            // itemTileH
            // 
            this.itemTileH.Name = "itemTileH";
            this.itemTileH.Size = new System.Drawing.Size(180, 22);
            this.itemTileH.Text = "Sắp xếp Ngang (Tile H)";
            this.itemTileH.Click += new System.EventHandler(this.itemTileH_Click);
            // 
            // itemTileV
            // 
            this.itemTileV.Name = "itemTileV";
            this.itemTileV.Size = new System.Drawing.Size(180, 22);
            this.itemTileV.Text = "Sắp xếp Dọc (Tile V)";
            this.itemTileV.Click += new System.EventHandler(this.itemTileV_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToolStudent});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(900, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnToolStudent
            // 
            this.btnToolStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnToolStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolStudent.Name = "btnToolStudent";
            this.btnToolStudent.Size = new System.Drawing.Size(107, 22);
            this.btnToolStudent.Text = "Quản lý Sinh viên";
            this.btnToolStudent.Click += new System.EventHandler(this.btnToolStudent_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUser,
            this.lblMessage,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(900, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(149, 17);
            this.lblUser.Text = "Người dùng: Administrator";
            // 
            // lblMessage
            // 
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(103, 17);
            this.lblMessage.Text = " | Trạng thái: Sẵn sàng";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(633, 17);
            this.lblTime.Spring = true;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Đào tạo - MDI Parent";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem itemLogout;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private System.Windows.Forms.ToolStripMenuItem menuCategory;
        private System.Windows.Forms.ToolStripMenuItem itemStudent;
        private System.Windows.Forms.ToolStripMenuItem itemProduct;
        private System.Windows.Forms.ToolStripMenuItem menuWindow;
        private System.Windows.Forms.ToolStripMenuItem itemCascade;
        private System.Windows.Forms.ToolStripMenuItem itemTileH;
        private System.Windows.Forms.ToolStripMenuItem itemTileV;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnToolStudent;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}