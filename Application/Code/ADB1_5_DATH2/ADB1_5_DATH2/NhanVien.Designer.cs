
namespace ADB1_5_DATH2
{
    partial class NhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxSDTKH = new System.Windows.Forms.ComboBox();
            this.buttonThemHD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMaNV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxHTTT = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxMaSP = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonThemSP = new System.Windows.Forms.Button();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTenSP = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCTDH = new System.Windows.Forms.DataGridView();
            this.buttonThanhToan = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewXemTimSP = new System.Windows.Forms.DataGridView();
            this.buttonXemSP = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTDH)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemTimSP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 100);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÂN VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxSDTKH);
            this.groupBox1.Controls.Add(this.buttonThemHD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimeNgayLap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxMaNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxHTTT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 276);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lập hóa đơn";
            // 
            // comboBoxSDTKH
            // 
            this.comboBoxSDTKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSDTKH.FormattingEnabled = true;
            this.comboBoxSDTKH.Location = new System.Drawing.Point(224, 133);
            this.comboBoxSDTKH.Name = "comboBoxSDTKH";
            this.comboBoxSDTKH.Size = new System.Drawing.Size(170, 33);
            this.comboBoxSDTKH.TabIndex = 17;
            // 
            // buttonThemHD
            // 
            this.buttonThemHD.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonThemHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemHD.ForeColor = System.Drawing.Color.Navy;
            this.buttonThemHD.Location = new System.Drawing.Point(82, 224);
            this.buttonThemHD.Name = "buttonThemHD";
            this.buttonThemHD.Size = new System.Drawing.Size(219, 46);
            this.buttonThemHD.TabIndex = 16;
            this.buttonThemHD.Text = "Thêm hóa đơn";
            this.buttonThemHD.UseVisualStyleBackColor = false;
            this.buttonThemHD.Click += new System.EventHandler(this.buttonThemHD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(108, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày lập";
            // 
            // dateTimeNgayLap
            // 
            this.dateTimeNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgayLap.Location = new System.Drawing.Point(224, 44);
            this.dateTimeNgayLap.Name = "dateTimeNgayLap";
            this.dateTimeNgayLap.Size = new System.Drawing.Size(170, 30);
            this.dateTimeNgayLap.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(67, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên";
            // 
            // comboBoxMaNV
            // 
            this.comboBoxMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMaNV.FormattingEnabled = true;
            this.comboBoxMaNV.Location = new System.Drawing.Point(224, 89);
            this.comboBoxMaNV.Name = "comboBoxMaNV";
            this.comboBoxMaNV.Size = new System.Drawing.Size(170, 33);
            this.comboBoxMaNV.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(37, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "SĐT khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(6, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hình thức thanh toán";
            // 
            // comboBoxHTTT
            // 
            this.comboBoxHTTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHTTT.FormattingEnabled = true;
            this.comboBoxHTTT.Location = new System.Drawing.Point(224, 177);
            this.comboBoxHTTT.Name = "comboBoxHTTT";
            this.comboBoxHTTT.Size = new System.Drawing.Size(170, 33);
            this.comboBoxHTTT.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxMaSP);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.buttonThemSP);
            this.groupBox2.Controls.Add(this.textBoxTongTien);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxSoLuong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 388);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 233);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm sản phẩm";
            // 
            // comboBoxMaSP
            // 
            this.comboBoxMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMaSP.FormattingEnabled = true;
            this.comboBoxMaSP.Location = new System.Drawing.Point(224, 42);
            this.comboBoxMaSP.Name = "comboBoxMaSP";
            this.comboBoxMaSP.Size = new System.Drawing.Size(170, 33);
            this.comboBoxMaSP.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(62, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mã sản phẩm";
            // 
            // buttonThemSP
            // 
            this.buttonThemSP.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonThemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemSP.ForeColor = System.Drawing.Color.Navy;
            this.buttonThemSP.Location = new System.Drawing.Point(85, 181);
            this.buttonThemSP.Name = "buttonThemSP";
            this.buttonThemSP.Size = new System.Drawing.Size(219, 46);
            this.buttonThemSP.TabIndex = 17;
            this.buttonThemSP.Text = "Thêm sản phẩm";
            this.buttonThemSP.UseVisualStyleBackColor = false;
            this.buttonThemSP.Click += new System.EventHandler(this.buttonThemSP_Click);
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTongTien.Location = new System.Drawing.Point(227, 139);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.Size = new System.Drawing.Size(170, 30);
            this.textBoxTongTien.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(106, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tổng tiền";
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoLuong.Location = new System.Drawing.Point(227, 94);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(170, 30);
            this.textBoxSoLuong.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(110, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(6, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên sản phẩm";
            // 
            // comboBoxTenSP
            // 
            this.comboBoxTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTenSP.FormattingEnabled = true;
            this.comboBoxTenSP.Location = new System.Drawing.Point(20, 68);
            this.comboBoxTenSP.Name = "comboBoxTenSP";
            this.comboBoxTenSP.Size = new System.Drawing.Size(170, 33);
            this.comboBoxTenSP.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(429, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 533);
            this.panel2.TabIndex = 21;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewCTDH);
            this.groupBox4.Controls.Add(this.buttonThanhToan);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(547, 251);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết đơn hàng";
            // 
            // dataGridViewCTDH
            // 
            this.dataGridViewCTDH.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewCTDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTDH.Location = new System.Drawing.Point(0, 76);
            this.dataGridViewCTDH.Name = "dataGridViewCTDH";
            this.dataGridViewCTDH.RowHeadersWidth = 51;
            this.dataGridViewCTDH.RowTemplate.Height = 24;
            this.dataGridViewCTDH.Size = new System.Drawing.Size(547, 175);
            this.dataGridViewCTDH.TabIndex = 21;
            // 
            // buttonThanhToan
            // 
            this.buttonThanhToan.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThanhToan.ForeColor = System.Drawing.Color.Navy;
            this.buttonThanhToan.Location = new System.Drawing.Point(277, 24);
            this.buttonThanhToan.Name = "buttonThanhToan";
            this.buttonThanhToan.Size = new System.Drawing.Size(178, 46);
            this.buttonThanhToan.TabIndex = 19;
            this.buttonThanhToan.Text = "Thanh toán";
            this.buttonThanhToan.UseVisualStyleBackColor = false;
            this.buttonThanhToan.Click += new System.EventHandler(this.buttonThanhToan_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewXemTimSP);
            this.groupBox3.Controls.Add(this.buttonXemSP);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBoxTenSP);
            this.groupBox3.Controls.Add(this.buttonTimKiem);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(547, 249);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xem, tìm sản phẩm";
            // 
            // dataGridViewXemTimSP
            // 
            this.dataGridViewXemTimSP.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewXemTimSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXemTimSP.Location = new System.Drawing.Point(196, 29);
            this.dataGridViewXemTimSP.Name = "dataGridViewXemTimSP";
            this.dataGridViewXemTimSP.RowHeadersWidth = 51;
            this.dataGridViewXemTimSP.RowTemplate.Height = 24;
            this.dataGridViewXemTimSP.Size = new System.Drawing.Size(345, 207);
            this.dataGridViewXemTimSP.TabIndex = 20;
            // 
            // buttonXemSP
            // 
            this.buttonXemSP.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonXemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXemSP.ForeColor = System.Drawing.Color.Navy;
            this.buttonXemSP.Location = new System.Drawing.Point(6, 168);
            this.buttonXemSP.Name = "buttonXemSP";
            this.buttonXemSP.Size = new System.Drawing.Size(184, 46);
            this.buttonXemSP.TabIndex = 19;
            this.buttonXemSP.Text = "Xem sản phẩm";
            this.buttonXemSP.UseVisualStyleBackColor = false;
            this.buttonXemSP.Click += new System.EventHandler(this.buttonXemSP_Click);
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.ForeColor = System.Drawing.Color.Navy;
            this.buttonTimKiem.Location = new System.Drawing.Point(11, 113);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(134, 46);
            this.buttonTimKiem.TabIndex = 18;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = false;
            this.buttonTimKiem.Click += new System.EventHandler(this.buttonTimKiem_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 633);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTDH)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemTimSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxSDTKH;
        private System.Windows.Forms.Button buttonThemHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeNgayLap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxHTTT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonThemSP;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxTenSP;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewCTDH;
        private System.Windows.Forms.Button buttonThanhToan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewXemTimSP;
        private System.Windows.Forms.Button buttonXemSP;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.ComboBox comboBoxMaSP;
        private System.Windows.Forms.Label label9;
    }
}