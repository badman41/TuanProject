﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DXApplication1.View._Form;
using DXApplication1.View._UC;
using DXApplication1.View.Report;
using DevExpress.XtraReports.UI;

namespace DXApplication1
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        FormDangNhap frm;
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Báo_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frm = new FormDangNhap();
            frm.ShowDialog();

        }

        private void barButtonItem8_ItemClick_1(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem8_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            pnlMain.Controls.Clear();
            UC_NguoiDung frmNV = new UC_NguoiDung();
            pnlMain.Controls.Add(frmNV);
            frmNV.loadData();
          
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlMain.Controls.Clear();
            UCTaiKhoan frmTK = new UCTaiKhoan();
            pnlMain.Controls.Add(frmTK);
           
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlMain.Controls.Clear();
            UCPhieuNhap frmTK = new UCPhieuNhap();
            pnlMain.Controls.Add(frmTK);
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlMain.Controls.Clear();
            UC_HDB uchdb = new UC_HDB();
            pnlMain.Controls.Add(uchdb);

        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlMain.Controls.Clear();
            UCPhieuXuat uchdb = new UCPhieuXuat();
            pnlMain.Controls.Add(uchdb);
        }

        private void Bao_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlMain.Controls.Clear();
            UCHangBan uchdb = new UCHangBan();
            pnlMain.Controls.Add(uchdb);

        }

        private void T_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlMain.Controls.Clear();
            chartHangBan uchdb = new chartHangBan();
            pnlMain.Controls.Add(uchdb);
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlMain.Controls.Clear();
            UCHangNhap uchdb = new UCHangNhap();
            pnlMain.Controls.Add(uchdb);
        }

        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlMain.Controls.Clear();
            chartHangNhap uchdb = new chartHangNhap();
            pnlMain.Controls.Add(uchdb);
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlMain.Controls.Clear();
            UCTonKho uchdb = new UCTonKho();
            pnlMain.Controls.Add(uchdb);
        }

        private void Th_ItemClick(object sender, ItemClickEventArgs e)
        {
            pnlMain.Controls.Clear();
            chartTonKho uchdb = new chartTonKho();
            pnlMain.Controls.Add(uchdb);
        }

        private void barButtonItem26_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            pnlMain.Controls.Clear();
            chartDoanhThu uchdb = new chartDoanhThu();
            pnlMain.Controls.Add(uchdb);
        }

        private void Báo_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            pnlMain.Controls.Clear();
            UCDoanhThu uchdb = new UCDoanhThu();
            pnlMain.Controls.Add(uchdb);
        }

        private void navBarControl2_Click(object sender, EventArgs e)
        {
           
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pnlMain.Controls.Clear();
            UCPhieuNhap uchdb = new UCPhieuNhap();
            pnlMain.Controls.Add(uchdb);
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pnlMain.Controls.Clear();
            UCPhieuXuat uchdb = new UCPhieuXuat();
            pnlMain.Controls.Add(uchdb);
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pnlMain.Controls.Clear();
            UC_HDB uchdb = new UC_HDB();
            pnlMain.Controls.Add(uchdb);
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pnlMain.Controls.Clear();
            UCHangBan uchdb = new UCHangBan();
            pnlMain.Controls.Add(uchdb);
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pnlMain.Controls.Clear();
            UCHangNhap uchdb = new UCHangNhap();
            pnlMain.Controls.Add(uchdb);
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pnlMain.Controls.Clear();
            UCTonKho uchdb = new UCTonKho();
            pnlMain.Controls.Add(uchdb);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            pnlMain.Controls.Clear();
            UCDoanhThu uchdb = new UCDoanhThu();
            pnlMain.Controls.Add(uchdb);
        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất khỏi tài khoản này?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Enabled = false;
                frm = new FormDangNhap();
                frm.ShowDialog();
                this.Enabled = true;
            }

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoiMK frmdmk = new frmDoiMK();
            frmdmk.ShowDialog();
      
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDangKyTK frmdk = new frmDangKyTK();
            frmdk.ShowDialog();
        }
    }
}