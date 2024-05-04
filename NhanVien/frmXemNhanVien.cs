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

namespace QLThuoc.NhanVien1
{
    public partial class frmXemNhanVien : Form
    {
        int mIdNV;
        QLThuocEntities qlnv = new QLThuocEntities();
        public frmXemNhanVien(int IdNV = -1)
        {
            InitializeComponent();
            mIdNV = IdNV;
            txt_manv.Text = mIdNV.ToString();
        }

        private void frmXemNhanVien_Load(object sender, EventArgs e)
        {
            var thongTinNV = qlnv.NhanViens.Where(x=>x.MaNV == mIdNV).FirstOrDefault();
            txt_manv.Text = thongTinNV.MaNV.ToString();
            txt_tennv.Text = thongTinNV.TenNV.ToString();
            txt_ngaysinh.Text = thongTinNV.NgaySinh.ToString();
            txt_cv.Text = thongTinNV.ChucVu.ToString();

            var nhanvien = mIdNV.ToString();
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(nhanvien, 50);
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

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
