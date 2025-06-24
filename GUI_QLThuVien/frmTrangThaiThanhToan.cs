using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Xuong;
using DTO_Xuong;

namespace GUI_QLThuVien
{
    public partial class frmTrangThaiThanhToan : Form
    {
        public frmTrangThaiThanhToan()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            txtMaTrangThai.Clear();
            txtTenTrangThai.Clear();
            rdoHoatDong.Checked = true;
            dtNgayTao.Value = DateTime.Now;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaTrangThai.Enabled = true;
        }
        private void LoadTrangThaiThanhToan()
        {
            // Khởi tạo BUS (hoặc DAL) để lấy dữ liệu
            var bus = new BUSTrangThaiThanhToan();
            var list = bus.GetAllTrangThaiThanhToan();

            // Gán dữ liệu cho DataGridView
            dgvtttt.DataSource = null;
            dgvtttt.DataSource = list;

            // Tuỳ chọn: Đặt lại header cho các cột nếu cần
            if (dgvtttt.Columns["MaTrangThai"] != null)
                dgvtttt.Columns["MaTrangThai"].HeaderText = "Mã Trạng Thái";
            if (dgvtttt.Columns["TenTrangThai"] != null)
                dgvtttt.Columns["TenTrangThai"].HeaderText = "Tên Trạng Thái";
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string KeyWork = txtTimKiem.Text;
            if (!string.IsNullOrWhiteSpace(KeyWork))
            {
                SearchInAllCells(KeyWork);
            }
        }
        private void SearchInAllCells(string keyWork)
        {
            foreach (DataGridViewRow row in dgvtttt.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(keyWork.ToLower()))
                    {

                        row.Selected = true;
                        break;
                    }
                    else
                    {
                        row.Selected = false;
                    }
                }

            }
        }

        private void frmTrangThaiThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
