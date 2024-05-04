namespace QLThuoc
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.txt_taikhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_matkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_dangnhap = new Guna.UI2.WinForms.Guna2Button();
            this.btn_tailai = new Guna.UI2.WinForms.Guna2Button();
            this.ckb_showpassword = new System.Windows.Forms.CheckBox();
            this.lbl_check = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(189, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "NaVin Pharmacity";
            // 
            // btn_Exit
            // 
            this.btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Exit.FillColor = System.Drawing.Color.Empty;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageSize = new System.Drawing.Size(15, 15);
            this.btn_Exit.Location = new System.Drawing.Point(442, 0);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(34, 31);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.BorderRadius = 5;
            this.txt_taikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_taikhoan.DefaultText = "";
            this.txt_taikhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_taikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_taikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_taikhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_taikhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_taikhoan.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.txt_taikhoan.ForeColor = System.Drawing.Color.Black;
            this.txt_taikhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_taikhoan.Location = new System.Drawing.Point(82, 203);
            this.txt_taikhoan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.PasswordChar = '\0';
            this.txt_taikhoan.PlaceholderText = "Username";
            this.txt_taikhoan.SelectedText = "";
            this.txt_taikhoan.Size = new System.Drawing.Size(328, 41);
            this.txt_taikhoan.TabIndex = 3;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BorderRadius = 5;
            this.txt_matkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matkhau.DefaultText = "";
            this.txt_matkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_matkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_matkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_matkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_matkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_matkhau.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.txt_matkhau.ForeColor = System.Drawing.Color.Black;
            this.txt_matkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_matkhau.Location = new System.Drawing.Point(82, 255);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.PlaceholderText = "Password";
            this.txt_matkhau.SelectedText = "";
            this.txt_matkhau.Size = new System.Drawing.Size(328, 41);
            this.txt_matkhau.TabIndex = 5;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.guna2Panel1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(44, 244);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(14, 10);
            this.guna2Panel1.TabIndex = 7;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.BorderRadius = 5;
            this.btn_dangnhap.BorderThickness = 1;
            this.btn_dangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dangnhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_dangnhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_dangnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_dangnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_dangnhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(169)))), ((int)(((byte)(58)))));
            this.btn_dangnhap.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.ForeColor = System.Drawing.Color.White;
            this.btn_dangnhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.btn_dangnhap.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_dangnhap.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_dangnhap.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_dangnhap.Location = new System.Drawing.Point(82, 323);
            this.btn_dangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(328, 36);
            this.btn_dangnhap.TabIndex = 8;
            this.btn_dangnhap.Text = "Login";
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // btn_tailai
            // 
            this.btn_tailai.BorderRadius = 5;
            this.btn_tailai.BorderThickness = 1;
            this.btn_tailai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tailai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_tailai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_tailai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_tailai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_tailai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(169)))), ((int)(((byte)(58)))));
            this.btn_tailai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tailai.ForeColor = System.Drawing.Color.White;
            this.btn_tailai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.btn_tailai.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_tailai.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_tailai.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_tailai.Location = new System.Drawing.Point(82, 363);
            this.btn_tailai.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tailai.Name = "btn_tailai";
            this.btn_tailai.Size = new System.Drawing.Size(328, 36);
            this.btn_tailai.TabIndex = 9;
            this.btn_tailai.Text = "Reload";
            this.btn_tailai.Click += new System.EventHandler(this.btn_tailai_Click);
            // 
            // ckb_showpassword
            // 
            this.ckb_showpassword.AutoSize = true;
            this.ckb_showpassword.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_showpassword.ForeColor = System.Drawing.Color.White;
            this.ckb_showpassword.Location = new System.Drawing.Point(297, 301);
            this.ckb_showpassword.Margin = new System.Windows.Forms.Padding(2);
            this.ckb_showpassword.Name = "ckb_showpassword";
            this.ckb_showpassword.Size = new System.Drawing.Size(134, 22);
            this.ckb_showpassword.TabIndex = 10;
            this.ckb_showpassword.Text = "Display password";
            this.ckb_showpassword.UseVisualStyleBackColor = true;
            this.ckb_showpassword.CheckedChanged += new System.EventHandler(this.ckb_showpassword_CheckedChanged);
            // 
            // lbl_check
            // 
            this.lbl_check.AutoSize = true;
            this.lbl_check.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_check.ForeColor = System.Drawing.Color.Red;
            this.lbl_check.Location = new System.Drawing.Point(562, 554);
            this.lbl_check.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_check.Name = "lbl_check";
            this.lbl_check.Size = new System.Drawing.Size(0, 17);
            this.lbl_check.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(15, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(442, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Welcome back! Enter your name to log in or create an account.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(4, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Copyright © 2024 NaVin AIF Technology";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(475, 443);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_check);
            this.Controls.Add(this.ckb_showpassword);
            this.Controls.Add(this.btn_tailai);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.btn_Exit);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_Exit;
        private Guna.UI2.WinForms.Guna2TextBox txt_taikhoan;
        private Guna.UI2.WinForms.Guna2TextBox txt_matkhau;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_dangnhap;
        private Guna.UI2.WinForms.Guna2Button btn_tailai;
        private System.Windows.Forms.CheckBox ckb_showpassword;
        private System.Windows.Forms.Label lbl_check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}