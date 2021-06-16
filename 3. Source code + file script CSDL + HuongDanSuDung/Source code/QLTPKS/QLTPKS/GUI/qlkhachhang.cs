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
    public partial class qlkhachhang : Form
    {
        KHACHHANGBUS khangbus = new KHACHHANGBUS();
        connect cn = new connect();
        public qlkhachhang()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();

            txtTenKH.Clear();
            txtDiaChi.Clear();

            txtCMT.Clear();
            txtSDTKH.Clear();

            txtQuocTich.Clear();
            txtMaKH.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                KHACHHANG khachh = new KHACHHANG();
                khachh.MAKH1 = txtMaKH.Text.ToString();
                khachh.TENKH1 = txtTenKH.Text.ToString();
                khachh.SDTKH1 = txtSDTKH.Text.ToString();
                khachh.DIACHI1 = txtDiaChi.Text.ToString();
                khachh.QUOCTICH1 = txtQuocTich.Text.ToString();
                khachh.CMND1 = txtCMT.Text.ToString();
                khangbus.InsertKHACHHANG(khachh);
                MessageBox.Show("Đã thêm xong!");
                dvKhachHang.DataSource = khangbus.getdata();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void qlkhachhang_Load(object sender, EventArgs e)
        {
            dvKhachHang.DataSource = khangbus.getdata();
        }

        private void dvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dvKhachHang.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaKH.Text = row.Cells[0].Value.ToString();
                txtTenKH.Text = row.Cells[1].Value.ToString();
                txtSDTKH.Text = row.Cells[2].Value.ToString();
                txtDiaChi.Text = row.Cells[3].Value.ToString();
                txtCMT.Text = row.Cells[4].Value.ToString();
                txtQuocTich.Text = row.Cells[5].Value.ToString();

                //Không cho phép sửa trường mã
                txtMaKH.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                KHACHHANG khachh = new KHACHHANG();
                khachh.MAKH1 = txtMaKH.Text.ToString();
                khachh.TENKH1 = txtTenKH.Text.ToString();
                khachh.SDTKH1 = txtSDTKH.Text.ToString();
                khachh.DIACHI1 = txtDiaChi.Text.ToString();
                khachh.CMND1 = txtCMT.Text.ToString();
                khachh.QUOCTICH1 = txtQuocTich.Text.ToString();
                khangbus.UpdateKHACHHANG(khachh, khachh.MAKH1);
                MessageBox.Show("Đã sửa xong!");
                dvKhachHang.DataSource = khangbus.getdata();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.ToString() != "")
            {
                try
                {
                    KHACHHANG khachh = new KHACHHANG();
                    khachh.MAKH1 = txtMaKH.Text.ToString();

                    khangbus.DeleteKHACHHANG(khachh.MAKH1);

                    MessageBox.Show("Đã xóa xong!");
                    dvKhachHang.DataSource = khangbus.getdata();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
