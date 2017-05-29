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
    public partial class Loaithietbi : Form
    {
        public Loaithietbi()
        {
            InitializeComponent();
        }

        private void Loaithietbi_Load(object sender, EventArgs e)
        {
            dgv_loai.DataSource = Bus.Getlistloaithietbi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
