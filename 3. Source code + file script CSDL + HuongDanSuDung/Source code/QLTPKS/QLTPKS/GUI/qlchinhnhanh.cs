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
    public partial class qlchinhnhanh : Form
    {
        CHINHANHBUS chinhanhbus = new CHINHANHBUS();
        connect cn = new connect();
        public qlchinhnhanh()
        {
            InitializeComponent();
            
        }

        private void qlchinhnhanh_Load(object sender, EventArgs e)
        {
            dvChiNhanh.DataSource = chinhanhbus.getdata();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_MaChiNhanh.Clear();
            txt_TenChiNhanh.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                CHINHANH chinhanh = new CHINHANH();
                chinhanh.MACHINHANH1 = txt_MaChiNhanh.Text.ToString();
                chinhanh.TENCHINHANH1 = txt_TenChiNhanh.Text.ToString();
                chinhanhbus.InsertCHINHANH(chinhanh);
                MessageBox.Show("Đã thêm xong!");
                dvChiNhanh.DataSource = chinhanhbus.getdata();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                CHINHANH chinhanh = new CHINHANH();
                chinhanh.MACHINHANH1 = txt_MaChiNhanh.Text.ToString();
                chinhanh.TENCHINHANH1 = txt_TenChiNhanh.Text.ToString();
                chinhanhbus.UpdateCHINHANH(chinhanh, chinhanh.MACHINHANH1);
                MessageBox.Show("Đã sữa xong!");
                dvChiNhanh.DataSource = chinhanhbus.getdata();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txt_MaChiNhanh.Text.ToString() != "")
            {
                try
                {
                    CHINHANH chinhanh = new CHINHANH();
                    chinhanh.MACHINHANH1 = txt_MaChiNhanh.Text.ToString();

                    chinhanhbus.DeleteCHINHANH(chinhanh.MACHINHANH1);

                    MessageBox.Show("Đã xóa xong!");
                    dvChiNhanh.DataSource = chinhanhbus.getdata();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void dvChiNhanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txt_MaChiNhanh.Text = dvChiNhanh.Rows[d].Cells[0].Value.ToString();
            txt_TenChiNhanh.Text = dvChiNhanh.Rows[d].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.capnhat1();
                cn.capnhat2();
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thành công!");
                dvChiNhanh.DataSource = chinhanhbus.getdata();
            }
        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

    }
}
