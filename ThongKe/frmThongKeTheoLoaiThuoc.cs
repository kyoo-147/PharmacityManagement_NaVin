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

namespace QLThuoc.ThongKe
{
    public partial class frmThongKeTheoLoaiThuoc : Form
    {
        private QLThuocEntities qlt = new QLThuocEntities();
        private List<ThongKeTheoLoaiThuocGridView> thuocGridViews = new List<ThongKeTheoLoaiThuocGridView>();
        private List<ThongKeTheoLoaiThuocGridView> filteredThuocGridViews = new List<ThongKeTheoLoaiThuocGridView>();
        public frmThongKeTheoLoaiThuoc(List<ThongKeTheoLoaiThuocGridView> thuocGridViews1)
        {
            InitializeComponent();
        }

        private void frmThongKeTheoLoaiThuoc_Load(object sender, EventArgs e)
        {
            // Lấy danh sách các loại thuốc từ cơ sở dữ liệu
            var loaiThuocList = qlt.LoaiThuocs.ToList();

            // Đổ dữ liệu vào ComboBox
            cmb_loaithuoc.DataSource = loaiThuocList;
            cmb_loaithuoc.DisplayMember = "TenLoai"; // Thay "TenLoai" bằng tên trường bạn muốn hiển thị
            cmb_loaithuoc.ValueMember = "MaLoai"; // Thay "MaLoai" bằng tên trường ID của loại thuốc

            // Load dữ liệu cho DataGridView
            LoadData();
        }

        private void cmb_loaithuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_loaithuoc.SelectedItem != null)
            {
                LoaiThuoc selectedLoaiThuoc = (LoaiThuoc)cmb_loaithuoc.SelectedItem;
                int selectedLoaiThuocId = selectedLoaiThuoc.MaLoai;

                // Lọc danh sách sản phẩm theo loại thuốc đã chọn
                filteredThuocGridViews = thuocGridViews.Where(x => x.MaLoai == selectedLoaiThuocId).ToList();

                // Hiển thị kết quả lên DataGridView
                dgv_loaithuoc.DataSource = filteredThuocGridViews;
            }
        }

        private void LoadData()
        {
            // Lấy danh sách thuốc từ cơ sở dữ liệu
            thuocGridViews = qlt.Thuocs.Select(x => new ThongKeTheoLoaiThuocGridView
            {
                MaThuoc = x.MaThuoc,
                TenThuoc = x.TenThuoc,
                DVT = x.DVT,
                MaLoai = x.LoaiThuoc.MaLoai, // Thêm MaLoai vào ThongKeTheoLoaiThuocGridView để có thể lọc theo loại thuốc
                TenLoai = x.LoaiThuoc.TenLoai,
                GiaBan = x.GiaBan
            }).ToList();

            // Đặt filteredThuocGridViews bằng thuocGridViews ban đầu
            filteredThuocGridViews = thuocGridViews;

            // Hiển thị dữ liệu trên DataGridView
            dgv_loaithuoc.DataSource = filteredThuocGridViews;
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
                    csvWriter.WriteRecords(filteredThuocGridViews);
                }
            }
            MessageBox.Show("Export Data Successful", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
