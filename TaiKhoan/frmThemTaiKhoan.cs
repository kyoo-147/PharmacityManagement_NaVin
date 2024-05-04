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

namespace QLThuoc.TaiKhoan
{
    public partial class frmThemTaiKhoan : Form
    {
        int mIdTK;
        QLThuocEntities qltk = new QLThuocEntities();
        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }

        public void Forucs()
        {
            txt_tentk.Text = "";
            txt_matkhau.Text = "";
            txt_tentk.Focus();
        }

        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            cmb_nhanvien.DataSource = qltk.NhanViens.Where(x => x.DaXoa != true).Select(x => new
            {
                x.MaNV,
                x.TenNV
            }).ToList();
            cmb_nhanvien.DisplayMember = "TenNV";
            cmb_nhanvien.ValueMember = "MaNV";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Themmoi();
        }

        public void Themmoi()
        {
            Login login = new Login();
            login.TaiKhoan = txt_tentk.Text;
            login.MatKhau = txt_matkhau.Text;
            login.MaNhanVien = (int?)cmb_nhanvien.SelectedValue;
            login.DaXoa = false;
            qltk.Logins.Add(login);
            qltk.SaveChanges();
            MessageBox.Show("Add Successful", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Focus();
        }

        //public void CapNhat()
        //{
        //    var itemCanCapNhat = qltk.Logins.Where(x => x.TaiKhoan == mIdTK.ToString() && x.DaXoa != true).FirstOrDefault();
        //    itemCanCapNhat.TaiKhoan = txt_tentk.Text;
        //    itemCanCapNhat.MatKhau = txt_matkhau.Text;
        //    itemCanCapNhat.MaNhanVien = (int?)cmb_nhanvien.SelectedValue;
        //    itemCanCapNhat.DaXoa = false;
        //    qltk.SaveChanges();
        //    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    this.Close();
        //}

        private void btn_lamoi_Click(object sender, EventArgs e)
        {
            Focus();
        }
    }
}
