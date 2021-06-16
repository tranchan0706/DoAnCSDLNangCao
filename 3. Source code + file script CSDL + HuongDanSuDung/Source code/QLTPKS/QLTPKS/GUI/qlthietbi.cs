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
    public partial class qlthietbi : Form
    {
        public qlthietbi()
        {
            InitializeComponent();
        }
        THIETBIBUS thietbibus = new THIETBIBUS();
        connect cn = new connect();
        private void qlthietbi_Load(object sender, EventArgs e)
        {
            dvThietBi.DataSource = thietbibus.getdata();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaTB.Text = "";
            txtTenTB.Clear();
            txtMota.Text = "";
            txtSoLuong.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                THIETBI thietbi = new THIETBI();
                thietbi.MATB1 = txtMaTB.Text.ToString();
                thietbi.TENTB1 = txtTenTB.Text.ToString();
                thietbi.MOTA1 = txtMota.Text.ToString();
                thietbi.SOLUONG1 = Convert.ToInt32(txtSoLuong.Text.ToString());
                thietbibus.InsertTHIETBI(thietbi);
                MessageBox.Show("Đã thêm xong!");
                dvThietBi.DataSource = thietbibus.getdata();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                THIETBI thietbi = new THIETBI();
                thietbi.MATB1 = txtMaTB.Text.ToString();
                thietbi.TENTB1 = txtTenTB.Text.ToString();
                thietbi.MOTA1 = txtMota.Text.ToString();
                thietbi.SOLUONG1 = Convert.ToInt32(txtSoLuong.Text.ToString());
                thietbibus.UpdateTHIETBI(thietbi, thietbi.MATB1);
                MessageBox.Show("Đã sữa xong!");
                dvThietBi.DataSource = thietbibus.getdata();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }   
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ((txtMaTB.Text.ToString() != ""))
            {
                try
                {
                    THIETBI thietbi = new THIETBI();
                    thietbi.MATB1 = txtMaTB.Text.ToString();

                    thietbibus.DeleteTHIETBI(thietbi.MATB1);

                    MessageBox.Show("Đã xóa xong!");
                    dvThietBi.DataSource = thietbibus.getdata();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void dvThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaTB.Text = dvThietBi.Rows[d].Cells[0].Value.ToString();
            txtTenTB.Text = dvThietBi.Rows[d].Cells[1].Value.ToString();
            txtMota.Text = dvThietBi.Rows[d].Cells[2].Value.ToString();
            txtSoLuong.Text = dvThietBi.Rows[d].Cells[3].Value.ToString();
        }
    }
}
