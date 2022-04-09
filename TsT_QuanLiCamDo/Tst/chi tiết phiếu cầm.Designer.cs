
namespace Tst
{
    partial class chi_tiết_phiếu_cầm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chi_tiết_phiếu_cầm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_name = new System.Windows.Forms.Label();
            this.bth_them = new System.Windows.Forms.Button();
            this.bth_xoa = new System.Windows.Forms.Button();
            this.bth_sua = new System.Windows.Forms.Button();
            this.lb_tenmathang = new System.Windows.Forms.Label();
            this.lb_soluong = new System.Windows.Forms.Label();
            this.bth_tenkhachhang = new System.Windows.Forms.Label();
            this.txt_tenkhachhang = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.bht_ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tiencam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbb_TenMatHang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1216, 371);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.Color.Maroon;
            this.lb_name.Location = new System.Drawing.Point(387, 9);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(474, 55);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Chi tiết phiếu cầm đồ";
            // 
            // bth_them
            // 
            this.bth_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bth_them.Location = new System.Drawing.Point(306, 179);
            this.bth_them.Name = "bth_them";
            this.bth_them.Size = new System.Drawing.Size(167, 40);
            this.bth_them.TabIndex = 2;
            this.bth_them.Text = "Thêm";
            this.bth_them.UseVisualStyleBackColor = true;
            this.bth_them.Click += new System.EventHandler(this.ht_them_Click);
            // 
            // bth_xoa
            // 
            this.bth_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bth_xoa.Location = new System.Drawing.Point(821, 179);
            this.bth_xoa.Name = "bth_xoa";
            this.bth_xoa.Size = new System.Drawing.Size(167, 40);
            this.bth_xoa.TabIndex = 3;
            this.bth_xoa.Text = "Xóa";
            this.bth_xoa.UseVisualStyleBackColor = true;
            this.bth_xoa.Click += new System.EventHandler(this.bth_xoa_Click);
            // 
            // bth_sua
            // 
            this.bth_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bth_sua.Location = new System.Drawing.Point(556, 179);
            this.bth_sua.Name = "bth_sua";
            this.bth_sua.Size = new System.Drawing.Size(167, 40);
            this.bth_sua.TabIndex = 4;
            this.bth_sua.Text = "Sửa";
            this.bth_sua.UseVisualStyleBackColor = true;
            this.bth_sua.Click += new System.EventHandler(this.bth_sua_Click);
            // 
            // lb_tenmathang
            // 
            this.lb_tenmathang.AutoSize = true;
            this.lb_tenmathang.Enabled = false;
            this.lb_tenmathang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenmathang.Location = new System.Drawing.Point(269, 125);
            this.lb_tenmathang.Name = "lb_tenmathang";
            this.lb_tenmathang.Size = new System.Drawing.Size(132, 24);
            this.lb_tenmathang.TabIndex = 5;
            this.lb_tenmathang.Text = "Tên mặt hàng:";
            // 
            // lb_soluong
            // 
            this.lb_soluong.AutoSize = true;
            this.lb_soluong.Enabled = false;
            this.lb_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soluong.Location = new System.Drawing.Point(655, 91);
            this.lb_soluong.Name = "lb_soluong";
            this.lb_soluong.Size = new System.Drawing.Size(91, 24);
            this.lb_soluong.TabIndex = 6;
            this.lb_soluong.Text = "Số lượng:";
            // 
            // bth_tenkhachhang
            // 
            this.bth_tenkhachhang.AutoSize = true;
            this.bth_tenkhachhang.Enabled = false;
            this.bth_tenkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bth_tenkhachhang.Location = new System.Drawing.Point(248, 91);
            this.bth_tenkhachhang.Name = "bth_tenkhachhang";
            this.bth_tenkhachhang.Size = new System.Drawing.Size(153, 24);
            this.bth_tenkhachhang.TabIndex = 7;
            this.bth_tenkhachhang.Text = "Tên khách hàng:";
            // 
            // txt_tenkhachhang
            // 
            this.txt_tenkhachhang.Enabled = false;
            this.txt_tenkhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenkhachhang.Location = new System.Drawing.Point(407, 94);
            this.txt_tenkhachhang.Name = "txt_tenkhachhang";
            this.txt_tenkhachhang.Size = new System.Drawing.Size(228, 22);
            this.txt_tenkhachhang.TabIndex = 8;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Location = new System.Drawing.Point(752, 94);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(228, 22);
            this.txt_soluong.TabIndex = 9;
            this.txt_soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soluong_KeyPress);
            // 
            // bht_ok
            // 
            this.bht_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bht_ok.Location = new System.Drawing.Point(1069, 79);
            this.bht_ok.Name = "bht_ok";
            this.bht_ok.Size = new System.Drawing.Size(113, 77);
            this.bht_ok.TabIndex = 12;
            this.bht_ok.Text = "OK";
            this.bht_ok.UseVisualStyleBackColor = true;
            this.bht_ok.Click += new System.EventHandler(this.bht_ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(673, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Số tiền:";
            // 
            // txt_tiencam
            // 
            this.txt_tiencam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tiencam.Location = new System.Drawing.Point(752, 125);
            this.txt_tiencam.Name = "txt_tiencam";
            this.txt_tiencam.Size = new System.Drawing.Size(228, 22);
            this.txt_tiencam.TabIndex = 14;
            this.txt_tiencam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tiencam_KeyPress);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImage = global::Tst.Properties.Resources.back_icon_4;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 103);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbb_TenMatHang
            // 
            this.cbb_TenMatHang.FormattingEnabled = true;
            this.cbb_TenMatHang.Location = new System.Drawing.Point(407, 127);
            this.cbb_TenMatHang.Name = "cbb_TenMatHang";
            this.cbb_TenMatHang.Size = new System.Drawing.Size(228, 21);
            this.cbb_TenMatHang.TabIndex = 15;
            // 
            // chi_tiết_phiếu_cầm
            // 
            this.AcceptButton = this.bht_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1241, 624);
            this.Controls.Add(this.cbb_TenMatHang);
            this.Controls.Add(this.txt_tiencam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bht_ok);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_tenkhachhang);
            this.Controls.Add(this.bth_tenkhachhang);
            this.Controls.Add(this.lb_soluong);
            this.Controls.Add(this.lb_tenmathang);
            this.Controls.Add(this.bth_sua);
            this.Controls.Add(this.bth_xoa);
            this.Controls.Add(this.bth_them);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1257, 663);
            this.MinimumSize = new System.Drawing.Size(1257, 663);
            this.Name = "chi_tiết_phiếu_cầm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "chi_tiết_phiếu_cầm";
            this.Load += new System.EventHandler(this.chi_tiết_phiếu_cầm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Button bth_them;
        private System.Windows.Forms.Button bth_xoa;
        private System.Windows.Forms.Button bth_sua;
        private System.Windows.Forms.Label lb_tenmathang;
        private System.Windows.Forms.Label lb_soluong;
        private System.Windows.Forms.Label bth_tenkhachhang;
        private System.Windows.Forms.TextBox txt_tenkhachhang;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Button bht_ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tiencam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbb_TenMatHang;
    }
}