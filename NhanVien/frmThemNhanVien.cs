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

namespace QLThuoc.NhanVien1
{
    public partial class frmThemNhanVien : Form
    {
        int mIdNV;
        QLThuocEntities qlnv = new QLThuocEntities();
        public frmThemNhanVien(int IdNV = -1)
        {
            InitializeComponent();
            if(IdNV != -1 ) 
            {
                lbl_text.Text = "Repair Employee";
                btn_them.Text = "Repair";
            }
            mIdNV = IdNV;
            txt_manv.Text = mIdNV.ToString();
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_lamoi_Click(object sender, EventArgs e)
        {
            focus();
        }

        public void focus()
        {
            txt_manv.Text = "";
            txt_chucvu.Text = "";
            txt_ngaysinh.Text = "";
            txt_tennv.Text = "";
            txt_tennv.Focus();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (mIdNV == -1)
            {
                if (txt_tennv.Text == "" && txt_chucvu.Text == "")
                {
                    MessageBox.Show("Please enter employee name or position!!");
                }
                else if (txt_ngaysinh.Text == "")
                {
                    MessageBox.Show("Please enter employee name or position!!");
                }
                else { ThemMoi(); }
               
            }
            else
            {
                CapNhat();
            }
        }

        public void ThemMoi()
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.TenNV = txt_tennv.Text;
            nhanVien.ChucVu = txt_chucvu.Text;
            
            nhanVien.NgaySinh = DateTime.Parse(txt_ngaysinh.Text);
            qlnv.NhanViens.Add(nhanVien);
            qlnv.SaveChanges();
            MessageBox.Show("Add Successful", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            focus();
        }

        public void CapNhat()
        {
            var itemCanCapNhat = qlnv.NhanViens.Where(x => x.MaNV == mIdNV && x.DaXoa != true).FirstOrDefault();
            itemCanCapNhat.TenNV = txt_tennv.Text;
            itemCanCapNhat.ChucVu = txt_chucvu.Text;
            itemCanCapNhat.NgaySinh = DateTime.Parse(txt_ngaysinh.Text);
            itemCanCapNhat.DaXoa = false;
            qlnv.SaveChanges();
            MessageBox.Show("Update Successful", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            txt_ngaysinh.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void txt_tennv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
