using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Khachsan.ValuesOject;
using Khachsan.BusinessLogiclayer;

namespace Khachsan.GUI
{
    public partial class Dichvu : Form
    {
        public Dichvu()
        {
            InitializeComponent();
        }

        private void Dichvu_Load(object sender, EventArgs e)
        {
            dgv_dichvu.DataSource = Bus.Getlistphieudichvu();
        }

        private void dgv_dichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_madv.Text = dgv_dichvu.CurrentRow.Cells["madichvu"].Value.ToString();
            txt_tendv.Text = dgv_dichvu.CurrentRow.Cells["tendichvu"].Value.ToString();
            txt_giadv.Text = dgv_dichvu.CurrentRow.Cells["giadichvu"].Value.ToString();
            
        }
      
        private void tbs_add_Click(object sender, EventArgs e)
        {
           
            txt_madv.Text = string.Empty;
            txt_tendv.Text = string.Empty;
            txt_giadv.Text = string.Empty;
         
        }

        private void tbs_save_Click(object sender, EventArgs e)
        {
           
            if (txt_madv.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa được nhập.");
                return;
            }
            dichvu d = new dichvu();
            d.madichvu = txt_madv.Text;
            d.tendichvu = txt_tendv.Text;
            d.giadichvu =int.Parse(txt_giadv.Text.ToString());
            if (MessageBox.Show(string.Format("Bạn có muốn thêm mới dịch vụ ?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(d) > 0)
                {
                    MessageBox.Show("Thao tác đã thực hiện.");
                    Dichvu_Load(sender,e);
                }
                else MessageBox.Show("Error!");
            }        
        }

        private void tbs_edit_Click(object sender, EventArgs e)
        {

            txt_madv.Enabled = false;
            if (txt_madv.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa được nhập.");
                return;
            }
            dichvu d = new dichvu();
            d.madichvu = txt_madv.Text;
            d.tendichvu = txt_tendv.Text;
            d.giadichvu = int.Parse(txt_giadv.Text.ToString());
            if (MessageBox.Show(string.Format("Bạn có muốn sửa dịch vụ ?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(d) > 0)
                {
                    MessageBox.Show("Thao tác đã thực hiện.");
                    Dichvu_Load(sender, e);
                }
                else MessageBox.Show("Error!");
            }
        }

        private void tbs_delete_Click(object sender, EventArgs e)
        {
           
            if (txt_madv.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa được nhập.");
                return;
            }
            dichvu d = new dichvu();
            d.madichvu = txt_madv.Text;
            d.tendichvu = txt_tendv.Text;
            d.giadichvu = int.Parse(txt_giadv.Text.ToString());
            if (MessageBox.Show(string.Format("Bạn có muốn xóa dịch vụ ?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(d) > 0)
                {
                    MessageBox.Show("Thao tác đã thực hiện.");
                    Dichvu_Load(sender, e);
                }
                else MessageBox.Show("Error!");
            }
        }

        private void tbs_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }
        public void Hienthi(string name)
        {
            dgv_dichvu.DataSource = Bus.Timkiemdichvu(name);
        }
        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            txt_timkiem.Text = string.Empty;
        }

        private void tbs_search_Click(object sender, EventArgs e)
        {
            Hienthi(" where tendichvu like N'%" +txt_timkiem.Text+ "%'");
        }
    }
}
