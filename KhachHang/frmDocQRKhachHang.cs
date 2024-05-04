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

namespace QLThuoc.KhachHang1
{
    public partial class frmDocQRKhachHang : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public frmDocQRKhachHang()
        {
            InitializeComponent();
        }

        private void frmQRKhachHang_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo f in filterInfoCollection)
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

        private void frmQRKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
                videoCaptureDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_kq.Text = "Looking for cameras...";
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    txt_kq.Text = result.ToString();
                    timer1.Stop();
                    if (videoCaptureDevice.IsRunning)
                        videoCaptureDevice.Stop();
                    QLThuoc.KhachHang1.frmXemKhachHang frmXemKhachHang = new QLThuoc.KhachHang1.frmXemKhachHang(int.Parse(txt_kq.Text));
                    frmXemKhachHang.ShowDialog();
                }
            }
        }

        private void btn_star_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cmb_camera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            if (videoCaptureDevice.IsRunning)
                videoCaptureDevice.Stop();
            videoCaptureDevice.Start();

            // DELAY
            timer1.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            //throw new NotImplementedException();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
