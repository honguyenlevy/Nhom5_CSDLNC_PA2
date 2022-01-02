
namespace ADB1_5_DATH2
{
    partial class KhachHangXemDonGiaoHang
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
            this.dataGridViewXem = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXem)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(54, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(869, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐƠN TÌNH TRẠNG ĐƠN GIAO HÀNG";
            // 
            // dataGridViewXem
            // 
            this.dataGridViewXem.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewXem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXem.Location = new System.Drawing.Point(12, 119);
            this.dataGridViewXem.Name = "dataGridViewXem";
            this.dataGridViewXem.RowHeadersWidth = 51;
            this.dataGridViewXem.RowTemplate.Height = 24;
            this.dataGridViewXem.Size = new System.Drawing.Size(958, 502);
            this.dataGridViewXem.TabIndex = 22;
            // 
            // KhachHangXemDonGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 633);
            this.Controls.Add(this.dataGridViewXem);
            this.Controls.Add(this.panel1);
            this.Name = "KhachHangXemDonGiaoHang";
            this.Text = "KhachHangXemHoaDon";
            this.Load += new System.EventHandler(this.KhachHangXemDonGiaoHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewXem;
    }
}