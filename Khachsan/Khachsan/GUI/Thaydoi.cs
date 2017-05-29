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

namespace Khachsan.GUI
{
    public partial class Thaydoi : Form
    {
        public Thaydoi()
        {
            InitializeComponent();
        }

        private void Thaydoi_Load(object sender, EventArgs e)
        {
        }
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-CUJBDU6\SQLEXPRESS;Database=Khachsan;Trusted_Connection=true ");
        private void btn_luu_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from login where taikhoan='"+txt_taikhoan.Text+"' and matkhau='"+txt_mkcu.Text+"'",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            login l = new login();
            l.matkhau = txt_mkcu.Text;
            l.taikhoan = txt_taikhoan.Text;
            
            if(dt.Rows[0][0].ToString()=="1")

            {
                if (txt_mkmoi.Text == txt_mkmoi1.Text)
                {
                    SqlDataAdapter d = new SqlDataAdapter("update login set Matkhau='" + txt_mkmoi.Text + "' where Taikhoan='" + txt_taikhoan.Text + "'", con);
                    DataTable df = new DataTable();
                    d.Fill(df);
                    MessageBox.Show("Thay đổi mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (txt_taikhoan.Text == "") MessageBox.Show("Chưa nhập tài khoản!");
                else if (txt_mkcu.Text == "") MessageBox.Show("Chưa nhập mật khẩu cũ.");
                else if (txt_mkcu.Text != l.matkhau) MessageBox.Show("Mật khẩu cũ không chính xác.");
                if (txt_mkmoi.Text == "") MessageBox.Show("Chưa nhập mật khẩu mới.");
                else if (txt_mkmoi1.Text == "") MessageBox.Show("Chưa nhập lại mật khẩu mới");
                else if (txt_mkmoi.Text != txt_mkmoi1.Text) MessageBox.Show("Mật khẩu không trùng khớp.");

            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
