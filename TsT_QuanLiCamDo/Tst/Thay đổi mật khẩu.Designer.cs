
namespace Tst
{
    partial class Thay_đổi_mật_khảu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thay_đổi_mật_khảu));
            this.button2 = new System.Windows.Forms.Button();
            this.btn_xn = new System.Windows.Forms.Button();
            this.txt_confirm_pass = new System.Windows.Forms.TextBox();
            this.txt_new_pass = new System.Windows.Forms.TextBox();
            this.txt_old_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(26, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 43);
            this.button2.TabIndex = 15;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_xn
            // 
            this.btn_xn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xn.Location = new System.Drawing.Point(287, 266);
            this.btn_xn.Name = "btn_xn";
            this.btn_xn.Size = new System.Drawing.Size(135, 43);
            this.btn_xn.TabIndex = 14;
            this.btn_xn.Text = "Xác nhận";
            this.btn_xn.UseVisualStyleBackColor = true;
            this.btn_xn.Click += new System.EventHandler(this.btn_xn_Click);
            // 
            // txt_confirm_pass
            // 
            this.txt_confirm_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirm_pass.Location = new System.Drawing.Point(230, 192);
            this.txt_confirm_pass.Name = "txt_confirm_pass";
            this.txt_confirm_pass.Size = new System.Drawing.Size(192, 22);
            this.txt_confirm_pass.TabIndex = 13;
            // 
            // txt_new_pass
            // 
            this.txt_new_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_new_pass.Location = new System.Drawing.Point(230, 141);
            this.txt_new_pass.Name = "txt_new_pass";
            this.txt_new_pass.Size = new System.Drawing.Size(192, 22);
            this.txt_new_pass.TabIndex = 12;
            // 
            // txt_old_pass
            // 
            this.txt_old_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_old_pass.Location = new System.Drawing.Point(230, 91);
            this.txt_old_pass.Name = "txt_old_pass";
            this.txt_old_pass.Size = new System.Drawing.Size(192, 22);
            this.txt_old_pass.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Xác nhận mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mật khẩu củ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(133, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "Đổi mật khẩu";
            // 
            // Thay_đổi_mật_khảu
            // 
            this.AcceptButton = this.btn_xn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(455, 336);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_xn);
            this.Controls.Add(this.txt_confirm_pass);
            this.Controls.Add(this.txt_new_pass);
            this.Controls.Add(this.txt_old_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(471, 375);
            this.MinimumSize = new System.Drawing.Size(471, 375);
            this.Name = "Thay_đổi_mật_khảu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay_đổi_mật_khẩu";
            this.Load += new System.EventHandler(this.Thay_đổi_mật_khảu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_xn;
        private System.Windows.Forms.TextBox txt_confirm_pass;
        private System.Windows.Forms.TextBox txt_new_pass;
        private System.Windows.Forms.TextBox txt_old_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}