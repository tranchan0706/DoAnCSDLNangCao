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
    public partial class phieuthue : Form
    {
        PHONGTHUEBUS phongthuebus = new PHONGTHUEBUS();
        PHIEUTHUEBUS PhieuThuebus = new PHIEUTHUEBUS();
        connect cn = new connect();
        public phieuthue()
        {
            InitializeComponent();
        }
        public phieuthue(String user)
        {
            InitializeComponent();
            button2.Text = user;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.capnhat1();
                cn.capnhat2();
                dvPhieuThue.DataSource = PhieuThuebus.getdata();
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thành công!");
                dvPhieuThue.DataSource = PhieuThuebus.getdata();
                return;
            }
        }

        private void phieuthue_Load(object sender, EventArgs e)
        {
            if (button2.Text.Trim().Equals("CN01"))
            {
                string sql1 = "SELECT MAPHONG FROM PHONG WHERE MAPHONG LIKE 'HN%'";
                DataTable dt1 = cn.taobang(sql1);
                comMaPhong.DataSource = dt1;
                comMaPhong.ValueMember = "MAPHONG";
            }
            else if (button2.Text.Trim().Equals("CN02"))
            {
                string sql1 = "SELECT MAPHONG FROM PHONG WHERE MAPHONG LIKE 'SG%'";
                DataTable dt1 = cn.taobang(sql1);
                comMaPhong.DataSource = dt1;
                comMaPhong.ValueMember = "MAPHONG";
            }
            else
            {
                string sql1 = "SELECT MAPHONG FROM PHONG ";
                DataTable dt1 = cn.taobang(sql1);
                comMaPhong.DataSource = dt1;
                comMaPhong.ValueMember = "MAPHONG";
            }
            //-------------------------------------------------------------
            string sql = "SELECT MAKH FROM KHACHHANG";
            DataTable dt = cn.taobang(sql);
            comMaKH.DataSource = dt;
            comMaKH.ValueMember = "MAKH";
            dvPhieuThue.DataSource = PhieuThuebus.getdata();
           // dvPhongThue.DataSource = phongthuebus.getdata();
        }

        private void dvPhongThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtSoPT.Text = dvPhongThue.Rows[d].Cells[0].Value.ToString();
            comMaPhong.Text = dvPhongThue.Rows[d].Cells[1].Value.ToString();
            dateNgayDen.Text = dvPhongThue.Rows[d].Cells[2].Value.ToString();
            dateNgayDi.Text = dvPhongThue.Rows[d].Cells[3].Value.ToString();
        }

        private void dvPhieuThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtSoPT.Text = dvPhieuThue.Rows[d].Cells[0].Value.ToString();
            comMaKH.Text = dvPhieuThue.Rows[d].Cells[1].Value.ToString();
            dateNgayThue.Text = dvPhieuThue.Rows[d].Cells[2].Value.ToString();
            txtTienCoc.Text = dvPhieuThue.Rows[d].Cells[3].Value.ToString();
            if (button2.Text.Trim() == "CN01")
            {
                dvPhongThue.DataSource = phongthuebus.getdata11(txtSoPT.Text.ToString());
            }
            else if (button2.Text.Trim() == "CN02")
            {
                dvPhongThue.DataSource = phongthuebus.getdata22(txtSoPT.Text.ToString());
            }
            else
            {
                dvPhongThue.DataSource = phongthuebus.getdata(txtSoPT.Text.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSoPT.Clear();
            comMaKH.Text = "";
            txtTienCoc.Clear();
            dateNgayThue.Text = "";
            comMaPhong.Text = "";
            dateNgayDen.Text = "";
            dateNgayDi.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                PHIEUTHUE pt = new PHIEUTHUE();
                pt.SOPT1 = txtSoPT.Text.ToString();
                pt.MAKH1 = comMaKH.Text.ToString();
                pt.NGAYTHUE1 = dateNgayThue.Value;
                pt.TIENCOC1 = Convert.ToInt32(txtTienCoc.Text.ToString());
                PhieuThuebus.InsertPHIEUTHUE(pt);
                MessageBox.Show("Đã thêm xong!");
                if (button2.Text.Trim() == "CN01")
                {
                    dvPhieuThue.DataSource = PhieuThuebus.getdata1();
                    dvPhongThue.DataSource = phongthuebus.getdata11(txtSoPT.Text.ToString());
                }
                else if (button2.Text.Trim() == "CN02")
                {
                    dvPhieuThue.DataSource = PhieuThuebus.getdata2();
                    dvPhongThue.DataSource = phongthuebus.getdata22(txtSoPT.Text.ToString());
                }
                else
                {
                    dvPhieuThue.DataSource = PhieuThuebus.getdata();
                    dvPhongThue.DataSource = phongthuebus.getdata(txtSoPT.Text.ToString());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                PHIEUTHUE pt = new PHIEUTHUE();
                pt.SOPT1 = txtSoPT.Text.ToString();
                pt.MAKH1 = comMaKH.Text.ToString();
                pt.NGAYTHUE1 = dateNgayThue.Value;
                pt.TIENCOC1 = Convert.ToInt32(txtTienCoc.Text.ToString());
                PhieuThuebus.UpdatePHIEUTHUE(pt, pt.SOPT1);
                MessageBox.Show("Đã sữa xong!");
                if (button2.Text.Trim() == "CN01")
                {
                    dvPhieuThue.DataSource = PhieuThuebus.getdata1();
                    dvPhongThue.DataSource = phongthuebus.getdata11(txtSoPT.Text.ToString());
                }
                else if (button2.Text.Trim() == "CN02")
                {
                    dvPhieuThue.DataSource = PhieuThuebus.getdata2();
                    dvPhongThue.DataSource = phongthuebus.getdata22(txtSoPT.Text.ToString());
                }
                else
                {
                    dvPhieuThue.DataSource = PhieuThuebus.getdata();
                    dvPhongThue.DataSource = phongthuebus.getdata(txtSoPT.Text.ToString());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtSoPT.Text.ToString() != "")
            {
                try
                {
                    PHIEUTHUE pt = new PHIEUTHUE();
                    pt.SOPT1 = txtSoPT.Text.ToString();
                    string delete = "delete from PHONGTHUE where SOPT='" + txtSoPT.Text.ToString() + "'";
                    cn.query1(delete);
                    PhieuThuebus.DeletePHIEUTHUE(pt.SOPT1);

                    MessageBox.Show("Đã xóa xong!");

                    if (button2.Text.Trim() == "CN01")
                    {
                        dvPhieuThue.DataSource = PhieuThuebus.getdata1();
                        dvPhongThue.DataSource = phongthuebus.getdata11(txtSoPT.Text.ToString());
                    }
                    else if (button2.Text.Trim() == "CN02")
                    {
                        dvPhieuThue.DataSource = PhieuThuebus.getdata2();
                        dvPhongThue.DataSource = phongthuebus.getdata22(txtSoPT.Text.ToString());
                    }
                    else
                    {
                        dvPhieuThue.DataSource = PhieuThuebus.getdata();
                        dvPhongThue.DataSource = phongthuebus.getdata(txtSoPT.Text.ToString());
                    }
                    
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {
                PHONGTHUE phongthue = new PHONGTHUE();
                phongthue.SOPT1 = txtSoPT.Text.ToString();
                phongthue.MAPHONG1 = comMaPhong.Text.ToString();
                phongthue.NGAYDEN1 = dateNgayDen.Value;
                phongthue.NGAYDI1 = dateNgayDi.Value;
                phongthuebus.InsertPHONGTHUE(phongthue);
                MessageBox.Show("Đã chon xong!");
                dvPhongThue.DataSource = phongthuebus.getdata(txtSoPT.Text.ToString());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if ((txtSoPT.Text.ToString() != "") && (comMaPhong.Text.ToString() != ""))
            {
                try
                {
                    PHONGTHUE phongthue = new PHONGTHUE();
                    phongthue.SOPT1 = txtSoPT.Text.ToString();
                    phongthue.MAPHONG1 = comMaPhong.Text.ToString();

                    phongthuebus.DeletePHONGTHUE(phongthue.SOPT1, phongthue.MAPHONG1);

                    MessageBox.Show("Đã hủy xong!");
                    dvPhongThue.DataSource = phongthuebus.getdata(txtSoPT.Text.ToString());
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
