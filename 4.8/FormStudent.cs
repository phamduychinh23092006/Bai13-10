using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentManagerApp
{
    public partial class FormStudent : Form
    {
        private BindingList<Student> studentList;
        private BindingSource bindingSource;
        private ContextMenuStrip contextMenuGrid;

        public FormStudent()
        {
            InitializeComponent();
            SetupContextMenu();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            this.Text = "Quản lý Sinh viên";

            // 1. Khởi tạo danh sách mẫu và BindingSource
            studentList = new BindingList<Student>()
            {
                new Student("SV001", "Nguyễn Văn An", 20, "Nam", ""),
                new Student("SV002", "Trần Thị Bình", 21, "Nữ", "")
            };

            bindingSource = new BindingSource { DataSource = studentList };
            dataGridView1.DataSource = bindingSource;

            // 2. Thiết lập DataBindings 2 chiều
            txtStudentId.DataBindings.Add("Text", bindingSource, "StudentId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFullName.DataBindings.Add("Text", bindingSource, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAge.DataBindings.Add("Text", bindingSource, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbGender.DataBindings.Add("SelectedItem", bindingSource, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);

            bindingSource.CurrentChanged += (s, ev) => LoadCurrentAvatar();
            LoadCurrentAvatar();

            NotifyParent("Đã mở cửa sổ Quản lý Sinh viên.");
        }

        // --- BẤT ĐỒNG BỘ (ASYNC/AWAIT) & TIẾN TRÌNH ---
        private async void btnLoadAsync_Click(object sender, EventArgs e)
        {
            SetControlsEnabled(false);
            progressBar1.Value = 0;

            try
            {
                var progress = new Progress<int>(percent =>
                {
                    progressBar1.Value = percent;
                    lblProgress.Text = $"{percent}%";
                    NotifyParent($"Đang nạp dữ liệu: {percent}% hoàn thành");
                });

                List<Student> loadedStudents = await LoadStudentsFromDatabaseAsync(progress);

                studentList.Clear();
                foreach (var st in loadedStudents)
                {
                    studentList.Add(st);
                }

                MessageBox.Show("Nạp dữ liệu bất đồng bộ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NotifyParent("Nạp dữ liệu hoàn tất.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nạp dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NotifyParent("Nạp dữ liệu thất bại.");
            }
            finally
            {
                SetControlsEnabled(true);
            }
        }

        private async Task<List<Student>> LoadStudentsFromDatabaseAsync(IProgress<int> progress)
        {
            return await Task.Run(() =>
            {
                List<Student> tempList = new List<Student>();
                int totalSteps = 10;

                for (int i = 1; i <= totalSteps; i++)
                {
                    Thread.Sleep(250); // Giả lập độ trễ tác vụ nặng
                    tempList.Add(new Student($"SV10{i}", $"Sinh viên Async {i}", 18 + (i % 5), i % 2 == 0 ? "Nữ" : "Nam", ""));
                    int percent = (i * 100) / totalSteps;
                    progress?.Report(percent);
                }

                return tempList;
            });
        }

        private void SetControlsEnabled(bool enabled)
        {
            btnLoadAsync.Enabled = enabled;
            btnAdd.Enabled = enabled;
            btnDelete.Enabled = enabled;
            btnUpdate.Enabled = enabled;
            btnExportCSV.Enabled = enabled;
        }

        // --- TÍCH HỢP CONTEXTMENUSTRIP ---
        private void SetupContextMenu()
        {
            contextMenuGrid = new ContextMenuStrip();

            ToolStripMenuItem menuDelete = new ToolStripMenuItem("Xóa dòng đang chọn");
            menuDelete.Click += (s, e) => btnDelete_Click(s, e);

            ToolStripMenuItem menuRefresh = new ToolStripMenuItem("Làm mới dữ liệu");
            menuRefresh.Click += (s, e) => {
                bindingSource.ResetBindings(false);
                NotifyParent("Đã làm mới danh sách sinh viên.");
            };

            ToolStripMenuItem menuDetail = new ToolStripMenuItem("Xem chi tiết sinh viên");
            menuDetail.Click += (s, e) => {
                if (bindingSource.Current is Student st)
                {
                    MessageBox.Show($"Mã: {st.StudentId}\nHọ tên: {st.FullName}\nTuổi: {st.Age}\nGiới tính: {st.Gender}",
                                    "Chi tiết sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            contextMenuGrid.Items.AddRange(new ToolStripItem[] { menuDelete, menuRefresh, menuDetail });
            dataGridView1.ContextMenuStrip = contextMenuGrid;
        }

        private void NotifyParent(string message)
        {
            if (this.MdiParent is FormMain mainForm)
            {
                mainForm.UpdateStatus(message);
            }
        }

        private void LoadCurrentAvatar()
        {
            if (bindingSource.Current is Student currentStudent && !string.IsNullOrEmpty(currentStudent.AvatarPath) && File.Exists(currentStudent.AvatarPath))
            {
                try
                {
                    using (var fs = new FileStream(currentStudent.AvatarPath, FileMode.Open, FileAccess.Read))
                    {
                        pictureBoxAvatar.Image = Image.FromStream(fs);
                    }
                }
                catch { pictureBoxAvatar.Image = null; }
            }
            else { pictureBoxAvatar.Image = null; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student
            {
                StudentId = "SV" + (studentList.Count + 1).ToString("D3"),
                FullName = "Sinh viên mới",
                Age = 18,
                Gender = "Nam",
                AvatarPath = ""
            };
            studentList.Add(newStudent);
            bindingSource.Position = studentList.Count - 1;

            NotifyParent($"Đã thêm sinh viên: {newStudent.StudentId}");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Student currentStudent)
            {
                var confirm = MessageBox.Show($"Xóa sinh viên {currentStudent.FullName}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    string id = currentStudent.StudentId;
                    bindingSource.RemoveCurrent();
                    NotifyParent($"Đã xóa sinh viên: {id}");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK && bindingSource.Current is Student st)
                {
                    st.AvatarPath = ofd.FileName;
                    LoadCurrentAvatar();
                    bindingSource.ResetCurrentItem();
                    NotifyParent($"Đã cập nhật ảnh đại diện cho {st.StudentId}");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bindingSource.EndEdit();
            NotifyParent("Đã cập nhật thông tin sinh viên thành công.");
            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV File (*.csv)|*.csv";
                sfd.FileName = "DanhSachSinhVien.csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        sw.WriteLine("StudentId,FullName,Age,Gender,AvatarPath");
                        foreach (var st in studentList)
                        {
                            sw.WriteLine($"{st.StudentId},{st.FullName},{st.Age},{st.Gender},\"{st.AvatarPath}\"");
                        }
                    }
                    NotifyParent("Xuất file CSV thành công.");
                    MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}