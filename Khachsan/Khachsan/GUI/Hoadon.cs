using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Khachsan.BusinessLogiclayer;
using Khachsan.ValuesOject;
using Khachsan.DataAccessLayer;

namespace Khachsan.GUI
{
    public partial class Hoadon : Form
    {
        public Hoadon()
        {
            InitializeComponent();
        }

        private void Hoadon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khachsanDataSet.hoadon' table. You can move, or remove it, as needed.
            dataGridView1.DataSource = Bus.Getlisthoadon();
            cmb_maphieu.ValueMember = "maphieu";
            cmb_maphieu.DataSource = Bus.Getlistphieudangki();
            cmb_makhachhang.ValueMember = "makhachhang";
            cmb_makhachhang.DataSource = Bus.Getlistkhachhang();
            cmb_manhanvien.ValueMember = "manhanvien";
            cmb_manhanvien.DataSource = Bus.Getlistnhanvien();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mahoadon.Text = dataGridView1.CurrentRow.Cells["mahoadon"].Value.ToString();
            txt_giaphong.Text = dataGridView1.CurrentRow.Cells["giaphong"].Value.ToString();
            txt_giadichvu.Text = dataGridView1.CurrentRow.Cells["giadichvu"].Value.ToString();
            txt_tongtien.Text = dataGridView1.CurrentRow.Cells["tongtien"].Value.ToString();
            cmb_makhachhang.Text = dataGridView1.CurrentRow.Cells["makhachhang"].Value.ToString();
            cmb_manhanvien.Text = dataGridView1.CurrentRow.Cells["manhanvien"].Value.ToString();
            cmb_maphieu.Text = dataGridView1.CurrentRow.Cells["maphieu"].Value.ToString();

        }
        private void tbs_them_Click(object sender, EventArgs e)
        {
            txt_mahoadon.Text = string.Empty;
            txt_giadichvu.Text = string.Empty;
            txt_giaphong.Text = string.Empty;
            txt_songay.Text = string.Empty;
            txt_tongtien.Text = string.Empty;
            cmb_makhachhang.Text = string.Empty;
            cmb_manhanvien.Text = string.Empty;
            cmb_maphieu.Text = string.Empty;
            date_ngaythanhtoan.Value = DateTime.Now;
        }

        private void tbs_save_Click(object sender, EventArgs e)
        {
            if (txt_mahoadon.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa nhập!");
                return;
            }
            hoadon h = new hoadon();
            h.mahoadon = txt_mahoadon.Text;
            h.makhachhang = cmb_makhachhang.Text;
            h.manhanvien = cmb_manhanvien.Text;
            h.maphieu = cmb_maphieu.Text;
            h.giaphong = int.Parse(txt_giaphong.Text.ToString());
            h.giadichvu = int.Parse(txt_giadichvu.Text.ToString());
            h.tongtien = int.Parse(txt_tongtien.Text.ToString());
            h.ngaythanhtoan = date_ngaythanhtoan.Value;
            if (MessageBox.Show(string.Format("Bạn có muốn thêm hóa đơn?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(h) > 0)
                {
                    MessageBox.Show("Thêmthành công!");
                    Hoadon_Load(sender, e);
                }
                else
                    MessageBox.Show("Error");
            }
        }

        private void tbs_edit_Click(object sender, EventArgs e)
        {
            if (txt_mahoadon.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa nhập!");
                return;
            }
            hoadon h = new hoadon();
            h.mahoadon = txt_mahoadon.Text;
            h.makhachhang = cmb_makhachhang.Text;
            h.manhanvien = cmb_manhanvien.Text;
            h.maphieu = cmb_maphieu.Text;
            h.giaphong = int.Parse(txt_giaphong.Text.ToString());
            h.giadichvu = int.Parse(txt_giadichvu.Text.ToString());
            h.tongtien = int.Parse(txt_tongtien.Text.ToString());
            h.ngaythanhtoan = date_ngaythanhtoan.Value;
            if (MessageBox.Show(string.Format("Bạn có muốn sửa hóa đơn?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(h) > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    Hoadon_Load(sender, e);
                }
                else
                    MessageBox.Show("Error");
            }
        }

        private void tbs_delete_Click(object sender, EventArgs e)
        {
            if (txt_mahoadon.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa nhập!");
                return;
            }
            hoadon h = new hoadon();
            h.mahoadon = txt_mahoadon.Text;
            h.makhachhang = cmb_makhachhang.Text;
            h.manhanvien = cmb_manhanvien.Text;
            h.maphieu = cmb_maphieu.Text;
            h.giaphong = int.Parse(txt_giaphong.Text.ToString());
            h.giadichvu = int.Parse(txt_giadichvu.Text.ToString());
            h.tongtien = int.Parse(txt_tongtien.Text.ToString());
            h.ngaythanhtoan = date_ngaythanhtoan.Value;
            if (MessageBox.Show(string.Format("Bạn có muốn xóa hóa đơn?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(h) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    Hoadon_Load(sender, e);
                }
                else
                    MessageBox.Show("Error");
            }
        }

        private void tbs_exit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e) //xem phiếu đăng kí
        {         
                Phieudangki p = new Phieudangki(cmb_maphieu.Text);
                p.Show();
        }

        private void button3_Click(object sender, EventArgs e) //xem khách hàng
        {
           Chitietkhachhang c = new Chitietkhachhang(cmb_makhachhang.Text);
            c.Show();
        }

        private void btn_hienthi1_Click(object sender, EventArgs e)
        {
            int giaphong;
            giaphong = int.Parse(DataProvider.GetValues("select giaphong from phong,phieuthuephong where phong.maphong=phieuthuephong.maphong and maphieu='" + cmb_maphieu.Text + "'").ToString());
            txt_giaphong.Text = giaphong.ToString();
            int giadichvu;
            giadichvu = int.Parse(DataProvider.GetValues("select sum(giadichvu) from chitietdungdichvu where maphieu='" + cmb_maphieu.Text + "' ").ToString());
            txt_giadichvu.Text = giadichvu.ToString();
            int songay;
            songay = int.Parse(DataProvider.GetValues("select  DATEDIFF(DAYOFYEAR,ngaydatphong,ngaytraphong) from phieuthuephong where maphieu='" + cmb_maphieu.Text + "'").ToString());
            txt_songay.Text = songay.ToString();
        }

        private void button4_Click(object sender, EventArgs e) //tính tổng tiền
        {
            int giaphong;
            int giadichvu;
            int songay;
            giadichvu = Convert.ToInt32(txt_giadichvu.Text);
            giaphong = Convert.ToInt32(txt_giaphong.Text);
            songay = Convert.ToInt32(txt_songay.Text);
            int tien = giaphong * songay + giadichvu;
            txt_tongtien.Text = tien.ToString();
        }

    }
}
