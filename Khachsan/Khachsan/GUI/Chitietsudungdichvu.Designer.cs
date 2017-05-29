namespace Khachsan.GUI
{
    partial class Chitietsudungdichvu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chitietsudungdichvu));
            this.dgv_chitietdichvu = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giadichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbs_add = new System.Windows.Forms.ToolStripButton();
            this.tbs_edit = new System.Windows.Forms.ToolStripButton();
            this.tbs_exit = new System.Windows.Forms.ToolStripButton();
            this.tbs_save = new System.Windows.Forms.ToolStripButton();
            this.txt_map = new System.Windows.Forms.ToolStripTextBox();
            this.tbs_hienthi = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_madv = new System.Windows.Forms.ComboBox();
            this.txt_tendv = new System.Windows.Forms.TextBox();
            this.txt_giadv = new System.Windows.Forms.TextBox();
            this.cmb_maphieu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietdichvu)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_chitietdichvu
            // 
            this.dgv_chitietdichvu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_chitietdichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitietdichvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.madichvu,
            this.maphieu,
            this.tendichvu,
            this.giadichvu});
            this.dgv_chitietdichvu.Location = new System.Drawing.Point(58, 202);
            this.dgv_chitietdichvu.Name = "dgv_chitietdichvu";
            this.dgv_chitietdichvu.Size = new System.Drawing.Size(550, 150);
            this.dgv_chitietdichvu.TabIndex = 1;
            this.dgv_chitietdichvu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chitietdichvu_CellContentClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // madichvu
            // 
            this.madichvu.DataPropertyName = "madichvu";
            this.madichvu.HeaderText = "Mã dịch vụ";
            this.madichvu.Name = "madichvu";
            // 
            // maphieu
            // 
            this.maphieu.DataPropertyName = "maphieu";
            this.maphieu.HeaderText = "Mã phiếu";
            this.maphieu.Name = "maphieu";
            // 
            // tendichvu
            // 
            this.tendichvu.DataPropertyName = "tendichvu";
            this.tendichvu.HeaderText = "Tên dịch vụ";
            this.tendichvu.Name = "tendichvu";
            // 
            // giadichvu
            // 
            this.giadichvu.DataPropertyName = "giadichvu";
            this.giadichvu.HeaderText = "Giá dịch vụ";
            this.giadichvu.Name = "giadichvu";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbs_add,
            this.tbs_edit,
            this.tbs_exit,
            this.tbs_save,
            this.txt_map,
            this.tbs_hienthi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(844, 36);
            this.toolStrip1.TabIndex = 2;
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
            this.tbs_add.Click += new System.EventHandler(this.tbs_dichvu_Click);
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
            this.label1.Location = new System.Drawing.Point(83, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(349, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(83, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã phiếu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(349, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giá dịch vụ";
            // 
            // cmb_madv
            // 
            this.cmb_madv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmb_madv.FormattingEnabled = true;
            this.cmb_madv.Location = new System.Drawing.Point(198, 88);
            this.cmb_madv.Name = "cmb_madv";
            this.cmb_madv.Size = new System.Drawing.Size(100, 23);
            this.cmb_madv.TabIndex = 10;
            this.cmb_madv.SelectedIndexChanged += new System.EventHandler(this.cmb_madv_SelectedIndexChanged);
            // 
            // txt_tendv
            // 
            this.txt_tendv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tendv.Location = new System.Drawing.Point(445, 89);
            this.txt_tendv.Name = "txt_tendv";
            this.txt_tendv.Size = new System.Drawing.Size(163, 21);
            this.txt_tendv.TabIndex = 11;
            // 
            // txt_giadv
            // 
            this.txt_giadv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_giadv.Location = new System.Drawing.Point(445, 122);
            this.txt_giadv.Name = "txt_giadv";
            this.txt_giadv.Size = new System.Drawing.Size(163, 21);
            this.txt_giadv.TabIndex = 12;
            // 
            // cmb_maphieu
            // 
            this.cmb_maphieu.FormattingEnabled = true;
            this.cmb_maphieu.Location = new System.Drawing.Point(198, 127);
            this.cmb_maphieu.Name = "cmb_maphieu";
            this.cmb_maphieu.Size = new System.Drawing.Size(100, 21);
            this.cmb_maphieu.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "VNĐ";
            // 
            // Chitietsudungdichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(844, 401);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_maphieu);
            this.Controls.Add(this.txt_giadv);
            this.Controls.Add(this.txt_tendv);
            this.Controls.Add(this.cmb_madv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_chitietdichvu);
            this.Name = "Chitietsudungdichvu";
            this.Text = "Chitietsudungdichvu";
            this.Load += new System.EventHandler(this.Chitietsudungdichvu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietdichvu)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_chitietdichvu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbs_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_madv;
        private System.Windows.Forms.TextBox txt_tendv;
        private System.Windows.Forms.TextBox txt_giadv;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn madichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn giadichvu;
        private System.Windows.Forms.ToolStripButton tbs_edit;
        private System.Windows.Forms.ToolStripButton tbs_exit;
        private System.Windows.Forms.ComboBox cmb_maphieu;
        private System.Windows.Forms.ToolStripButton tbs_save;
        private System.Windows.Forms.ToolStripTextBox txt_map;
        private System.Windows.Forms.ToolStripButton tbs_hienthi;
        private System.Windows.Forms.Label label5;
    }
}