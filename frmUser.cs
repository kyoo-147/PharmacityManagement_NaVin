using Guna.UI2.WinForms;
using QLThuoc.NhanVien1;
using QLThuoc.TaiKhoan;
using QLThuoc.ThongKe;
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
    // Thua ke lop form - giao dien nguoi dung cuoi
    public partial class frmUser : Form
    {
        string chucvuhientai = "";
        // Constructor duoc goi khi mot the hien cua frmUser duoc tao ra
        public frmUser(string chucvu)
        {
            InitializeComponent();
            // luu tru gia tri cua chucvu trong chucvuhien tai
            this.chucvuhientai = chucvu;
        }

        // Log Out Func
        private void guna2Button8_Click(object sender, EventArgs e)
        {
            // Callback log in 
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            // Hide frmUser present
            this.Hide();
        }
        
        // Call frmThuoc and show
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // Thiet lap cac thuoc tinh mac dinh cho form xuat hien
            this.panel_content.Controls.Clear();
            frmThuoc frmThuoc = new frmThuoc();
            frmThuoc.TopLevel = false;
            frmThuoc.Dock = DockStyle.Fill;
            frmThuoc.AutoScroll = true;
            this.panel_content.Controls.Add(frmThuoc);
            frmThuoc.Show();
        }
        // Call frmLoaiThuoc and show
        private void guna2Button6_Click(object sender, EventArgs e)
        {
            // Thiet lap cac thuoc tinh mac dinh cho form xuat hien
            this.panel_content.Controls.Clear();
            frmLoaiThuoc frmLoaiThuoc = new frmLoaiThuoc();
            frmLoaiThuoc.TopLevel = false;
            frmLoaiThuoc.Dock= DockStyle.Fill;
            frmLoaiThuoc.AutoScroll= true;
            this.panel_content.Controls.Add(frmLoaiThuoc);
            frmLoaiThuoc .Show();
        }

        // Call frmNhaCungCap and show
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            // Thiet lap cac thuoc tinh mac dinh cho form xuat hien
            this.panel_content.Controls.Clear();
            frmNhaCungCap frmNhaCungCap = new frmNhaCungCap();
            frmNhaCungCap.TopLevel = false;
            frmNhaCungCap.Dock = DockStyle.Fill;
            frmNhaCungCap.AutoScroll= true;
            this.panel_content.Controls.Add (frmNhaCungCap);
            frmNhaCungCap .Show();
        }

        // Call frmDonThuoc and show
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            // Thiet lap cac thuoc tinh mac dinh cho form xuat hien
            this.panel_content.Controls.Clear();
            frmDonThuoc frmDonThuoc = new frmDonThuoc();
            frmDonThuoc.TopLevel = false;
            frmDonThuoc.Dock = DockStyle.Fill;
            frmDonThuoc.AutoScroll= true;
            this.panel_content.Controls.Add(frmDonThuoc); 
            frmDonThuoc .Show();
        }

        // Call frmKhachHang and show
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            // Thiet lap cac thuoc tinh mac dinh cho form xuat hien
            this.panel_content.Controls.Clear();
            frmKhachHang frmKhachHang = new frmKhachHang();
            frmKhachHang.TopLevel = false;
            frmKhachHang.Dock = DockStyle.Fill;
            frmKhachHang.AutoScroll= true;
            this.panel_content.Controls.Add(frmKhachHang);
            frmKhachHang .Show();
        }

        // Call frmChiNhanh and show
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // Thiet lap cac thuoc tinh mac dinh cho form moi xuat hien
            this.panel_content.Controls.Clear();
            frmChiNhanh frmChiNhanh = new frmChiNhanh();
            frmChiNhanh.TopLevel = false;
            frmChiNhanh.Dock = DockStyle.Fill;
            frmChiNhanh.AutoScroll= true;
            this.panel_content.Controls.Add(frmChiNhanh);
            frmChiNhanh.Show();
        }
        // Call check permission func when app load
        private void frmUser_Load(object sender, EventArgs e)
        {
            checkquyen();
        }
        // Check permission of user
        public void checkquyen()
        {
            // Dua tren gia tri hien tai - Neu la quan ly, giao dien se show ra toan bo nut chuc nang
            if (this.chucvuhientai != "Quan Ly")
            {
                btn_nhanvien.Visible = false; // Only Manager
                guna2Button3.Visible = true; // Thuoc 
                guna2Button6.Visible = false; // Loai Thuoc - Only Manager
                guna2Button4.Visible = false; // Nha Cung Cap - Only Manager
                guna2Button2.Visible = false; // Chi Nhanh - Only Manager
                btn_nhanvien.Visible = false; // Only Manager
                btn_TaiKhoan.Visible = false; // Only Manager
            }
            else
            {
                btn_nhanvien.Visible = true;
                guna2Button6.Visible = true;
            }
        }

        // Call frmNhanVien and show
        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            // Thiet lap cac chuc nang mac dinh cho form moi xuat hien
            this.panel_content.Controls.Clear();
            frmNhanVien frmNhanVien = new frmNhanVien();
            frmNhanVien.TopLevel = false;
            frmNhanVien.Dock = DockStyle.Fill;
            frmNhanVien.AutoScroll = true;
            this.panel_content.Controls.Add(frmNhanVien);
            frmNhanVien .Show();
        }

        // Call frmTaiKhoan and show
        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            // Thiet lap cac chuc nang mac dinh cho form moi xuat hien
            this.panel_content.Controls.Clear();
            frmTaiKhoan frmTaiKhoan = new frmTaiKhoan();
            frmTaiKhoan.TopLevel = false;
            frmTaiKhoan.Dock = DockStyle.Fill;
            frmTaiKhoan.AutoScroll = true;
            this.panel_content.Controls.Add(frmTaiKhoan);
            frmTaiKhoan.Show();
        }

        // Call frmMainThongKe and show
        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            // Thiet lap cac chuc nang mac dinh cho form moi xuat hien
            this.panel_content.Controls.Clear();
            frmMainThongKe frmMainThongKe = new frmMainThongKe();
            frmMainThongKe.TopLevel = false;
            frmMainThongKe.Dock = DockStyle.Fill;
            frmMainThongKe.AutoScroll = true;
            this.panel_content.Controls.Add(frmMainThongKe);
            frmMainThongKe.Show();
        }

        // Thoat chuong trinh va tro ve giao dien login
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Close();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
