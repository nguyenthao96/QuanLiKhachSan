namespace Khachsan.GUI
{
    partial class Thietbi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mathietbi = new System.Windows.Forms.TextBox();
            this.txt_tenthietbi = new System.Windows.Forms.TextBox();
            this.txt_giathietbi = new System.Windows.Forms.TextBox();
            this.cmb_maloai = new System.Windows.Forms.ComboBox();
            this.dgv_thietbi = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloaithietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giathietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbs_add = new System.Windows.Forms.ToolStripButton();
            this.tbs_edit = new System.Windows.Forms.ToolStripButton();
            this.tbs_save = new System.Windows.Forms.ToolStripButton();
            this.tbs_delete = new System.Windows.Forms.ToolStripButton();
            this.tbs_exit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tbs_xemtb = new System.Windows.Forms.ToolStripButton();
            this.lbl_tinhtrang = new System.Windows.Forms.Label();
            this.txt_tinhtrang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thietbi)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(82, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thiết bị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(372, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá loại thiết bị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(82, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã thiết bị";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(372, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Loại thiết bị ";
            // 
            // txt_mathietbi
            // 
            this.txt_mathietbi.Location = new System.Drawing.Point(186, 64);
            this.txt_mathietbi.Name = "txt_mathietbi";
            this.txt_mathietbi.Size = new System.Drawing.Size(139, 20);
            this.txt_mathietbi.TabIndex = 9;
            // 
            // txt_tenthietbi
            // 
            this.txt_tenthietbi.Location = new System.Drawing.Point(186, 106);
            this.txt_tenthietbi.Name = "txt_tenthietbi";
            this.txt_tenthietbi.Size = new System.Drawing.Size(139, 20);
            this.txt_tenthietbi.TabIndex = 10;
            // 
            // txt_giathietbi
            // 
            this.txt_giathietbi.Location = new System.Drawing.Point(489, 106);
            this.txt_giathietbi.Name = "txt_giathietbi";
            this.txt_giathietbi.Size = new System.Drawing.Size(139, 20);
            this.txt_giathietbi.TabIndex = 11;
            // 
            // cmb_maloai
            // 
            this.cmb_maloai.FormattingEnabled = true;
            this.cmb_maloai.Location = new System.Drawing.Point(489, 63);
            this.cmb_maloai.Name = "cmb_maloai";
            this.cmb_maloai.Size = new System.Drawing.Size(139, 21);
            this.cmb_maloai.TabIndex = 12;
            // 
            // dgv_thietbi
            // 
            this.dgv_thietbi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_thietbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_thietbi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.mathietbi,
            this.tenthietbi,
            this.maloaithietbi,
            this.giathietbi,
            this.tinhtrang});
            this.dgv_thietbi.Location = new System.Drawing.Point(44, 194);
            this.dgv_thietbi.Name = "dgv_thietbi";
            this.dgv_thietbi.Size = new System.Drawing.Size(648, 224);
            this.dgv_thietbi.TabIndex = 13;
            this.dgv_thietbi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_thietbi_CellContentClick);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
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
            // maloaithietbi
            // 
            this.maloaithietbi.DataPropertyName = "maloaithietbi";
            this.maloaithietbi.HeaderText = "Mã loại thiết bị";
            this.maloaithietbi.Name = "maloaithietbi";
            // 
            // giathietbi
            // 
            this.giathietbi.DataPropertyName = "giathietbi";
            this.giathietbi.HeaderText = "Giá thiết bị";
            this.giathietbi.Name = "giathietbi";
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "tinhtrang";
            this.tinhtrang.HeaderText = "Tình trạng sử dụng";
            this.tinhtrang.Name = "tinhtrang";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbs_add,
            this.tbs_edit,
            this.tbs_save,
            this.tbs_delete,
            this.tbs_exit,
            this.toolStripButton1,
            this.tbs_xemtb});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(710, 37);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbs_add
            // 
            this.tbs_add.Image = global::Khachsan.Properties.Resources.add1;
            this.tbs_add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_add.Name = "tbs_add";
            this.tbs_add.Size = new System.Drawing.Size(59, 34);
            this.tbs_add.Text = "Add";
            this.tbs_add.Click += new System.EventHandler(this.tbs_add_Click);
            // 
            // tbs_edit
            // 
            this.tbs_edit.Image = global::Khachsan.Properties.Resources.Edit_icon;
            this.tbs_edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_edit.Name = "tbs_edit";
            this.tbs_edit.Size = new System.Drawing.Size(58, 34);
            this.tbs_edit.Text = "Edit";
            this.tbs_edit.ToolTipText = "Edit";
            this.tbs_edit.Click += new System.EventHandler(this.tbs_edit_Click);
            // 
            // tbs_save
            // 
            this.tbs_save.Image = global::Khachsan.Properties.Resources.save_icon;
            this.tbs_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_save.Name = "tbs_save";
            this.tbs_save.Size = new System.Drawing.Size(61, 34);
            this.tbs_save.Text = "Save";
            this.tbs_save.Click += new System.EventHandler(this.tbs_save_Click);
            // 
            // tbs_delete
            // 
            this.tbs_delete.Image = global::Khachsan.Properties.Resources.blue_delete_button_png_291;
            this.tbs_delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_delete.Name = "tbs_delete";
            this.tbs_delete.Size = new System.Drawing.Size(78, 34);
            this.tbs_delete.Text = "Delete";
            this.tbs_delete.Click += new System.EventHandler(this.tbs_delete_Click);
            // 
            // tbs_exit
            // 
            this.tbs_exit.Image = global::Khachsan.Properties.Resources.tao_icon_shutdown_hoac_restart_ngoai_desktop_1;
            this.tbs_exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_exit.Name = "tbs_exit";
            this.tbs_exit.Size = new System.Drawing.Size(58, 34);
            this.tbs_exit.Text = "Exit";
            this.tbs_exit.Click += new System.EventHandler(this.tbs_exit_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Khachsan.Properties.Resources.xem;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(148, 34);
            this.toolStripButton1.Text = "Xem chi tiết thiết bị";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tbs_xemtb
            // 
            this.tbs_xemtb.Image = global::Khachsan.Properties.Resources.xem;
            this.tbs_xemtb.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_xemtb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_xemtb.Name = "tbs_xemtb";
            this.tbs_xemtb.Size = new System.Drawing.Size(158, 34);
            this.tbs_xemtb.Text = "Xem thiết bị theo loại";
            this.tbs_xemtb.Click += new System.EventHandler(this.tbs_xemtb_Click);
            // 
            // lbl_tinhtrang
            // 
            this.lbl_tinhtrang.AutoSize = true;
            this.lbl_tinhtrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_tinhtrang.Location = new System.Drawing.Point(183, 156);
            this.lbl_tinhtrang.Name = "lbl_tinhtrang";
            this.lbl_tinhtrang.Size = new System.Drawing.Size(117, 16);
            this.lbl_tinhtrang.TabIndex = 15;
            this.lbl_tinhtrang.Text = "Tình trạng sử dụng";
            // 
            // txt_tinhtrang
            // 
            this.txt_tinhtrang.Location = new System.Drawing.Point(350, 152);
            this.txt_tinhtrang.Name = "txt_tinhtrang";
            this.txt_tinhtrang.Size = new System.Drawing.Size(142, 20);
            this.txt_tinhtrang.TabIndex = 16;
            // 
            // Thietbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 430);
            this.Controls.Add(this.txt_tinhtrang);
            this.Controls.Add(this.lbl_tinhtrang);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_thietbi);
            this.Controls.Add(this.cmb_maloai);
            this.Controls.Add(this.txt_giathietbi);
            this.Controls.Add(this.txt_tenthietbi);
            this.Controls.Add(this.txt_mathietbi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Thietbi";
            this.Text = "Thiết bị";
            this.Load += new System.EventHandler(this.Thietbi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_thietbi)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_mathietbi;
        private System.Windows.Forms.TextBox txt_tenthietbi;
        private System.Windows.Forms.TextBox txt_giathietbi;
        private System.Windows.Forms.ComboBox cmb_maloai;
        private System.Windows.Forms.DataGridView dgv_thietbi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbs_add;
        private System.Windows.Forms.ToolStripButton tbs_edit;
        private System.Windows.Forms.ToolStripButton tbs_save;
        private System.Windows.Forms.ToolStripButton tbs_delete;
        private System.Windows.Forms.ToolStripButton tbs_exit;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tbs_xemtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaithietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn giathietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
        private System.Windows.Forms.Label lbl_tinhtrang;
        private System.Windows.Forms.TextBox txt_tinhtrang;
    }
}