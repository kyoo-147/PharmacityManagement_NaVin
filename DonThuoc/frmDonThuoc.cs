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
using QLThuoc.DonThuoc1;

// # -*- encoding: utf-8 -*-
// # Copyright NaVin Pharmacity (https://github.com/kyoo-147/PharmacityManagement_NaVin) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace QLThuoc
{
    public partial class frmDonThuoc : Form
    {
        QLThuocEntities qldt = new QLThuocEntities();
        List<DonThuocGridView> donThuocGridViews = new List<DonThuocGridView>();
        List<DonThuocGridView> fiterdonThuocGridViews = new List<DonThuocGridView>();
        public frmDonThuoc()
        {
            InitializeComponent();
        }

        private void frmDonThuoc_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadForm()
        {
            donThuocGridViews = qldt.DonThuocs.Where(x=>x.DaXoa!=true).Select(x => new DonThuocGridView()
            {
                MaDonThuoc = x.MaDon,
                NgayLapDon = (DateTime)x.NgayLap,
                TenNhanVien = x.NhanVien.TenNV,
                TenKhachHang = x.KhachHang.TenKH,
                TenChiNhanh = x.ChiNhanh.TenChiNhanh

            }).ToList();
            fiterdonThuocGridViews = donThuocGridViews;
            dvg_donthuoc.DataSource = fiterdonThuocGridViews;
        }

        private void btn_donthuoc_Click(object sender, EventArgs e)
        {
            frmThemDonThuoc frmThemDonThuoc = new frmThemDonThuoc();
            frmThemDonThuoc.ShowDialog();
            LoadForm();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            fiterdonThuocGridViews = donThuocGridViews.Where(x=>x.TenKhachHang.ToLower().Contains(txt_search.Text.ToLower())).ToList();
            dvg_donthuoc.DataSource = fiterdonThuocGridViews;
        }

        private void dvg_donthuoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                //edit
                
                int selectID = (int)dvg_donthuoc.Rows[e.RowIndex].Cells[3].Value;
                //MessageBox.Show("ID dang sua: " + selectID.ToString());
                frmThemDonThuoc frmThemDonThuoc = new frmThemDonThuoc(selectID);
                frmThemDonThuoc.ShowDialog();
                LoadForm();
            }
            else if (e.ColumnIndex == 2)
            {
                int selectID = (int)dvg_donthuoc.Rows[e.RowIndex].Cells[3].Value;
                var itemCanXoa = qldt.DonThuocs.Where(x => x.DaXoa != true && x.MaDon == selectID).FirstOrDefault();
                qldt.DonThuocs.Remove(itemCanXoa);
                qldt.SaveChanges();
                MessageBox.Show("Deleted Successfully", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadForm();
            }
            else if (e.ColumnIndex == 0)
            {
                int selectID = (int)dvg_donthuoc.Rows[e.RowIndex].Cells[3].Value;//them moi
                QLThuoc.DonThuoc1.frmXemDonThuoc donThuoc1 = new DonThuoc1.frmXemDonThuoc(selectID);
                donThuoc1.ShowDialog();
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
                    csvWriter.WriteRecords(fiterdonThuocGridViews);
                }
            }
            MessageBox.Show("Export Data Successfully");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmDocQRDonThuoc frmDocQRDonThuoc = new frmDocQRDonThuoc();
            frmDocQRDonThuoc.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
