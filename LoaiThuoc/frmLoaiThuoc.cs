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
using QLThuoc.LoaiThuoc1;

// # -*- encoding: utf-8 -*-
// # Copyright NaVin Pharmacity (https://github.com/kyoo-147/PharmacityManagement_NaVin) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace QLThuoc
{
    public partial class frmLoaiThuoc : Form
    {
        QLThuocEntities qlt = new QLThuocEntities();
        List<LoaiThuocGridView> loaiThuocGridViews = new List<LoaiThuocGridView>();
        List<LoaiThuocGridView> fiterloaiThuocGridViews = new List<LoaiThuocGridView>();
        public frmLoaiThuoc()
        {
            InitializeComponent();
        }

        public void frmLoaiThuoc_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frmThemLoaiThuoc frmThemLoaiThuoc = new frmThemLoaiThuoc();
            frmThemLoaiThuoc.ShowDialog();
            LoadForm();
        }

        public void LoadForm()
        {
             loaiThuocGridViews= qlt.LoaiThuocs.Where(x => x.DaXoa != true).Select(x => new LoaiThuocGridView()
            {
                MaLoaiThuoc = x.MaLoai,
                TenLoaiThuoc = x.TenLoai,
            }).ToList();
            fiterloaiThuocGridViews = loaiThuocGridViews;
            dvg_loaithuoc.DataSource = fiterloaiThuocGridViews;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            fiterloaiThuocGridViews = loaiThuocGridViews.Where(x => x.TenLoaiThuoc.ToLower().Contains(txt_search.Text.ToLower())).ToList();
            dvg_loaithuoc.DataSource = fiterloaiThuocGridViews;
        }

        private void dvg_loaithuoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex== 1)
            {
                //edit
                int selectID = (int)dvg_loaithuoc.Rows[e.RowIndex].Cells[3].Value;
                frmThemLoaiThuoc frmThemLoaiThuoc = new frmThemLoaiThuoc(selectID);
                frmThemLoaiThuoc.ShowDialog();
                LoadForm();

            }
            else if(e.ColumnIndex== 2)
            {
                int selectID = (int)dvg_loaithuoc.Rows[e.RowIndex].Cells[2].Value;
                var itemCanXoa = qlt.LoaiThuocs.Where(x => x.DaXoa != true && x.MaLoai == selectID).FirstOrDefault();
                qlt.LoaiThuocs.Remove(itemCanXoa);
                qlt.SaveChanges();
                MessageBox.Show("Delete Successful", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadForm();
            }
            else if (e.ColumnIndex == 0)
            {
                int selectID = (int)dvg_loaithuoc.Rows[e.RowIndex].Cells[3].Value;
                QLThuoc.LoaiThuoc1.frmXemLoaiThuoc frmXemLoaiThuoc = new LoaiThuoc1.frmXemLoaiThuoc(selectID);
                frmXemLoaiThuoc.ShowDialog();
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
                    csvWriter.WriteRecords(fiterloaiThuocGridViews);
                }
            }
            MessageBox.Show("Export Data Successful");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmDocQRLoaiThuoc frmDocQRLoaiThuoc = new frmDocQRLoaiThuoc();
            frmDocQRLoaiThuoc.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
