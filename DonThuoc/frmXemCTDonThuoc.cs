using Guna.UI2.WinForms;
using QLThuoc.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// # -*- encoding: utf-8 -*-
// # Copyright NaVin Pharmacity (https://github.com/kyoo-147/PharmacityManagement_NaVin) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace QLThuoc.DonThuoc1
{
    public partial class frmXemCTDonThuoc : Form
    {
        QLThuocEntities qldt = new QLThuocEntities();
        List<ProductHoaDonVM> dsdt = new List<ProductHoaDonVM>();
        int mIdDonThuoc;
        public frmXemCTDonThuoc(int maHD)
        {
            InitializeComponent();
            mIdDonThuoc = maHD;
        }

        private void frmXemCTDonThuoc_Load(object sender, EventArgs e)
        {
            var thongtinsp = qldt.DonThuocs.Where(x => x.MaDon == mIdDonThuoc).FirstOrDefault();
            cbm_Tenthuoc.DataSource = qldt.Thuocs.Select(x => new
            {
                MaSP = x.MaThuoc,
                TenSp = x.TenThuoc
            }).ToList();
            cbm_Tenthuoc.ValueMember = "MaSP";
            cbm_Tenthuoc.DisplayMember = "TenSp";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            ThemSp();
        }

        private void cbm_Tenthuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbm_Tenthuoc.DataSource = qldt.Thuocs.Select(x => new
            //{
            //    MaSP = x.MaThuoc,
            //    TenSp = x.TenThuoc
            //}).ToList();
            //cbm_Tenthuoc.ValueMember = "MaSP";
            //cbm_Tenthuoc.DisplayMember = "TenThuoc";
        }

        public void ThemSp()
        {
            ProductHoaDonVM sp = new ProductHoaDonVM();
            sp.MaThuoc = int.Parse(cbm_Tenthuoc.SelectedValue.ToString());
            sp.TenThuoc = cbm_Tenthuoc.Text.ToString();
            sp.SoLuong = int.Parse(txt_SL.Text);
            dsdt.Add(sp);
            MessageBox.Show("The number of products: " + dsdt.Count().ToString(),"Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadLuoi();
        }

        public void loadLuoi()
        {
            dgv_Thongtin.DataSource = null;
            dgv_Thongtin.DataSource = dsdt;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            //frmDonThuoc frmDonThuoc = new frmDonThuoc();    
            //foreach(var cthd in dsdt)
            //{
            //    ChiTietDon chiTietDon = new ChiTietDon();
            //    chiTietDon.MaDon = mIdDonThuoc; 
            //    chiTietDon.MaThuoc = cthd.MaThuoc;
            //    chiTietDon.SoLuong = cthd.SoLuong;
            //    int thanhtien = 0;
            //    thanhtien = cthd.SoLuong * 10000;
            //    chiTietDon.ThanhTien = thanhtien;
            //    chiTietDon.DaXoa = false;
            //    qldt.ChiTietDons.Add(chiTietDon);
            //}
            //qldt.SaveChanges();
            //MessageBox.Show("Lưu Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Close();
            frmDonThuoc frmDonThuoc = new frmDonThuoc();

            foreach (var cthd in dsdt)
            {
                ChiTietDon chiTietDon = new ChiTietDon();

                // Các thuộc tính của chi tiết đơn
                chiTietDon.MaDon = mIdDonThuoc;
                chiTietDon.MaThuoc = cthd.MaThuoc;
                chiTietDon.SoLuong = cthd.SoLuong;

                // Tính toán thành tiền
                int thanhtien = cthd.SoLuong * 10000;
                chiTietDon.ThanhTien = thanhtien;

                chiTietDon.DaXoa = false;

                // Thêm chi tiết đơn vào DbSet
                qldt.ChiTietDons.Add(chiTietDon);
            }

            // Lưu thay đổi vào cơ sở dữ liệu
            qldt.SaveChanges();

            MessageBox.Show("Save Successful", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Thongtin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                int selectID = (int)dgv_Thongtin.Rows[e.RowIndex].Cells[1].Value;
                var itemCanXoa = qldt.ChiTietDons.Where(x => x.DaXoa != true && x.MaCTDT == selectID).FirstOrDefault();

                MessageBox.Show("Delete", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadLuoi();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
