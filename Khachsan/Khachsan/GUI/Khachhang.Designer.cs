namespace Khachsan.GUI
{
    partial class Khachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khachhang));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_makhachhang = new System.Windows.Forms.TextBox();
            this.txt_quoctich = new System.Windows.Forms.TextBox();
            this.txt_sodt = new System.Windows.Forms.TextBox();
            this.txt_cmt = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_tenkhachhang = new System.Windows.Forms.TextBox();
            this.khachhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbs_add = new System.Windows.Forms.ToolStripButton();
            this.tbs_edit = new System.Windows.Forms.ToolStripButton();
            this.tbs_save = new System.Windows.Forms.ToolStripButton();
            this.tbs_delete = new System.Windows.Forms.ToolStripButton();
            this.tbs_exit = new System.Windows.Forms.ToolStripButton();
            this.txt_timkiem = new System.Windows.Forms.ToolStripTextBox();
            this.tbs_seach = new System.Windows.Forms.ToolStripButton();
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.dgv_kh = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoctich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_gioitinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.date_ngaysinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.grp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(121, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(466, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số ĐT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(121, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(464, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "CMT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(464, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quốc tịch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(464, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Địa chỉ";
            // 
            // txt_makhachhang
            // 
            this.txt_makhachhang.Location = new System.Drawing.Point(247, 82);
            this.txt_makhachhang.Name = "txt_makhachhang";
            this.txt_makhachhang.Size = new System.Drawing.Size(130, 20);
            this.txt_makhachhang.TabIndex = 11;
            // 
            // txt_quoctich
            // 
            this.txt_quoctich.Location = new System.Drawing.Point(554, 176);
            this.txt_quoctich.Name = "txt_quoctich";
            this.txt_quoctich.Size = new System.Drawing.Size(122, 20);
            this.txt_quoctich.TabIndex = 13;
            // 
            // txt_sodt
            // 
            this.txt_sodt.Location = new System.Drawing.Point(554, 111);
            this.txt_sodt.Name = "txt_sodt";
            this.txt_sodt.Size = new System.Drawing.Size(122, 20);
            this.txt_sodt.TabIndex = 15;
            // 
            // txt_cmt
            // 
            this.txt_cmt.Location = new System.Drawing.Point(554, 143);
            this.txt_cmt.Name = "txt_cmt";
            this.txt_cmt.Size = new System.Drawing.Size(122, 20);
            this.txt_cmt.TabIndex = 17;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(554, 82);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(122, 20);
            this.txt_diachi.TabIndex = 19;
            // 
            // txt_tenkhachhang
            // 
            this.txt_tenkhachhang.Location = new System.Drawing.Point(247, 111);
            this.txt_tenkhachhang.Name = "txt_tenkhachhang";
            this.txt_tenkhachhang.Size = new System.Drawing.Size(130, 20);
            this.txt_tenkhachhang.TabIndex = 21;
            // 
            // khachhangBindingSource
            // 
            this.khachhangBindingSource.DataMember = "khachhang";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbs_add,
            this.tbs_edit,
            this.tbs_save,
            this.tbs_delete,
            this.tbs_exit,
            this.txt_timkiem,
            this.tbs_seach});
            this.toolStrip1.Location = new System.Drawing.Point(124, 9);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(504, 41);
            this.toolStrip1.TabIndex = 29;
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
            this.tbs_exit.Size = new System.Drawing.Size(58, 38);
            this.tbs_exit.Text = "Exit";
            this.tbs_exit.Click += new System.EventHandler(this.tbs_exit_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(100, 41);
            this.txt_timkiem.Click += new System.EventHandler(this.txt_timkiem_Click);
            // 
            // tbs_seach
            // 
            this.tbs_seach.Image = global::Khachsan.Properties.Resources.timkiem;
            this.tbs_seach.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_seach.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_seach.Name = "tbs_seach";
            this.tbs_seach.Size = new System.Drawing.Size(76, 38);
            this.tbs_seach.Text = "Seach";
            this.tbs_seach.Click += new System.EventHandler(this.tbs_seach_Click);
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.dgv_kh);
            this.grp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grp1.Location = new System.Drawing.Point(12, 226);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(784, 193);
            this.grp1.TabIndex = 30;
            this.grp1.TabStop = false;
            this.grp1.Text = "Danh sách khách hàng";
            // 
            // dgv_kh
            // 
            this.dgv_kh.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_kh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.makhachhang,
            this.tenkhachhang,
            this.ngaysinh,
            this.gioitinh,
            this.diachi,
            this.sodienthoai,
            this.CMT,
            this.quoctich});
            this.dgv_kh.Location = new System.Drawing.Point(22, 37);
            this.dgv_kh.Name = "dgv_kh";
            this.dgv_kh.Size = new System.Drawing.Size(745, 150);
            this.dgv_kh.TabIndex = 0;
            this.dgv_kh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kh_CellContentClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // makhachhang
            // 
            this.makhachhang.DataPropertyName = "makhachhang";
            this.makhachhang.HeaderText = "Mã khách hàng";
            this.makhachhang.Name = "makhachhang";
            // 
            // tenkhachhang
            // 
            this.tenkhachhang.DataPropertyName = "tenkhachhang";
            this.tenkhachhang.HeaderText = "Tên khách hàng";
            this.tenkhachhang.Name = "tenkhachhang";
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
            // CMT
            // 
            this.CMT.DataPropertyName = "CMT";
            this.CMT.HeaderText = "Chứng minh thư";
            this.CMT.Name = "CMT";
            // 
            // quoctich
            // 
            this.quoctich.DataPropertyName = "quoctich";
            this.quoctich.HeaderText = "Quốc tịch";
            this.quoctich.Name = "quoctich";
            // 
            // txt_gioitinh
            // 
            this.txt_gioitinh.Location = new System.Drawing.Point(247, 181);
            this.txt_gioitinh.Name = "txt_gioitinh";
            this.txt_gioitinh.Size = new System.Drawing.Size(130, 20);
            this.txt_gioitinh.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(121, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Giới tính";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(121, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Ngày sinh";
            // 
            // date_ngaysinh
            // 
            this.date_ngaysinh.Location = new System.Drawing.Point(247, 143);
            this.date_ngaysinh.Name = "date_ngaysinh";
            this.date_ngaysinh.Size = new System.Drawing.Size(130, 20);
            this.date_ngaysinh.TabIndex = 34;
            // 
            // Khachhang
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 454);
            this.Controls.Add(this.date_ngaysinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_gioitinh);
            this.Controls.Add(this.grp1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txt_tenkhachhang);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.txt_cmt);
            this.Controls.Add(this.txt_sodt);
            this.Controls.Add(this.txt_quoctich);
            this.Controls.Add(this.txt_makhachhang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Khachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khachhang";
            this.Load += new System.EventHandler(this.Khachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khachhangBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_makhachhang;
        private System.Windows.Forms.TextBox txt_quoctich;
        private System.Windows.Forms.TextBox txt_sodt;
        private System.Windows.Forms.TextBox txt_cmt;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_tenkhachhang;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbs_add;
        private System.Windows.Forms.ToolStripButton tbs_edit;
        private System.Windows.Forms.ToolStripButton tbs_save;
        private System.Windows.Forms.ToolStripButton tbs_delete;
        private System.Windows.Forms.ToolStripButton tbs_exit;
        private System.Windows.Forms.ToolStripTextBox txt_timkiem;
        private System.Windows.Forms.ToolStripButton tbs_seach;
        private System.Windows.Forms.GroupBox grp1;
    //    private KhachsanDataSet khachsanDataSet;
        private System.Windows.Forms.BindingSource khachhangBindingSource;
     //   private KhachsanDataSetTableAdapters.khachhangTableAdapter khachhangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhachhangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhachhangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoctichDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_gioitinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker date_ngaysinh;
        private System.Windows.Forms.DataGridView dgv_kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoctich;
    }
}