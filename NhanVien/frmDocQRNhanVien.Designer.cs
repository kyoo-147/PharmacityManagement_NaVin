namespace QLThuoc.NhanVien1
{
    partial class frmDocQRNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocQRNhanVien));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kq = new System.Windows.Forms.TextBox();
            this.btn_star = new System.Windows.Forms.Button();
            this.cmb_camera = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 32);
            this.label2.TabIndex = 31;
            this.label2.Text = "Search for employees by QR code";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 273);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Device:";
            // 
            // txt_kq
            // 
            this.txt_kq.Location = new System.Drawing.Point(84, 383);
            this.txt_kq.Margin = new System.Windows.Forms.Padding(2);
            this.txt_kq.Multiline = true;
            this.txt_kq.Name = "txt_kq";
            this.txt_kq.Size = new System.Drawing.Size(273, 279);
            this.txt_kq.TabIndex = 30;
            // 
            // btn_star
            // 
            this.btn_star.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(169)))), ((int)(((byte)(58)))));
            this.btn_star.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_star.ForeColor = System.Drawing.Color.White;
            this.btn_star.Location = new System.Drawing.Point(339, 58);
            this.btn_star.Margin = new System.Windows.Forms.Padding(2);
            this.btn_star.Name = "btn_star";
            this.btn_star.Size = new System.Drawing.Size(94, 35);
            this.btn_star.TabIndex = 28;
            this.btn_star.Text = "Find";
            this.btn_star.UseVisualStyleBackColor = false;
            this.btn_star.Click += new System.EventHandler(this.btn_star_Click);
            // 
            // cmb_camera
            // 
            this.cmb_camera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_camera.FormattingEnabled = true;
            this.cmb_camera.Location = new System.Drawing.Point(106, 60);
            this.cmb_camera.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_camera.Name = "cmb_camera";
            this.cmb_camera.Size = new System.Drawing.Size(216, 28);
            this.cmb_camera.TabIndex = 27;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(83, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 278);
            this.panel1.TabIndex = 29;
            // 
            // btn_Exit
            // 
            this.btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Exit.FillColor = System.Drawing.Color.Black;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageSize = new System.Drawing.Size(15, 15);
            this.btn_Exit.Location = new System.Drawing.Point(436, 1);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(29, 28);
            this.btn_Exit.TabIndex = 32;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // frmDocQRNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(463, 678);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kq);
            this.Controls.Add(this.btn_star);
            this.Controls.Add(this.cmb_camera);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDocQRNhanVien";
            this.Text = "frmDocQRNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDocQRNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmDocQRNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kq;
        private System.Windows.Forms.Button btn_star;
        private System.Windows.Forms.ComboBox cmb_camera;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btn_Exit;
    }
}