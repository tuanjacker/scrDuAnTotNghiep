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
    public partial class frmKhachHang : Form
    {
        BUSKhachHang busKhachHang = new BUSKhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKhachHang.Text.Trim();
            string hoTen = txtTenKhachHang.Text.Trim();
            string email = txtEmail.Text.Trim();
            string cccd = txtCCCD.Text.Trim();
            string phone = txtSoDienThoai.Text.Trim();

            bool trangThai;

            if (rdoHoatDong.Checked)
            {
                trangThai = true;
            }
            else
            {
                trangThai = false;
            }
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(cccd))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khách hàng.");
                return;
            }

            KhachHang kh = new KhachHang
            {
                MaKhachHang = maKH,
                TenKhachHang = hoTen,
                Email = email,
                CCCD = cccd,
                SoDienThoai = phone,
                TrangThai = trangThai
            };
            string result = busKhachHang.InsertKhachHang(kh);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật thông tin thành công");
                ClearForm();
                LoadKhachHang();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ form
                string maKH = txtMaKhachHang.Text.Trim();
                string tenKH = txtTenKhachHang.Text.Trim();
                string emailKH = txtEmail.Text.Trim();
                string soDienThoai = txtSoDienThoai.Text.Trim();
                string cccd = txtCCCD.Text.Trim();
                bool trangThai = rdoHoatDong.Checked; // True nếu "Đang hoạt động"
            

                // Kiểm tra dữ liệu nhập vào
                if (string.IsNullOrEmpty(maKH) ||
                    string.IsNullOrEmpty(tenKH) ||
                    string.IsNullOrEmpty(emailKH) ||
                    string.IsNullOrEmpty(soDienThoai) ||
                    string.IsNullOrEmpty(cccd))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng khách hàng
                KhachHang kh = new KhachHang
                {
                    MaKhachHang = maKH,
                    TenKhachHang = tenKH,
                    Email = emailKH,
                    SoDienThoai = soDienThoai,
                    CCCD = cccd,
                    TrangThai = trangThai,
                  
                };

                // Gọi BUS để cập nhật khách hàng
                BUSKhachHang busKhachHang = new BUSKhachHang();
                string result = busKhachHang.UpdateKhachHang(kh);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Sửa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadKhachHang();
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
            if (string.IsNullOrEmpty(txtMaKhachHang.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string maKH = txtMaKhachHang.Text.Trim();
                BUSKhachHang bllnhanvien = new BUSKhachHang();

                try
                {
                    bllnhanvien.DeleteKhachHang(maKH);
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadKhachHang();
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
            LoadKhachHang();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadKhachHang();
        }

        private void LoadKhachHang()
        {
            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = busKhachHang.GetKhachHangList();

            dgvKhachHang.Columns["MaKhachHang"].HeaderText = "Mã Khách Hàng";
            dgvKhachHang.Columns["TenKhachHang"].HeaderText = "Họ Tên";
            dgvKhachHang.Columns["Email"].HeaderText = "Email";
            dgvKhachHang.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dgvKhachHang.Columns["CCCD"].HeaderText = "Vai Trò";
            dgvKhachHang.Columns["TrangThaiText"].HeaderText = "Trạng Thái";
            dgvKhachHang.Columns["NgayTao"].Visible = false;
            dgvKhachHang.Columns["TrangThai"].Visible = false;

            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void ClearForm()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            txtMaKhachHang.Clear();
            txtTenKhachHang.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            txtCCCD.Clear();
            rdoHoatDong.Checked = true;
        }

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
            // Đổ dữ liệu vào các ô nhập liệu trên form
            txtMaKhachHang.Text = row.Cells["MaKhachHang"].Value.ToString();
            txtTenKhachHang.Text = row.Cells["TenKhachHang"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            txtCCCD.Text = row.Cells["CCCD"].Value.ToString();
            txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value.ToString();

            bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
            if (trangThai == false)
            {
                rdoKhongHoatDong.Checked = true;
            }
            else
            {
                rdoHoatDong.Checked = true;
            }

            // Bật nút "Sửa"
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            // Tắt chỉnh sửa mã nhân viên
            txtMaKhachHang.Enabled = false;
        }
    }
}
