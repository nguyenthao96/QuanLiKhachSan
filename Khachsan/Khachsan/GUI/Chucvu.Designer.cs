namespace Khachsan.GUI
{
    partial class Chucvu
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
            this.dgv_chucvu = new System.Windows.Forms.DataGridView();
            this.chucvuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grp1 = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chucvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource)).BeginInit();
            this.grp1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_chucvu
            // 
            this.dgv_chucvu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_chucvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chucvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_chucvu.Location = new System.Drawing.Point(57, 40);
            this.dgv_chucvu.Name = "dgv_chucvu";
            this.dgv_chucvu.Size = new System.Drawing.Size(345, 174);
            this.dgv_chucvu.TabIndex = 15;
            // 
            // chucvuBindingSource
            // 
            this.chucvuBindingSource.DataMember = "chucvu";
            // 
            // grp1
            // 
            this.grp1.Controls.Add(this.dgv_chucvu);
            this.grp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grp1.ForeColor = System.Drawing.Color.Black;
            this.grp1.Location = new System.Drawing.Point(12, 12);
            this.grp1.Name = "grp1";
            this.grp1.Size = new System.Drawing.Size(461, 214);
            this.grp1.TabIndex = 16;
            this.grp1.TabStop = false;
            this.grp1.Text = "Danh sách chức vụ";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "STT";
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "machucvu";
            this.Column2.HeaderText = "Mã chức vụ";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tenchucvu";
            this.Column3.HeaderText = "Tên chức vụ";
            this.Column3.Name = "Column3";
            // 
            // Chucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(529, 252);
            this.Controls.Add(this.grp1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Chucvu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chức Vụ";
            this.Load += new System.EventHandler(this.Chucvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chucvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucvuBindingSource)).EndInit();
            this.grp1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_chucvu;
        private System.Windows.Forms.GroupBox grp1;
    //    private KhachsanDataSet khachsanDataSet;
        private System.Windows.Forms.BindingSource chucvuBindingSource;
     //   private KhachsanDataSetTableAdapters.chucvuTableAdapter chucvuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machucvuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenchucvuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}