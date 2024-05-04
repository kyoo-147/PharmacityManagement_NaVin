using CsvHelper;
using CsvHelper.Configuration;
using QLThuoc.BangThuoc1;
using QLThuoc.ViewModel;
using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

// # -*- encoding: utf-8 -*-
// # Copyright NaVin Pharmacity (https://github.com/kyoo-147/PharmacityManagement_NaVin) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace QLThuoc
{
    public partial class frmThuoc : Form
    {
        QLThuocEntities qlt = new QLThuocEntities();
        List<ThuocGridView> thuocGridViews = new List<ThuocGridView>();
        List<ThuocGridView> fiterthuocGridViews = new List<ThuocGridView>();
        private IEnumerable fiterProduct;

        public frmThuoc()
        {
            InitializeComponent();
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frmThemThuoc frmThemThuoc = new frmThemThuoc();
            frmThemThuoc.ShowDialog();
            FormLoad();
        }

        // Goi FormLoad de load cac du lieu len DataGridView
        private void frmThuoc_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        // Lay du lieu tu co so du lieu va hien thi len datagridview
        public void FormLoad()
        {
            thuocGridViews = qlt.Thuocs.Where(x => x.DaXoa != true).Select(x => new ThuocGridView()
            {
                MaThuoc = x.MaThuoc,
                TenThuoc = x.TenThuoc,
                DVT = x.DVT,
                TenLoai = x.LoaiThuoc.TenLoai,
                NhaCC = x.NhaCungCap.TenNCC,
                GiaBan = x.GiaBan
            }).ToList();
            fiterthuocGridViews = thuocGridViews;
            dgv_thuoc.DataSource = fiterthuocGridViews;
        }

        // loc du lieu theo tu khoa tim kiem va gan du lieu cho datagridview
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            fiterProduct = thuocGridViews.Where(x => x.TenThuoc.ToLower().Contains(txt_search.Text.ToLower())).ToList();
            dgv_thuoc.DataSource =fiterProduct;
        }

        // su kien xay ra khi nguoi dung double click vao 
        private void dgv_thuoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // neu user nhap vao chinh sua
            if (e.ColumnIndex == 1)
            {
                //edit
                int selectID = (int)dgv_thuoc.Rows[e.RowIndex].Cells[3].Value;
                frmThemThuoc frmThemThuoc = new frmThemThuoc(selectID);
                
                frmThemThuoc.ShowDialog();
                FormLoad();
            }
            // neu user nhap vao xoa
            else if (e.ColumnIndex == 2)
            {
                int selectID = (int)dgv_thuoc.Rows[e.RowIndex].Cells[3].Value;
                var itemCanXoa = qlt.Thuocs.Where(x => x.DaXoa != true && x.MaThuoc == selectID).FirstOrDefault();
                qlt.Thuocs.Remove(itemCanXoa);
                qlt.SaveChanges();
                MessageBox.Show("Deleted Successfully", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormLoad();
            }
            // neu user nhap vao xoa
            else if (e.ColumnIndex == 0)
            {
                int selectID = (int)dgv_thuoc.Rows[e.RowIndex].Cells[3].Value;//them moi
                QLThuoc.Thuoc1.frmXemThuoc xemthuoc = new QLThuoc.Thuoc1.frmXemThuoc(selectID);
                xemthuoc.ShowDialog();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ExportCSV();
        }

        // xuat du lieu thanh file csv
        public void ExportCSV()//them nay
        {
            // 
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
                    csvWriter.WriteRecords(fiterProduct);
                }
            }
            MessageBox.Show("Export Data Successfully", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // goi den quet ma qr
            frmDocQRThuoc frmDocQRThuoc = new frmDocQRThuoc();
            frmDocQRThuoc.ShowDialog();

        }

        private void dgv_thuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
