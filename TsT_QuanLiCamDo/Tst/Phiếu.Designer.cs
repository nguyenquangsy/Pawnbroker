
namespace Tst
{
    partial class Phiếu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phiếu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_phieuquahan = new System.Windows.Forms.Button();
            this.btn_phieudatra = new System.Windows.Forms.Button();
            this.btn_phieudangcam = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1117, 470);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_phieuquahan
            // 
            this.btn_phieuquahan.BackColor = System.Drawing.Color.Crimson;
            this.btn_phieuquahan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phieuquahan.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btn_phieuquahan.Location = new System.Drawing.Point(171, 35);
            this.btn_phieuquahan.Name = "btn_phieuquahan";
            this.btn_phieuquahan.Size = new System.Drawing.Size(211, 63);
            this.btn_phieuquahan.TabIndex = 1;
            this.btn_phieuquahan.Text = "Phiếu cầm quá hạn";
            this.btn_phieuquahan.UseVisualStyleBackColor = false;
            this.btn_phieuquahan.Click += new System.EventHandler(this.btn_phieuquahan_Click);
            // 
            // btn_phieudatra
            // 
            this.btn_phieudatra.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_phieudatra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phieudatra.ForeColor = System.Drawing.Color.OldLace;
            this.btn_phieudatra.Location = new System.Drawing.Point(757, 36);
            this.btn_phieudatra.Name = "btn_phieudatra";
            this.btn_phieudatra.Size = new System.Drawing.Size(211, 62);
            this.btn_phieudatra.TabIndex = 2;
            this.btn_phieudatra.Text = "Phiếu đã trả";
            this.btn_phieudatra.UseVisualStyleBackColor = false;
            this.btn_phieudatra.Click += new System.EventHandler(this.btn_phieudatra_Click);
            // 
            // btn_phieudangcam
            // 
            this.btn_phieudangcam.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_phieudangcam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phieudangcam.ForeColor = System.Drawing.Color.LightYellow;
            this.btn_phieudangcam.Location = new System.Drawing.Point(471, 35);
            this.btn_phieudangcam.Name = "btn_phieudangcam";
            this.btn_phieudangcam.Size = new System.Drawing.Size(211, 62);
            this.btn_phieudangcam.TabIndex = 3;
            this.btn_phieudangcam.Text = "Phiếu đang cầm";
            this.btn_phieudangcam.UseVisualStyleBackColor = false;
            this.btn_phieudangcam.Click += new System.EventHandler(this.btn_phieudangcam_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_thoat.BackgroundImage = global::Tst.Properties.Resources.back_icon_4;
            this.btn_thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_thoat.Location = new System.Drawing.Point(12, 12);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(70, 64);
            this.btn_thoat.TabIndex = 5;
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Phiếu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1142, 606);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_phieudangcam);
            this.Controls.Add(this.btn_phieudatra);
            this.Controls.Add(this.btn_phieuquahan);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1158, 645);
            this.MinimumSize = new System.Drawing.Size(1158, 645);
            this.Name = "Phiếu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_phieuquahan;
        private System.Windows.Forms.Button btn_phieudatra;
        private System.Windows.Forms.Button btn_phieudangcam;
        private System.Windows.Forms.Button btn_thoat;
    }
}