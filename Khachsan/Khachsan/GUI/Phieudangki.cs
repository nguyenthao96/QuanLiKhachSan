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
using Khachsan.GUI;
using Khachsan.DataAccessLayer;

namespace Khachsan
{
    public partial class Phieudangki : Form
    {
        public Phieudangki()
        {
            InitializeComponent();
        }
        private string ma;
        public Phieudangki(string Ma):this()
        {
            ma = Ma;
            txt_mapdk.Text = ma;
        }
        private void Phieudangki_Load_1(object sender, EventArgs e)
        {
            dgv_phieudangki.DataSource = Bus.Getlistphieudangki();
            cmb_makh.DataSource = Bus.Getlistkhachhang();
            cmb_makh.ValueMember = "makhachhang";
            cmb_manv.DataSource = Bus.Getlistnhanvien();
            cmb_manv.ValueMember = "manhanvien";
            comboboxphong();
            dgv_phong.DataSource = Bus.Getlistphong();
        }
        public void comboboxphong()
        {
            cmb_maloaiphong.DisplayMember = "loaiphong";
            cmb_maloaiphong.ValueMember = "maloaiphong";
            cmb_maloaiphong.DataSource = Bus.Getlistloaiphong();
        }

        private void dgv_phieudangki_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mapdk.Text = dgv_phieudangki.CurrentRow.Cells["maphieu"].Value.ToString();
            txt_songuoi.Text = dgv_phieudangki.CurrentRow.Cells["songuoio"].Value.ToString();
            cmb_makh.Text = dgv_phieudangki.CurrentRow.Cells["makhachhang"].Value.ToString();
            cmb_manv.Text = dgv_phieudangki.CurrentRow.Cells["manhanvien"].Value.ToString();
            date_ngaydk.Text = dgv_phieudangki.CurrentRow.Cells["ngaydatphong"].Value.ToString();
            date_ngaytra.Text = dgv_phieudangki.CurrentRow.Cells["ngaytraphong"].Value.ToString();
            date_ngaydukien.Text = dgv_phieudangki.CurrentRow.Cells["ngaydukientra"].Value.ToString();
            txt_maphong.Text = dgv_phieudangki.CurrentRow.Cells["maphong"].Value.ToString();
           
        }
        private void dgv_phong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maph.Text = dgv_phong.CurrentRow.Cells["maphong1"].Value.ToString();
            cmb_maloaiphong.SelectedValue = dgv_phong.CurrentRow.Cells["maloaiphong"].Value.ToString();
            txt_tinhtrangphong.Text = dgv_phong.CurrentRow.Cells["tinhtrangphong"].Value.ToString();
            txt_giaphong.Text = dgv_phong.CurrentRow.Cells["giaphong"].Value.ToString();
        
        }
        private void tbs_exit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }
        private void tbs_xemchitiet_Click(object sender, EventArgs e)
        {
        }

        private void tbs_khachhang_Click(object sender, EventArgs e)
        { 
           Chitietsudungdichvu k = new Chitietsudungdichvu(txt_mapdk.Text);
            k.Show();
        }

        private void cmb_maloaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public void Hienthi(string maloai)
        {
            comboboxphong();
            dgv_phong.DataSource = Bus.Xemdanhsachphong(maloai);
        }
        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            Hienthi(" where maloaiphong like N'%" + cmb_maloaiphong.SelectedValue.ToString() + "%'");
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_mapdk.Text = string.Empty;
            txt_songuoi.Text = string.Empty;
            cmb_makh.Text = string.Empty;
            cmb_manv.Text = string.Empty;
            date_ngaydk.Value = DateTime.Now;
            date_ngaytra.Value = DateTime.Now;
            date_ngaydukien.Value = DateTime.Now;
            txt_maphong.Text =string.Empty;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_mapdk.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa nhập!");
                return;
            }
            phieudangki p = new phieudangki();
            p.maphieu = txt_mapdk.Text;
            p.makhachhang = cmb_makh.Text;
            p.manhanvien = cmb_manv.Text;
            p.songuoio = int.Parse(txt_songuoi.Text.ToString());
            p.ngaydatphong = date_ngaydk.Value;
            p.ngaytraphong = date_ngaytra.Value;
            p.ngaydukientraphong = date_ngaydukien.Value;
            p.maphong = txt_maphong.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn thêm phiếu thuê phòng?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(p) > 0)
                {
                    MessageBox.Show("Thêm thành công.");
                    Phieudangki_Load_1(sender, e);
                }
                else
                    MessageBox.Show("Error");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            if (txt_mapdk.Text == "")
            {
                MessageBox.Show("Chưa hiển thị dữ liệu!");
                return;
            }
            phieudangki p = new phieudangki();
            p.maphieu = txt_mapdk.Text;
            p.makhachhang = cmb_makh.Text;
            p.manhanvien = cmb_manv.Text;
            p.songuoio = int.Parse(txt_songuoi.Text.ToString());
            p.ngaydatphong = date_ngaydk.Value;
            p.ngaytraphong = date_ngaytra.Value;
            p.ngaydukientraphong = date_ngaydukien.Value;
            p.maphong = txt_maphong.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn sửa phiếu thuê phòng?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(p) > 0)
                {
                    MessageBox.Show("Sửa thành công.");
                    Phieudangki_Load_1(sender, e);
                }
                else
                    MessageBox.Show("Error");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_mapdk.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa chọn!");
                return;
            }
            phieudangki p = new phieudangki();
            p.maphieu = txt_mapdk.Text;
            p.makhachhang = cmb_makh.Text;
            p.manhanvien = cmb_manv.Text;
            p.songuoio = int.Parse(txt_songuoi.Text.ToString());
            p.ngaydatphong = date_ngaydk.Value;
            p.ngaytraphong = date_ngaytra.Value;
            p.ngaydukientraphong = date_ngaydukien.Value;
            p.maphong = txt_maphong.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn xóa phiếu thuê phòng?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(p) > 0)
                {
                    MessageBox.Show("Xóa thành công.");
                    Phieudangki_Load_1(sender, e);
                }
                else
                    MessageBox.Show("Error");
            }
        }

        private void btn_themphong_Click(object sender, EventArgs e)
        {
            txt_maph.Text = string.Empty;
            txt_giaphong.Text = string.Empty;
            cmb_maloaiphong.Text = string.Empty;
            txt_tinhtrangphong.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e) //button lưu phòng
        {
            if(txt_maph.Text=="")
            {
                MessageBox.Show("Thông tin phòng mới chưa được nhập");
            }
            phong ph = new phong();
            ph.maloaiphong = cmb_maloaiphong.SelectedValue.ToString();
            ph.maphong = txt_maph.Text;
            ph.giaphong =int.Parse( txt_giaphong.Text.ToString());
            ph.tinhtrangphong = txt_tinhtrangphong.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn thêm phòng mới?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(ph) > 0)
                {
                    MessageBox.Show("Phòng mới đã được thêm.");
                    Phieudangki_Load_1(sender, e);
                }
                else
                    MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e) //button sửa giá phòng
        {
            if (txt_maph.Text == "")
            {
                MessageBox.Show("Thông tin phòng  chưa được hiển thị.");
            }
            phong ph = new phong();
            ph.maloaiphong = cmb_maloaiphong.SelectedValue.ToString();
            ph.maphong = txt_maph.Text;
            ph.giaphong = int.Parse(txt_giaphong.Text.ToString());
            ph.tinhtrangphong = txt_tinhtrangphong.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn sửa giá phòng ?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(ph) > 0)
                {
                    MessageBox.Show("Phòng đã được sửa.");
                    Phieudangki_Load_1(sender, e);
                }
                else
                    MessageBox.Show("Error");
            }
        }

        private void btn_xemtb_Click(object sender, EventArgs e)
        {
            Chitietsudungthietbi c = new Chitietsudungthietbi(txt_maph.Text);
            c.Show();
        }

        public void hienthi(string ma)
        {
            dgv_phieudangki.DataSource = Bus.Timkiemphieuthuephong(ma);
        }
        private void btn_hienthiphong_Click(object sender, EventArgs e)
        {
            hienthi(" where maphieu like N'%" + txt_mapdk.Text + "%'");
        }
        public void hienthiphong(string maphong)
        {
            dgv_phong.DataSource = Bus.Xemchitietphong(maphong);
        }
        private void btn_xemphong_Click(object sender, EventArgs e)
        {
            hienthiphong(" where maphong like N'%" + txt_maph.Text + "%'");
        }

        private void tbs_dichvu_Click(object sender, EventArgs e)
        {
            Chitietsudungdichvu c = new Chitietsudungdichvu(txt_mapdk.Text);
            c.Show();
        }

        private void tbs_home_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void cmb_makh_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_name.Text = DataProvider.GetValues("select tenkhachhang from khachhang where makhachhang='" + cmb_makh.Text + "'");
        }

        private void cmb_manv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_tennv.Text = DataProvider.GetValues("select tennhanvien from nhanvien where manhanvien='" + cmb_manv.Text + "'");
        }
    }
}
