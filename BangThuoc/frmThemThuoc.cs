using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

// # -*- encoding: utf-8 -*-
// # Copyright NaVin Pharmacity (https://github.com/kyoo-147/PharmacityManagement_NaVin) 2024. All Rights Reserved.
// #  MIT License  (https://opensource.org/licenses/MIT)

namespace QLThuoc
{
    
    public partial class frmThemThuoc : Form
    {
        int mIdThuoc;
        QLThuocEntities qlt = new QLThuocEntities();

        // Constructor cua form, nhan tham so Idthuoc
        public frmThemThuoc(int Idthuoc =-1)
        {
            InitializeComponent();
            // neu id kahc -1 
            // duoc su dung de sua thong tin cua mot loai thuoc da ton tai
            if(Idthuoc != -1)
            {
                lbl_text.Text = "Repair products";
                btn_them.Text = "Repair";
            }
            mIdThuoc = Idthuoc;
            txt_mathuoc.Text = mIdThuoc.ToString();
        }

        // Back user form
        private void btn_trolai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 
        private void btn_them_Click(object sender, EventArgs e)
        {
            // Neu id khac -1
            // du lieu cua loai thuoc can sua se duoc load vao cac
            // truong thong tin tuong ung
            if(mIdThuoc == -1)
            {
                if (txt_tenthuoc.Text == "")
                {
                    MessageBox.Show("Please do not leave data blank");
                    txt_tenthuoc.Focus();
                }else if (txt_dvt.Text == "")
                {
                    MessageBox.Show("Please do not leave data blank");
                    txt_dvt.Focus();
                }
                else if (txt_giaban.Text == "")
                {
                    MessageBox.Show("Please do not leave data blank");
                    txt_giaban.Focus();
                }
                else if (txt_soluong.Text == "")
                {
                    MessageBox.Show("Please do not leave data blank");
                    txt_soluong.Focus();
                }
                else if (IsNumber(txt_giaban.Text) != true )
                {
                    MessageBox.Show("The input data is invalid, characters cannot be entered", "Notifications");
                    txt_giaban.Text = "";
                    
                }
                else if (IsNumber(txt_soluong.Text) != true)
                {
                    MessageBox.Show("The input data is invalid, characters cannot be entered", "Notifications");
                    
                    txt_soluong.Text = "";
                }
                // neu khong se duoc goi form moi de them vao
                else { Themmoi(); }
               
            }

            else
            {
                CapNhat();
            }
        }

        // kiem tra xem chuoi truyen vao co phai la so hay khong
        public static bool IsNumber(string val)
        {
            // se duoc dung de kiem tra chuoi du lieu truyen vafo cho giaban va soluong
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }

        // Du lieu se duoc load vao cac combobox de nguoi dung chon
        private void frmThemThuoc_Load(object sender, EventArgs e)
        {
            //Load danh muc loai thuoc
            cb_tenloaithuoc.DataSource = qlt.LoaiThuocs.Where(x => x.DaXoa != true).Select(x => new
            {
                x.MaLoai,
                x.TenLoai
            }).ToList();
            cb_tenloaithuoc.DisplayMember = "TenLoai";
            cb_tenloaithuoc.ValueMember = "MaLoai";

            //Load Nha cung cap
            cb_ncc.DataSource = qlt.NhaCungCaps.Where(x => x.DaXoa != true).Select(x => new
            {
                x.MaNCC,
                x.TenNCC
            }).ToList();
            cb_ncc.DisplayMember = "TenNCC";
            cb_ncc.ValueMember = "MaNCC";

            ////Load loai thuoc
            //cb_tenloaithuoc.DataSource = qlt.Thuocs
            //    .Where(sp => sp.MaThuoc == mIdThuoc)
            //    .Join(qlt.LoaiThuocs.Where(x => x.DaXoa != true),
            //        sp => sp.MaLoai,
            //        lt => lt.MaLoai,
            //        (sp, lt) => new
            //        {
            //            lt.MaLoai,
            //            lt.TenLoai
            //        })
            //    .ToList();

            //cb_tenloaithuoc.DisplayMember = "TenLoai";
            //cb_tenloaithuoc.ValueMember = "MaLoai";





            ////Load nhà cung cấp
            //cb_ncc.DataSource = qlt.Thuocs
            //    .Where(sp => sp.MaThuoc == mIdThuoc)
            //    .Join(qlt.NhaCungCaps.Where(x => x.DaXoa != true),
            //        sp => sp.MaNCC,
            //        ncc => ncc.MaNCC,
            //        (sp, ncc) => new
            //        {
            //            ncc.MaNCC,
            //            ncc.TenNCC
            //        }).ToList();
            //cb_ncc.DisplayMember = "TenNCC";
            //cb_ncc.ValueMember = "MaNCC";

            // Neu id khac 1 
            // du lieu cua loai thuoc can sua duoc load vao cac truong thong tin tuong ung
            if (mIdThuoc != -1)
            {
                var thuoc = qlt.Thuocs.Where(x => x.MaThuoc == mIdThuoc && x.DaXoa != true).FirstOrDefault();
                {

                    txt_mathuoc.Text = thuoc.MaThuoc.ToString();
                    txt_tenthuoc.Text = thuoc.TenThuoc.ToString();
                    txt_soluong.Text = thuoc.SoLuong.ToString();
                    txt_dvt.Text = thuoc.DVT.ToString();
                    txt_giaban.Text = thuoc.GiaBan.ToString();
                }
            }

        }
        public void Forcus()
        {
            txt_tenthuoc.Text = "";
            txt_soluong.Text = "";
            txt_giaban.Text = "";
            txt_dvt.Text = "";
            txt_tenthuoc.Focus();
        }

        //
        public void Themmoi()
        {
            // Tao mot doi tuong thuoc tu cac thong tin nhap vao
            Thuoc thuoc = new Thuoc();
            thuoc.TenThuoc = txt_tenthuoc.Text;
            thuoc.SoLuong = int.Parse(txt_soluong.Text);
            thuoc.GiaBan = int.Parse(txt_giaban.Text);
            thuoc.DVT = txt_dvt.Text;
            thuoc.MaLoai = (int?)cb_ncc.SelectedValue;
            thuoc.MaNCC = (int?)cb_tenloaithuoc.SelectedValue;
            thuoc.DaXoa = false;
            qlt.Thuocs.Add(thuoc);
            qlt.SaveChanges();
            // Them doi tuong nay vao co so du lieu thong qua
            // QLThuocEntities
            MessageBox.Show("Add Success", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            Focus();
        }

        //
        public void CapNhat()
        {
            // Tim kiem doi tuongthuoc can sua thong qua id thuoc
            var itemCanCapNhat = qlt.Thuocs.Where(x => x.MaThuoc == mIdThuoc && x.DaXoa != true).FirstOrDefault();
            itemCanCapNhat.TenThuoc = txt_tenthuoc.Text;
            itemCanCapNhat.SoLuong = int.Parse(txt_soluong.Text);
            itemCanCapNhat.GiaBan = int.Parse(txt_giaban.Text);
            itemCanCapNhat.DVT = txt_dvt.Text;


            itemCanCapNhat.MaLoai = (int?)cb_tenloaithuoc.SelectedValue;
            itemCanCapNhat.MaNCC = (int?)cb_ncc.SelectedValue;
            itemCanCapNhat.DaXoa = false;
            qlt.SaveChanges();
            MessageBox.Show("Update Successful", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_lamoi_Click(object sender, EventArgs e)
        {
            Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {


        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
