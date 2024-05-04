namespace QLThuoc.LoaiThuoc1
{
    partial class frmXemLoaiThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemLoaiThuoc));
            this.btn_trolai = new Guna.UI2.WinForms.Guna2Button();
            this.txt_tenloaithuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maloaithuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_trolai
            // 
            this.btn_trolai.BorderRadius = 19;
            this.btn_trolai.BorderThickness = 1;
            this.btn_trolai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_trolai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_trolai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_trolai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_trolai.FillColor = System.Drawing.Color.Black;
            this.btn_trolai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trolai.ForeColor = System.Drawing.Color.White;
            this.btn_trolai.HoverState.BorderColor = System.Drawing.Color.Black;
            this.btn_trolai.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_trolai.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_trolai.Image = ((System.Drawing.Image)(resources.GetObject("btn_trolai.Image")));
            this.btn_trolai.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_trolai.Location = new System.Drawing.Point(0, -3);
            this.btn_trolai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_trolai.Name = "btn_trolai";
            this.btn_trolai.Size = new System.Drawing.Size(32, 37);
            this.btn_trolai.TabIndex = 49;
            this.btn_trolai.Click += new System.EventHandler(this.btn_trolai_Click);
            // 
            // txt_tenloaithuoc
            // 
            this.txt_tenloaithuoc.BorderRadius = 5;
            this.txt_tenloaithuoc.BorderThickness = 0;
            this.txt_tenloaithuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenloaithuoc.DefaultText = "";
            this.txt_tenloaithuoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tenloaithuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tenloaithuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenloaithuoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenloaithuoc.Enabled = false;
            this.txt_tenloaithuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenloaithuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tenloaithuoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenloaithuoc.Location = new System.Drawing.Point(37, 175);
            this.txt_tenloaithuoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_tenloaithuoc.Name = "txt_tenloaithuoc";
            this.txt_tenloaithuoc.PasswordChar = '\0';
            this.txt_tenloaithuoc.PlaceholderText = "";
            this.txt_tenloaithuoc.SelectedText = "";
            this.txt_tenloaithuoc.Size = new System.Drawing.Size(302, 32);
            this.txt_tenloaithuoc.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Drug Type Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_maloaithuoc
            // 
            this.txt_maloaithuoc.BorderRadius = 5;
            this.txt_maloaithuoc.BorderThickness = 0;
            this.txt_maloaithuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_maloaithuoc.DefaultText = "";
            this.txt_maloaithuoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_maloaithuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_maloaithuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maloaithuoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_maloaithuoc.Enabled = false;
            this.txt_maloaithuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maloaithuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_maloaithuoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_maloaithuoc.Location = new System.Drawing.Point(37, 96);
            this.txt_maloaithuoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_maloaithuoc.Name = "txt_maloaithuoc";
            this.txt_maloaithuoc.PasswordChar = '\0';
            this.txt_maloaithuoc.PlaceholderText = "";
            this.txt_maloaithuoc.SelectedText = "";
            this.txt_maloaithuoc.Size = new System.Drawing.Size(302, 32);
            this.txt_maloaithuoc.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Drug Type Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(220, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 36);
            this.label1.TabIndex = 42;
            this.label1.Text = "Description";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(372, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 179);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(169)))), ((int)(((byte)(58)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(37, 232);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(302, 37);
            this.guna2Button1.TabIndex = 57;
            this.guna2Button1.Text = "Download QR Code";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(50)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(-3, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Copyright © 2024 NaVin AIF Technology";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmXemLoaiThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 309);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_trolai);
            this.Controls.Add(this.txt_tenloaithuoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_maloaithuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmXemLoaiThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmXemLoaiThuoc";
            this.Load += new System.EventHandler(this.frmXemLoaiThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_trolai;
        private Guna.UI2.WinForms.Guna2TextBox txt_tenloaithuoc;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_maloaithuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
    }
}