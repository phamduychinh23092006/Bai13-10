using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace StudentManagerApp
{
    public partial class Form1 : Form
    {
        private BindingList<Student> studentList;
        private BindingSource bindingSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Khởi tạo danh sách mẫu và BindingSource
            studentList = new BindingList<Student>()
            {
                new Student("SV001", "Nguyễn Văn An", 20, "Nam", ""),
                new Student("SV002", "Trần Thị Bình", 21, "Nữ", "")
            };

            bindingSource = new BindingSource();
            bindingSource.DataSource = studentList;

            // 2. Gắn BindingSource vào DataGridView
            dataGridView1.DataSource = bindingSource;

            // 3. Thiết lập DataBindings 2 chiều cho các Control nhập liệu
            txtStudentId.DataBindings.Add("Text", bindingSource, "StudentId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFullName.DataBindings.Add("Text", bindingSource, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAge.DataBindings.Add("Text", bindingSource, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
            cmbGender.DataBindings.Add("SelectedItem", bindingSource, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);

            // 4. Lắng nghe sự kiện chuyển dòng trên BindingSource để cập nhật PictureBox
            bindingSource.CurrentChanged += BindingSource_CurrentChanged;

            // Nạp hiển thị cho dòng đầu tiên khi khởi động
            LoadCurrentAvatar();
        }

        // Sự kiện khi thay đổi dòng chọn trên DataGridView / BindingSource
        private void BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            LoadCurrentAvatar();
        }

        // Hàm hỗ trợ nạp ảnh vào PictureBox từ AvatarPath (Dùng MemoryStream để tránh khóa file ảnh)
        private void LoadCurrentAvatar()
        {
            if (bindingSource.Current is Student currentStudent)
            {
                if (!string.IsNullOrEmpty(currentStudent.AvatarPath) && File.Exists(currentStudent.AvatarPath))
                {
                    try
                    {
                        using (var fs = new FileStream(currentStudent.AvatarPath, FileMode.Open, FileAccess.Read))
                        {
                            pictureBoxAvatar.Image = Image.FromStream(fs);
                        }
                    }
                    catch
                    {
                        pictureBoxAvatar.Image = null;
                    }
                }
                else
                {
                    pictureBoxAvatar.Image = null;
                }
            }
            else
            {
                pictureBoxAvatar.Image = null;
            }
        }

        // Chức năng: Chọn ảnh đại diện (OpenFileDialog)
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";
                ofd.Title = "Chọn ảnh đại diện sinh viên";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (bindingSource.Current is Student currentStudent)
                    {
                        currentStudent.AvatarPath = ofd.FileName;
                        LoadCurrentAvatar();
                        bindingSource.ResetCurrentItem(); // Làm mới hiển thị trên DataGridView
                    }
                }
            }
        }

        // Chức năng: Thêm sinh viên mới
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng sinh viên mới tạm thời
            Student newStudent = new Student
            {
                StudentId = "SV" + (studentList.Count + 1).ToString("D3"),
                FullName = "Nhập họ tên",
                Age = 18,
                Gender = "Nam",
                AvatarPath = ""
            };

            studentList.Add(newStudent);
            bindingSource.Position = studentList.Count - 1; // Di chuyển tới dòng vừa thêm
            txtStudentId.Focus();
        }

        // Chức năng: Xóa sinh viên đang chọn
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Student currentStudent)
            {
                var confirm = MessageBox.Show($"Bạn có chắc muốn xóa sinh viên {currentStudent.FullName}?",
                                              "Xác nhận xóa",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    bindingSource.RemoveCurrent();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Chức năng: Cập nhật (Do đã dùng BindingSource 2 chiều nên dữ liệu tự đồng bộ, 
        // nút này dùng để xác nhận hoặc thông báo trạng thái thành công).
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bindingSource.EndEdit();
            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Chức năng: Xuất file CSV (Hỗ trợ tiếng Việt UTF-8)
        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV File (*.csv)|*.csv";
                sfd.FileName = "DanhSachSinhVien.csv";
                sfd.Title = "Xuất danh sách ra file CSV";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Sử dụng Encoding.UTF8 để hỗ trợ tiếng Việt có dấu
                        using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                        {
                            // Ghi tiêu đề cột
                            sw.WriteLine("StudentId,FullName,Age,Gender,AvatarPath");

                            // Ghi từng dòng dữ liệu
                            foreach (var st in studentList)
                            {
                                // Bao bọc đường dẫn trong dấu ngoặc kép đề phòng đường dẫn chứa dấu phẩy
                                sw.WriteLine($"{st.StudentId},{st.FullName},{st.Age},{st.Gender},\"{st.AvatarPath}\"");
                            }
                        }

                        MessageBox.Show("Xuất file CSV thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}