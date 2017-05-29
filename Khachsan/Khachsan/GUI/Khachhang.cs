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
    public partial class Khachhang : Form
    {

        
        public Khachhang()
        {
            InitializeComponent();
        }

        private string ma;
        public Khachhang(string Ma):this()
        {
            ma = Ma;
            txt_makhachhang.Text = ma;
        }

        private void Khachhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khachsanDataSet.khachhang' table. You can move, or remove it, as needed.
   //         this.khachhangTableAdapter.Fill(this.khachsanDataSet.khachhang);
            dgv_kh.DataSource = Bus.Getlistkhachhang();
        }
        private void tbs_add_Click(object sender, EventArgs e)
        {
            txt_tenkhachhang.Text = string.Empty;
            txt_makhachhang.Text = string.Empty;
            txt_diachi.Text = string.Empty;
            txt_cmt.Text = string.Empty;
            txt_quoctich.Text = string.Empty;
            txt_sodt.Text = string.Empty;
            txt_gioitinh.Text = string.Empty;
            date_ngaysinh.Value = DateTime.Now;
        }

        private void tbs_save_Click(object sender, EventArgs e)
        {

            if (txt_makhachhang.Text == "")
            {
                MessageBox.Show("Dữ liệu chưa nhập!");
                return;
            }
            khachhang k = new khachhang();
            k.makhachhang = txt_makhachhang.Text;
            k.tenkhachhang = txt_tenkhachhang.Text;
            k.diachi = txt_diachi.Text;
            k.CMT = txt_cmt.Text;
            k.quoctich = txt_quoctich.Text;
            k.sodienthoai = txt_sodt.Text;
            k.gioitinh = txt_gioitinh.Text;
            k.ngaysinh = date_ngaysinh.Value;
            if (MessageBox.Show(string.Format("Bạn có muốn thêm khách hàng?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.InsertProfile(k) > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    Khachhang_Load(sender, e);
                }
                else
                    MessageBox.Show("Error");
            }
        }

        private void tbs_edit_Click(object sender, EventArgs e)
        {
            if (txt_makhachhang.Text == "")
            {
                MessageBox.Show("Thông tin chưa được chọn.");
                return;
            }
            khachhang k = new khachhang();
            k.makhachhang = txt_makhachhang.Text;
            k.tenkhachhang = txt_tenkhachhang.Text;
            k.diachi = txt_diachi.Text;
            k.CMT = txt_cmt.Text;
            k.quoctich = txt_quoctich.Text;
            k.sodienthoai = txt_sodt.Text;
            k.gioitinh = txt_gioitinh.Text;
            k.ngaysinh = date_ngaysinh.Value;
            if (MessageBox.Show(string.Format("Bạn có muốn sửa khách hàng?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(k) > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    Khachhang_Load(sender, e);
                }
                else MessageBox.Show("Error!");
            }
        }

        private void tbs_delete_Click(object sender, EventArgs e)
        {
            if (txt_makhachhang.Text == "")
            {
                MessageBox.Show("Thông tin chưa được chọn.");
                return;
            }
            khachhang k = new khachhang();
            k.makhachhang = txt_makhachhang.Text;
            k.tenkhachhang = txt_tenkhachhang.Text;
            k.diachi = txt_diachi.Text;
            k.CMT = txt_cmt.Text;
            k.quoctich = txt_quoctich.Text;
            k.sodienthoai = txt_sodt.Text;
            k.gioitinh = txt_gioitinh.Text;
            k.ngaysinh = date_ngaysinh.Value;
            if (MessageBox.Show(string.Format("Bạn có muốn xóa khách hàng ?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(k) > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    Khachhang_Load(sender, e);
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
        public void Hienthi(string ten)
        {
            dgv_kh.DataSource = Bus.Timkiemkhachhang(ten);
        }

        private void txt_timkiem_Click(object sender, EventArgs e)
        {
            txt_timkiem.Text = string.Empty;
        }

        private void tbs_seach_Click(object sender, EventArgs e)
        {
            Hienthi(" where tenkhachhang like N'%" + txt_timkiem.Text + "%'");
        }

        private void dgv_kh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makhachhang.Text = dgv_kh.CurrentRow.Cells["makhachhang"].Value.ToString();
            txt_tenkhachhang.Text = dgv_kh.CurrentRow.Cells["tenkhachhang"].Value.ToString();
            date_ngaysinh.Text = dgv_kh.CurrentRow.Cells["ngaysinh"].Value.ToString();
            txt_gioitinh.Text = dgv_kh.CurrentRow.Cells["gioitinh"].Value.ToString();
            txt_diachi.Text = dgv_kh.CurrentRow.Cells["diachi"].Value.ToString();
            txt_sodt.Text = dgv_kh.CurrentRow.Cells["sodienthoai"].Value.ToString();
            txt_cmt.Text = dgv_kh.CurrentRow.Cells["CMT"].Value.ToString();
            txt_quoctich.Text = dgv_kh.CurrentRow.Cells["quoctich"].Value.ToString();
        }

       
    }
}
