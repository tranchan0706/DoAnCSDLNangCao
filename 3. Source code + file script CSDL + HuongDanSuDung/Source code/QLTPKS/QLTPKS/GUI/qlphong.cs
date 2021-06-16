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
    public partial class qlphong : Form
    {
        PHONGBUS phongbus = new PHONGBUS();
        connect cn = new connect();
        public qlphong()
        {
            InitializeComponent();
        }
        public qlphong(String user)
        {
            InitializeComponent();
            button2.Text = user;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                PHONG phong = new PHONG();
                phong.MAPHONG1 = txtMaPhong.Text.ToString();
                phong.MALOAIPHONG1 = comMaLoaiPhong.Text.ToString();
                phong.TINHTRANG1 = txtTinhTrang.Text.ToString();
                phong.SDTPHONG1 = Convert.ToInt32(txtSDTPhong.Text.ToString());
                phongbus.UpdatePHONG(phong, phong.MAPHONG1);
                MessageBox.Show("Đã sữa xong!");
                if (button2.Text.Trim().Equals("CN01"))
                {
                    dvPhong.DataSource = phongbus.getdata1();
                }
                else if (button2.Text.Trim().Equals("CN02"))
                {
                    dvPhong.DataSource = phongbus.getdata2();
                }
                else
                {
                    dvPhong.DataSource = phongbus.getdata();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaPhong.Clear();
            comMaLoaiPhong.Text = "";
            txtTinhTrang.Clear();
            txtSDTPhong.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                PHONG phong = new PHONG();
                phong.MAPHONG1 = txtMaPhong.Text.ToString();
                phong.MALOAIPHONG1 = comMaLoaiPhong.Text.ToString();
                phong.TINHTRANG1 = txtTinhTrang.Text.ToString();
                phong.SDTPHONG1 = Convert.ToInt32(txtSDTPhong.Text.ToString());
                phongbus.InsertPHONG(phong);
                MessageBox.Show("Đã thêm xong!");
                if (button2.Text.Trim().Equals("CN01"))
                {
                    dvPhong.DataSource = phongbus.getdata1();
                }
                else if (button2.Text.Trim().Equals("CN02"))
                {
                    dvPhong.DataSource = phongbus.getdata2();
                }
                else
                {
                    dvPhong.DataSource = phongbus.getdata();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.capnhat1();
                cn.capnhat2();
                dvPhong.DataSource = phongbus.getdata();
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thành công!");
                if (button2.Text.Trim().Equals("CN01"))
                {
                    dvPhong.DataSource = phongbus.getdata1();
                }
                else if (button2.Text.Trim().Equals("CN02"))
                {
                    dvPhong.DataSource = phongbus.getdata2();
                }
                else
                {
                    dvPhong.DataSource = phongbus.getdata();
                }
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text.ToString() != "")
            {
                try
                {
                    PHONG phong = new PHONG();
                    phong.MAPHONG1 = txtMaPhong.Text.ToString();

                    phongbus.DeletePHONG(phong.MAPHONG1);

                    MessageBox.Show("Đã xóa xong!");
                    if (button2.Text.Trim().Equals("CN01"))
                    {
                        dvPhong.DataSource = phongbus.getdata1();
                    }
                    else if (button2.Text.Trim().Equals("CN02"))
                    {
                        dvPhong.DataSource = phongbus.getdata2();
                    }
                    else
                    {
                        dvPhong.DataSource = phongbus.getdata();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void qlphong_Load(object sender, EventArgs e)
        {
            if (button2.Text.Trim().Equals("CN01")) 
            {
                string sql = "SELECT MALOAIPHONG FROM LOAIPHONG";
                DataTable dt = cn.taobang(sql);
                comMaLoaiPhong.DataSource = dt;
                comMaLoaiPhong.ValueMember = "MALOAIPHONG";
                dvPhong.DataSource = phongbus.getdata1();
            }
            else if (button2.Text.Trim().Equals("CN02"))
            {
                string sql = "SELECT MALOAIPHONG FROM LOAIPHONG";
                DataTable dt = cn.taobang(sql);
                comMaLoaiPhong.DataSource = dt;
                comMaLoaiPhong.ValueMember = "MALOAIPHONG";
                dvPhong.DataSource = phongbus.getdata2();
            }
            else
            {
                string sql = "SELECT MALOAIPHONG FROM LOAIPHONG";
                DataTable dt = cn.taobang(sql);
                comMaLoaiPhong.DataSource = dt;
                comMaLoaiPhong.ValueMember = "MALOAIPHONG";
                dvPhong.DataSource = phongbus.getdata();
            }

        }

        private void dvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaPhong.Text = dvPhong.Rows[d].Cells[0].Value.ToString();
            comMaLoaiPhong.Text = dvPhong.Rows[d].Cells[1].Value.ToString();
            txtTinhTrang.Text = dvPhong.Rows[d].Cells[2].Value.ToString();
            txtSDTPhong.Text = dvPhong.Rows[d].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
