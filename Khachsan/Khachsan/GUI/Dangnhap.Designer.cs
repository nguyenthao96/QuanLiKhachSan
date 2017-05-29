namespace Khachsan.GUI
{
    partial class Dangnhap
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
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.btn_thaydoimatkhau = new System.Windows.Forms.Button();
            this.chk_hienthi = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.lbl_thongbao = new System.Windows.Forms.Label();
            this.btn_dangki = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_dangnhap.Location = new System.Drawing.Point(65, 206);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(83, 29);
            this.btn_dangnhap.TabIndex = 0;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // btn_thaydoimatkhau
            // 
            this.btn_thaydoimatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thaydoimatkhau.Location = new System.Drawing.Point(260, 206);
            this.btn_thaydoimatkhau.Name = "btn_thaydoimatkhau";
            this.btn_thaydoimatkhau.Size = new System.Drawing.Size(133, 29);
            this.btn_thaydoimatkhau.TabIndex = 1;
            this.btn_thaydoimatkhau.Text = "Thay đổi mật khẩu";
            this.btn_thaydoimatkhau.UseVisualStyleBackColor = true;
            this.btn_thaydoimatkhau.Click += new System.EventHandler(this.btn_thaydoimatkhau_Click);
            // 
            // chk_hienthi
            // 
            this.chk_hienthi.AutoSize = true;
            this.chk_hienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chk_hienthi.Location = new System.Drawing.Point(162, 139);
            this.chk_hienthi.Name = "chk_hienthi";
            this.chk_hienthi.Size = new System.Drawing.Size(128, 20);
            this.chk_hienthi.TabIndex = 2;
            this.chk_hienthi.Text = "Hiển thị mật khẩu";
            this.chk_hienthi.UseVisualStyleBackColor = true;
            this.chk_hienthi.CheckedChanged += new System.EventHandler(this.chk_hienthi_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(62, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mật khẩu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(62, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tài khoản";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_taikhoan.Location = new System.Drawing.Point(162, 33);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(119, 21);
            this.txt_taikhoan.TabIndex = 5;
            this.txt_taikhoan.TextChanged += new System.EventHandler(this.txt_taikhoan_TextChanged);
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_matkhau.Location = new System.Drawing.Point(162, 93);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(119, 21);
            this.txt_matkhau.TabIndex = 6;
            this.txt_matkhau.UseSystemPasswordChar = true;
            this.txt_matkhau.TextChanged += new System.EventHandler(this.txt_matkhau_TextChanged);
            // 
            // lbl_thongbao
            // 
            this.lbl_thongbao.AutoSize = true;
            this.lbl_thongbao.ForeColor = System.Drawing.Color.Red;
            this.lbl_thongbao.Location = new System.Drawing.Point(89, 179);
            this.lbl_thongbao.Name = "lbl_thongbao";
            this.lbl_thongbao.Size = new System.Drawing.Size(0, 13);
            this.lbl_thongbao.TabIndex = 7;
            this.lbl_thongbao.UseMnemonic = false;
            this.lbl_thongbao.Click += new System.EventHandler(this.lbl_thongbao_Click);
            // 
            // btn_dangki
            // 
            this.btn_dangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_dangki.Location = new System.Drawing.Point(162, 206);
            this.btn_dangki.Name = "btn_dangki";
            this.btn_dangki.Size = new System.Drawing.Size(75, 29);
            this.btn_dangki.TabIndex = 9;
            this.btn_dangki.Text = "Đăng kí";
            this.btn_dangki.UseVisualStyleBackColor = true;
            this.btn_dangki.Click += new System.EventHandler(this.btn_dangki_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Khachsan.Properties.Resources.gd1;
            this.pictureBox1.Location = new System.Drawing.Point(420, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 202);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(656, 261);
            this.Controls.Add(this.btn_dangki);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_thongbao);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_hienthi);
            this.Controls.Add(this.btn_thaydoimatkhau);
            this.Controls.Add(this.btn_dangnhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Button btn_thaydoimatkhau;
        private System.Windows.Forms.CheckBox chk_hienthi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Label lbl_thongbao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_dangki;
    }
}