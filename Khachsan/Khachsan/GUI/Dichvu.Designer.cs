namespace Khachsan.GUI
{
    partial class Dichvu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_dichvu = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbs_add = new System.Windows.Forms.ToolStripButton();
            this.tbs_save = new System.Windows.Forms.ToolStripButton();
            this.tbs_edit = new System.Windows.Forms.ToolStripButton();
            this.tbs_delete = new System.Windows.Forms.ToolStripButton();
            this.tbs_exit = new System.Windows.Forms.ToolStripButton();
            this.txt_timkiem = new System.Windows.Forms.ToolStripTextBox();
            this.tbs_search = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_madv = new System.Windows.Forms.TextBox();
            this.txt_giadv = new System.Windows.Forms.TextBox();
            this.txt_tendv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giadichvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichvu)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dichvu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(51, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách dịch vụ";
            // 
            // dgv_dichvu
            // 
            this.dgv_dichvu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_dichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dichvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.madichvu,
            this.tendichvu,
            this.giadichvu});
            this.dgv_dichvu.Location = new System.Drawing.Point(61, 37);
            this.dgv_dichvu.Name = "dgv_dichvu";
            this.dgv_dichvu.Size = new System.Drawing.Size(448, 139);
            this.dgv_dichvu.TabIndex = 0;
            this.dgv_dichvu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dichvu_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbs_add,
            this.tbs_save,
            this.tbs_edit,
            this.tbs_delete,
            this.tbs_exit,
            this.txt_timkiem,
            this.tbs_search});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(755, 41);
            this.toolStrip1.TabIndex = 1;
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
            // tbs_save
            // 
            this.tbs_save.Image = global::Khachsan.Properties.Resources.save_icon;
            this.tbs_save.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_save.Name = "tbs_save";
            this.tbs_save.Size = new System.Drawing.Size(61, 38);
            this.tbs_save.Text = "Save";
            this.tbs_save.Click += new System.EventHandler(this.tbs_save_Click);
            // 
            // tbs_edit
            // 
            this.tbs_edit.Image = global::Khachsan.Properties.Resources.Edit_icon;
            this.tbs_edit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_edit.Name = "tbs_edit";
            this.tbs_edit.Size = new System.Drawing.Size(58, 38);
            this.tbs_edit.Text = "Edit";
            this.tbs_edit.Click += new System.EventHandler(this.tbs_edit_Click);
            // 
            // tbs_delete
            // 
            this.tbs_delete.Image = global::Khachsan.Properties.Resources.blue_delete_button_png_291;
            this.tbs_delete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_delete.Name = "tbs_delete";
            this.tbs_delete.Size = new System.Drawing.Size(78, 38);
            this.tbs_delete.Text = "Delete";
            this.tbs_delete.Click += new System.EventHandler(this.tbs_delete_Click);
            // 
            // tbs_exit
            // 
            this.tbs_exit.Image = global::Khachsan.Properties.Resources.tao_icon_shutdown_hoac_restart_ngoai_desktop_1;
            this.tbs_exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbs_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbs_exit.Name = "tbs_exit";
            this.tbs_exit.Size = new System.Drawing.Size(58, 38);
            this.tbs_exit.Text = "Exit";
            this.tbs_exit.Click += new System.EventHandler(this.tbs_exit_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(100, 41);
            this.txt_timkiem.Click += new System.EventHandler(this.txt_timkiem_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(188, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(188, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên dịch vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(188, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giá dịch vụ";
            // 
            // txt_madv
            // 
            this.txt_madv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_madv.Location = new System.Drawing.Point(288, 45);
            this.txt_madv.Name = "txt_madv";
            this.txt_madv.Size = new System.Drawing.Size(184, 21);
            this.txt_madv.TabIndex = 9;
            // 
            // txt_giadv
            // 
            this.txt_giadv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_giadv.Location = new System.Drawing.Point(288, 118);
            this.txt_giadv.Name = "txt_giadv";
            this.txt_giadv.Size = new System.Drawing.Size(184, 21);
            this.txt_giadv.TabIndex = 11;
            // 
            // txt_tendv
            // 
            this.txt_tendv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tendv.Location = new System.Drawing.Point(288, 83);
            this.txt_tendv.Name = "txt_tendv";
            this.txt_tendv.Size = new System.Drawing.Size(184, 21);
            this.txt_tendv.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(478, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "VNĐ";
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
            // Dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(755, 363);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tendv);
            this.Controls.Add(this.txt_giadv);
            this.Controls.Add(this.txt_madv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dichvu";
            this.Text = "Dịch vụ";
            this.Load += new System.EventHandler(this.Dichvu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichvu)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbs_add;
        private System.Windows.Forms.ToolStripButton tbs_save;
        private System.Windows.Forms.ToolStripButton tbs_edit;
        private System.Windows.Forms.ToolStripButton tbs_delete;
        private System.Windows.Forms.ToolStripButton tbs_exit;
        private System.Windows.Forms.DataGridView dgv_dichvu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_madv;
        private System.Windows.Forms.TextBox txt_giadv;
        private System.Windows.Forms.TextBox txt_tendv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripTextBox txt_timkiem;
        private System.Windows.Forms.ToolStripButton tbs_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn madichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn giadichvu;
    }
}