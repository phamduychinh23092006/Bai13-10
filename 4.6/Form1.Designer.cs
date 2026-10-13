namespace StudentManagerApp
{
    partial class Form1
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
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();

            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExportCSV = new System.Windows.Forms.Button();

            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.groupBoxActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.lblStudentId);
            this.groupBoxInput.Controls.Add(this.txtStudentId);
            this.groupBoxInput.Controls.Add(this.lblFullName);
            this.groupBoxInput.Controls.Add(this.txtFullName);
            this.groupBoxInput.Controls.Add(this.lblAge);
            this.groupBoxInput.Controls.Add(this.txtAge);
            this.groupBoxInput.Controls.Add(this.lblGender);
            this.groupBoxInput.Controls.Add(this.cmbGender);
            this.groupBoxInput.Controls.Add(this.pictureBoxAvatar);
            this.groupBoxInput.Controls.Add(this.btnBrowse);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 12);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(760, 180);
            this.groupBoxInput.TabIndex = 0;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Thông tin sinh viên";

            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(20, 30);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(42, 15);
            this.lblStudentId.Text = "Mã SV:";

            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(90, 27);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(200, 23);
            this.txtStudentId.TabIndex = 1;

            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(20, 65);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(46, 15);
            this.lblFullName.Text = "Họ tên:";

            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(90, 62);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 23);
            this.txtFullName.TabIndex = 2;

            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(20, 100);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 15);
            this.lblAge.Text = "Tuổi:";

            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(90, 97);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(200, 23);
            this.txtAge.TabIndex = 3;

            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(20, 135);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(55, 15);
            this.lblGender.Text = "Giới tính:";

            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cmbGender.Location = new System.Drawing.Point(90, 132);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(200, 23);
            this.cmbGender.TabIndex = 4;

            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(340, 27);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(120, 128);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar.TabIndex = 5;
            this.pictureBoxAvatar.TabStop = false;

            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(475, 27);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(90, 30);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Chọn ảnh";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);

            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.btnAdd);
            this.groupBoxActions.Controls.Add(this.btnUpdate);
            this.groupBoxActions.Controls.Add(this.btnDelete);
            this.groupBoxActions.Controls.Add(this.btnExportCSV);
            this.groupBoxActions.Location = new System.Drawing.Point(12, 198);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(760, 60);
            this.groupBoxActions.TabIndex = 1;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Chức năng";

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(125, 20);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(230, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(335, 20);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(110, 30);
            this.btnExportCSV.TabIndex = 3;
            this.btnExportCSV.Text = "Xuất CSV";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);

            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 266);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(760, 230);
            this.dataGridView1.TabIndex = 2;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.groupBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Sinh viên (Data Binding & CSV)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.groupBoxActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Button btnBrowse;

        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExportCSV;

        private System.Windows.Forms.DataGridView dataGridView1;
    }
}