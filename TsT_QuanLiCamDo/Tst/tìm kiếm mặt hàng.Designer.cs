
namespace Tst
{
    partial class tìm_kiếm_mặt_hàng
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tìm_kiếm_mặt_hàng));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_tenmathang = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.txt_tenmathang = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1038, 514);
            this.dataGridView1.TabIndex = 0;
            // 
            // lb_tenmathang
            // 
            this.lb_tenmathang.AutoSize = true;
            this.lb_tenmathang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenmathang.Location = new System.Drawing.Point(347, 40);
            this.lb_tenmathang.Name = "lb_tenmathang";
            this.lb_tenmathang.Size = new System.Drawing.Size(166, 29);
            this.lb_tenmathang.TabIndex = 1;
            this.lb_tenmathang.Text = "Tên mặt hàng:";
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_thoat.BackgroundImage = global::Tst.Properties.Resources.back_icon_4;
            this.btn_thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_thoat.Location = new System.Drawing.Point(12, 12);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(98, 79);
            this.btn_thoat.TabIndex = 2;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // txt_tenmathang
            // 
            this.txt_tenmathang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenmathang.Location = new System.Drawing.Point(519, 43);
            this.txt_tenmathang.Name = "txt_tenmathang";
            this.txt_tenmathang.Size = new System.Drawing.Size(227, 29);
            this.txt_tenmathang.TabIndex = 3;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(768, 40);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(108, 32);
            this.btn_timkiem.TabIndex = 4;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // tìm_kiếm_mặt_hàng
            // 
            this.AcceptButton = this.btn_timkiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1062, 636);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_tenmathang);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.lb_tenmathang);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1078, 675);
            this.MinimumSize = new System.Drawing.Size(1078, 675);
            this.Name = "tìm_kiếm_mặt_hàng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tìm_kiếm_mặt_hàng";
            this.Load += new System.EventHandler(this.tìm_kiếm_mặt_hàng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_tenmathang;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.TextBox txt_tenmathang;
        private System.Windows.Forms.Button btn_timkiem;
    }
}