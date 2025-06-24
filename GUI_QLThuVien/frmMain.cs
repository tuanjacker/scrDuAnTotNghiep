﻿using System;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form currentFormChild;

        private void openChildForm(Form formChild)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            pnMain.Controls.Add(formChild);
            pnMain.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();

        }

        private void btnQLSach_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "QUẢN LÝ SÁCH";
            openChildForm(new frmSach());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "QUẢN LÝ NHÂN VIÊN";
            openChildForm(new frmNhanVien());
        }

        private void txtTitle_Resize(object sender, EventArgs e)
        {
            txtTitle.Left = (this.ClientSize.Width - txtTitle.Width) / 2;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "MƯỢN TRẢ SÁCH";
            openChildForm(new frmMuonTraSach());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtTitle.Text = "MƯỢN TRẢ SÁCH";
            openChildForm(new frmMuonTraSach());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "ĐỌC GIẢ";
            openChildForm(new frmKhachHang());
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "MƯỢN TRẢ SÁCH";
            openChildForm(new frmMuonTra());
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "BÁO CÁO - THỐNG KÊ";
            openChildForm(new frmReport());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "Cài Đặt";
            openChildForm(new frmSetting());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
