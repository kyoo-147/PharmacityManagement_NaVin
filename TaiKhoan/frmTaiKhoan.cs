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

// # -*- encoding: utf-8 -*-
// # Copyright NaVin Pharmacity (https://github.com/kyoo-147/PharmacityManagement_NaVin) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace QLThuoc.TaiKhoan
{
    public partial class frmTaiKhoan : Form
    {
        QLThuocEntities qltk = new QLThuocEntities();
        List<TaiKhoanGridView> taikhoanGirdView = new List<TaiKhoanGridView>();
        List<TaiKhoanGridView> fitertaikhoanGirdView = new List<TaiKhoanGridView>();
        public frmTaiKhoan()
        {
            InitializeComponent();

        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan frmThemTaiKhoan = new frmThemTaiKhoan();
            frmThemTaiKhoan.ShowDialog();
            FormLoad();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            FormLoad();
        }
        public void FormLoad()
        {
            taikhoanGirdView = qltk.Logins.Where(x => x.DaXoa != true).Select(x => new TaiKhoanGridView()
            {
                MaNhanVien = (int)x.MaNhanVien,
                TaiKhoan = x.TaiKhoan,
                MatKhau = x.MatKhau,
            }).ToList();
            foreach (var taiKhoan in taikhoanGirdView)
            {
                var nhanVien = qltk.NhanViens.FirstOrDefault(nv => nv.MaNV == taiKhoan.MaNhanVien);
                if (nhanVien != null)
                {
                    taiKhoan.TenNhanVien = nhanVien.TenNV;
                }
            }
            fitertaikhoanGirdView = taikhoanGirdView;
            dgv_taikhoan.DataSource = fitertaikhoanGirdView;
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            fitertaikhoanGirdView = taikhoanGirdView.Where(x => x.TaiKhoan.ToLower().Contains(txt_search.Text.ToLower())).ToList();
            dgv_taikhoan.DataSource = fitertaikhoanGirdView;
        }

        private void dgv_taikhoan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            XuatData();
        }
        public void XuatData()
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
                    csvWriter.WriteRecords(fitertaikhoanGirdView);
                }
            }
            MessageBox.Show("Export Data Successful", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgv_taikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
