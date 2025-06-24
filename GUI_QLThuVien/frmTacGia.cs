using BUS_Xuong;
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
    public partial class frmTacGia : Form
    {
        BUSTacGia busTacGia = new BUSTacGia();
        public frmTacGia()
        {
            InitializeComponent();
        }
        private void LoadDanhSachTacGia()
        {
            dgvTacGia.DataSource = null;
            dgvTacGia.DataSource = busTacGia.GetAllTacGia();

            dgvTacGia.Columns["MaTacGia"].HeaderText = "Mã Tác Giả";
            dgvTacGia.Columns["TenTacGia"].HeaderText = "Tên Tác Giả";
            dgvTacGia.Columns["QuocTich"].HeaderText = "Quốc Tịch";
            dgvTacGia.Columns["TrangThai"].HeaderText = "Trạng Thái";

            dgvTacGia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void ClearForm()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            txtMaTacGia.Clear();
            txtQuocTich.Clear();
            rdoHoatDong.Checked = true;
        }
        private TacGia GetTacGiaFromForm()
        {
            return new TacGia
            {
                MaTacGia = txtMaTacGia.Text.Trim(),
                TenTacGia = txtTenTacGia.Text.Trim(),
                QuocTich = txtQuocTich.Text.Trim(),
                TrangThai = rdoHoatDong.Checked
            };
        }


        private void frmTacGia_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachTacGia();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TacGia tg = GetTacGiaFromForm();

            if (string.IsNullOrWhiteSpace(tg.MaTacGia) || string.IsNullOrWhiteSpace(tg.TenTacGia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tác giả.");
                return;
            }

            string result = busTacGia.InsertTacGia(tg);
            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Thêm tác giả thành công!");
                LoadDanhSachTacGia();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Lỗi: " + result);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TacGia tg = GetTacGiaFromForm();

            if (string.IsNullOrWhiteSpace(tg.MaTacGia))
            {
                MessageBox.Show("Vui lòng chọn tác giả cần sửa.");
                return;
            }

            string result = busTacGia.UpdateTacGia(tg);
            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật tác giả thành công!");
                LoadDanhSachTacGia();
                ClearForm();
                txtMaTacGia.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lỗi: " + result);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maTacGia = txtMaTacGia.Text.Trim();
            if (string.IsNullOrWhiteSpace(maTacGia))
            {
                MessageBox.Show("Vui lòng chọn tác giả để xoá.");
                return;
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xoá tác giả {maTacGia}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string result = busTacGia.DeleteTacGia(maTacGia);
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Xoá tác giả thành công!");
                    LoadDanhSachTacGia();
                    ClearForm();
                    txtMaTacGia.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Lỗi: " + result);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDanhSachTacGia();
            txtMaTacGia.Enabled = true;
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
            foreach (DataGridViewRow row in dgvTacGia.Rows)
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

        private void dgvTacGia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTacGia.Rows[e.RowIndex];
                txtMaTacGia.Text = row.Cells["MaTacGia"].Value.ToString();
                txtTenTacGia.Text = row.Cells["TenTacGia"].Value.ToString();
                txtQuocTich.Text = row.Cells["QuocTich"].Value.ToString();

                int trangThai = Convert.ToInt32(row.Cells["TrangThai"].Value);
                rdoHoatDong.Checked = trangThai == 1;
                rdoKhongHoatDong.Checked = trangThai == 0;

                txtMaTacGia.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
            }
        }
    }
}
