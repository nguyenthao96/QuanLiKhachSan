namespace Khachsan.GUI
{
    partial class Hoadon
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.date_ngaythanhtoan = new System.Windows.Forms.DateTimePicker();
            this.cmb_manhanvien = new System.Windows.Forms.ComboBox();
            this.cmb_makhachhang = new System.Windows.Forms.ComboBox();
            this.cmb_maphieu = new System.Windows.Forms.ComboBox();
            this.txt_mahoadon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giadichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaythanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_hienthi1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_songay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_giaphong = new System.Windows.Forms.TextBox();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.txt_giadichvu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbs_them = new System.Windows.Forms.ToolStripButton();
            this.tbs_edit = new System.Windows.Forms.ToolStripButton();
            this.tbs_save = new System.Windows.Forms.ToolStripButton();
            this.tbs_delete = new System.Windows.Forms.ToolStripButton();
            this.tbs_exit = new System.Windows.Forms.ToolStripButton();
            this.hoadonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.date_ngaythanhtoan);
            this.groupBox1.Controls.Add(this.cmb_manhanvien);
            this.groupBox1.Controls.Add(this.cmb_makhachhang);
            this.groupBox1.Controls.Add(this.cmb_maphieu);
            this.groupBox1.Controls.Add(this.txt_mahoadon);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(56, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 24);
            this.button3.TabIndex = 21;
            this.button3.Text = "Xem khách hàng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Xem phiếu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // date_ngaythanhtoan
            // 
            this.date_ngaythanhtoan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaythanhtoan.Location = new System.Drawing.Point(136, 159);
            this.date_ngaythanhtoan.Name = "date_ngaythanhtoan";
            this.date_ngaythanhtoan.Size = new System.Drawing.Size(100, 21);
            this.date_ngaythanhtoan.TabIndex = 18;
            // 
            // cmb_manhanvien
            // 
            this.cmb_manhanvien.FormattingEnabled = true;
            this.cmb_manhanvien.Location = new System.Drawing.Point(136, 58);
            this.cmb_manhanvien.Name = "cmb_manhanvien";
            this.cmb_manhanvien.Size = new System.Drawing.Size(100, 23);
            this.cmb_manhanvien.TabIndex = 17;
            // 
            // cmb_makhachhang
            // 
            this.cmb_makhachhang.FormattingEnabled = true;
            this.cmb_makhachhang.Location = new System.Drawing.Point(136, 122);
            this.cmb_makhachhang.Name = "cmb_makhachhang";
            this.cmb_makhachhang.Size = new System.Drawing.Size(100, 23);
            this.cmb_makhachhang.TabIndex = 16;
            // 
            // cmb_maphieu
            // 
            this.cmb_maphieu.FormattingEnabled = true;
            this.cmb_maphieu.Location = new System.Drawing.Point(136, 90);
            this.cmb_maphieu.Name = "cmb_maphieu";
            this.cmb_maphieu.Size = new System.Drawing.Size(100, 23);
            this.cmb_maphieu.TabIndex = 15;
            // 
            // txt_mahoadon
            // 
            this.txt_mahoadon.Location = new System.Drawing.Point(136, 31);
            this.txt_mahoadon.Name = "txt_mahoadon";
            this.txt_mahoadon.Size = new System.Drawing.Size(100, 21);
            this.txt_mahoadon.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày thanh toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.mahoadon,
            this.manhanvien,
            this.maphieu,
            this.makhachhang,
            this.giaphong,
            this.giadichvu,
            this.tongtien,
            this.ngaythanhtoan});
            this.dataGridView1.Location = new System.Drawing.Point(12, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(949, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // mahoadon
            // 
            this.mahoadon.DataPropertyName = "mahoadon";
            this.mahoadon.HeaderText = "Mã hóa đơn";
            this.mahoadon.Name = "mahoadon";
            // 
            // manhanvien
            // 
            this.manhanvien.DataPropertyName = "manhanvien";
            this.manhanvien.HeaderText = "Mã nhân viên";
            this.manhanvien.Name = "manhanvien";
            // 
            // maphieu
            // 
            this.maphieu.DataPropertyName = "maphieu";
            this.maphieu.HeaderText = "Mã phiếu";
            this.maphieu.Name = "maphieu";
            // 
            // makhachhang
            // 
            this.makhachhang.DataPropertyName = "makhachhang";
            this.makhachhang.HeaderText = "Mã khách hàng";
            this.makhachhang.Name = "makhachhang";
            // 
            // giaphong
            // 
            this.giaphong.DataPropertyName = "giaphong";
            this.giaphong.HeaderText = "Giá phòng";
            this.giaphong.Name = "giaphong";
            // 
            // giadichvu
            // 
            this.giadichvu.DataPropertyName = "giadichvu";
            this.giadichvu.HeaderText = "Giá dịch vụ";
            this.giadichvu.Name = "giadichvu";
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.Name = "tongtien";
            // 
            // ngaythanhtoan
            // 
            this.ngaythanhtoan.DataPropertyName = "ngaythanhtoan";
            this.ngaythanhtoan.HeaderText = "Ngày thanh toán";
            this.ngaythanhtoan.Name = "ngaythanhtoan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_hienthi1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.txt_songay);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_giaphong);
            this.groupBox2.Controls.Add(this.txt_tongtien);
            this.groupBox2.Controls.Add(this.txt_giadichvu);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(541, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 218);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh toán";
            // 
            // btn_hienthi1
            // 
            this.btn_hienthi1.Location = new System.Drawing.Point(202, 29);
            this.btn_hienthi1.Name = "btn_hienthi1";
            this.btn_hienthi1.Size = new System.Drawing.Size(75, 23);
            this.btn_hienthi1.TabIndex = 17;
            this.btn_hienthi1.Text = "Hiển thị";
            this.btn_hienthi1.UseVisualStyleBackColor = true;
            this.btn_hienthi1.Click += new System.EventHandler(this.btn_hienthi1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(193, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 30);
            this.button4.TabIndex = 16;
            this.button4.Text = "Tính tổng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_songay
            // 
            this.txt_songay.Location = new System.Drawing.Point(80, 93);
            this.txt_songay.Name = "txt_songay";
            this.txt_songay.Size = new System.Drawing.Size(100, 21);
            this.txt_songay.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tổng tiền";
            // 
            // txt_giaphong
            // 
            this.txt_giaphong.Location = new System.Drawing.Point(80, 31);
            this.txt_giaphong.Name = "txt_giaphong";
            this.txt_giaphong.Size = new System.Drawing.Size(100, 21);
            this.txt_giaphong.TabIndex = 12;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(80, 121);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(100, 21);
            this.txt_tongtien.TabIndex = 14;
            // 
            // txt_giadichvu
            // 
            this.txt_giadichvu.Location = new System.Drawing.Point(80, 62);
            this.txt_giadichvu.Name = "txt_giadichvu";
            this.txt_giadichvu.Size = new System.Drawing.Size(100, 21);
            this.txt_giadichvu.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Giá phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Giá dịch vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số ngày ở ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbs_them,
            this.tbs_edit,
            this.tbs_save,
            this.tbs_delete,
            this.tbs_exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(1038, 36);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbs_them
            // 
            this.tbs_them.Image = global::Khachsan.Properties.Resources.add1;
            this.tbs_them.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_them.Name = "tbs_them";
            this.tbs_them.Size = new System.Drawing.Size(59, 33);
            this.tbs_them.Text = "Add";
            this.tbs_them.Click += new System.EventHandler(this.tbs_them_Click);
            // 
            // tbs_edit
            // 
            this.tbs_edit.Image = global::Khachsan.Properties.Resources.Edit_icon;
            this.tbs_edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_edit.Name = "tbs_edit";
            this.tbs_edit.Size = new System.Drawing.Size(58, 33);
            this.tbs_edit.Text = "Edit";
            this.tbs_edit.Click += new System.EventHandler(this.tbs_edit_Click);
            // 
            // tbs_save
            // 
            this.tbs_save.Image = global::Khachsan.Properties.Resources.save_icon;
            this.tbs_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_save.Name = "tbs_save";
            this.tbs_save.Size = new System.Drawing.Size(61, 33);
            this.tbs_save.Text = "Save";
            this.tbs_save.Click += new System.EventHandler(this.tbs_save_Click);
            // 
            // tbs_delete
            // 
            this.tbs_delete.Image = global::Khachsan.Properties.Resources.blue_delete_button_png_29;
            this.tbs_delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_delete.Name = "tbs_delete";
            this.tbs_delete.Size = new System.Drawing.Size(78, 33);
            this.tbs_delete.Text = "Delete";
            this.tbs_delete.Click += new System.EventHandler(this.tbs_delete_Click);
            // 
            // tbs_exit
            // 
            this.tbs_exit.Image = global::Khachsan.Properties.Resources.tao_icon_shutdown_hoac_restart_ngoai_desktop_1;
            this.tbs_exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_exit.Name = "tbs_exit";
            this.tbs_exit.Size = new System.Drawing.Size(58, 33);
            this.tbs_exit.Text = "Exit";
            this.tbs_exit.Click += new System.EventHandler(this.tbs_exit_Click);
            // 
            // hoadonBindingSource
            // 
            this.hoadonBindingSource.DataMember = "hoadon";
            // 
            // Hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1038, 454);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.Hoadon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoadonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
   //     private KhachsanDataSet khachsanDataSet;
        private System.Windows.Forms.BindingSource hoadonBindingSource;
   //     private KhachsanDataSetTableAdapters.hoadonTableAdapter hoadonTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker date_ngaythanhtoan;
        private System.Windows.Forms.ComboBox cmb_manhanvien;
        private System.Windows.Forms.ComboBox cmb_makhachhang;
        private System.Windows.Forms.ComboBox cmb_maphieu;
        private System.Windows.Forms.TextBox txt_mahoadon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahoadonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhanvienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhachhangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaphongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giadichvuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythanhtoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_songay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_giaphong;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.TextBox txt_giadichvu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbs_them;
        private System.Windows.Forms.ToolStripButton tbs_edit;
        private System.Windows.Forms.ToolStripButton tbs_save;
        private System.Windows.Forms.ToolStripButton tbs_delete;
        private System.Windows.Forms.ToolStripButton tbs_exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giadichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythanhtoan;
        private System.Windows.Forms.Button btn_hienthi1;
    }
}