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
    public partial class Dangki : Form
    {
        public Dangki()
        {
            InitializeComponent();
        }
        string sql = @"Server=DESKTOP-CUJBDU6\SQLEXPRESS;Database=Khachsan;Trusted_Connection=true ";
        SqlConnection con;
        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(sql);
                con.Open();
                login l = new login();
                l.taikhoan = txt_taikhoan.Text;
                l.matkhau = txt_matkhau.Text;
                string ng = "insert into login(taikhoan,matkhau) values('" + txt_taikhoan.Text + "','" + txt_matkhau.Text + "')";
               
                    lbl_thongbao.Text = "Đăng kí thành công! \n Mời bạn vào đăng nhập";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = ng;
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            txt_matkhau.Text = "";
            txt_taikhoan.Text = "";
        }

        private void Dangki_Load(object sender, EventArgs e)
        {

        }
    }
}
