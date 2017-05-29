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

namespace Khachsan.GUI
{
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            
            ChangerCBX();
            dgv_nhanvien.DataSource = Bus.Getlistnhanvien();
            
        }

        private void dgv_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_manhanvien.Text = dgv_nhanvien.CurrentRow.Cells["manhanvien"].Value.ToString();
            txt_tennv.Text = dgv_nhanvien.CurrentRow.Cells["tennhanvien"].Value.ToString();
            txt_diachi.Text = dgv_nhanvien.CurrentRow.Cells["diachi"].Value.ToString();
            txt_sodt.Text = dgv_nhanvien.CurrentRow.Cells["sodienthoai"].Value.ToString();
            date_ngaysinh.Text = dgv_nhanvien.CurrentRow.Cells["ngaysinh"].Value.ToString();
            cmb_macv.SelectedValue = dgv_nhanvien.CurrentRow.Cells["machucvu"].Value.ToString();
            txt_gioitinh.Text = dgv_nhanvien.CurrentRow.Cells["gioitinh"].Value.ToString();
        }

        private void tbs_add_Click(object sender, EventArgs e)
        {
            txt_manhanvien.Text = string.Empty;
            txt_diachi.Text = string.Empty;
            txt_sodt.Text = string.Empty;
            txt_tennv.Text = string.Empty;
            date_ngaysinh.Value = DateTime.Now;
            cmb_macv.Text = string.Empty;
            txt_gioitinh.Text = string.Empty;
        }

        private void tbs_edit_Click(object sender, EventArgs e)
        {
            if (txt_manhanvien.Text == "")
            {
                MessageBox.Show("Thông tin chưa được chọn.");
                return;
            }
            nhanvien n = new nhanvien();
            n.manhanvien = txt_manhanvien.Text;
            n.machucvu = cmb_macv.SelectedValue.ToString();
            n.tennhanvien = txt_tennv.Text;
            n.ngaysinh = date_ngaysinh.Value;
            n.sodienthoai = txt_sodt.Text;
            n.diachi = txt_diachi.Text;
            n.gioitinh = txt_gioitinh.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn sửa nhân viên?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.UpdateProfile(n) > 0)
                {
                    MessageBox.Show("Sửa thành công.");
                    Nhanvien_Load(sender, e);
                }
                else MessageBox.Show("Error!");
            }
        }

        private void tbs_save_Click(object sender, EventArgs e)
        {

            if (txt_manhanvien.Text == "")
            {
                MessageBox.Show("Thông tin chưa được chọn.");
                return;
            }
            nhanvien n = new nhanvien();
            n.manhanvien = txt_manhanvien.Text;
            n.machucvu = cmb_macv.SelectedValue.ToString();
            n.tennhanvien = txt_tennv.Text;
            n.ngaysinh = date_ngaysinh.Value;
            n.sodienthoai = txt_sodt.Text;
            n.diachi = txt_diachi.Text;
            n.gioitinh = txt_gioitinh.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn thêm nhân viên?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.ThemMoi(n) > 0)
                {
                    MessageBox.Show("Thêm thành công.");
                    Nhanvien_Load(sender, e);
                }
                else MessageBox.Show("Error!");
            }
        }

        private void tbs_delete_Click(object sender, EventArgs e)
        {

            if (txt_manhanvien.Text == "")
            {
                MessageBox.Show("Thông tin chưa được chọn.");
                return;
            }
            nhanvien n = new nhanvien();
            n.manhanvien = txt_manhanvien.Text;
            n.machucvu = cmb_macv.SelectedValue.ToString();
            n.tennhanvien = txt_tennv.Text;
            n.ngaysinh = date_ngaysinh.Value;
            n.sodienthoai = txt_sodt.Text;
            n.diachi = txt_diachi.Text;
            n.gioitinh = txt_gioitinh.Text;
            if (MessageBox.Show(string.Format("Bạn có muốn xóa nhân viên?"), "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.DeleteProfile(n) > 0)
                {
                    MessageBox.Show("Xóa thành công.");
                    Nhanvien_Load(sender, e);
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
            dgv_nhanvien.DataSource = Bus.Timkiemnhanvien(ten);
        }

       
        private void tbs_search_Click(object sender, EventArgs e)
        {
            Hienthi(" where hoten like N'%" + txt_search.Text + "%'");
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            txt_search.Text = string.Empty;
        }

        private void ChangerCBX()
        {
            cmb_macv.DisplayMember = "tenchucvu";
            cmb_macv.ValueMember = "machucvu";
            cmb_macv.DataSource = Bus.Getlistchucvu();
        }

       public  void hienthi(string machucvu)
        {
            ChangerCBX();
            dgv_nhanvien.DataSource = Bus.Xemnhanvien(machucvu);
        }
        private void tbs_xemnv_Click(object sender, EventArgs e)
        {
            hienthi(" where machucvu like N'%" + cmb_macv.SelectedValue.ToString() + "%'");
        }
    }
}
