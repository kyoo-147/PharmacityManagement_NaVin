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
using QLThuoc.ChiNhanh1;

// # -*- encoding: utf-8 -*-
// # Copyright NaVin Pharmacity (https://github.com/kyoo-147/PharmacityManagement_NaVin) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace QLThuoc
{
    public partial class frmChiNhanh : Form
    {
        QLThuocEntities qlcn =  new QLThuocEntities();
        List<ChiNhanhGridView> chiNhanhGridViews = new List<ChiNhanhGridView>();
        List<ChiNhanhGridView> fiterchiNhanhGridViews = new List<ChiNhanhGridView>();
        public frmChiNhanh()
        {
            InitializeComponent();
        }

        // Call FormLoad
        private void frmChiNhanh_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        // Exit
        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FormLoad()
        {
             chiNhanhGridViews = qlcn.ChiNhanhs.Where(x=>x.DaXoa!=true).Select(x => new ChiNhanhGridView()
             {
                MaChiNhanh = x.MaChiNhanh,
                TenChiNhanh = x.TenChiNhanh,
                DiaChi = x.DiaChi,
                SoDienThoai = (int)x.SoDienThoai
             }).ToList();
            fiterchiNhanhGridViews = chiNhanhGridViews;
            dgv_chinhanh.DataSource = fiterchiNhanhGridViews;
        }

        // Call form them chi nhanh
        private void btn_new_Click(object sender, EventArgs e)
        {
            frmThemChiNhanh frmThemChiNhanh = new frmThemChiNhanh();
            frmThemChiNhanh.ShowDialog();
            FormLoad();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            fiterchiNhanhGridViews = chiNhanhGridViews.Where(x=>x.TenChiNhanh.ToLower().Contains(txt_search.Text.ToLower())).ToList();
            dgv_chinhanh.DataSource = fiterchiNhanhGridViews;
        }

        private void dgv_chinhanh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                //edit
                int selectID = (int)dgv_chinhanh.Rows[e.RowIndex].Cells[3].Value;
                frmThemChiNhanh frmThemChiNhanh = new frmThemChiNhanh(selectID);
                frmThemChiNhanh.ShowDialog();
                FormLoad();
            }
            else if (e.ColumnIndex == 2)
            {
                int selectID = (int)dgv_chinhanh.Rows[e.RowIndex].Cells[3].Value;
                var itemCanXoa = qlcn.ChiNhanhs.Where(x => x.DaXoa != true && x.MaChiNhanh == selectID).FirstOrDefault();
                qlcn.ChiNhanhs.Remove(itemCanXoa);
                qlcn.SaveChanges();
                MessageBox.Show("Deleted Successfully", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormLoad();
            }
            else if (e.ColumnIndex == 0)
            {
                int selectID = (int)dgv_chinhanh.Rows[e.RowIndex].Cells[3].Value; // Add New
                QLThuoc.ChiNhanh1.frmXemChiNhanh frmXemChiNhanh = new ChiNhanh1.frmXemChiNhanh(selectID);
                frmXemChiNhanh.ShowDialog();
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
                    csvWriter.WriteRecords(fiterchiNhanhGridViews);
                }
            }
            MessageBox.Show("Export Data Successfully");
        }

        // Open QR Check
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmDocQRChiNhanh frmDocQRChiNhanh = new frmDocQRChiNhanh();
            frmDocQRChiNhanh.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
