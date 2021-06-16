using QLTPKS.BUS;
using QLTPKS.DTO;
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
    public partial class qlphongtb : Form
    {
        public qlphongtb()
        {
            InitializeComponent();
        }
        PHONGTBBUS phongTBbus = new PHONGTBBUS();
        connect cn = new connect();
        public qlphongtb(String user)
        {
            InitializeComponent();
            button2.Text = user;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cn.capnhat1();
            cn.capnhat2();
            MessageBox.Show("Cập nhật thành công!");
            dvPhongTB.DataSource = phongTBbus.getdata();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comMaTB.Text = "";
            txtTinhTrangPTB.Clear();
            comMaPhong.Text = "";
            txtGhiChu.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                PHONGTB phongTB = new PHONGTB();
                phongTB.MATB1 = comMaTB.Text.ToString();
                phongTB.MAPHONG1 = comMaPhong.Text.ToString();
                phongTB.TINHTRANGPTB1 = txtTinhTrangPTB.Text.ToString();
                phongTB.GHICHU1 = txtGhiChu.Text.ToString();
                phongTBbus.InsertPHONGTB(phongTB);
                MessageBox.Show("Đã thêm xong!");
                dvPhongTB.DataSource = phongTBbus.getdata();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                PHONGTB phongTB = new PHONGTB();
                phongTB.MATB1 = comMaTB.Text.ToString();
                phongTB.MAPHONG1 = comMaPhong.Text.ToString();
                phongTB.TINHTRANGPTB1 = txtTinhTrangPTB.Text.ToString();
                phongTB.GHICHU1 = txtGhiChu.Text.ToString();
                phongTBbus.UpdatePHONGTB(phongTB, phongTB.MATB1, phongTB.MAPHONG1);
                MessageBox.Show("Đã sữa xong!");
                dvPhongTB.DataSource = phongTBbus.getdata();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ((comMaTB.Text.ToString() != "") && (comMaPhong.Text.ToString() != ""))
            {
                try
                {
                    PHONGTB phongTB = new PHONGTB();
                    phongTB.MATB1 = comMaTB.Text.ToString();
                    phongTB.MAPHONG1 = comMaPhong.Text.ToString();

                    phongTBbus.DeletePHONGTB(phongTB.MATB1, phongTB.MAPHONG1);

                    MessageBox.Show("Đã xóa xong!");
                    dvPhongTB.DataSource = phongTBbus.getdata();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void qlphongtb_Load(object sender, EventArgs e)
        {
            string sql = "SELECT MATB FROM THIETBI";
            DataTable dt = cn.taobang(sql);
            comMaTB.DataSource = dt;
            comMaTB.ValueMember = "MATB";
            string sql1 = "SELECT MAPHONG FROM PHONG";
            DataTable dt1 = cn.taobang(sql1);
            comMaPhong.DataSource = dt1;
            comMaPhong.ValueMember = "MAPHONG";
            dvPhongTB.DataSource = phongTBbus.getdata();
        }

        private void dvPhongTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            comMaTB.Text = dvPhongTB.Rows[d].Cells[0].Value.ToString();
            comMaPhong.Text = dvPhongTB.Rows[d].Cells[1].Value.ToString();
            txtTinhTrangPTB.Text = dvPhongTB.Rows[d].Cells[2].Value.ToString();
            txtGhiChu.Text = dvPhongTB.Rows[d].Cells[3].Value.ToString();
        }

    }
}
