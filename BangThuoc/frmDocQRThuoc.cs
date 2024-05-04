using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

// # -*- encoding: utf-8 -*-
// # Copyright NaVin Pharmacity (https://github.com/kyoo-147/PharmacityManagement_NaVin) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace QLThuoc.BangThuoc1
{
    // Constructor cua lop form
    // instance cua form duoc tao
    public partial class frmDocQRThuoc : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public frmDocQRThuoc()
        {
            InitializeComponent();
        }

        // Su kien xay ra khi form duoc load
        private void frmDocQRThuoc_Load(object sender, EventArgs e)
        {
            // Tim thiet bi camera co san tai trong may
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            // vong lap lay ra danh sach camera co trong may
            foreach (FilterInfo f in filterInfoCollection)
                // Add vao comboobox de nguoi dung chon lua
                cmb_camera.Items.Add(f.Name);

            if (filterInfoCollection.Count > 0)
            {
                cmb_camera.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Camera Not Found");
            }
        }

        // Dong chuong trinh
        // neu camera dang chay thi chuong trinh se duoc dong lai
        private void frmDocQRThuoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
                videoCaptureDevice.Stop();
            //else
            //{
            //    videoCaptureDevice.Stop();
            //        }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_kq.Text = "Looking for cameras...";
            if (pictureBox1.Image != null)
            {
                // Tao mot doi tuong cua lop barcodereader
                // Doc va giai ma cac ma vach va qr
                BarcodeReader barcodeReader = new BarcodeReader();
                // Ep kieu du lieu hinh anh sang doi tuong bitmap de doc va giai ma cac ma qr
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                // 
                if (result != null)
                {
                    // 
                    txt_kq.Text = result.ToString();
                    timer1.Stop();
                    if (videoCaptureDevice.IsRunning)
                        videoCaptureDevice.Stop();
                    // Hien thi ket qua
                    QLThuoc.Thuoc1.frmXemThuoc xemthuoc = new QLThuoc.Thuoc1.frmXemThuoc(int.Parse(txt_kq.Text));
                    xemthuoc.ShowDialog();
                }
            }
        }

        // Nut kich hoat camera doc qr
        private void btn_star_Click(object sender, EventArgs e)
        {

            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmb_camera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            if (videoCaptureDevice.IsRunning)
                videoCaptureDevice.Stop();
            videoCaptureDevice.Start();

            // delay 1 giay va giai ma
            timer1.Start();
        }

        // Frame moi nhat duoc chup tu camera
        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            // Tao mot ban sao cua frame
            // tranh thay doi truc tiep du lieu cua frame goc
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            // giup cap nhap frame moi nhat len picture box moi khi frame moi nhan duoc ma qr
            //throw new NotImplementedException();
        }

        // shutdown
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //videoCaptureDevice.Stop();
            Close();
        }
    }
}
