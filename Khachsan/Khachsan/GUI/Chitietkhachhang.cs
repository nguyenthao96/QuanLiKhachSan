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
using Khachsan.BusinessLogiclayer;


namespace Khachsan.GUI
{
    public partial class Chitietkhachhang : Form
    {
        private string ma;
        SqlConnection con;
        string sql = @"Server=DESKTOP-CUJBDU6\SQLEXPRESS;Database=Khachsan;Trusted_Connection=true ";
        public Chitietkhachhang()
        {
            InitializeComponent();
        }
        public Chitietkhachhang(string Ma):this()
        {
            ma = Ma;
            txt_makhachang.Text = ma;
        }
        private void Chitietkhachhang_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(sql);
            con.Open();
            SqlCommand cmd = new SqlCommand("xemkhachhang", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter p = new SqlParameter("@ma", ma);
            cmd.Parameters.Add(p);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_chitiet.DataSource = dt;

          }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
