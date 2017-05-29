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

namespace Khachsan.GUI
{
    public partial class Loaiphong : Form
    {
        public Loaiphong()
        {
            InitializeComponent();
        }

        private void Loaiphong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khachsanDataSet.loaiphong' table. You can move, or remove it, as needed.
       //     this.loaiphongTableAdapter.Fill(this.khachsanDataSet.loaiphong);
            dgv_loaiphong.DataSource = Bus.Getlistloaiphong();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
