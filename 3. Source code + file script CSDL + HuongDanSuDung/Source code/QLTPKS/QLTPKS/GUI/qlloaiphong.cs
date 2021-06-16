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
    public partial class qlloaiphong : Form
    {
        LOAIPHONGBUS Lphongbus = new LOAIPHONGBUS();
        connect cn = new connect();
        public qlloaiphong()
        {
            InitializeComponent();
        }
        public qlloaiphong(String user)
        {
            InitializeComponent();
            button2.Text = user;
        }

        private void qlloaiphong_Load(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                string sql = "SELECT MACHINHANH FROM CHINHANH";
                DataTable dt = cn.taobang(sql);
                comMaChiNhanh.DataSource = dt;
                comMaChiNhanh.ValueMember = "MACHINHANH";
                dvLoaiPhong.DataSource = Lphongbus.getdata();
            }
            else
            {
                string sql = "SELECT MACHINHANH FROM CHINHANH WHERE MACHINHANH='" + button2.Text + "'";
                DataTable dt = cn.taobang(sql);
                comMaChiNhanh.DataSource = dt;
                comMaChiNhanh.ValueMember = "MACHINHANH";
                dvLoaiPhong.DataSource = Lphongbus.getdata1(button2.Text);
            }

        }

        private void dvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaLPhong.Text = dvLoaiPhong.Rows[d].Cells[0].Value.ToString();
            comMaChiNhanh.Text = dvLoaiPhong.Rows[d].Cells[1].Value.ToString();
            txtGiaPhong.Text = dvLoaiPhong.Rows[d].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.capnhat1();
                cn.capnhat2();
                dvLoaiPhong.DataSource = Lphongbus.getdata();
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thành công!");
                if (button2.Text.Trim() == "")
                {
                    dvLoaiPhong.DataSource = Lphongbus.getdata();
                }
                else
                {
                    dvLoaiPhong.DataSource = Lphongbus.getdata1(button2.Text);
                }
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGiaPhong.Clear();
            comMaChiNhanh.Text = "";
            txtMaLPhong.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                LOAIPHONG loaip = new LOAIPHONG();
                loaip.MALOAIPHONG1 = txtMaLPhong.Text.ToString();
                loaip.MACHINHANH1 = comMaChiNhanh.Text.ToString();
                loaip.GIAPHONG1 = Convert.ToInt32(txtGiaPhong.Text.ToString());
                Lphongbus.InsertLOAIPHONG(loaip);
                MessageBox.Show("Đã thêm xong!");
                if (button2.Text.Trim() == "")
                {
                    dvLoaiPhong.DataSource = Lphongbus.getdata();
                }
                else
                {
                    dvLoaiPhong.DataSource = Lphongbus.getdata1(button2.Text);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                LOAIPHONG loaip = new LOAIPHONG();
                loaip.MALOAIPHONG1 = txtMaLPhong.Text.ToString();
                loaip.MACHINHANH1 = comMaChiNhanh.Text.ToString();
                loaip.GIAPHONG1 = Convert.ToInt32(txtGiaPhong.Text.ToString());
                Lphongbus.UpdateLOAIPHONG(loaip, loaip.MALOAIPHONG1);
                MessageBox.Show("Đã sữa xong!");
                if (button2.Text.Trim() == "")
                {
                    dvLoaiPhong.DataSource = Lphongbus.getdata();
                }
                else
                {
                    dvLoaiPhong.DataSource = Lphongbus.getdata1(button2.Text);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLPhong.Text.ToString() != "")
            {
                try
                {
                    LOAIPHONG loaip = new LOAIPHONG();
                    loaip.MALOAIPHONG1 = txtMaLPhong.Text.ToString();

                    Lphongbus.DeleteLOAIPHONG(loaip.MALOAIPHONG1);

                    MessageBox.Show("Đã xóa xong!");
                    if (button2.Text.Trim() == "")
                    {
                        dvLoaiPhong.DataSource = Lphongbus.getdata();
                    }
                    else
                    {
                        dvLoaiPhong.DataSource = Lphongbus.getdata1(button2.Text);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
