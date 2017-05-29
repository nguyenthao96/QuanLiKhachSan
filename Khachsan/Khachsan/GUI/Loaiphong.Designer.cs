namespace Khachsan.GUI
{
    partial class Loaiphong
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
            this.grp_danhsach = new System.Windows.Forms.GroupBox();
            this.dgv_loaiphong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.grp_danhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiphong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiphongBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_danhsach
            // 
            this.grp_danhsach.Controls.Add(this.dgv_loaiphong);
            this.grp_danhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grp_danhsach.Location = new System.Drawing.Point(35, 12);
            this.grp_danhsach.Name = "grp_danhsach";
            this.grp_danhsach.Size = new System.Drawing.Size(482, 237);
            this.grp_danhsach.TabIndex = 9;
            this.grp_danhsach.TabStop = false;
            this.grp_danhsach.Text = "Danh sách loại phòng";
            // 
            // dgv_loaiphong
            // 
            this.dgv_loaiphong.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv_loaiphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaiphong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.maloaiphong,
            this.Column3,
            this.Column4});
            this.dgv_loaiphong.Location = new System.Drawing.Point(18, 36);
            this.dgv_loaiphong.Name = "dgv_loaiphong";
            this.dgv_loaiphong.Size = new System.Drawing.Size(447, 195);
            this.dgv_loaiphong.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "STT";
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // maloaiphong
            // 
            this.maloaiphong.DataPropertyName = "maloaiphong";
            this.maloaiphong.HeaderText = "Mã loại";
            this.maloaiphong.Name = "maloaiphong";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "loaiphong";
            this.Column3.HeaderText = "Tên loại";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "giaphong";
            this.Column4.HeaderText = "Giá phòng";
            this.Column4.Name = "Column4";
            // 
            // loaiphongBindingSource
            // 
            this.loaiphongBindingSource.DataMember = "loaiphong";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Loaiphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(608, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grp_danhsach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Loaiphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân loại phòng";
            this.Load += new System.EventHandler(this.Loaiphong_Load);
            this.grp_danhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiphong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiphongBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grp_danhsach;
        private System.Windows.Forms.DataGridView dgv_loaiphong;
   //     private KhachsanDataSet khachsanDataSet;
        private System.Windows.Forms.BindingSource loaiphongBindingSource;
    //    private KhachsanDataSetTableAdapters.loaiphongTableAdapter loaiphongTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaiphongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiphongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaphongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button1;
    }
}