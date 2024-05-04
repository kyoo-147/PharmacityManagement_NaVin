namespace QLThuoc.DonThuoc1
{
    partial class frmXemCTDonThuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemCTDonThuoc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_them = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbm_Tenthuoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_SL = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Soluong = new System.Windows.Forms.Label();
            this.dgv_Thongtin = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Luu = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Thongtin)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbm_Tenthuoc);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_SL);
            this.panel1.Controls.Add(this.txt_Soluong);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 160);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(34)))));
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageSize = new System.Drawing.Size(15, 15);
            this.btn_Exit.Location = new System.Drawing.Point(652, 1);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(29, 28);
            this.btn_Exit.TabIndex = 59;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_them
            // 
            this.btn_them.BorderRadius = 5;
            this.btn_them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_them.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(169)))), ((int)(((byte)(58)))));
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_them.Location = new System.Drawing.Point(525, 90);
            this.btn_them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(122, 36);
            this.btn_them.TabIndex = 58;
            this.btn_them.Text = "Add Product";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(220, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 29);
            this.label1.TabIndex = 53;
            this.label1.Text = "Add Medication Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbm_Tenthuoc
            // 
            this.cbm_Tenthuoc.BackColor = System.Drawing.Color.Transparent;
            this.cbm_Tenthuoc.BorderRadius = 5;
            this.cbm_Tenthuoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbm_Tenthuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbm_Tenthuoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbm_Tenthuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbm_Tenthuoc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbm_Tenthuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbm_Tenthuoc.ItemHeight = 30;
            this.cbm_Tenthuoc.Location = new System.Drawing.Point(24, 90);
            this.cbm_Tenthuoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbm_Tenthuoc.Name = "cbm_Tenthuoc";
            this.cbm_Tenthuoc.Size = new System.Drawing.Size(229, 36);
            this.cbm_Tenthuoc.TabIndex = 57;
            this.cbm_Tenthuoc.SelectedIndexChanged += new System.EventHandler(this.cbm_Tenthuoc_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 56;
            this.label9.Text = "Drug Name";
            // 
            // txt_SL
            // 
            this.txt_SL.BorderRadius = 5;
            this.txt_SL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SL.DefaultText = "";
            this.txt_SL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SL.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_SL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SL.Location = new System.Drawing.Point(273, 90);
            this.txt_SL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.PasswordChar = '\0';
            this.txt_SL.PlaceholderText = "";
            this.txt_SL.SelectedText = "";
            this.txt_SL.Size = new System.Drawing.Size(229, 36);
            this.txt_SL.TabIndex = 55;
            // 
            // txt_Soluong
            // 
            this.txt_Soluong.AutoSize = true;
            this.txt_Soluong.BackColor = System.Drawing.Color.Black;
            this.txt_Soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Soluong.ForeColor = System.Drawing.Color.White;
            this.txt_Soluong.Location = new System.Drawing.Point(278, 57);
            this.txt_Soluong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_Soluong.Name = "txt_Soluong";
            this.txt_Soluong.Size = new System.Drawing.Size(76, 20);
            this.txt_Soluong.TabIndex = 54;
            this.txt_Soluong.Text = "Quantity";
            // 
            // dgv_Thongtin
            // 
            this.dgv_Thongtin.AllowUserToAddRows = false;
            this.dgv_Thongtin.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Thongtin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Thongtin.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Thongtin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Thongtin.ColumnHeadersHeight = 18;
            this.dgv_Thongtin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Thongtin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.MaThuoc,
            this.TenThuoc,
            this.SoLuong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Thongtin.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Thongtin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Thongtin.Location = new System.Drawing.Point(3, 9);
            this.dgv_Thongtin.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_Thongtin.Name = "dgv_Thongtin";
            this.dgv_Thongtin.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Thongtin.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Thongtin.RowHeadersVisible = false;
            this.dgv_Thongtin.RowHeadersWidth = 51;
            this.dgv_Thongtin.RowTemplate.Height = 24;
            this.dgv_Thongtin.Size = new System.Drawing.Size(678, 229);
            this.dgv_Thongtin.TabIndex = 1;
            this.dgv_Thongtin.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Thongtin.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Thongtin.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Thongtin.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Thongtin.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Thongtin.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dgv_Thongtin.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Thongtin.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Thongtin.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Thongtin.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Thongtin.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Thongtin.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Thongtin.ThemeStyle.HeaderStyle.Height = 18;
            this.dgv_Thongtin.ThemeStyle.ReadOnly = true;
            this.dgv_Thongtin.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Thongtin.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Thongtin.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Thongtin.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Thongtin.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_Thongtin.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Thongtin.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Thongtin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Thongtin_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "Delete";
            this.Column1.Image = ((System.Drawing.Image)(resources.GetObject("Column1.Image")));
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 35;
            // 
            // MaThuoc
            // 
            this.MaThuoc.DataPropertyName = "MaThuoc";
            this.MaThuoc.HeaderText = "Drug Code";
            this.MaThuoc.MinimumWidth = 6;
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.ReadOnly = true;
            // 
            // TenThuoc
            // 
            this.TenThuoc.DataPropertyName = "TenThuoc";
            this.TenThuoc.HeaderText = "Drug Name";
            this.TenThuoc.MinimumWidth = 6;
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Quantity";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_Thongtin);
            this.panel2.Location = new System.Drawing.Point(4, 154);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 231);
            this.panel2.TabIndex = 2;
            // 
            // btn_Luu
            // 
            this.btn_Luu.BorderRadius = 5;
            this.btn_Luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Luu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(169)))), ((int)(((byte)(58)))));
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Luu.Location = new System.Drawing.Point(527, 396);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(122, 36);
            this.btn_Luu.TabIndex = 59;
            this.btn_Luu.Text = "Save Detail";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(1, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Copyright © 2024 NaVin AIF Technology";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmXemCTDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(684, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmXemCTDonThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXemCTDonThuoc";
            this.Load += new System.EventHandler(this.frmXemCTDonThuoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Thongtin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbm_Tenthuoc;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txt_SL;
        private System.Windows.Forms.Label txt_Soluong;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Thongtin;
        private Guna.UI2.WinForms.Guna2Button btn_them;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btn_Luu;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private Guna.UI2.WinForms.Guna2Button btn_Exit;
        private System.Windows.Forms.Label label3;
    }
}