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

namespace QLThuoc.LoaiThuoc1
{
    public partial class frmXemLoaiThuoc : Form
    {
        int mIdLoaiThuoc;
        QLThuocEntities qllt = new QLThuocEntities();
        public frmXemLoaiThuoc(int IdLoaiThuoc = -1)
        {
            InitializeComponent();
            mIdLoaiThuoc = IdLoaiThuoc;
            txt_maloaithuoc.Text = mIdLoaiThuoc.ToString();
        }

        private void frmXemLoaiThuoc_Load(object sender, EventArgs e)
        {
            var thongTinLoaiThuoc = qllt.LoaiThuocs.Where(x => x.MaLoai == mIdLoaiThuoc).FirstOrDefault();
            txt_maloaithuoc.Text = thongTinLoaiThuoc.MaLoai.ToString();
            txt_tenloaithuoc.Text = thongTinLoaiThuoc.TenLoai.ToString();


            var loaiThuoc = mIdLoaiThuoc.ToString();
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(loaiThuoc, 50);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
