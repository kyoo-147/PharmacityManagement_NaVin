using CsvHelper.Configuration;
using CsvHelper;
using QLThuoc.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLThuoc.KhachHang1;

// # -*- encoding: utf-8 -*-
// # Copyright NaVin Pharmacity (https://github.com/kyoo-147/PharmacityManagement_NaVin) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace QLThuoc
{
    public partial class frmKhachHang : Form
    {
        QLThuocEntities qlkh = new QLThuocEntities();
        List<KhachHangGridView> khachHangGridViews = new List<KhachHangGridView>();
        List<KhachHangGridView> fiterkhachHangGridViews = new List<KhachHangGridView>();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            frmThemKhachHang frmThemKhachHang = new frmThemKhachHang();
            frmThemKhachHang.ShowDialog();
            LoadForm();

        }
        public void LoadForm()
        {
           khachHangGridViews = qlkh.KhachHangs.Where(x => x.DaXoa != true).Select(x => new KhachHangGridView()
            {
                MaKhachHang = x.MaKH,
                TenKhachHang = x.TenKH,
                DiaChi = x.DiaChi,
                SoDienThoai = x.SDT,
            }).ToList();
            fiterkhachHangGridViews = khachHangGridViews;
            dvg_khachhang.DataSource = fiterkhachHangGridViews;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            fiterkhachHangGridViews = khachHangGridViews.Where(x=>x.TenKhachHang.ToLower().Contains(txt_search.Text.ToLower())).ToList();
            dvg_khachhang.DataSource = fiterkhachHangGridViews;
        }

        private void dvg_khachhang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                //edit
                int selectID = (int)dvg_khachhang.Rows[e.RowIndex].Cells[3].Value;
                frmThemKhachHang frmThemKhachHang = new frmThemKhachHang(selectID);
                frmThemKhachHang.ShowDialog();
            }
            else if (e.ColumnIndex == 2)
            {
                int selectID = (int)dvg_khachhang.Rows[e.RowIndex].Cells[3].Value;
                var itemCanXoa = qlkh.KhachHangs.Where(x => x.DaXoa != true && x.MaKH == selectID).FirstOrDefault();
                qlkh.KhachHangs.Remove(itemCanXoa);
                qlkh.SaveChanges();
                MessageBox.Show("Deleted Successfully", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadForm();
            }
            else if (e.ColumnIndex == 0)
            {
                int selectID = (int)dvg_khachhang.Rows[e.RowIndex].Cells[3].Value;//them moi
                QLThuoc.KhachHang1.frmXemKhachHang frmkh = new QLThuoc.KhachHang1.frmXemKhachHang(selectID);
                frmkh.ShowDialog();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ExportCSV();
        }
        public void ExportCSV()//them nay
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Export CSV-NaVinPharmacity";
            saveFileDialog1.Filter = "CSV|*.csv";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
                {
                    HasHeaderRecord = true,
                    Delimiter = ",",
                    Encoding = Encoding.UTF8,
                };
                string mpath = saveFileDialog1.FileName;
                using (var write = new StreamWriter(mpath, false, new UTF8Encoding(true)))
                using (var csvWriter = new CsvWriter(write, csvConfig))
                {
                    csvWriter.WriteRecords(fiterkhachHangGridViews);
                }
            }
            MessageBox.Show("Export Data Successful");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmDocQRKhachHang frmDocQRKhachHang = new frmDocQRKhachHang();
            frmDocQRKhachHang.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
