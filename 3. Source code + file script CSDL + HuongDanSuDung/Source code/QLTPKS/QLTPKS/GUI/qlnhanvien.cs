using QLTPKS.BUS;
using QLTPKS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTPKS.GUI
{
    public partial class qlnhanvien : Form
    {
        public qlnhanvien()
        {
            InitializeComponent();
        }
        public qlnhanvien(String user)
        {
            InitializeComponent();
            button2.Text = user;
        }
        NHANVIENBUS nhanvienbus = new NHANVIENBUS();
        connect cn = new connect();
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (KTKC(txtMaNV.Text) == true)
                {
                    NHANVIEN nhanvienn = new NHANVIEN();
                    nhanvienn.MANV1 = txtMaNV.Text.ToString();
                    nhanvienn.TENNV1 = txtTenNV.Text.ToString();
                    nhanvienn.DIACHI1 = txtDiaChi.Text.ToString();
                    nhanvienn.SDT1 = txtSDT.Text.ToString();
                    nhanvienn.TK1 = txtTK.Text.ToString();
                    nhanvienn.MK1 = txtMK.Text.ToString();
                    nhanvienn.MACHINHANH1 = txtMACN.Text.ToString();
                    nhanvienbus.InsertNHANVIEN(nhanvienn);
                    MessageBox.Show("Đã thêm xong!");
                    if (button2.Text.Trim() == "CN01")
                    {
                        txtMACN.Enabled = false;
                        dvNHANVIEN.DataSource = nhanvienbus.getdata1(button2.Text);
                    }
                    else if (button2.Text.Trim() == "CN02")
                    {
                        txtMACN.Enabled = false;
                        dvNHANVIEN.DataSource = nhanvienbus.getdata2(button2.Text);
                    }
                    else
                    {
                        txtMACN.Enabled = true;
                        dvNHANVIEN.DataSource = nhanvienbus.getdata();
                    }
                }
                else
                {
                    MessageBox.Show("Mã Nhân Viên đã tồn tại!");
                    return;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDiaChi.Clear();
            txtTK.Clear();
            txtMK.Clear();
            if(button2.Text.Trim()=="")
            {
                txtMACN.Clear();}
            txtSDT.Clear();

            txtMaNV.Enabled = true;
        }

        private void qlnhanvien_Load(object sender, EventArgs e)
        {
            if (button2.Text.Trim() == "CN01")
            {
                txtMACN.Enabled = false;
                dvNHANVIEN.DataSource = nhanvienbus.getdata1(button2.Text);
            }
            else if (button2.Text.Trim() == "CN02")
            {
                txtMACN.Enabled = false;
                dvNHANVIEN.DataSource = nhanvienbus.getdata2(button2.Text); }
            else
            {
                txtMACN.Enabled = true;
                dvNHANVIEN.DataSource = nhanvienbus.getdata();
            }
        }

        private void dvNHANVIEN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dvNHANVIEN.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                txtDiaChi.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();
                txtTK.Text = row.Cells[4].Value.ToString();
                txtMK.Text = row.Cells[5].Value.ToString();
                txtMACN.Text = row.Cells[6].Value.ToString();
                //Không cho phép sửa trường mã
                txtMaNV.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                NHANVIEN nhanvienn = new NHANVIEN();
                nhanvienn.MANV1 = txtMaNV.Text.ToString();
                nhanvienn.TENNV1 = txtTenNV.Text.ToString();
                nhanvienn.DIACHI1 = txtDiaChi.Text.ToString();
                nhanvienn.SDT1 = txtSDT.Text.ToString();
                nhanvienn.TK1 = txtTK.Text.ToString();
                nhanvienn.MK1 = txtMK.Text.ToString();
                nhanvienn.MACHINHANH1 = txtMACN.Text.ToString();
                nhanvienbus.UpdateNHANVIEN(nhanvienn, nhanvienn.MANV1);
                MessageBox.Show("Đã sửa xong!");
                if (button2.Text.Trim() == "CN01")
                {
                    txtMACN.Enabled = false;
                    dvNHANVIEN.DataSource = nhanvienbus.getdata1(button2.Text);
                }
                else if (button2.Text.Trim() == "CN02")
                {
                    txtMACN.Enabled = false;
                    dvNHANVIEN.DataSource = nhanvienbus.getdata2(button2.Text);
                }
                else
                {
                    txtMACN.Enabled = true;
                    dvNHANVIEN.DataSource = nhanvienbus.getdata();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.ToString() != "")
            {
                try
                {
                    NHANVIEN nhanvienn = new NHANVIEN();
                    nhanvienn.MANV1 = txtMaNV.Text.ToString();

                    nhanvienbus.DeleteNHANVIEN(nhanvienn.MANV1);

                    MessageBox.Show("Đã xóa xong!");
                    if (button2.Text.Trim() == "CN01")
                    {
                        txtMACN.Enabled = false;
                        dvNHANVIEN.DataSource = nhanvienbus.getdata1(button2.Text);
                    }
                    else if (button2.Text.Trim() == "CN02")
                    {
                        txtMACN.Enabled = false;
                        dvNHANVIEN.DataSource = nhanvienbus.getdata2(button2.Text);
                    }
                    else
                    {
                        txtMACN.Enabled = true;
                        dvNHANVIEN.DataSource = nhanvienbus.getdata();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.capnhat1();
                cn.capnhat2();
                dvNHANVIEN.DataSource = nhanvienbus.getdata();
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thành công!");
                if (button2.Text.Trim() == "CN01")
                {
                    txtMACN.Enabled = false;
                    dvNHANVIEN.DataSource = nhanvienbus.getdata1(button2.Text);
                }
                else if (button2.Text.Trim() == "CN02")
                {
                    txtMACN.Enabled = false;
                    dvNHANVIEN.DataSource = nhanvienbus.getdata2(button2.Text);
                }
                else
                {
                    txtMACN.Enabled = true;
                    dvNHANVIEN.DataSource = nhanvienbus.getdata();
                }
            }
        }
        public bool KTKC(string MANV)
        {
            try
            {
                if (button2.Text.Trim()=="CN01")
                {
                    cn.ketnoiCN1.Open();
                    string CauLenh = "DECLARE	@return_value int EXEC	@return_value = [dbo].[sp_KiemTraMaNhanVienTonTai] @manv = N'" + MANV + "' SELECT	'Return Value' = @return_value";
                    SqlCommand cmd = new SqlCommand(CauLenh, cn.ketnoiCN1);
                    object value = cmd.ExecuteScalar();
                    cn.ketnoiCN1.Close();
                    int kq = int.Parse(value.ToString());
                    if (kq == 1)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                }
                else if (button2.Text.Trim() == "CN02")
                {

                    cn.ketnoiCN2.Open();
                    string CauLenh = "DECLARE	@return_value int EXEC	@return_value = [dbo].[sp_KiemTraMaNhanVienTonTai] @manv = N'" + MANV + "' SELECT	'Return Value' = @return_value";
                    SqlCommand cmd = new SqlCommand(CauLenh, cn.ketnoiCN2);
                    object value = cmd.ExecuteScalar();
                    cn.ketnoiCN2.Close();
                    int kq = int.Parse(value.ToString());
                    if (kq == 1)
                    {

                        return false;

                    }
                    else
                    {
                        return true;
                    }

                }
                else
                {
                    cn.ketnoiCN.Open();
                    string CauLenh = "DECLARE	@return_value int EXEC	@return_value = [dbo].[sp_KiemTraMaNhanVienTonTai] @manv = N'" + MANV + "' SELECT	'Return Value' = @return_value";
                    SqlCommand cmd = new SqlCommand(CauLenh, cn.ketnoiCN);
                    object value = cmd.ExecuteScalar();
                    cn.ketnoiCN.Close();
                    int kq = int.Parse(value.ToString());
                    if (kq == 1)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch { return false; }
        }
    }
}
