
namespace Tst
{
    partial class Doanhthu_MH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doanhthu_MH));
            this.btn_khoangtg = new System.Windows.Forms.Button();
            this.dtp_tu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.date_time = new System.Windows.Forms.DateTimePicker();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_nam = new System.Windows.Forms.Button();
            this.btn_Thang = new System.Windows.Forms.Button();
            this.btn_ngay = new System.Windows.Forms.Button();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.cmb_TenMatHang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_khoangtg
            // 
            this.btn_khoangtg.BackColor = System.Drawing.SystemColors.Window;
            this.btn_khoangtg.Location = new System.Drawing.Point(121, 12);
            this.btn_khoangtg.Name = "btn_khoangtg";
            this.btn_khoangtg.Size = new System.Drawing.Size(75, 23);
            this.btn_khoangtg.TabIndex = 30;
            this.btn_khoangtg.Text = "Khoảng t/g";
            this.btn_khoangtg.UseVisualStyleBackColor = false;
            this.btn_khoangtg.Click += new System.EventHandler(this.btn_khoangtg_Click);
            // 
            // dtp_tu
            // 
            this.dtp_tu.Location = new System.Drawing.Point(325, 50);
            this.dtp_tu.Name = "dtp_tu";
            this.dtp_tu.Size = new System.Drawing.Size(198, 20);
            this.dtp_tu.TabIndex = 29;
            this.dtp_tu.Visible = false;
            this.dtp_tu.ValueChanged += new System.EventHandler(this.dtp_tu_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "đến:";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Từ:";
            this.label2.Visible = false;
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(405, 570);
            this.txt_TongTien.Multiline = true;
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(217, 25);
            this.txt_TongTien.TabIndex = 26;
            this.txt_TongTien.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tổng tiền:";
            // 
            // date_time
            // 
            this.date_time.Location = new System.Drawing.Point(325, 76);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(198, 20);
            this.date_time.TabIndex = 24;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(547, 73);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 22;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_all
            // 
            this.btn_all.BackColor = System.Drawing.SystemColors.Window;
            this.btn_all.Location = new System.Drawing.Point(547, 12);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(75, 23);
            this.btn_all.TabIndex = 21;
            this.btn_all.Text = "Tất cả";
            this.btn_all.UseVisualStyleBackColor = false;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_nam
            // 
            this.btn_nam.BackColor = System.Drawing.SystemColors.Window;
            this.btn_nam.Location = new System.Drawing.Point(449, 12);
            this.btn_nam.Name = "btn_nam";
            this.btn_nam.Size = new System.Drawing.Size(75, 23);
            this.btn_nam.TabIndex = 20;
            this.btn_nam.Text = "Năm";
            this.btn_nam.UseVisualStyleBackColor = false;
            this.btn_nam.Click += new System.EventHandler(this.btn_nam_Click);
            // 
            // btn_Thang
            // 
            this.btn_Thang.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Thang.Location = new System.Drawing.Point(343, 12);
            this.btn_Thang.Name = "btn_Thang";
            this.btn_Thang.Size = new System.Drawing.Size(75, 23);
            this.btn_Thang.TabIndex = 19;
            this.btn_Thang.Text = "Tháng";
            this.btn_Thang.UseVisualStyleBackColor = false;
            this.btn_Thang.Click += new System.EventHandler(this.btn_Thang_Click);
            // 
            // btn_ngay
            // 
            this.btn_ngay.BackColor = System.Drawing.SystemColors.Window;
            this.btn_ngay.Location = new System.Drawing.Point(235, 12);
            this.btn_ngay.Name = "btn_ngay";
            this.btn_ngay.Size = new System.Drawing.Size(75, 23);
            this.btn_ngay.TabIndex = 18;
            this.btn_ngay.Text = "Ngày";
            this.btn_ngay.UseVisualStyleBackColor = false;
            this.btn_ngay.Click += new System.EventHandler(this.btn_ngay_Click);
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(12, 112);
            this.dtgv.Name = "dtgv";
            this.dtgv.Size = new System.Drawing.Size(610, 452);
            this.dtgv.TabIndex = 17;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Thoat.BackgroundImage = global::Tst.Properties.Resources.back_icon_4;
            this.btn_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Thoat.Location = new System.Drawing.Point(12, 12);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(83, 73);
            this.btn_Thoat.TabIndex = 23;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // cmb_TenMatHang
            // 
            this.cmb_TenMatHang.FormattingEnabled = true;
            this.cmb_TenMatHang.Location = new System.Drawing.Point(121, 63);
            this.cmb_TenMatHang.Name = "cmb_TenMatHang";
            this.cmb_TenMatHang.Size = new System.Drawing.Size(158, 21);
            this.cmb_TenMatHang.TabIndex = 31;
            // 
            // Doanhthu_MH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(630, 601);
            this.Controls.Add(this.cmb_TenMatHang);
            this.Controls.Add(this.btn_khoangtg);
            this.Controls.Add(this.dtp_tu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_time);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.btn_nam);
            this.Controls.Add(this.btn_Thang);
            this.Controls.Add(this.btn_ngay);
            this.Controls.Add(this.dtgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(646, 640);
            this.MinimumSize = new System.Drawing.Size(646, 640);
            this.Name = "Doanhthu_MH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanhthu_MH";
            this.Load += new System.EventHandler(this.Doanhthu_MH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_khoangtg;
        private System.Windows.Forms.DateTimePicker dtp_tu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_time;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Button btn_nam;
        private System.Windows.Forms.Button btn_Thang;
        private System.Windows.Forms.Button btn_ngay;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.ComboBox cmb_TenMatHang;
    }
}