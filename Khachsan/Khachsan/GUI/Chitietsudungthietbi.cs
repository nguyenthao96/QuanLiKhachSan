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
using Khachsan.BusinessLogiclayer;
using Khachsan.ValuesOject;
using Khachsan.DataAccessLayer;

namespace Khachsan.GUI
{
    public partial class Chitietsudungthietbi : Form
    {
        private string ma;
       
        public Chitietsudungthietbi()
        {
            InitializeComponent();
        }
        public Chitietsudungthietbi(string Ma):this()
        {
            ma = Ma;
            txt_map.Text = ma;
        }
        private void Chitietdangki_Load(object sender, EventArgs e)
        {
            dgv_chitiet.DataSource = Bus.Getlistchitietthietbi();
            cmb_maphong.ValueMember = "maphong";
            cmb_maphong.DataSource = Bus.Getlistphong();
            cmb_mathietbi.ValueMember = "mathietbi";
            cmb_mathietbi.DataSource = Bus.Getlistthietbi();
        }

        private void dgv_chitiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmb_mathietbi.Text = dgv_chitiet.CurrentRow.Cells["mathietbi"].Value.ToString();
            cmb_maphong.Text = dgv_chitiet.CurrentRow.Cells["maphong"].Value.ToString();
            txt_tenthietbi.Text = dgv_chitiet.CurrentRow.Cells["tenthietbi"].Value.ToString();
        }

        private void tbs_add_Click(object sender, EventArgs e)
        {
            cmb_maphong.Text = string.Empty;
            cmb_mathietbi.Text = string.Empty;
            txt_tenthietbi.Text = string.Empty;
        }

        private void tbs_save_Click(object sender, EventArgs e)
        {
            if (cmb_maphong.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa được nhập.");
                return;
            }
            chitietsudungthietbi c = new chitietsudungthietbi();
            c.maphong = cmb_maphong.Text;
            c.mathietbi = cmb_mathietbi.Text;
            c.tenthietbi = txt_tenthietbi.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn thêm mới chi tiết dùng thiết bị ?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(c) > 0)
                {
                    MessageBox.Show("Thông tin đã lưu.");
                    Chitietdangki_Load(sender, e);
                }
                else MessageBox.Show("Error!");
            }
        }

        private void tbs_edit_Click(object sender, EventArgs e)
        {
            if (cmb_maphong.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa được nhập.");
                return;
            }
            chitietsudungthietbi c = new chitietsudungthietbi();
            c.maphong = cmb_maphong.Text;
            c.mathietbi = cmb_mathietbi.Text;
            c.tenthietbi = txt_tenthietbi.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn thêm mới chi tiết dùng thiết bị ?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(c) > 0)
                {
                    MessageBox.Show("Thông tin đã sửa.");
                    Chitietdangki_Load(sender, e);
                }
                else MessageBox.Show("Error!");
            }
        }

        private void tbs_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Hienthi(string ma)
        {
            dgv_chitiet.DataSource = Bus.Hienthidv(ma);
        }
        private void tbs_hienthi_Click(object sender, EventArgs e)
        {   Hienthi(" where mathietbi like N'%" + txt_map.Text + "%'");
        }

        private void cmb_mathietbi_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_tenthietbi.Text = DataProvider.GetValues("select tenthietbi from danhsachthietbi where mathietbi='" + cmb_mathietbi.Text + "'");
        }
    }
}
