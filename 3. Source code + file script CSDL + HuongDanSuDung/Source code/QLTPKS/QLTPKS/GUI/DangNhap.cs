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
    public partial class DangNhap : Form
    {
        connect dbconnect = new connect();
        connect cn = new connect();


        public DangNhap()
        {
            InitializeComponent();
            textBox1.Focus();
        }
        public bool KTDN(string Acc, string MK,string chinhanh)
        {
            try
            {
                    cn.ketnoiCN1.Open();
                    string CauLenh = "DECLARE @return_value int EXEC	@return_value = [dbo].[sp_KiemTraDangNhap] "
                        +"@manv = N'" + Acc + "',@mk = N'" + MK + "',@macn = N'" + chinhanh + "' SELECT	'Return Value' = @return_value";
                    SqlCommand cmd = new SqlCommand(CauLenh, cn.ketnoiCN1);
                    object value = cmd.ExecuteScalar();
                    cn.ketnoiCN1.Close();
                    int kq = int.Parse(value.ToString());
                    if (kq == 1)
                    {
                        return true;
                    }
                    else
                        return false;
            }
            catch { return false; }
        }
        public bool KTDN1(string Acc, string MK, string chinhanh)
        {
            try
            {
                cn.ketnoiCN.Open();
                string CauLenh = "DECLARE @return_value int EXEC	@return_value = [dbo].[sp_KiemTraDangNhap] @manv = N'" 
                    + Acc + "',@mk = N'" + MK + "',@macn = N'" + chinhanh + "' SELECT	'Return Value' = @return_value";
                SqlCommand cmd = new SqlCommand(CauLenh, cn.ketnoiCN);
                object value = cmd.ExecuteScalar();
                cn.ketnoiCN.Close();
                int kq = int.Parse(value.ToString());
                if (kq == 1)
                {
                    return true;
                }
                else
                    return false;
            }
            catch { return false; }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true )
            {
                if (KTDN1(textBox1.Text, textBox2.Text, comboBox1.SelectedValue.ToString()) == true)
                {
                    if (textBox1.Text == "ADMIN")
                    {
                        Form1 f = new Form1();
                        f.Show();
                        //this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Người dùng không hợp lệ!");
                        return; }
                }
                else
                {
                    MessageBox.Show("Người dùng không hợp lệ!");
                    return; 
                }
            }
            else if (checkBox1.Checked == false && KTDN(textBox1.Text, textBox2.Text, comboBox1.SelectedValue.ToString()) == true)
            {
                MessageBox.Show("Thành công");
                // Truyên biến mã chi nhánh
                Form1 f = new Form1(comboBox1.SelectedValue.ToString());

                f.Show();
                this.Hide();
            }
            else
            { MessageBox.Show("Người dùng không hợp lệ!"); } 
        }
        
        private void DangNhap_Load(object sender, EventArgs e)
        {
            
            dbconnect.conn = new SqlConnection("Data Source=TRAN-CHAN;Initial Catalog=QL_TPKS;User ID=sa;Password=123");
            DataSet ds = new DataSet();
            textBox1.Focus();
            string CauLenh = "SELECT * FROM CHINHANH";
            SqlDataAdapter da = new SqlDataAdapter(CauLenh,dbconnect.conn );
            da.Fill(ds, "CHINHANH");
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "TENCHINHANH";
            comboBox1.ValueMember = "MACHINHANH";
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
