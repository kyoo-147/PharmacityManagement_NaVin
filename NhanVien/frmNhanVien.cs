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
using System.Data.Entity.Migrations;
using QLThuoc.NhaCungCap1;
using QLThuoc.BangThuoc1;

// # -*- encoding: utf-8 -*-
// # Copyright NaVin Pharmacity (https://github.com/kyoo-147/PharmacityManagement_NaVin) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace QLThuoc.NhanVien1
{
    public partial class frmNhanVien : Form
    {
        QLThuocEntities qlnv = new QLThuocEntities();
        List<NhanVienGridView> nhanVienGridViews = new List<NhanVienGridView>();
        List<NhanVienGridView> fiternhanVienGridViews = new List<NhanVienGridView>();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void FormLoad()
        {
            nhanVienGridViews = qlnv.NhanViens.Where(x=>x.DaXoa !=true).Select(x=> new NhanVienGridView()
            {
                MaNhanVien =x.MaNV,
                TenNhanVien =x.TenNV,
                ChucVu = x.ChucVu,
                NgaySinh = (DateTime)x.NgaySinh
            }).ToList();
            fiternhanVienGridViews = nhanVienGridViews;
            dgv_nv.DataSource = fiternhanVienGridViews;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            fiternhanVienGridViews = nhanVienGridViews.Where(x => x.TenNhanVien.ToLower().Contains(txt_search.Text.ToLower())).ToList();
            dgv_nv.DataSource = fiternhanVienGridViews;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ExportCSV();
        }
        public void ExportCSV()
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
                    csvWriter.WriteRecords(fiternhanVienGridViews);
                }
            }
            MessageBox.Show("Export Data Successful");
        }

        private void btn_nv_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frmThemNhanVien = new frmThemNhanVien();
            frmThemNhanVien.ShowDialog();
            FormLoad();
        }

        private void dgv_nv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                //edit
                int selectID = (int)dgv_nv.Rows[e.RowIndex].Cells[3].Value;
                frmThemNhanVien frmThemNhanVien = new frmThemNhanVien(selectID);
                frmThemNhanVien.ShowDialog();
                FormLoad();
            }
            else if (e.ColumnIndex == 2)
            {
                int selectID = (int)dgv_nv.Rows[e.RowIndex].Cells[3].Value;
                var itemCanXoa = qlnv.NhanViens.Where(x => x.DaXoa != true && x.MaNV == selectID).FirstOrDefault();
                itemCanXoa.DaXoa = true;
                //qlnv.NhanViens.Remove(itemCanXoa);
                qlnv.NhanViens.AddOrUpdate(itemCanXoa);
                qlnv.SaveChanges();
                
                MessageBox.Show("Delete Successful", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormLoad();

            }
            else if (e.ColumnIndex == 0)
            {
                int selectID = (int)dgv_nv.Rows[e.RowIndex].Cells[3].Value;
                QLThuoc.NhanVien1.frmXemNhanVien frmXemNhanVien = new QLThuoc.NhanVien1.frmXemNhanVien(selectID);
                frmXemNhanVien.ShowDialog();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmDocQRThuoc frmDocQRThuoc = new frmDocQRThuoc();
            frmDocQRThuoc.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
