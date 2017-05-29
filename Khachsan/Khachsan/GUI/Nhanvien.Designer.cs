namespace Khachsan.GUI
{
    partial class Nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhanvien));
            this.lbl_manv = new System.Windows.Forms.Label();
            this.lbl_tennv = new System.Windows.Forms.Label();
            this.lbl_ngaysinh = new System.Windows.Forms.Label();
            this.lbl_macv = new System.Windows.Forms.Label();
            this.lbl_sodt = new System.Windows.Forms.Label();
            this.lbl_diachi = new System.Windows.Forms.Label();
            this.grpchitiet = new System.Windows.Forms.GroupBox();
            this.txt_gioitinh = new System.Windows.Forms.TextBox();
            this.txt_manhanvien = new System.Windows.Forms.TextBox();
            this.bl_gioitinh = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_sodt = new System.Windows.Forms.TextBox();
            this.date_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cmb_macv = new System.Windows.Forms.ComboBox();
            this.dgv_nhanvien = new System.Windows.Forms.DataGridView();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grp_danhsach = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbs_add = new System.Windows.Forms.ToolStripButton();
            this.tbs_edit = new System.Windows.Forms.ToolStripButton();
            this.tbs_save = new System.Windows.Forms.ToolStripButton();
            this.tbs_delete = new System.Windows.Forms.ToolStripButton();
            this.tbs_exit = new System.Windows.Forms.ToolStripButton();
            this.txt_search = new System.Windows.Forms.ToolStripTextBox();
            this.tbs_search = new System.Windows.Forms.ToolStripButton();
            this.tbs_xemnv = new System.Windows.Forms.ToolStripButton();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpchitiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            this.grp_danhsach.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_manv
            // 
            this.lbl_manv.AutoSize = true;
            this.lbl_manv.ForeColor = System.Drawing.Color.Black;
            this.lbl_manv.Location = new System.Drawing.Point(9, 60);
            this.lbl_manv.Name = "lbl_manv";
            this.lbl_manv.Size = new System.Drawing.Size(87, 16);
            this.lbl_manv.TabIndex = 0;
            this.lbl_manv.Text = "Mã nhân viên";
            // 
            // lbl_tennv
            // 
            this.lbl_tennv.AutoSize = true;
            this.lbl_tennv.ForeColor = System.Drawing.Color.Black;
            this.lbl_tennv.Location = new System.Drawing.Point(9, 93);
            this.lbl_tennv.Name = "lbl_tennv";
            this.lbl_tennv.Size = new System.Drawing.Size(92, 16);
            this.lbl_tennv.TabIndex = 2;
            this.lbl_tennv.Text = "Tên nhân viên";
            // 
            // lbl_ngaysinh
            // 
            this.lbl_ngaysinh.AutoSize = true;
            this.lbl_ngaysinh.ForeColor = System.Drawing.Color.Black;
            this.lbl_ngaysinh.Location = new System.Drawing.Point(347, 56);
            this.lbl_ngaysinh.Name = "lbl_ngaysinh";
            this.lbl_ngaysinh.Size = new System.Drawing.Size(68, 16);
            this.lbl_ngaysinh.TabIndex = 4;
            this.lbl_ngaysinh.Text = "Ngày sinh";
            // 
            // lbl_macv
            // 
            this.lbl_macv.AutoSize = true;
            this.lbl_macv.ForeColor = System.Drawing.Color.Black;
            this.lbl_macv.Location = new System.Drawing.Point(9, 131);
            this.lbl_macv.Name = "lbl_macv";
            this.lbl_macv.Size = new System.Drawing.Size(55, 16);
            this.lbl_macv.TabIndex = 6;
            this.lbl_macv.Text = "Chức vụ";
            // 
            // lbl_sodt
            // 
            this.lbl_sodt.AutoSize = true;
            this.lbl_sodt.ForeColor = System.Drawing.Color.Black;
            this.lbl_sodt.Location = new System.Drawing.Point(347, 127);
            this.lbl_sodt.Name = "lbl_sodt";
            this.lbl_sodt.Size = new System.Drawing.Size(86, 16);
            this.lbl_sodt.TabIndex = 8;
            this.lbl_sodt.Text = "Số điện thoại";
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.AutoSize = true;
            this.lbl_diachi.ForeColor = System.Drawing.Color.Black;
            this.lbl_diachi.Location = new System.Drawing.Point(347, 87);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(48, 16);
            this.lbl_diachi.TabIndex = 10;
            this.lbl_diachi.Text = "Địa chỉ";
            // 
            // grpchitiet
            // 
            this.grpchitiet.Controls.Add(this.txt_gioitinh);
            this.grpchitiet.Controls.Add(this.txt_manhanvien);
            this.grpchitiet.Controls.Add(this.bl_gioitinh);
            this.grpchitiet.Controls.Add(this.groupBox1);
            this.grpchitiet.Controls.Add(this.txt_tennv);
            this.grpchitiet.Controls.Add(this.lbl_macv);
            this.grpchitiet.Controls.Add(this.txt_diachi);
            this.grpchitiet.Controls.Add(this.txt_sodt);
            this.grpchitiet.Controls.Add(this.date_ngaysinh);
            this.grpchitiet.Controls.Add(this.cmb_macv);
            this.grpchitiet.Controls.Add(this.lbl_manv);
            this.grpchitiet.Controls.Add(this.lbl_sodt);
            this.grpchitiet.Controls.Add(this.lbl_diachi);
            this.grpchitiet.Controls.Add(this.lbl_tennv);
            this.grpchitiet.Controls.Add(this.lbl_ngaysinh);
            this.grpchitiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpchitiet.Location = new System.Drawing.Point(154, 53);
            this.grpchitiet.Name = "grpchitiet";
            this.grpchitiet.Size = new System.Drawing.Size(647, 205);
            this.grpchitiet.TabIndex = 11;
            this.grpchitiet.TabStop = false;
            this.grpchitiet.Text = "Chi tiết";
            // 
            // txt_gioitinh
            // 
            this.txt_gioitinh.Location = new System.Drawing.Point(116, 167);
            this.txt_gioitinh.Name = "txt_gioitinh";
            this.txt_gioitinh.Size = new System.Drawing.Size(148, 21);
            this.txt_gioitinh.TabIndex = 24;
            // 
            // txt_manhanvien
            // 
            this.txt_manhanvien.Location = new System.Drawing.Point(116, 53);
            this.txt_manhanvien.Name = "txt_manhanvien";
            this.txt_manhanvien.Size = new System.Drawing.Size(148, 21);
            this.txt_manhanvien.TabIndex = 23;
            // 
            // bl_gioitinh
            // 
            this.bl_gioitinh.AutoSize = true;
            this.bl_gioitinh.Location = new System.Drawing.Point(9, 172);
            this.bl_gioitinh.Name = "bl_gioitinh";
            this.bl_gioitinh.Size = new System.Drawing.Size(55, 16);
            this.bl_gioitinh.TabIndex = 20;
            this.bl_gioitinh.Text = "Giới tính";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(28, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 52);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(116, 86);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(148, 21);
            this.txt_tennv.TabIndex = 19;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(454, 84);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(148, 21);
            this.txt_diachi.TabIndex = 17;
            // 
            // txt_sodt
            // 
            this.txt_sodt.Location = new System.Drawing.Point(454, 121);
            this.txt_sodt.Name = "txt_sodt";
            this.txt_sodt.Size = new System.Drawing.Size(148, 21);
            this.txt_sodt.TabIndex = 15;
            // 
            // date_ngaysinh
            // 
            this.date_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaysinh.Location = new System.Drawing.Point(454, 51);
            this.date_ngaysinh.Name = "date_ngaysinh";
            this.date_ngaysinh.Size = new System.Drawing.Size(148, 21);
            this.date_ngaysinh.TabIndex = 12;
            // 
            // cmb_macv
            // 
            this.cmb_macv.DisplayMember = "tenchucvu";
            this.cmb_macv.FormattingEnabled = true;
            this.cmb_macv.Location = new System.Drawing.Point(116, 123);
            this.cmb_macv.Name = "cmb_macv";
            this.cmb_macv.Size = new System.Drawing.Size(148, 23);
            this.cmb_macv.TabIndex = 11;
            this.cmb_macv.ValueMember = "machucvu";
            // 
            // dgv_nhanvien
            // 
            this.dgv_nhanvien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.manhanvien,
            this.tennhanvien,
            this.machucvu,
            this.ngaysinh,
            this.gioitinh,
            this.diachi,
            this.sodienthoai});
            this.dgv_nhanvien.Location = new System.Drawing.Point(9, 26);
            this.dgv_nhanvien.Name = "dgv_nhanvien";
            this.dgv_nhanvien.Size = new System.Drawing.Size(883, 187);
            this.dgv_nhanvien.TabIndex = 0;
            this.dgv_nhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhanvien_CellContentClick);
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataMember = "nhanvien";
            // 
            // grp_danhsach
            // 
            this.grp_danhsach.Controls.Add(this.dgv_nhanvien);
            this.grp_danhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grp_danhsach.Location = new System.Drawing.Point(28, 264);
            this.grp_danhsach.Name = "grp_danhsach";
            this.grp_danhsach.Size = new System.Drawing.Size(898, 219);
            this.grp_danhsach.TabIndex = 12;
            this.grp_danhsach.TabStop = false;
            this.grp_danhsach.Text = "Danh sách nhân viên";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbs_add,
            this.tbs_edit,
            this.tbs_save,
            this.tbs_delete,
            this.tbs_exit,
            this.txt_search,
            this.tbs_search,
            this.tbs_xemnv});
            this.toolStrip1.Location = new System.Drawing.Point(201, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(682, 41);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbs_add
            // 
            this.tbs_add.Image = global::Khachsan.Properties.Resources.add1;
            this.tbs_add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_add.Name = "tbs_add";
            this.tbs_add.Size = new System.Drawing.Size(59, 38);
            this.tbs_add.Text = "Add";
            this.tbs_add.Click += new System.EventHandler(this.tbs_add_Click);
            // 
            // tbs_edit
            // 
            this.tbs_edit.Image = ((System.Drawing.Image)(resources.GetObject("tbs_edit.Image")));
            this.tbs_edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_edit.Name = "tbs_edit";
            this.tbs_edit.Size = new System.Drawing.Size(58, 38);
            this.tbs_edit.Text = "Edit";
            this.tbs_edit.Click += new System.EventHandler(this.tbs_edit_Click);
            // 
            // tbs_save
            // 
            this.tbs_save.Image = ((System.Drawing.Image)(resources.GetObject("tbs_save.Image")));
            this.tbs_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_save.Name = "tbs_save";
            this.tbs_save.Size = new System.Drawing.Size(61, 38);
            this.tbs_save.Text = "Save";
            this.tbs_save.Click += new System.EventHandler(this.tbs_save_Click);
            // 
            // tbs_delete
            // 
            this.tbs_delete.Image = ((System.Drawing.Image)(resources.GetObject("tbs_delete.Image")));
            this.tbs_delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_delete.Name = "tbs_delete";
            this.tbs_delete.Size = new System.Drawing.Size(78, 38);
            this.tbs_delete.Text = "Delete";
            this.tbs_delete.Click += new System.EventHandler(this.tbs_delete_Click);
            // 
            // tbs_exit
            // 
            this.tbs_exit.Image = ((System.Drawing.Image)(resources.GetObject("tbs_exit.Image")));
            this.tbs_exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_exit.Name = "tbs_exit";
            this.tbs_exit.Size = new System.Drawing.Size(61, 38);
            this.tbs_exit.Text = "Exit ";
            this.tbs_exit.Click += new System.EventHandler(this.tbs_exit_Click);
            // 
            // txt_search
            // 
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 41);
            this.txt_search.Click += new System.EventHandler(this.txt_search_Click);
            // 
            // tbs_search
            // 
            this.tbs_search.Image = global::Khachsan.Properties.Resources.timkiem;
            this.tbs_search.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_search.Name = "tbs_search";
            this.tbs_search.Size = new System.Drawing.Size(80, 38);
            this.tbs_search.Text = "Search";
            this.tbs_search.Click += new System.EventHandler(this.tbs_search_Click);
            // 
            // tbs_xemnv
            // 
            this.tbs_xemnv.Image = global::Khachsan.Properties.Resources.xem;
            this.tbs_xemnv.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_xemnv.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_xemnv.Name = "tbs_xemnv";
            this.tbs_xemnv.Size = new System.Drawing.Size(171, 38);
            this.tbs_xemnv.Text = "Nhân viên theo chức vụ";
            this.tbs_xemnv.Click += new System.EventHandler(this.tbs_xemnv_Click);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // manhanvien
            // 
            this.manhanvien.DataPropertyName = "manhanvien";
            this.manhanvien.HeaderText = "Mã nhân viên";
            this.manhanvien.Name = "manhanvien";
            // 
            // tennhanvien
            // 
            this.tennhanvien.DataPropertyName = "tennhanvien";
            this.tennhanvien.HeaderText = "Tên nhân viên";
            this.tennhanvien.Name = "tennhanvien";
            // 
            // machucvu
            // 
            this.machucvu.DataPropertyName = "machucvu";
            this.machucvu.HeaderText = "Mã chức vụ";
            this.machucvu.Name = "machucvu";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // sodienthoai
            // 
            this.sodienthoai.DataPropertyName = "sodienthoai";
            this.sodienthoai.HeaderText = "Số điện thoại";
            this.sodienthoai.Name = "sodienthoai";
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(938, 554);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grp_danhsach);
            this.Controls.Add(this.grpchitiet);
            this.Name = "Nhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.Nhanvien_Load);
            this.grpchitiet.ResumeLayout(false);
            this.grpchitiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            this.grp_danhsach.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_manv;
        private System.Windows.Forms.Label lbl_tennv;
        private System.Windows.Forms.Label lbl_ngaysinh;
        private System.Windows.Forms.Label lbl_macv;
        private System.Windows.Forms.Label lbl_sodt;
        private System.Windows.Forms.Label lbl_diachi;
        private System.Windows.Forms.GroupBox grpchitiet;
        private System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_sodt;
        private System.Windows.Forms.DateTimePicker date_ngaysinh;
        private System.Windows.Forms.ComboBox cmb_macv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_nhanvien;
        private System.Windows.Forms.GroupBox grp_danhsach;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbs_add;
        private System.Windows.Forms.ToolStripButton tbs_edit;
        private System.Windows.Forms.ToolStripButton tbs_save;
        private System.Windows.Forms.ToolStripButton tbs_delete;
        private System.Windows.Forms.ToolStripButton tbs_exit;
        private System.Windows.Forms.ToolStripTextBox txt_search;
        private System.Windows.Forms.ToolStripButton tbs_search;
 //       private KhachsanDataSet khachsanDataSet;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private System.Windows.Forms.Label bl_gioitinh;
        private System.Windows.Forms.TextBox txt_manhanvien;
        private System.Windows.Forms.TextBox txt_gioitinh;
        private System.Windows.Forms.ToolStripButton tbs_xemnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn machucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
    }
}