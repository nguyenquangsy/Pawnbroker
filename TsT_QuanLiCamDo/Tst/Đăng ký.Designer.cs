
namespace Tst
{
    partial class Đăng_ký
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Đăng_ký));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_xn_pass = new System.Windows.Forms.TextBox();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ckbShowPassword = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.cb_VaiTro = new System.Windows.Forms.ComboBox();
            this.pb_check = new System.Windows.Forms.PictureBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_NhapMaDangKy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_check)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 325);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_user
            // 
            this.txt_user.Enabled = false;
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_user.Location = new System.Drawing.Point(34, 147);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(328, 26);
            this.txt_user.TabIndex = 0;
            this.txt_user.Text = "Nhập tên tài khoản";
            this.txt_user.Enter += new System.EventHandler(this.txt_user_Enter);
            // 
            // txt_pass
            // 
            this.txt_pass.Enabled = false;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_pass.Location = new System.Drawing.Point(32, 358);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(158, 26);
            this.txt_pass.TabIndex = 3;
            this.txt_pass.Text = "Mật khẩu";
            this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
            // 
            // txt_xn_pass
            // 
            this.txt_xn_pass.Enabled = false;
            this.txt_xn_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_xn_pass.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_xn_pass.Location = new System.Drawing.Point(207, 358);
            this.txt_xn_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_xn_pass.Name = "txt_xn_pass";
            this.txt_xn_pass.Size = new System.Drawing.Size(155, 26);
            this.txt_xn_pass.TabIndex = 4;
            this.txt_xn_pass.Text = "Nhập lại mật khẩu";
            this.txt_xn_pass.TextChanged += new System.EventHandler(this.txt_xn_pass_TextChanged);
            this.txt_xn_pass.Enter += new System.EventHandler(this.txt_xn_pass_Enter);
            this.txt_xn_pass.Leave += new System.EventHandler(this.txt_xn_pass_Leave);
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Enabled = false;
            this.btn_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.Location = new System.Drawing.Point(34, 425);
            this.btn_DangKy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(156, 33);
            this.btn_DangKy.TabIndex = 5;
            this.btn_DangKy.Text = "Đăng ký";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            this.btn_DangKy.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(723, 422);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(0, 0);
            this.button3.TabIndex = 8;
            this.button3.Text = "ĐĂNG KÝ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ckbShowPassword
            // 
            this.ckbShowPassword.AutoSize = true;
            this.ckbShowPassword.Enabled = false;
            this.ckbShowPassword.Location = new System.Drawing.Point(251, 391);
            this.ckbShowPassword.Name = "ckbShowPassword";
            this.ckbShowPassword.Size = new System.Drawing.Size(111, 20);
            this.ckbShowPassword.TabIndex = 9;
            this.ckbShowPassword.Text = "Xem mật khẩu";
            this.ckbShowPassword.UseVisualStyleBackColor = true;
            this.ckbShowPassword.CheckedChanged += new System.EventHandler(this.ckbShowPassword_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Họ và tên: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vai trò:";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Enabled = false;
            this.txt_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_HoTen.Location = new System.Drawing.Point(34, 219);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(328, 26);
            this.txt_HoTen.TabIndex = 1;
            this.txt_HoTen.Text = "Nhập họ và tên";
            this.txt_HoTen.Enter += new System.EventHandler(this.txt_HoTen_Enter);
            // 
            // cb_VaiTro
            // 
            this.cb_VaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_VaiTro.Enabled = false;
            this.cb_VaiTro.Items.AddRange(new object[] {
            "Chủ tiệm",
            "Nhân viên"});
            this.cb_VaiTro.Location = new System.Drawing.Point(34, 284);
            this.cb_VaiTro.Name = "cb_VaiTro";
            this.cb_VaiTro.Size = new System.Drawing.Size(328, 24);
            this.cb_VaiTro.TabIndex = 2;
            // 
            // pb_check
            // 
            this.pb_check.BackgroundImage = global::Tst.Properties.Resources._180px_Messagebox_info_svg;
            this.pb_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_check.Location = new System.Drawing.Point(116, 323);
            this.pb_check.Name = "pb_check";
            this.pb_check.Size = new System.Drawing.Size(29, 22);
            this.pb_check.TabIndex = 15;
            this.pb_check.TabStop = false;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(207, 425);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(155, 33);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Hủy";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_NhapMaDangKy
            // 
            this.btn_NhapMaDangKy.BackColor = System.Drawing.Color.Red;
            this.btn_NhapMaDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapMaDangKy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_NhapMaDangKy.Location = new System.Drawing.Point(49, 42);
            this.btn_NhapMaDangKy.Name = "btn_NhapMaDangKy";
            this.btn_NhapMaDangKy.Size = new System.Drawing.Size(297, 53);
            this.btn_NhapMaDangKy.TabIndex = 0;
            this.btn_NhapMaDangKy.Text = "Nhập mã đăng ký";
            this.btn_NhapMaDangKy.UseVisualStyleBackColor = false;
            this.btn_NhapMaDangKy.Click += new System.EventHandler(this.btn_NhapMaDangKy_Click);
            // 
            // Đăng_ký
            // 
            this.AcceptButton = this.btn_NhapMaDangKy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 494);
            this.Controls.Add(this.pb_check);
            this.Controls.Add(this.cb_VaiTro);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_NhapMaDangKy);
            this.Controls.Add(this.ckbShowPassword);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangKy);
            this.Controls.Add(this.txt_xn_pass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(412, 533);
            this.MinimumSize = new System.Drawing.Size(412, 533);
            this.Name = "Đăng_ký";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng_ký";
            ((System.ComponentModel.ISupportInitialize)(this.pb_check)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_xn_pass;
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox ckbShowPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.ComboBox cb_VaiTro;
        private System.Windows.Forms.PictureBox pb_check;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_NhapMaDangKy;
    }
}