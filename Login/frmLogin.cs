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
    public partial class frmLogin : Form
    {
        QLThuocEntities qlthuoc = new QLThuocEntities();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            var check = qlthuoc.Logins.Where(x=>x.TaiKhoan == txt_taikhoan.Text && x.MatKhau == txt_matkhau.Text).FirstOrDefault();
            if (check != null)
            {
                var chucvu = check.NhanVien.ChucVu.ToString();
                frmUser frmUser = new frmUser(chucvu);
                frmUser.Show();
                this.Visible = false;
            }
            else
            {
                lbl_check.Text = "Account or password is incorrect";
                txt_taikhoan.Text = "";
                txt_matkhau.Text = "";
                txt_taikhoan.Focus();
            }
        }

        private void btn_tailai_Click(object sender, EventArgs e)
        {
            txt_taikhoan.Text = "";
            txt_matkhau.Text = "";
            txt_taikhoan.Focus();
        }

        private void ckb_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if(ckb_showpassword.Checked == true) { 
                txt_matkhau.PasswordChar = default(char);
            }
            else
            {
                txt_matkhau.PasswordChar = '*';
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
