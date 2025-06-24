using BUS_Xuong;
using DAL_Xuong;
using DTO_Xuong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLThuVien
{
    public partial class frmTheLoaiSach : Form
    {
        BUSTheLoaiSach BUSTheLoaiSach = new BUSTheLoaiSach();
        public frmTheLoaiSach()
        {
            InitializeComponent();
        }

        private void LoadDanhSachLoaiSach()
        {
            dgvTheLoaiSach.DataSource = null;
            dgvTheLoaiSach.DataSource = BUSTheLoaiSach.GetAllTheLoaiSach();

            dgvTheLoaiSach.Columns["MaTheLoai"].HeaderText = "Mã Thể Loại";
            dgvTheLoaiSach.Columns["TenTheLoai"].HeaderText = "Tên Thể Loại";
            dgvTheLoaiSach.Columns["TrangThai"].HeaderText = "Trạng Thái";

            dgvTheLoaiSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void ClearForm()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            txtTenTheLoai.Clear();
            rdoHoatDong.Checked = true;
        }

        private void frmTheLoaiSach_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachLoaiSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maTL = txtMaTheLoai.Text.Trim();
                string tenTL = txtTenTheLoai.Text.Trim();
                bool trangThai = rdoHoatDong.Checked;
                DateTime ngayTao = ngaytaodt.Value; // ← dùng DateTimePicker đã gán trên form (không nên hardcode DateTime.Now)

                // Kiểm tra dữ liệu
                if (string.IsNullOrEmpty(maTL) || string.IsNullOrEmpty(tenTL))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin thể loại.");
                    return;
                }

                // Tạo đối tượng
                TheLoaiSach theLoai = new TheLoaiSach
                {
                    MaTheLoai = maTL,
                    TenTheLoai = tenTL,
                    TrangThai = trangThai,
                    NgayTao = ngayTao
                };

                // Gọi BUS
                string result = BUSTheLoaiSach.InsertTheLoaiSach(theLoai);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Thêm thể loại thành công!");
                    ClearForm();
                    LoadDanhSachLoaiSach();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm thể loại: " + ex.Message);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ form
                string maTL = txtMaTheLoai.Text.Trim();
                string tenTL = txtTenTheLoai.Text.Trim();
                bool trangThai = rdoHoatDong.Checked; // True nếu đang hoạt động
                DateTime ngayTao = ngaytaodt.Value;

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(maTL) || string.IsNullOrEmpty(tenTL))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng thể loại sách
                TheLoaiSach tls = new TheLoaiSach
                {
                    MaTheLoai = maTL,
                    TenTheLoai = tenTL,
                    TrangThai = trangThai,
                    NgayTao = ngayTao
                };

                // Gọi BUS để cập nhật
                BUSTheLoaiSach bus = new BUSTheLoaiSach();
                string result = bus.UpdateTheLoaiSach(tls);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Sửa thể loại sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachLoaiSach();
                }
                else
                {
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTheLoai.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string maKH = txtMaTheLoai.Text.Trim();
                BUSKhachHang bllnhanvien = new BUSKhachHang();

                try
                {
                    bllnhanvien.DeleteKhachHang(maKH);
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadDanhSachLoaiSach();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvTheLoaiSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không phải header hoặc hàng không hợp lệ
            {
                DataGridViewRow row = dgvTheLoaiSach.Rows[e.RowIndex];

                // Gán dữ liệu từ DataGridView vào các control
                txtMaTheLoai.Text = row.Cells["MaTheLoai"].Value?.ToString();
                txtTenTheLoai.Text = row.Cells["TenTheLoai"].Value?.ToString();

                // Chuyển đổi trạng thái từ chuỗi sang radio button
                string trangThai = row.Cells["TrangThai"].Value?.ToString();
                if (trangThai == "Đang hoạt động")
                    rdoHoatDong.Checked = true;
                else
                    rdoKhongHoatDong.Checked = true;

                // Đặt ngày tạo (nếu có cột ngày tạo)
                if (row.Cells["NgayTao"].Value != null &&
                    DateTime.TryParse(row.Cells["NgayTao"].Value.ToString(), out DateTime ngayTao))
                {
                    ngaytaodt.Value = ngayTao;
                }

                // Chuyển sang chế độ sửa
                txtMaTheLoai.Enabled = false; // Không cho sửa mã thể loại
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
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
            foreach (DataGridViewRow row in dgvTheLoaiSach.Rows)
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
    }
}
