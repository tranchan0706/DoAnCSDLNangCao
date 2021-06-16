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
    public partial class qlhoadon : Form
    {
        HOADONBUS hoadonbus = new HOADONBUS();
        connect cn = new connect();
        public qlhoadon()
        {
            InitializeComponent();
        }

        private void qlhoadon_Load(object sender, EventArgs e)
        {
            string sql = "SELECT SOPT FROM PHIEUTHUE";
            DataTable dt = cn.taobang(sql);
            comSOPT.DataSource = dt;
            comSOPT.ValueMember = "SOPT";
            dvHoaDon.DataSource = hoadonbus.getdata();
        }

        private void dvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtSoHD.Text = dvHoaDon.Rows[d].Cells[0].Value.ToString();
            comSOPT.Text = dvHoaDon.Rows[d].Cells[1].Value.ToString();
            dateNgayTT.Text = dvHoaDon.Rows[d].Cells[2].Value.ToString();
            txtSoTien.Text = dvHoaDon.Rows[d].Cells[3].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSoHD.Clear();
            comSOPT.Text = "";
            dateNgayTT.Text = "";
            txtSoTien.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                HOADON hd = new HOADON();
                hd.SOHD1 = txtSoHD.Text.ToString();
                hd.SOPT1 = comSOPT.Text.ToString();
                hd.NGAYTT1 = dateNgayTT.Value;
                hd.SOTIEN1 = Convert.ToInt32(txtSoTien.Text.ToString());
                hoadonbus.InsertHOADON(hd);
                MessageBox.Show("Đã thêm xong!");
                dvHoaDon.DataSource = hoadonbus.getdata();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                HOADON hd = new HOADON();
                hd.SOHD1 = txtSoHD.Text.ToString();
                hd.SOPT1 = comSOPT.Text.ToString();
                hd.NGAYTT1 = dateNgayTT.Value;
                hd.SOTIEN1 = Convert.ToInt32(txtSoTien.Text.ToString());
                hoadonbus.UpdateHOADON(hd, hd.SOHD1);
                MessageBox.Show("Đã sữa xong!");
                dvHoaDon.DataSource = hoadonbus.getdata();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtSoHD.Text.ToString() != "")
            {
                try
                {
                    HOADON hd = new HOADON();
                    hd.SOHD1 = txtSoHD.Text.ToString();

                    hoadonbus.DeleteHOADON(hd.SOHD1);

                    MessageBox.Show("Đã xóa xong!");
                    dvHoaDon.DataSource = hoadonbus.getdata();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
