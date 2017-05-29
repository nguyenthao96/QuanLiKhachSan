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
    public partial class Chucvu : Form
    {
        public Chucvu()
        {
            InitializeComponent();
        }

        private void Chucvu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khachsanDataSet.chucvu' table. You can move, or remove it, as needed.
          //  this.chucvuTableAdapter.Fill(this.khachsanDataSet.chucvu);
            dgv_chucvu.DataSource = Bus.Getlistchucvu();
        }
    }
}
