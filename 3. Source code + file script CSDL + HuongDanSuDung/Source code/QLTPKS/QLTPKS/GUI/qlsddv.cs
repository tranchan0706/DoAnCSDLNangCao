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
    public partial class qlsddv : Form
    {
        SUDUNGDVBUS sudungDVbus = new SUDUNGDVBUS();
        connect cn = new connect();
        public qlsddv()
        {
            InitializeComponent();
        }

        private void qlsddv_Load(object sender, EventArgs e)
        {
            string sql = "SELECT MAHDDV FROM HOADONDV";
            DataTable dt = cn.taobang(sql);
            comMaHDDV.DataSource = dt;
            comMaHDDV.ValueMember = "MAHDDV";
            string sql1 = "SELECT MADV FROM DICHVU";
            DataTable dt1 = cn.taobang(sql1);
            comMaDV.DataSource = dt1;
            comMaDV.ValueMember = "MADV";
            dvSuDungDV.DataSource = sudungDVbus.getdata(comMaHDDV.Text.ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comMaHDDV.Text = "";
            comMaDV.Text = "";
            txtGiaDV.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SUDUNGDV sudungDV = new SUDUNGDV();
                sudungDV.MAHDDV1 = comMaHDDV.Text.ToString();
                sudungDV.MADV1 = comMaDV.Text.ToString();
                sudungDV.GIADV1 = Convert.ToInt32(txtGiaDV.Text.ToString());
                sudungDVbus.InsertSUDUNGDV(sudungDV);
                MessageBox.Show("Đã thêm xong!");
                dvSuDungDV.DataSource = sudungDVbus.getdata(comMaHDDV.Text.ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SUDUNGDV sudungDV = new SUDUNGDV();
                sudungDV.MAHDDV1 = comMaHDDV.Text.ToString();
                sudungDV.MADV1 = comMaDV.Text.ToString();
                sudungDV.GIADV1 = Convert.ToInt32(txtGiaDV.Text.ToString());
                sudungDVbus.UpdateSUDUNGDV(sudungDV, sudungDV.MAHDDV1, sudungDV.MADV1);
                MessageBox.Show("Đã sữa xong!");
                dvSuDungDV.DataSource = sudungDVbus.getdata(comMaHDDV.Text.ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ((comMaHDDV.Text.ToString() != "") && (comMaDV.Text.ToString() != ""))
            {
                try
                {
                    SUDUNGDV sudungDV = new SUDUNGDV();
                    sudungDV.MAHDDV1 = comMaHDDV.Text.ToString();
                    sudungDV.MADV1 = comMaDV.Text.ToString();

                    sudungDVbus.DeleteSUDUNGDV(sudungDV.MAHDDV1, sudungDV.MADV1);

                    MessageBox.Show("Đã xóa xong!");
                    dvSuDungDV.DataSource = sudungDVbus.getdata(comMaHDDV.Text.ToString());
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void dvSuDungDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            comMaHDDV.Text = dvSuDungDV.Rows[d].Cells[0].Value.ToString();
            comMaDV.Text = dvSuDungDV.Rows[d].Cells[1].Value.ToString();
            txtGiaDV.Text = dvSuDungDV.Rows[d].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dvSuDungDV.DataSource = sudungDVbus.getdata(comMaHDDV.Text.ToString());
        }
    }
}
