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
    public partial class qlhddv : Form
    {
        public qlhddv()
        {
            InitializeComponent();
        }
        HOADONDVBUS hoadonDvbus = new HOADONDVBUS();
        SUDUNGDVBUS sudungDVbus = new SUDUNGDVBUS();
        connect cn = new connect();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.capnhat1();
                cn.capnhat2();
                MessageBox.Show("Cập nhật thành công!");
                dvHoaDonDV.DataSource = hoadonDvbus.getdata();
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thành công!");
            }
        }

        private void qlhddv_Load(object sender, EventArgs e)
        {
            string sql = "SELECT SOPT FROM PHIEUTHUE";
            DataTable dt = cn.taobang(sql);
            comSOPT.DataSource = dt;
            comSOPT.ValueMember = "SOPT";
            string sql1 = "SELECT MADV FROM DICHVU";
            DataTable dt1 = cn.taobang(sql1);
            txtMaDV.DataSource = dt1;
            txtMaDV.ValueMember = "MADV";
            dvHoaDonDV.DataSource = hoadonDvbus.getdata();
        }

        private void dvHoaDonDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaHDDV.Text = dvHoaDonDV.Rows[d].Cells[0].Value.ToString();
            comSOPT.Text = dvHoaDonDV.Rows[d].Cells[1].Value.ToString();
            txtSotienDV.Text = dvHoaDonDV.Rows[d].Cells[2].Value.ToString();
            dvSDDichVu.DataSource = sudungDVbus.getdata(txtMaHDDV.Text.ToString());
        }

        private void dvSDDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaHDDV.Text = dvSDDichVu.Rows[d].Cells[0].Value.ToString();
            txtMaDV.Text = dvSDDichVu.Rows[d].Cells[1].Value.ToString();
            txtGiaDV.Text = dvSDDichVu.Rows[d].Cells[2].Value.ToString();
            txtSoluong.Text = dvSDDichVu.Rows[d].Cells[3].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaHDDV.Clear();
            comSOPT.Text = "";
            txtSotienDV.Clear();
            txtGiaDV.Clear();
            txtMaDV.Text = "";
            txtSoluong.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HOADONDV hddv = new HOADONDV();
                hddv.MAHDDV1 = txtMaHDDV.Text.ToString();
                hddv.MAHDDV1 = txtMaHDDV.Text.ToString();
                hddv.SOPT1 = comSOPT.Text.ToString();
                hddv.SOTIENDV1 = Convert.ToInt32(txtSotienDV.Text.ToString());
                hoadonDvbus.InsertHOADONDV(hddv);
                MessageBox.Show("Đã thêm xong!");
                dvHoaDonDV.DataSource = hoadonDvbus.getdata();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                HOADONDV hddv = new HOADONDV();
                hddv.MAHDDV1 = txtMaHDDV.Text.ToString();
                hddv.SOPT1 = comSOPT.Text.ToString();
                hddv.SOTIENDV1 = Convert.ToInt32(txtSotienDV.Text.ToString());
                hoadonDvbus.UpdateHOADONDV(hddv, hddv.MAHDDV1);
                MessageBox.Show("Đã sữa xong!");
                dvHoaDonDV.DataSource = hoadonDvbus.getdata();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHDDV.Text.ToString() != "")
            {
                try
                {
                    HOADONDV hddv = new HOADONDV();
                    hddv.MAHDDV1 = txtMaHDDV.Text.ToString();
                    string delete = "delete from SUDUNGDV where MAHDDV='" + txtMaHDDV.Text.ToString() + "'";
                    cn.query1(delete);
                    hoadonDvbus.DeleteHOADONDV(hddv.MAHDDV1);

                    MessageBox.Show("Đã xóa xong!");
                    dvHoaDonDV.DataSource = hoadonDvbus.getdata();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            SUDUNGDV sudungDV = new SUDUNGDV();
            sudungDV.MAHDDV1 = txtMaHDDV.Text.ToString();
            sudungDV.MADV1 = txtMaDV.Text.ToString();
            sudungDV.GIADV1 = Convert.ToInt32(txtGiaDV.Text.ToString());
            sudungDV.SOLUONG1 = Convert.ToInt32(txtSoluong.Text.ToString());
            sudungDVbus.InsertSUDUNGDV(sudungDV);
            MessageBox.Show("Đã chọn xong!");
            dvSDDichVu.DataSource = sudungDVbus.getdata(txtMaHDDV.Text.ToString());
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if ((txtMaHDDV.Text.ToString() != "") && (txtMaDV.Text.ToString() != ""))
            {
                try
                {
                    SUDUNGDV sudungDV = new SUDUNGDV();
                    sudungDV.MAHDDV1 = txtMaHDDV.Text.ToString();
                    sudungDV.MADV1 = txtMaDV.Text.ToString();

                    sudungDVbus.DeleteSUDUNGDV(sudungDV.MAHDDV1, sudungDV.MADV1);

                    MessageBox.Show("Đã hủy xong!");
                    dvSDDichVu.DataSource = sudungDVbus.getdata(txtMaHDDV.Text.ToString());
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
