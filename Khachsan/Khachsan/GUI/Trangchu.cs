using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khachsan.GUI
{
    public partial class Trangchu : Form
    {
        public Trangchu()
        {
            InitializeComponent();
        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loaiphong lp = new Loaiphong();
            lp.Show();
      
        }

        private void phiếuĐăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phieudangki p = new Phieudangki();
            p.Show();
       
        }

     

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoadon h = new Hoadon();
            h.Show();
            
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhanvien n = new Nhanvien();
            n.Show();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chucvu c = new Chucvu();
            c.Show();
           

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Khachhang k = new Khachhang();
            k.Show();
            
        }

        private void hươngDânSưaDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Huongdan d = new Huongdan();
            d.Show();
            
        }

        private void Trangchu_Load(object sender, EventArgs e)
        {

        }

        private void loạiThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Loaithietbi l = new Loaithietbi();
            l.Show();
        }

        private void thiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thietbi t = new Thietbi();
            t.Show();
        }

        private void chiTiếtThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chitietsudungthietbi c = new Chitietsudungthietbi();
            c.Show();
        }

        private void dịchVụKháchSạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dichvu d = new Dichvu();
            d.Show();
        }

        private void chiTiếtSửDụngDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chitietsudungdichvu c = new Chitietsudungdichvu();
            c.Show();
        }
    }
}
