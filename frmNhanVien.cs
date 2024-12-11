using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bt4;

namespace bt4
{
    public partial class frmNhanVien : Form
    {
        public delegate void AddNhanVien(NV nhanvien); // Sử dụng NV thay vì NhanVien
        public delegate void SuaNhanVien(NV nhanvien); // Sử dụng NV thay vì NhanVien
        private NV _nhanVien; // Lưu trữ NV đang chỉnh sửa
        private Mode _currentMode; // Chế độ hiện tại (Thêm hoặc Sửa)
        public enum Mode
        {
            Add,
            Edit
        }

        public frmNhanVien()
        {
            InitializeComponent();
            _currentMode = Mode.Add;
        }

        public frmNhanVien(NV nhanVien) : this() // Gọi constructor mặc định
        {
            _nhanVien = nhanVien; // Lưu đối tượng NV để sửa
            InitializeNhanVien(nhanVien); // Khởi tạo các trường
            _currentMode = Mode.Edit; // Thiết lập chế độ là Sửa
        }

        private void InitializeNhanVien(NV nhanVien)
        {
            txtMSNV.Text = nhanVien.MSNV.ToString(); // Điền ID (MSNV)
            txtTenNV.Text = nhanVien.TenNV; // Điền tên (TenNV)
            txtLuongCB.Text = nhanVien.LuongCB.ToString(); // Điền lương (LuongCB)
            txtMSNV.ReadOnly = true; // Làm cho ID không thể sửa
        }

        public AddNhanVien OnAddNhanVien;
        public SuaNhanVien OnSuaNhanVien;

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện thay đổi nội dung của txtID nếu cần
        }

        private void btnDongy_Click_1(object sender, EventArgs e)
        {
            if (_currentMode == Mode.Add) // Nếu đang ở chế độ Thêm
            {
                var nhanvien = new NV(int.Parse(txtMSNV.Text), txtTenNV.Text, double.Parse(txtLuongCB.Text));
                OnAddNhanVien?.Invoke(nhanvien); // Gọi sự kiện thêm
            }
            else if (_currentMode == Mode.Edit) // Nếu đang ở chế độ Sửa
            {
                _nhanVien.TenNV = txtTenNV.Text; // Cập nhật tên
                _nhanVien.LuongCB = double.Parse(txtLuongCB.Text); // Cập nhật lương
                OnSuaNhanVien?.Invoke(_nhanVien); // Gọi sự kiện sửa
            }

            this.Close(); // Đóng Form2
        }

        private void btnBoqua_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
