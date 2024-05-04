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
using QLThuoc.NhaCungCap1;

// # -*- encoding: utf-8 -*-
// # Copyright NaVin Pharmacity (https://github.com/kyoo-147/PharmacityManagement_NaVin) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace QLThuoc
{
    public partial class frmNhaCungCap : Form
    {
        QLThuocEntities qlncc = new QLThuocEntities();
        List<NhaCungCapGridView> nhaCungCapGridViews = new List<NhaCungCapGridView>();
        List<NhaCungCapGridView> fiternhaCungCapGridViews = new List<NhaCungCapGridView>();
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ncc_Click(object sender, EventArgs e)
        {
            frmThemNhaCC frmThemNhaCC = new frmThemNhaCC();
            frmThemNhaCC.ShowDialog();
            FormLoad();
        }
        public void FormLoad()
        {
            nhaCungCapGridViews= qlncc.NhaCungCaps.Where(x => x.DaXoa != true).Select(x => new NhaCungCapGridView()
            {
                MaNhaCungCap = x.MaNCC,
                TenNhaCungCap = x.TenNCC,
                DiaChi = x.DiaChi,
                SoDienThoai = x.SDT,
            }).ToList();
            fiternhaCungCapGridViews = nhaCungCapGridViews;
            dvg_nhacungcap.DataSource = fiternhaCungCapGridViews.ToList();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            fiternhaCungCapGridViews= nhaCungCapGridViews.Where(x=>x.TenNhaCungCap.ToLower().Contains(txt_search.Text.ToLower())).ToList();
            dvg_nhacungcap.DataSource = fiternhaCungCapGridViews;
        }

        private void dvg_nhacungcap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                //edit
                int selectID = (int)dvg_nhacungcap.Rows[e.RowIndex].Cells[3].Value;
                frmThemNhaCC frmThemNhaCC = new frmThemNhaCC(selectID);
                frmThemNhaCC.ShowDialog();
                FormLoad();
            }
            else if (e.ColumnIndex == 2)
            {
                int selectID = (int)dvg_nhacungcap.Rows[e.RowIndex].Cells[3].Value;
                var itemCanXoa = qlncc.NhaCungCaps.Where(x => x.DaXoa != true && x.MaNCC == selectID).FirstOrDefault();
                qlncc.NhaCungCaps.Remove(itemCanXoa);
                qlncc.SaveChanges();
                MessageBox.Show("Delete Successful", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormLoad();
            }
            else if (e.ColumnIndex == 0)
            {
                int selectID = (int)dvg_nhacungcap.Rows[e.RowIndex].Cells[3].Value;//them moi
                QLThuoc.NhaCungCap1.frmXemNhaCungCap frmXemNhaCungCap = new NhaCungCap1.frmXemNhaCungCap(selectID);
                frmXemNhaCungCap.ShowDialog();
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
                    csvWriter.WriteRecords(fiternhaCungCapGridViews);
                }
            }
            MessageBox.Show("Export Data Successful");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmDocQRNhaCungCap docQRNhaCungCap = new frmDocQRNhaCungCap();
            docQRNhaCungCap.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
