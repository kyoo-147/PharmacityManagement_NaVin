using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// # -*- encoding: utf-8 -*-
// # Copyright NaVin Pharmacity (https://github.com/kyoo-147/PharmacityManagement_NaVin) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace QLThuoc
{
    public partial class frmThemChiNhanh : Form
    {
        int mIdChiNhanh;
        QLThuocEntities qlcn = new QLThuocEntities();
        public frmThemChiNhanh(int IdChiNhanh=-1)
        {
            InitializeComponent();
            if(IdChiNhanh != -1)
            {
                lbl_text.Text = "Repair Branch";
                btn_them.Text = "Repair";
            }
            mIdChiNhanh = IdChiNhanh;
            txt_chinhanh.Text = mIdChiNhanh.ToString();
        }

        public void Forcus()
        {
            txt_chinhanh.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";
            txt_tenchinhanh.Text = "";
            txt_tenchinhanh.Focus();

        }
        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_lamoi_Click(object sender, EventArgs e)
        {
            Forcus();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (mIdChiNhanh == -1)
            {
                ThemMoi();
            }
            else
            {
                CapNhat();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ThemMoi()
        {
            ChiNhanh chiNhanh = new ChiNhanh();
            chiNhanh.TenChiNhanh = txt_tenchinhanh.Text;
            chiNhanh.DiaChi = txt_diachi.Text;
            chiNhanh.SoDienThoai = int.Parse(txt_sdt.Text);
            qlcn.ChiNhanhs.Add(chiNhanh);
            qlcn.SaveChanges();
            MessageBox.Show("Add Success", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Forcus();
        }
        public void CapNhat()
        {
            var itemCanCapNhat = qlcn.ChiNhanhs.Where(x=>x.MaChiNhanh == mIdChiNhanh && x.DaXoa !=true).FirstOrDefault();
            itemCanCapNhat.TenChiNhanh = txt_tenchinhanh.Text;
            itemCanCapNhat.DiaChi = txt_diachi.Text;
            itemCanCapNhat.SoDienThoai = int.Parse(txt_sdt.Text);

            itemCanCapNhat.DaXoa = false;
            qlcn.SaveChanges();
            MessageBox.Show("Update Successful", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void frmThemChiNhanh_Load(object sender, EventArgs e)
        {
            if (mIdChiNhanh != -1)
            {
                var chinhanh = qlcn.ChiNhanhs.Where(x => x.MaChiNhanh == mIdChiNhanh && x.DaXoa != true).FirstOrDefault();
                {
                    txt_chinhanh.Text = chinhanh.MaChiNhanh.ToString();
                    txt_tenchinhanh.Text = chinhanh.TenChiNhanh.ToString();
                    txt_diachi.Text = chinhanh.DiaChi.ToString();
                    txt_sdt.Text = chinhanh.SoDienThoai.ToString();

                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
