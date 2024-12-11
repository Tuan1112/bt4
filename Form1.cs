using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using bt4;

namespace bt4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false; // Đặt AutoGenerateColumns là false nếu bạn thêm cột thủ công
        }

        private BindingSource bindingSource;
        private List<NV> danhSachNhanVien;

        private void Form1_Load(object sender, EventArgs e)
        {
            danhSachNhanVien = new List<NV>
            {
                new NV() { MSNV = 1, TenNV = "A", LuongCB = 20 },
                new NV() { MSNV = 2, TenNV = "B", LuongCB = 30 },
                new NV() { MSNV = 3, TenNV = "C", LuongCB = 40 }
            };

            // Xóa các cột hiện có
            dataGridView1.Columns.Clear();

            // Thêm các cột thủ công
            if (dataGridView1.Columns.Count == 0) // Kiểm tra xem cột đã được thêm chưa
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "MSNV", HeaderText = "MSNV" });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "TenNV", HeaderText = "Tên Nhân Viên" });
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "LuongCB", HeaderText = "Lương Căn Bản" });
            }

            bindingSource = new BindingSource { DataSource = danhSachNhanVien };
            dataGridView1.DataSource = bindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNhanVien frm2 = new frmNhanVien();
            frm2.OnAddNhanVien += AddNhanVien;
            frm2.ShowDialog();
        }

        private void AddNhanVien(NV nhanvien)
        {
            danhSachNhanVien.Add(nhanvien);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachNhanVien;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedNhanVien = (NV)selectedRow.DataBoundItem;

                frmNhanVien frm2 = new frmNhanVien(selectedNhanVien);
                frm2.OnSuaNhanVien += UpdateNhanVien;
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa.");
            }
        }

        private void UpdateNhanVien(NV nhanvien)
        {
            var original = danhSachNhanVien.FirstOrDefault(nv => nv.MSNV == nhanvien.MSNV);
            if (original != null)
            {
                original.TenNV = nhanvien.TenNV;
                original.LuongCB = nhanvien.LuongCB;
            }
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachNhanVien;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var selectedNhanVien = (NV)selectedRow.DataBoundItem;

                var result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa nhân viên này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    danhSachNhanVien.Remove(selectedNhanVien);
                    UpdateDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa.");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
