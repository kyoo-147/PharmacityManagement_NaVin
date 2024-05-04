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

namespace QLThuoc.ChiNhanh1
{
    public partial class frmDocQRChiNhanh : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public frmDocQRChiNhanh()
        {
            InitializeComponent();
        }

        private void frmDocQRChiNhanh_Load(object sender, EventArgs e)
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
                MessageBox.Show("Khong tim thay camera");
            }
        }

        private void frmDocQRChiNhanh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
                videoCaptureDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_kq.Text = "Dang doc.......";
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
                    QLThuoc.ChiNhanh1.frmXemChiNhanh frmXemChiNhanh = new QLThuoc.ChiNhanh1.frmXemChiNhanh(int.Parse(txt_kq.Text));
                    frmXemChiNhanh.ShowDialog();
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

            //chup anh sau 1s moi giai ma
            timer1.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            //throw new NotImplementedException();
        }

        private void txt_kq_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
