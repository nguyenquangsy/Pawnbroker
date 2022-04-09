
namespace Tst
{
    partial class Doanhthu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doanhthu));
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.btn_ngay = new System.Windows.Forms.Button();
            this.btn_Thang = new System.Windows.Forms.Button();
            this.btn_nam = new System.Windows.Forms.Button();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.data_time = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_tu = new System.Windows.Forms.DateTimePicker();
            this.btn_khoangtg = new System.Windows.Forms.Button();
            this.btn_TheoKhachHang = new System.Windows.Forms.Button();
            this.btn_TheoMatHang = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(12, 112);
            this.dtgv.Name = "dtgv";
            this.dtgv.Size = new System.Drawing.Size(610, 452);
            this.dtgv.TabIndex = 0;
            // 
            // btn_ngay
            // 
            this.btn_ngay.BackColor = System.Drawing.SystemColors.Window;
            this.btn_ngay.Location = new System.Drawing.Point(235, 12);
            this.btn_ngay.Name = "btn_ngay";
            this.btn_ngay.Size = new System.Drawing.Size(75, 23);
            this.btn_ngay.TabIndex = 1;
            this.btn_ngay.Text = "Ngày";
            this.btn_ngay.UseVisualStyleBackColor = false;
            this.btn_ngay.Click += new System.EventHandler(this.btn_ngay_Click);
            // 
            // btn_Thang
            // 
            this.btn_Thang.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Thang.Location = new System.Drawing.Point(343, 12);
            this.btn_Thang.Name = "btn_Thang";
            this.btn_Thang.Size = new System.Drawing.Size(75, 23);
            this.btn_Thang.TabIndex = 2;
            this.btn_Thang.Text = "Tháng";
            this.btn_Thang.UseVisualStyleBackColor = false;
            this.btn_Thang.Click += new System.EventHandler(this.btn_Thang_Click);
            // 
            // btn_nam
            // 
            this.btn_nam.BackColor = System.Drawing.SystemColors.Window;
            this.btn_nam.Location = new System.Drawing.Point(449, 12);
            this.btn_nam.Name = "btn_nam";
            this.btn_nam.Size = new System.Drawing.Size(75, 23);
            this.btn_nam.TabIndex = 3;
            this.btn_nam.Text = "Năm";
            this.btn_nam.UseVisualStyleBackColor = false;
            this.btn_nam.Click += new System.EventHandler(this.btn_nam_Click);
            // 
            // btn_all
            // 
            this.btn_all.BackColor = System.Drawing.SystemColors.Window;
            this.btn_all.Location = new System.Drawing.Point(547, 12);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(75, 23);
            this.btn_all.TabIndex = 4;
            this.btn_all.Text = "Tất cả";
            this.btn_all.UseVisualStyleBackColor = false;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(513, 70);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // data_time
            // 
            this.data_time.Location = new System.Drawing.Point(291, 73);
            this.data_time.Name = "data_time";
            this.data_time.Size = new System.Drawing.Size(198, 20);
            this.data_time.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tổng tiền:";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(405, 570);
            this.txt_TongTien.Multiline = true;
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(217, 25);
            this.txt_TongTien.TabIndex = 10;
            this.txt_TongTien.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Từ:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "đến:";
            this.label3.Visible = false;
            // 
            // dtp_tu
            // 
            this.dtp_tu.Location = new System.Drawing.Point(291, 47);
            this.dtp_tu.Name = "dtp_tu";
            this.dtp_tu.Size = new System.Drawing.Size(198, 20);
            this.dtp_tu.TabIndex = 13;
            this.dtp_tu.Visible = false;
            this.dtp_tu.ValueChanged += new System.EventHandler(this.dtp_tu_ValueChanged);
            // 
            // btn_khoangtg
            // 
            this.btn_khoangtg.BackColor = System.Drawing.SystemColors.Window;
            this.btn_khoangtg.Location = new System.Drawing.Point(121, 12);
            this.btn_khoangtg.Name = "btn_khoangtg";
            this.btn_khoangtg.Size = new System.Drawing.Size(75, 23);
            this.btn_khoangtg.TabIndex = 14;
            this.btn_khoangtg.Text = "Khoảng t/g";
            this.btn_khoangtg.UseVisualStyleBackColor = false;
            this.btn_khoangtg.Click += new System.EventHandler(this.btn_khoangtg_Click);
            // 
            // btn_TheoKhachHang
            // 
            this.btn_TheoKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TheoKhachHang.Location = new System.Drawing.Point(12, 570);
            this.btn_TheoKhachHang.Name = "btn_TheoKhachHang";
            this.btn_TheoKhachHang.Size = new System.Drawing.Size(125, 25);
            this.btn_TheoKhachHang.TabIndex = 15;
            this.btn_TheoKhachHang.Text = "Theo Khách Hàng";
            this.btn_TheoKhachHang.UseVisualStyleBackColor = true;
            this.btn_TheoKhachHang.Click += new System.EventHandler(this.btn_TheoKhachHang_Click);
            // 
            // btn_TheoMatHang
            // 
            this.btn_TheoMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TheoMatHang.Location = new System.Drawing.Point(160, 570);
            this.btn_TheoMatHang.Name = "btn_TheoMatHang";
            this.btn_TheoMatHang.Size = new System.Drawing.Size(125, 25);
            this.btn_TheoMatHang.TabIndex = 16;
            this.btn_TheoMatHang.Text = "Theo Mặt Hàng";
            this.btn_TheoMatHang.UseVisualStyleBackColor = true;
            this.btn_TheoMatHang.Click += new System.EventHandler(this.btn_TheoMatHang_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Thoat.BackgroundImage = global::Tst.Properties.Resources.back_icon_4;
            this.btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Thoat.Location = new System.Drawing.Point(12, 12);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(83, 73);
            this.btn_Thoat.TabIndex = 7;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Doanhthu
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 602);
            this.Controls.Add(this.btn_TheoMatHang);
            this.Controls.Add(this.btn_TheoKhachHang);
            this.Controls.Add(this.btn_khoangtg);
            this.Controls.Add(this.dtp_tu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_time);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.btn_nam);
            this.Controls.Add(this.btn_Thang);
            this.Controls.Add(this.btn_ngay);
            this.Controls.Add(this.dtgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 641);
            this.MinimumSize = new System.Drawing.Size(650, 641);
            this.Name = "Doanhthu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanhthu";
            this.Load += new System.EventHandler(this.Doanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Button btn_ngay;
        private System.Windows.Forms.Button btn_Thang;
        private System.Windows.Forms.Button btn_nam;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DateTimePicker data_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_tu;
        private System.Windows.Forms.Button btn_khoangtg;
        private System.Windows.Forms.Button btn_TheoKhachHang;
        private System.Windows.Forms.Button btn_TheoMatHang;
    }
}