namespace Khachsan.GUI
{
    partial class Huongdan
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(882, 36);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Khachsan.Properties.Resources.tao_icon_shutdown_hoac_restart_ngoai_desktop_1;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(71, 33);
            this.toolStripButton1.Text = "Thoát";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightBlue;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "1.Người dùng",
            "\tĐăng nhập :Người dùng nhập thông tin tài khoản,mật khẩu chính xác",
            "\tNgười dùng có thể thay đổi mật khẩu của mình trong form thay đổi mật khẩu ",
            "2.Các chức năng chính",
            "\tSau khi đăng nhập hệ thống gửi đến người dùng Trang chủ, trên Trang chủ hệ ",
            "                   thống hiển thị các phân vùng chức năng để người dùng dễ dàng q" +
                "uản lí,",
            "                   trong mỗi phân vùng sẽ có các mục chức năng của từng phần cho " +
                "người dùng chọn",
            "\tKhi click vào mỗi chức năng của mỗi phân vùng hệ thống sẽ hiển thị ra màn",
            "                   hình form tương ứng với mỗi chức năng:",
            "•\tPhân vùng “Quản lí phòng”:   gồm chức năng quản lí loại phòng tương ứng ",
            "                                                                     với loại phò" +
                "ng là các phòng được phân chia.Người dùng có thể chỉnh sửa",
            "                                                                     phòng sau kh" +
                "i có khách hàng đến đặt phòng hoặc trả phòng ",
            "•\tPhân vùng “Quản lí nhân viên” :để quản lí thông tin của nhân viên và chức ",
            "                                                                       vụ tương ứ" +
                "ng với mỗi nhân viên ",
            "•\tPhân vùng “Quản lí khách hàng”:Quản lí thông tin của khách hàng khi đến ",
            "                                                                      khách sạn t" +
                "hêm mới,chỉnh sửa thông tin khách hàng và xóa thông tin ",
            "                                                                      khách hàng " +
                "khi trả phòng ",
            "•\tPhân vùng “Quản lí đăng kí” gồm 3 chức năng : ",
            "i.\tChức năng quản lí dịch vụ:    quản lí các dịch vụ của khách sạn, ",
            "                                                                   thêm mới 1 dịc" +
                "h vụ,hay chỉnh sửa giá tiền hoặc bỏ đi 1 dịch vụ.",
            "                                                                   Ngoài ra còn q" +
                "uản lí chi tiết từng dịch vụ được khách hàng dùng như thế nào.",
            "ii.\tChức năng đăng kí :                Khi có khách hàng đến khách sạn,nhân viên " +
                "sẽ sử dụng chức năng này để ghi ",
            "                                                                    nhận khách hà" +
                "ng thuê phòng nào,thời gian khách hàng ở tại khách sạn và số người ở ",
            "iii.\tChức năng tính hóa đơn:       Tính tổng số tiền của khách gồm có tiền phòng," +
                "tiền dịch vụ mà khách hàng sử dụng khi ở khách sạn"});
            this.listBox1.Location = new System.Drawing.Point(45, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(781, 379);
            this.listBox1.TabIndex = 1;
            // 
            // Huongdan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(882, 438);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Huongdan";
            this.Text = "Hướng dẫn";
            this.Load += new System.EventHandler(this.Huongdan_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ListBox listBox1;
    }
}