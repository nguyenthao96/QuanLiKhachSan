namespace Khachsan.GUI
{
    partial class Chitietsudungthietbi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chitietsudungthietbi));
            this.dgv_chitiet = new System.Windows.Forms.DataGridView();
            this.chitietsudungthietbiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_tenthietbi = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbs_add = new System.Windows.Forms.ToolStripButton();
            this.tbs_save = new System.Windows.Forms.ToolStripButton();
            this.tbs_edit = new System.Windows.Forms.ToolStripButton();
            this.tbs_exit = new System.Windows.Forms.ToolStripButton();
            this.txt_map = new System.Windows.Forms.ToolStripTextBox();
            this.tbs_hienthi = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_maphong = new System.Windows.Forms.ComboBox();
            this.cmb_mathietbi = new System.Windows.Forms.ComboBox();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietsudungthietbiBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_chitiet
            // 
            this.dgv_chitiet.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_chitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphong,
            this.mathietbi,
            this.tenthietbi});
            this.dgv_chitiet.Location = new System.Drawing.Point(86, 188);
            this.dgv_chitiet.Name = "dgv_chitiet";
            this.dgv_chitiet.Size = new System.Drawing.Size(346, 150);
            this.dgv_chitiet.TabIndex = 0;
            this.dgv_chitiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chitiet_CellContentClick);
            // 
            // chitietsudungthietbiBindingSource
            // 
            this.chitietsudungthietbiBindingSource.DataMember = "chitietsudungthietbi";
            // 
            // txt_tenthietbi
            // 
            this.txt_tenthietbi.Location = new System.Drawing.Point(229, 131);
            this.txt_tenthietbi.Name = "txt_tenthietbi";
            this.txt_tenthietbi.Size = new System.Drawing.Size(100, 20);
            this.txt_tenthietbi.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbs_add,
            this.tbs_save,
            this.tbs_edit,
            this.tbs_exit,
            this.txt_map,
            this.tbs_hienthi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(555, 36);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbs_add
            // 
            this.tbs_add.Image = global::Khachsan.Properties.Resources.add1;
            this.tbs_add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_add.Name = "tbs_add";
            this.tbs_add.Size = new System.Drawing.Size(59, 33);
            this.tbs_add.Text = "Add";
            this.tbs_add.Click += new System.EventHandler(this.tbs_add_Click);
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
            // txt_map
            // 
            this.txt_map.Name = "txt_map";
            this.txt_map.Size = new System.Drawing.Size(100, 36);
            // 
            // tbs_hienthi
            // 
            this.tbs_hienthi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tbs_hienthi.Image = ((System.Drawing.Image)(resources.GetObject("tbs_hienthi.Image")));
            this.tbs_hienthi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_hienthi.Name = "tbs_hienthi";
            this.tbs_hienthi.Size = new System.Drawing.Size(53, 33);
            this.tbs_hienthi.Text = "Hiển thị";
            this.tbs_hienthi.Click += new System.EventHandler(this.tbs_hienthi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(109, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên thiết bị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(109, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã thiết bị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(109, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã phòng";
            // 
            // cmb_maphong
            // 
            this.cmb_maphong.FormattingEnabled = true;
            this.cmb_maphong.Location = new System.Drawing.Point(229, 60);
            this.cmb_maphong.Name = "cmb_maphong";
            this.cmb_maphong.Size = new System.Drawing.Size(100, 21);
            this.cmb_maphong.TabIndex = 8;
            // 
            // cmb_mathietbi
            // 
            this.cmb_mathietbi.FormattingEnabled = true;
            this.cmb_mathietbi.Location = new System.Drawing.Point(229, 94);
            this.cmb_mathietbi.Name = "cmb_mathietbi";
            this.cmb_mathietbi.Size = new System.Drawing.Size(100, 21);
            this.cmb_mathietbi.TabIndex = 9;
            this.cmb_mathietbi.SelectedIndexChanged += new System.EventHandler(this.cmb_mathietbi_SelectedIndexChanged);
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.Name = "maphong";
            // 
            // mathietbi
            // 
            this.mathietbi.DataPropertyName = "mathietbi";
            this.mathietbi.HeaderText = "Mã thiết bị";
            this.mathietbi.Name = "mathietbi";
            // 
            // tenthietbi
            // 
            this.tenthietbi.DataPropertyName = "tenthietbi";
            this.tenthietbi.HeaderText = "Tên thiết bị";
            this.tenthietbi.Name = "tenthietbi";
            // 
            // Chitietsudungthietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 368);
            this.Controls.Add(this.cmb_mathietbi);
            this.Controls.Add(this.cmb_maphong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txt_tenthietbi);
            this.Controls.Add(this.dgv_chitiet);
            this.Name = "Chitietsudungthietbi";
            this.Text = "Chi tiết sử dụng thiết bị";
            this.Load += new System.EventHandler(this.Chitietdangki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitietsudungthietbiBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_chitiet;
  //      private KhachsanDataSet khachsanDataSet;
        private System.Windows.Forms.BindingSource chitietsudungthietbiBindingSource;
   //     private KhachsanDataSetTableAdapters.chitietsudungthietbiTableAdapter chitietsudungthietbiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathietbiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthietbiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_tenthietbi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_maphong;
        private System.Windows.Forms.ComboBox cmb_mathietbi;
        private System.Windows.Forms.ToolStripButton tbs_add;
        private System.Windows.Forms.ToolStripButton tbs_save;
        private System.Windows.Forms.ToolStripButton tbs_edit;
        private System.Windows.Forms.ToolStripButton tbs_exit;
        private System.Windows.Forms.ToolStripTextBox txt_map;
        private System.Windows.Forms.ToolStripButton tbs_hienthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthietbi;
    }
}