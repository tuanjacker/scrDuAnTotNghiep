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
    public partial class frmPhiSach : Form
    {
        BUSPhiSach busPhiSach = new BUSPhiSach();
        public frmPhiSach()
        {
            InitializeComponent();
        }

        private void frmPhiSach_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachPhiSach();
        }

        private void LoadDanhSachPhiSach()
        {
            dgvPhiSach.DataSource = null;
            dgvPhiSach.DataSource = busPhiSach.GetAllPhiSach();

            dgvPhiSach.Columns["MaPhiSach"].HeaderText = "Mã Phí Sách";
            dgvPhiSach.Columns["MaSach"].HeaderText = "Mã Sách";
            dgvPhiSach.Columns["PhiMuon"].HeaderText = "Phí Mượn";
            dgvPhiSach.Columns["PhiPhat"].HeaderText = "Phí Phạt";
            dgvPhiSach.Columns["TrangThai"].HeaderText = "Trạng Thái";

            dgvPhiSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void ClearForm()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            txtMaPhiSach.Clear();
            txtMaSach.Clear();
            txtPhiMuon.Clear();
            txtPhiPhat.Clear();
            rdoHoatDong.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhi = txtMaPhiSach.Text.Trim();
            string maSach = txtMaSach.Text.Trim();
            string phiMuon = txtPhiMuon.Text.Trim();
            string phiPhat = txtPhiPhat.Text.Trim();
            bool trangThai = rdoHoatDong.Checked;

            if (string.IsNullOrWhiteSpace(maPhi) || string.IsNullOrWhiteSpace(maSach) ||
                string.IsNullOrWhiteSpace(phiMuon) || string.IsNullOrWhiteSpace(phiPhat))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            PhiSach ps = new PhiSach
            {
                MaPhiSach = maPhi,
                MaSach = maSach,
                PhiMuon = decimal.Parse(phiMuon),
                PhiPhat = decimal.Parse(phiPhat),
                TrangThai = trangThai
            };

            string kq = busPhiSach.InsertPhiSach(ps);

            if (string.IsNullOrEmpty(kq))
            {
                MessageBox.Show("Thêm thành công!");
                ClearForm();
                LoadDanhSachPhiSach();
            }
            else
            {
                MessageBox.Show("Lỗi: " + kq);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maPhi = txtMaPhiSach.Text.Trim();
            string maSach = txtMaSach.Text.Trim();
            string phiMuon = txtPhiMuon.Text.Trim();
            string phiPhat = txtPhiPhat.Text.Trim();
            bool trangThai = rdoHoatDong.Checked;

            if (string.IsNullOrWhiteSpace(maPhi))
            {
                MessageBox.Show("Vui lòng chọn bản ghi để sửa.");
                return;
            }

            PhiSach ps = new PhiSach
            {
                MaPhiSach = maPhi,
                MaSach = maSach,
                PhiMuon = decimal.Parse(phiMuon),
                PhiPhat = decimal.Parse(phiPhat),
                TrangThai = trangThai
            };

            string kq = busPhiSach.UpdatePhiSach(ps);

            if (string.IsNullOrEmpty(kq))
            {
                MessageBox.Show("Cập nhật thành công!");
                ClearForm();
                LoadDanhSachPhiSach();
            }
            else
            {
                MessageBox.Show("Lỗi: " + kq);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maPhi = txtMaPhiSach.Text.Trim();

            if (string.IsNullOrWhiteSpace(maPhi))
            {
                MessageBox.Show("Vui lòng chọn bản ghi để xoá.");
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xoá phí sách này?", "Xác nhận xoá",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                string kq = busPhiSach.DeletePhiSach(maPhi);

                if (string.IsNullOrEmpty(kq))
                {
                    MessageBox.Show("Xoá thành công!");
                    ClearForm();
                    LoadDanhSachPhiSach();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + kq);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachPhiSach();
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
            foreach (DataGridViewRow row in dgvPhiSach.Rows)
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

        private void dgvPhiSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhiSach.Rows[e.RowIndex];

                txtMaPhiSach.Text = row.Cells["MaPhiSach"].Value.ToString();
                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtPhiMuon.Text = row.Cells["PhiMuon"].Value.ToString();
                txtPhiPhat.Text = row.Cells["PhiPhat"].Value.ToString();

                bool trangThai = Convert.ToBoolean(row.Cells["TrangThai"].Value);
                rdoHoatDong.Checked = trangThai;
                rdoKhongHoatDong.Checked = !trangThai;

                txtMaPhiSach.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
    }
}
