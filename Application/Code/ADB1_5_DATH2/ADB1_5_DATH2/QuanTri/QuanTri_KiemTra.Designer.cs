
namespace ADB1_5_DATH2.QuanTri
{
    partial class QuanTri_KiemTra
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
            this.buttonKiemTra = new System.Windows.Forms.Button();
            this.dataGridViewXemSP = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKiemTraHD = new System.Windows.Forms.Button();
            this.dateTimePickerKT = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemSP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).BeginInit();
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
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "KIỂM TRA";
            // 
            // buttonKiemTra
            // 
            this.buttonKiemTra.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonKiemTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKiemTra.ForeColor = System.Drawing.Color.Navy;
            this.buttonKiemTra.Location = new System.Drawing.Point(153, 71);
            this.buttonKiemTra.Name = "buttonKiemTra";
            this.buttonKiemTra.Size = new System.Drawing.Size(237, 46);
            this.buttonKiemTra.TabIndex = 24;
            this.buttonKiemTra.Text = "Kiểm tra sản phẩm";
            this.buttonKiemTra.UseVisualStyleBackColor = false;
            this.buttonKiemTra.Click += new System.EventHandler(this.buttonKiemTra_Click);
            // 
            // dataGridViewXemSP
            // 
            this.dataGridViewXemSP.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewXemSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXemSP.Location = new System.Drawing.Point(12, 123);
            this.dataGridViewXemSP.Name = "dataGridViewXemSP";
            this.dataGridViewXemSP.RowHeadersWidth = 51;
            this.dataGridViewXemSP.RowTemplate.Height = 24;
            this.dataGridViewXemSP.Size = new System.Drawing.Size(478, 404);
            this.dataGridViewXemSP.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(67, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Sản phẩm tồn bé hơn";
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoLuong.Location = new System.Drawing.Point(289, 35);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(170, 30);
            this.textBoxSoLuong.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonKiemTra);
            this.groupBox1.Controls.Add(this.textBoxSoLuong);
            this.groupBox1.Controls.Add(this.dataGridViewXemSP);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 533);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểm tra sản phẩm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewHoaDon);
            this.groupBox2.Controls.Add(this.dateTimePickerKT);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonKiemTraHD);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(496, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 533);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiểm tra hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(81, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ngày kiểm tra";
            // 
            // buttonKiemTraHD
            // 
            this.buttonKiemTraHD.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonKiemTraHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKiemTraHD.ForeColor = System.Drawing.Color.Navy;
            this.buttonKiemTraHD.Location = new System.Drawing.Point(138, 71);
            this.buttonKiemTraHD.Name = "buttonKiemTraHD";
            this.buttonKiemTraHD.Size = new System.Drawing.Size(237, 46);
            this.buttonKiemTraHD.TabIndex = 24;
            this.buttonKiemTraHD.Text = "Kiểm tra hóa đơn";
            this.buttonKiemTraHD.UseVisualStyleBackColor = false;
            this.buttonKiemTraHD.Click += new System.EventHandler(this.buttonKiemTraHD_Click);
            // 
            // dateTimePickerKT
            // 
            this.dateTimePickerKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerKT.Location = new System.Drawing.Point(251, 29);
            this.dateTimePickerKT.Name = "dateTimePickerKT";
            this.dateTimePickerKT.Size = new System.Drawing.Size(177, 30);
            this.dateTimePickerKT.TabIndex = 26;
            // 
            // dataGridViewHoaDon
            // 
            this.dataGridViewHoaDon.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoaDon.Location = new System.Drawing.Point(6, 123);
            this.dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            this.dataGridViewHoaDon.RowHeadersWidth = 51;
            this.dataGridViewHoaDon.RowTemplate.Height = 24;
            this.dataGridViewHoaDon.Size = new System.Drawing.Size(478, 404);
            this.dataGridViewHoaDon.TabIndex = 27;
            // 
            // QuanTri_KiemTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 633);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "QuanTri_KiemTra";
            this.Text = "QuanTri_KiemTra";
            this.Load += new System.EventHandler(this.QuanTri_SanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXemSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKiemTra;
        private System.Windows.Forms.DataGridView dataGridViewXemSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewHoaDon;
        private System.Windows.Forms.DateTimePicker dateTimePickerKT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonKiemTraHD;
    }
}