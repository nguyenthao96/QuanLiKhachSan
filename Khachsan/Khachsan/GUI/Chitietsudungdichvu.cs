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
using Khachsan.GUI;
using Khachsan.DataAccessLayer;
using Khachsan.BusinessLogiclayer;



namespace Khachsan.GUI
{
    public partial class Chitietsudungdichvu : Form
    {
        private string ma;
        public Chitietsudungdichvu()
        {
            InitializeComponent();
        }
        public Chitietsudungdichvu(string Ma):this()
        {
            ma = Ma;
            txt_map.Text = ma;
        }
        private void Chitietsudungdichvu_Load_1(object sender, EventArgs e)
        {
            
            dgv_chitietdichvu.DataSource = Bus.Getlistchitietdungdichvu();
            cmb_madv.ValueMember = "madichvu";
            cmb_madv.DataSource = Bus.Getlistphieudichvu();
            cmb_maphieu.ValueMember = "maphieu";
            cmb_maphieu.DataSource = Bus.Getlistphieudangki();
        }

        private void dgv_chitietdichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmb_maphieu.Text = dgv_chitietdichvu.CurrentRow.Cells["maphieu"].Value.ToString();
            txt_tendv.Text = dgv_chitietdichvu.CurrentRow.Cells["tendichvu"].Value.ToString();
            txt_giadv.Text = dgv_chitietdichvu.CurrentRow.Cells["giadichvu"].Value.ToString();
            cmb_madv.Text = dgv_chitietdichvu.CurrentRow.Cells["madichvu"].Value.ToString();
        }

        private void tbs_dichvu_Click(object sender, EventArgs e) //thêm người dùng dịch vụ
        {
            cmb_maphieu.Text = string.Empty;
            cmb_madv.Text = string.Empty;
            txt_tendv.Text = string.Empty;
            txt_giadv.Text = string.Empty;
        }

        private void tbs_edit_Click(object sender, EventArgs e)
        {
            if (cmb_maphieu.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa được nhập.");
                return;
            }
            chitietsudungdichvu c = new chitietsudungdichvu();
            c.madichvu = cmb_madv.Text;
            c.tendichvu = txt_tendv.Text;
            c.giadichvu = int.Parse(txt_giadv.Text.ToString());
            c.maphieu = cmb_maphieu.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn thêm mới dịch vụ ?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(c) > 0)
                {
                    MessageBox.Show("Thông tin đã lưu.");
                    Chitietsudungdichvu_Load_1(sender, e);
                }
                else MessageBox.Show("Error!");
            }
        }

        private void tbs_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbs_save_Click(object sender, EventArgs e)
        {
            if (cmb_maphieu.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa được nhập.");
                return;
            }
            chitietsudungdichvu c = new chitietsudungdichvu();
            c.madichvu = cmb_madv.Text;
            c.tendichvu = txt_tendv.Text;
            c.giadichvu = int.Parse(txt_giadv.Text.ToString());
            c.maphieu = cmb_maphieu.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn thêm mới dịch vụ ?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(c) > 0)
                {
                    MessageBox.Show("Thông tin đã lưu.");
                    Chitietsudungdichvu_Load_1(sender, e);
                }
                else MessageBox.Show("Error!");
            }
        }

        private void cmb_madv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_tendv.Text = DataAccessLayer.DataProvider.GetValues("select tendichvu from dichvu where madichvu='" + cmb_madv.Text + "'");
            txt_giadv.Text = DataProvider.GetValues("select giadichvu from dichvu where madichvu='" + cmb_madv.Text + "'");
        }
        public void Hienthi(string ma)
        {
            dgv_chitietdichvu.DataSource = Bus.Hienthi(ma);
        }
        private void tbs_hienthi_Click(object sender, EventArgs e)
        {
            Hienthi(" where maphieu like N'%" + txt_map.Text + "%'");
        }
    }
}
