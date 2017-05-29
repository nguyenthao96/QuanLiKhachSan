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
using Khachsan.GUI;

namespace Khachsan.GUI
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        string sql = @"Server=DESKTOP-CUJBDU6\SQLEXPRESS;Database=Khachsan;Trusted_Connection=true ";
        SqlConnection con;
        SqlCommand cmd;

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(sql);
                con.Open();
                string ng = "select count(*) from login where taikhoan='" + txt_taikhoan.Text + "' and matkhau='" + txt_matkhau.Text + "'";
                cmd = new SqlCommand(ng, con);
                int x = (int)cmd.ExecuteScalar();
                if (x == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    this.Hide();
                    Trangchu t = new Trangchu();
                    t.Show();
                }
                else
                {
                    lbl_thongbao.Text = "Tài khoản hoặc mật khẩu không chính xác!";
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_thaydoimatkhau_Click(object sender, EventArgs e)
        {
            Thaydoi t = new Thaydoi();
            t.Show();
        }

        private void chk_hienthi_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_hienthi.Checked)
            {
                txt_matkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matkhau.UseSystemPasswordChar = true;
            }
        }

        private void lbl_thongbao_Click(object sender, EventArgs e)
        {

        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_taikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            Dangki d = new Dangki();
            d.Show();
        }
    }
}
