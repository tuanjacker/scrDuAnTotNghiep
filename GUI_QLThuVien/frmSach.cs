using BUS_Xuong;
using DAL_Xuong;
using DTO_Xuong;
using Guna.UI2.WinForms;
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
    public partial class frmSach : Form
    {

        BUSSach busSach = new BUSSach();
        public frmSach()
        {
            InitializeComponent();
        }

        private void tabSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabSach.SelectedTab != null)
            {
                if (tabSach.SelectedTab.Name == "qlPhiSach")
                {
                    TabPage tab = tabSach.SelectedTab;
                    frmPhiSach frm = new frmPhiSach();
                    if (tabSach.SelectedTab.Name == "qlPhiSach")
                    {
                        frm.TopLevel = false;
                        frm.FormBorderStyle = FormBorderStyle.None;
                        frm.Dock = DockStyle.Fill;

                        tab.Controls.Add(frm);
                        frm.Show();
                        return;
                    }
                }
                else if (tabSach.SelectedTab.Name == "qlLoaiSach")
                {
                    TabPage tab = tabSach.SelectedTab;
                    frmTheLoaiSach frm = new frmTheLoaiSach();
                    if (tabSach.SelectedTab.Name == "qlLoaiSach")
                    {
                        frm.TopLevel = false;
                        frm.FormBorderStyle = FormBorderStyle.None;
                        frm.Dock = DockStyle.Fill;

                        tab.Controls.Add(frm);
                        frm.Show();
                        return;
                    }
                }

                else if (tabSach.SelectedTab.Name == "qlTacGia")
                {
                    TabPage tab = tabSach.SelectedTab;
                    frmTacGia frm = new frmTacGia();
                    if (tabSach.SelectedTab.Name == "qlTacGia")
                    {
                        frm.TopLevel = false;
                        frm.FormBorderStyle = FormBorderStyle.None;
                        frm.Dock = DockStyle.Fill;

                        tab.Controls.Add(frm);
                        frm.Show();
                        return;
                    }
                }

            }
        }

        private void LoadDataToGrid()
        {
            var ds = busSach.GetAllSach();
            dgvSach.DataSource = null;
            dgvSach.AutoGenerateColumns = false; // Tắt tự động tạo cột

            // Xóa các cột cũ để tránh trùng lặp
            dgvSach.Columns.Clear();

            // Tạo các cột thủ công với Name và DataPropertyName
            dgvSach.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaSach", DataPropertyName = "MaSach", HeaderText = "Mã sách" });
            dgvSach.Columns.Add(new DataGridViewTextBoxColumn { Name = "TieuDe", DataPropertyName = "TieuDe", HeaderText = "Tên sách" });
            dgvSach.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaTheLoai", DataPropertyName = "MaTheLoai", HeaderText = "Mã thể loại" });
            dgvSach.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaTacGia", DataPropertyName = "MaTacGia", HeaderText = "Tác giả" });
            dgvSach.Columns.Add(new DataGridViewTextBoxColumn { Name = "NhaXuatBan", DataPropertyName = "NhaXuatBan", HeaderText = "Nhà xuất bản" });
            dgvSach.Columns.Add(new DataGridViewTextBoxColumn { Name = "SoLuongTon", DataPropertyName = "SoLuongTon", HeaderText = "Số lượng tồn" });
            dgvSach.Columns.Add(new DataGridViewTextBoxColumn { Name = "TrangThai", DataPropertyName = "TrangThai", HeaderText = "Trạng thái" });

            dgvSach.DataSource = ds;

        }
        private Sach GetSachFromForm()
        {
            return new Sach
            {
                MaSach = txtMaSach.Text.Trim(),
                TieuDe = txtTenSach.Text.Trim(),
                MaTheLoai = cbTheLoai.ValueMember,
                MaTacGia = cbTacGia.ValueMember,
                NhaXuatBan = cbNhaXuatBan.ValueMember,
                SoLuongTon = int.TryParse(txtsoluong.Text.Trim(), out int sl) ? sl : 0,
            };
        }
        private void ClearForm()
        {
            txtMaSach.Clear();
            txtTenSach.Clear();
            cbTheLoai.SelectedIndex = -1;
            cbTacGia.SelectedIndex = -1;
            cbNhaXuatBan.SelectedIndex = -1;
            txtsoluong.Clear();

        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            ClearForm();
            LoadDataToGrid();
        }



        private void dgvSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            string KeyWork = txtTimKiem.Text;
            if (!string.IsNullOrWhiteSpace(KeyWork))
            {
                SearchInAllCells(KeyWork);
            }
        }
        private void SearchInAllCells(string keyWork)
        {
            foreach (DataGridViewRow row in dgvSach.Rows)
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

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Sach sach = GetSachFromForm();

            if (string.IsNullOrWhiteSpace(sach.MaSach) || string.IsNullOrWhiteSpace(sach.TieuDe))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sách.");
                return;
            }

            string result = busSach.InsertSach(sach);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Thêm sách thành công!");
                ClearForm();
                LoadDataToGrid();
            }
            else
            {
                MessageBox.Show("Lỗi: " + result);
            }
        }

        //sua
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Sach sach = GetSachFromForm();

            if (string.IsNullOrWhiteSpace(sach.MaSach))
            {
                MessageBox.Show("Vui lòng chọn sách để sửa.");
                return;
            }

            string result = busSach.UpdateSach(sach);

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Cập nhật sách thành công!");
                ClearForm();
                LoadDataToGrid();
                txtMaSach.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lỗi: " + result);
            }

        }

        private void xoa_Click(object sender, EventArgs e)
        {
            string maSach = txtMaSach.Text.Trim();
            if (string.IsNullOrEmpty(maSach))
            {
                MessageBox.Show("Vui lòng chọn sách để xoá.");
                return;
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xoá sách {maSach}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                string result = busSach.DeleteSach(maSach);
                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Xoá sách thành công!");
                    ClearForm();
                    LoadDataToGrid();
                    txtMaSach.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Lỗi: " + result);
                }
            }
        }

        private void lammoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDataToGrid();
            txtMaSach.Enabled = true;
        }

        private void dgvSach_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSach.Rows[e.RowIndex];
                txtMaSach.Text = row.Cells["MaSach"].Value.ToString();
                txtTenSach.Text = row.Cells["TieuDe"].Value.ToString();
                cbTheLoai.SelectedValue = row.Cells["MaTheLoai"].Value;
                cbTacGia.SelectedValue = row.Cells["MaTacGia"].Value;
                cbNhaXuatBan.SelectedValue = row.Cells["NhaXuatBan"].Value;
                txtsoluong.Text = row.Cells["SoLuongTon"].Value.ToString();

                // Không cho sửa mã sách
                txtMaSach.Enabled = false;
            }
        }
    }
}

