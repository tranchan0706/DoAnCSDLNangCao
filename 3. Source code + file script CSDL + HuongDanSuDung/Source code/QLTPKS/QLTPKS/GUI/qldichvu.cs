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
    public partial class qldichvu : Form
    {
        public qldichvu()
        {
            InitializeComponent();
        }
        DICHVUBUS dichvubus = new DICHVUBUS();
        connect cn = new connect();
        private void qldichvu_Load(object sender, EventArgs e)
        {
            dvDichVu.DataSource = dichvubus.getdata();
        }

        private void dvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaDV.Text = dvDichVu.Rows[d].Cells[0].Value.ToString();
            txtTenDV.Text = dvDichVu.Rows[d].Cells[1].Value.ToString();
            txtGiaDV.Text = dvDichVu.Rows[d].Cells[2].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGiaDV.Clear();
            txtMaDV.Clear();
            txtTenDV.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DICHVU dv = new DICHVU();
                dv.MADV1 = txtMaDV.Text.ToString();
                dv.TENDV1 = txtTenDV.Text.ToString();
                dv.GIADV1 = Convert.ToInt32(txtGiaDV.Text.ToString());
                dichvubus.InsertDICHVU(dv);
                MessageBox.Show("Đã thêm xong!");
                dvDichVu.DataSource = dichvubus.getdata();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                DICHVU dv = new DICHVU();
                dv.MADV1 = txtMaDV.Text.ToString();
                dv.TENDV1 = txtTenDV.Text.ToString();
                dv.GIADV1 = Convert.ToInt32(txtGiaDV.Text.ToString());
                dichvubus.UpdateDICHVU(dv, dv.MADV1);
                MessageBox.Show("Đã sữa xong!");
                dvDichVu.DataSource = dichvubus.getdata();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDV.Text.ToString() != "")
            {
                try
                {
                    DICHVU dv = new DICHVU();
                    dv.MADV1 = txtMaDV.Text.ToString();

                    dichvubus.DeleteDICHVU(dv.MADV1);

                    MessageBox.Show("Đã xóa xong!");
                    dvDichVu.DataSource = dichvubus.getdata();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
