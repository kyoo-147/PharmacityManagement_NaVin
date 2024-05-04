using Microsoft.Win32;
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

namespace QLThuoc.KhachHang1
{
    public partial class frmXemKhachHang : Form
    {
        int mIdKH;
        QLThuocEntities qlkh = new QLThuocEntities();
        public frmXemKhachHang(int IdKH =-1)
        {
            InitializeComponent();
            mIdKH = IdKH;
            txt_makh.Text = mIdKH.ToString();
        }

        private void frmXemKhachHang_Load(object sender, EventArgs e)
        {
            var thongTinKH = qlkh.KhachHangs.Where(x => x.MaKH == mIdKH).FirstOrDefault();
            txt_makh.Text = thongTinKH.MaKH.ToString();
            txt_tenkh.Text = thongTinKH.TenKH.ToString();
            txt_diachi.Text = thongTinKH.DiaChi.ToString();
            txt_sdt.Text = thongTinKH.SDT.ToString();


            var khachhang = mIdKH.ToString();
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(khachhang, 50);

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
