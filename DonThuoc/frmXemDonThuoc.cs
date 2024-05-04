using QLThuoc.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// # -*- encoding: utf-8 -*-
// # Copyright NaVin Pharmacity (https://github.com/kyoo-147/PharmacityManagement_NaVin) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace QLThuoc.DonThuoc1
{
    public partial class frmXemDonThuoc : Form
    {
        int mIdDonThuoc;
        QLThuocEntities qldt = new QLThuocEntities();
        List<ProductHoaDonVM> productView = new List<ProductHoaDonVM>();
        List<ProductHoaDonVM> fiterproductView = new List<ProductHoaDonVM>();
        public frmXemDonThuoc(int IdDonThuoc=-1)
        {
            InitializeComponent();
            mIdDonThuoc = IdDonThuoc;
            txt_madonthuoc.Text = mIdDonThuoc.ToString();
        }

        private void frmXemDonThuoc_Load(object sender, EventArgs e)
        {
            ////Load Nhan Vien
            //cmb_nhanvien.DataSource = qldt.NhanViens.Where(x => x.DaXoa != true).Select(x => new
            //{
            //    x.MaNV,
            //    x.TenNV
            //}).ToList();
            //cmb_nhanvien.DisplayMember = "TenNV";
            //cmb_nhanvien.ValueMember = "MaNV";
            ////Load chi nhanh
            //cb_machinhanh.DataSource = qldt.ChiNhanhs.Where(x => x.DaXoa != true).Select(x => new
            //{
            //    x.MaChiNhanh,
            //    x.TenChiNhanh
            //}).ToList();
            //cb_machinhanh.DisplayMember = "TenChiNhanh";
            //cb_machinhanh.ValueMember = "MaChiNhanh";

            ////Load Nha cung cap
            //cb_makhachhang.DataSource = qldt.KhachHangs.Where(x => x.DaXoa != true).Select(x => new
            //{
            //    x.MaKH,
            //    x.TenKH
            //}).ToList();
            //cb_makhachhang.DisplayMember = "TenKH";
            //cb_makhachhang.ValueMember = "MaKH";


            // Load Khách Hàng
            cb_makhachhang.DataSource = qldt.DonThuocs
                .Where(sp => sp.MaDon == mIdDonThuoc)
                .Join(qldt.KhachHangs.Where(x => x.DaXoa != true),
                    sp => sp.MaKH,
                    kh => kh.MaKH,
                    (sp, kh) => new
                    {
                        kh.MaKH,
                        kh.TenKH
                    })
                .ToList();

            cb_makhachhang.DisplayMember = "TenKH";
            cb_makhachhang.ValueMember = "MaKH";


            // Load Chi Nhánh
            cb_machinhanh.DataSource = qldt.DonThuocs
                .Where(sp => sp.MaDon == mIdDonThuoc)
                .Join(qldt.ChiNhanhs.Where(x => x.DaXoa != true),
                    sp => sp.MaChiNhanh,
                    ncc => ncc.MaChiNhanh,
                    (sp, ncc) => new
                    {
                        ncc.MaChiNhanh,
                        ncc.TenChiNhanh
                    })
                .ToList();

            cb_machinhanh.DisplayMember = "TenChiNhanh";
            cb_machinhanh.ValueMember = "MaChiNhanh";


            // Load Nhân Viên
            cmb_nhanvien.DataSource = qldt.DonThuocs
                .Where(sp => sp.MaDon == mIdDonThuoc)
                .Join(qldt.NhanViens.Where(x => x.DaXoa != true),
                    sp => sp.MaNV,
                    ncc => ncc.MaNV,
                    (sp, ncc) => new
                    {
                        ncc.MaNV,
                        ncc.TenNV
                    }).ToList();
            cmb_nhanvien.DisplayMember = "TenNV";
            cmb_nhanvien.ValueMember = "MaNV";



            productView = qldt.ChiTietDons.Where(x => x.MaDon == mIdDonThuoc).Select(x => new ProductHoaDonVM()
            {
                MaThuoc = x.Thuoc.MaThuoc,
                TenThuoc = x.Thuoc.TenThuoc,
                SoLuong = (int)x.SoLuong

            }).ToList();
            fiterproductView = productView;
            dgv_Thuoc.DataSource = fiterproductView;


            var thongtinDonThuoc = qldt.DonThuocs.Where(x => x.MaDon == mIdDonThuoc).FirstOrDefault();
            txt_madonthuoc.Text = thongtinDonThuoc.MaDon.ToString();
            txt_ngaylap.Text = thongtinDonThuoc.NgayLap.ToString();
            

            var madonthuoc = mIdDonThuoc.ToString();
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(madonthuoc, 50);
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Jpeg image | *.jpg";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                string path1 = saveFileDialog1.FileName;
                pictureBox1.Image.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Save Successful");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmXemCTDonThuoc frmXemCTDonThuoc = new frmXemCTDonThuoc(mIdDonThuoc);
            frmXemCTDonThuoc.ShowDialog();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
