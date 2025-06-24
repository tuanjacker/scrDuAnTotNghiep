using BUS_Xuong;
using DAL_Xuong;
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
    public partial class frmMuonTra : Form
    {
        BUSMuonTraSach busMuonTraSach = new BUSMuonTraSach();
        public frmMuonTra()
        {
            InitializeComponent();
        }

        private void frmMuonTra_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvMuonTra.DataSource = null;
            dgvMuonTra.DataSource = busMuonTraSach.GetAllMuonTra();

            dgvMuonTra.Columns["MaMuonTra"].HeaderText = "Mã Mượn Trả";
            dgvMuonTra.Columns["MaKhachHang"].HeaderText = "Khách Hàng";
            dgvMuonTra.Columns["MaNhanVien"].HeaderText = "Nhân viên";
            dgvMuonTra.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
            dgvMuonTra.Columns["NgayTra"].HeaderText = "Ngyaf Trả";
            dgvMuonTra.Columns["MaTrangThai"].HeaderText = "Trạng Thái";

            dgvMuonTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            foreach (DataGridViewRow row in dgvMuonTra.Rows)
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
