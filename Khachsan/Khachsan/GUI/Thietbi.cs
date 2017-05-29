using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Khachsan.ValuesOject;
using Khachsan.BusinessLogiclayer;

namespace Khachsan.GUI
{
    public partial class Thietbi : Form
    {
        public Thietbi()
        {
            InitializeComponent();
        }

        private void Thietbi_Load(object sender, EventArgs e)
        {
            combobox1();
            dgv_thietbi.DataSource = Bus.Getlistthietbi();
          
        }
        public void combobox1()
        {
            cmb_maloai.DisplayMember = "tenloaithietbi";
            cmb_maloai.ValueMember = "maloaithietbi";
            cmb_maloai.DataSource = Bus.Getlistloaithietbi();
           
        }
        private void dgv_thietbi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mathietbi.Text = dgv_thietbi.CurrentRow.Cells["mathietbi"].Value.ToString();
            txt_tenthietbi.Text = dgv_thietbi.CurrentRow.Cells["tenthietbi"].Value.ToString();
            txt_giathietbi.Text = dgv_thietbi.CurrentRow.Cells["giathietbi"].Value.ToString();
            cmb_maloai.SelectedValue = dgv_thietbi.CurrentRow.Cells["maloaithietbi"].Value.ToString();
            txt_tinhtrang.Text = dgv_thietbi.CurrentRow.Cells["tinhtrang"].Value.ToString();
        }

        private void tbs_add_Click(object sender, EventArgs e)
        {
            txt_mathietbi.Text = string.Empty;
            txt_tenthietbi.Text = string.Empty;
            cmb_maloai.Text = string.Empty;
            txt_giathietbi.Text = string.Empty;
            txt_tinhtrang.Text = string.Empty;
        }

        private void tbs_save_Click(object sender, EventArgs e)
        {

            if (txt_mathietbi.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa được nhập.");
                return;
            }
            thietbi t = new thietbi();
            t.maloaithietbi = cmb_maloai.SelectedValue.ToString();
            t.mathietbi = txt_mathietbi.Text;
            t.tenthietbi = txt_tenthietbi.Text;
            t.giathietbi = int.Parse(txt_giathietbi.Text.ToString());
            t.tinhtrang = txt_tinhtrang.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn thêm mới thiết bị ?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(t) > 0)
                {
                    MessageBox.Show("Thao tác đã được thực hiện.");
                    Thietbi_Load(sender, e);
                }
                    
            }
            else MessageBox.Show("Error!");
        }

        private void tbs_edit_Click(object sender, EventArgs e)
        {
            if (txt_mathietbi.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa được nhập.");
                return;
            }
            thietbi t = new thietbi();
            t.maloaithietbi = cmb_maloai.SelectedValue.ToString();
            t.mathietbi = txt_mathietbi.Text;
            t.tenthietbi = txt_tenthietbi.Text;
            t.giathietbi = int.Parse(txt_giathietbi.Text.ToString());
            t.tinhtrang = txt_tinhtrang.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn sửa thiết bị ?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(t) > 0)
                {
                    MessageBox.Show("Thao tác đã được thực hiện.");
                    Thietbi_Load(sender, e);
                }
                    
            }
            else MessageBox.Show("Lỗi!");
        }

        private void tbs_delete_Click(object sender, EventArgs e)
        {
            if (txt_mathietbi.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa được chọn.");
            }
            thietbi t = new thietbi();
            t.mathietbi = txt_mathietbi.Text;
            t.tenthietbi = txt_tenthietbi.Text;
            t.maloaithietbi = cmb_maloai.SelectedValue.ToString();
            t.giathietbi = int.Parse(txt_giathietbi.Text.ToString());
            t.tinhtrang = txt_tinhtrang.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn xóa thiết bị ?"), "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult)
            {
                if (Bus.DeleteProfile(t) > 0)
                {
                    MessageBox.Show("Thực hiện thành công!");
                    Thietbi_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Lỗi.");
                }
            }
        }

        private void tbs_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Chitietsudungthietbi c = new Chitietsudungthietbi(txt_mathietbi.Text);
            c.Show();
        }
        public void Hienthi(string maloai)
        {
            combobox1();
            dgv_thietbi.DataSource = Bus.Xemdanhsachthietbi(maloai);
        }
        private void tbs_xemtb_Click(object sender, EventArgs e)
        {
            Hienthi(" where maloaithietbi like N'%" + cmb_maloai.SelectedValue.ToString() + "%'");
        }
    }
}
