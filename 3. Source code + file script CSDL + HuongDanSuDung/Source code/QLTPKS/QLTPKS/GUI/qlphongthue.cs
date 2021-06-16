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
    public partial class qlphongthue : Form
    {
        PHONGTHUEBUS phongthuebus = new PHONGTHUEBUS();
        connect cn = new connect();
        public qlphongthue()
        {
            InitializeComponent();
        }
        public qlphongthue(String user)
        {
            InitializeComponent();
            button2.Text = user;
        }
        private void qlphongthue_Load(object sender, EventArgs e)
        {
            if (button2.Text.Trim() == "CN01")
            {
                button3.Enabled = false;
                string sql = "SELECT SOPT FROM PHONGTHUE";
                DataTable dt = cn.taobang(sql);
                comSOPT.DataSource = dt;
                comSOPT.ValueMember = "SOPT";
                string sql1 = "SELECT MAPHONG FROM PHONG where MAPHONG LIKE 'HN%'";
                DataTable dt1 = cn.taobang(sql1);
                comMaPhong.DataSource = dt1;
                comMaPhong.ValueMember = "MAPHONG";
                dvPhongThue.DataSource = phongthuebus.getdata1();
            }
            else if (button2.Text.Trim() == "CN02")
            {
                button3.Enabled = false;
                //comMaPhong.Enabled = false;
                string sql = "SELECT SOPT FROM PHONGTHUE ";
                DataTable dt = cn.taobang(sql);
                comSOPT.DataSource = dt;
                comSOPT.ValueMember = "SOPT";
                string sql1 = "SELECT MAPHONG FROM PHONG where MAPHONG LIKE 'SG%'";
                DataTable dt1 = cn.taobang(sql1);
                comMaPhong.DataSource = dt1;
                comMaPhong.ValueMember = "MAPHONG";
                dvPhongThue.DataSource = phongthuebus.getdata2();
            }
            else
            {
                button3.Enabled = true;
                //comMaPhong.Enabled = true;
                string sql = "SELECT SOPT FROM PHIEUTHUE";
                DataTable dt = cn.taobang(sql);
                comSOPT.DataSource = dt;
                comSOPT.ValueMember = "SOPT";
                string sql1 = "SELECT MAPHONG FROM PHONG";
                DataTable dt1 = cn.taobang(sql1);
                comMaPhong.DataSource = dt1;
                comMaPhong.ValueMember = "MAPHONG";
                dvPhongThue.DataSource = phongthuebus.getdata(comSOPT.SelectedValue.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comSOPT.Text = "";
            comMaPhong.Text = "";
            dateNgayDen.Text = "";
            dateNgayDi.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                PHONGTHUE phongthue = new PHONGTHUE();
                phongthue.SOPT1 = comSOPT.Text.ToString();
                phongthue.MAPHONG1 = comMaPhong.Text.ToString();
                phongthue.NGAYDEN1 = dateNgayDen.Value;
                phongthue.NGAYDI1 = dateNgayDi.Value;
                phongthuebus.InsertPHONGTHUE(phongthue);
                MessageBox.Show("Đã thêm xong!");
                if (button2.Text.Trim() == "CN01")
                {
                    dvPhongThue.DataSource = phongthuebus.getdata1();
                }
                else if (button2.Text.Trim() == "CN02")
                {
                    dvPhongThue.DataSource = phongthuebus.getdata2();
                }
                else
                {
                    dvPhongThue.DataSource = phongthuebus.getdata(comSOPT.SelectedValue.ToString());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                PHONGTHUE phongthue = new PHONGTHUE();
                phongthue.SOPT1 = comSOPT.Text.ToString();
                phongthue.MAPHONG1 = comMaPhong.Text.ToString();
                phongthue.NGAYDEN1 = dateNgayDen.Value;
                phongthue.NGAYDI1 = dateNgayDi.Value;
                phongthuebus.UpdatePHONGTHUE(phongthue, phongthue.SOPT1, phongthue.MAPHONG1);
                MessageBox.Show("Đã sữa xong!");
                if (button2.Text.Trim() == "CN01")
                {
                    dvPhongThue.DataSource = phongthuebus.getdata1();
                }
                else if (button2.Text.Trim() == "CN02")
                {
                    dvPhongThue.DataSource = phongthuebus.getdata2();
                }
                else
                {
                    dvPhongThue.DataSource = phongthuebus.getdata(comSOPT.SelectedValue.ToString());
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ((comSOPT.Text.ToString() != "") && (comMaPhong.Text.ToString() != ""))
            {
                try
                {
                    PHONGTHUE phongthue = new PHONGTHUE();
                    phongthue.SOPT1 = comSOPT.Text.ToString();
                    phongthue.MAPHONG1 = comMaPhong.Text.ToString();

                    phongthuebus.DeletePHONGTHUE(phongthue.SOPT1, phongthue.MAPHONG1);

                    MessageBox.Show("Đã xóa xong!");
                    if (button2.Text.Trim() == "CN01")
                    {
                        dvPhongThue.DataSource = phongthuebus.getdata1();
                    }
                    else if (button2.Text.Trim() == "CN02")
                    {
                        dvPhongThue.DataSource = phongthuebus.getdata2();
                    }
                    else
                    {
                        dvPhongThue.DataSource = phongthuebus.getdata(comSOPT.SelectedValue.ToString());
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void dvPhongThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            comSOPT.Text = dvPhongThue.Rows[d].Cells[0].Value.ToString();
            comMaPhong.Text = dvPhongThue.Rows[d].Cells[1].Value.ToString();
            dateNgayDen.Text = dvPhongThue.Rows[d].Cells[2].Value.ToString();
            dateNgayDi.Text = dvPhongThue.Rows[d].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.capnhat1();
                cn.capnhat2();
                dvPhongThue.DataSource = phongthuebus.getdata(comSOPT.SelectedValue.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thành công!");
                if (button2.Text.Trim() == "CN01")
                {
                    dvPhongThue.DataSource = phongthuebus.getdata1();
                }
                else if (button2.Text.Trim() == "CN02")
                {
                    dvPhongThue.DataSource = phongthuebus.getdata2();
                }
                else
                {
                    dvPhongThue.DataSource = phongthuebus.getdata(comSOPT.SelectedValue.ToString());
                }
                return;
            }
        }

        private void comSOPT_MouseClick(object sender, MouseEventArgs e)
        {
            //dvPhongThue.DataSource = phongthuebus.getdata(comSOPT.SelectedValue.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dvPhongThue.DataSource = phongthuebus.getdata(comSOPT.SelectedValue.ToString());
        }
    }
}
