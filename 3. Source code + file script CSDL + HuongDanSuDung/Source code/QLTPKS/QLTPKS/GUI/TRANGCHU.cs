using QLTPKS.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTPKS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(String user)
        {
            InitializeComponent();
            button1.Text = user;
        }

        private void quarLyPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlphong qlp = new qlphong();
            qlp.Show();
        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlloaiphong qllp = new qlloaiphong(button1.Text);
            //qlloaiphong qllp = new qlloaiphong();
            qllp.Show();
        }

        private void phòngThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlphongtb qlptb = new qlphongtb();
            qlptb.Show();
        }

        private void thiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void hóaĐơnDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlhddv ql = new qlhddv();
            ql.Show();
        }
        
        private void chiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlchinhnhanh CN = new qlchinhnhanh();
            CN.Show();
            this.Hide();
        }

        private void phiếuThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            phieuthue pt = new phieuthue(button1.Text);
            //phieuthue pt = new phieuthue();
            pt.Show();
        }

        private void phòngThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlphongthue qlpt = new qlphongthue();
            qlpt.Show();
        }

        private void qUẢNLÝPHÒNGToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            qlphong qlp = new qlphong(button1.Text);
            //qlphong qlp = new qlphong();
            qlp.Show();
        }

        private void loạiPhòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            qlloaiphong qllp = new qlloaiphong(button1.Text.ToString());
            qllp.Show();
        }

        private void phòngThiếtBịToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            qlloaiphong qlptb = new qlloaiphong(button1.Text.ToString());
           // qlphongtb qlptb = new qlphongtb();
            qlptb.Show();
        }

        private void phòngThuêToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            qlphongthue qlpt = new qlphongthue(button1.Text.ToString());
            //qlphongthue qlpt = new qlphongthue();
            qlpt.Show();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlhoadon hd = new qlhoadon();
            hd.Show();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            qlkhachhang kh = new qlkhachhang();
            kh.Show();
        }

        private void thiếtBịToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            qlthietbi qltb = new qlthietbi();
            qltb.Show();
        }

        private void dịchVụToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            qldichvu dv = new qldichvu();
            dv.Show();
        }

        private void sửDụngDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlsddv sd = new qlsddv();
            sd.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (button1.Text != "")
            {
                qUẢNLÝCHINHÁNHToolStripMenuItem.Enabled = false;
                //qUẢNLÝNHÂNVIÊNToolStripMenuItem.Enabled = false;
            }
        }

        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            qlnhanvien nv = new qlnhanvien(button1.Text.ToString());
            //qlnhanvien nv = new qlnhanvien();
            nv.Show();
        }
    }
}
