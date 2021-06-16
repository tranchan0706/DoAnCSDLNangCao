using QLTPKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTPKS.BUS
{
    class NHANVIENBUS
    {
        connect dbconnect = new connect();

        public DataTable getdata()
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  MANV as [Mã Nhân Viên],TENNV as [Tên Nhân Viên],DIACHI as [Địa Chỉ],SDT as[Số Điện Thoại],TK as [Tài Khoản], MK as [Mật Khẩu],MACHINHANH as [Mã Chi Nhánh] from NHANVIEN");
            dbconnect.Closeconnect();
            return table;
        }
        public DataTable getdata1(string macn)
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  MANV as [Mã Nhân Viên],TENNV as [Tên Nhân Viên],DIACHI as [Địa Chỉ],SDT as[Số Điện Thoại],TK as [Tài Khoản], MK as [Mật Khẩu],MACHINHANH as [Mã Chi Nhánh] from NHANVIEN where MACHINHANH='"+macn+"'");
            dbconnect.Closeconnect();
            return table;
        }
        public DataTable getdata2(string macn)
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  MANV as [Mã Nhân Viên],TENNV as [Tên Nhân Viên],DIACHI as [Địa Chỉ],SDT as[Số Điện Thoại],TK as [Tài Khoản], MK as [Mật Khẩu],MACHINHANH as [Mã Chi Nhánh] from NHANVIEN where MACHINHANH='"+macn+"'");
            dbconnect.Closeconnect();
            return table;
        }
        public void InsertNHANVIEN(NHANVIEN nhanvien)
        {
            string insert = "insert into NHANVIEN(MANV,TENNV,DIACHI,SDT,TK,MK,MACHINHANH) values(";
            insert += "'" + nhanvien.MANV1 + "',";
            insert += "N'" + nhanvien.TENNV1 + "',";
            insert += "N'" + nhanvien.DIACHI1 + "',";
            insert += "'" + nhanvien.SDT1 + "',";
            insert += "'" + nhanvien.TK1 + "',";
            insert += "'" + nhanvien.MK1 + "',";
            insert += "'" + nhanvien.MACHINHANH1 + "')";
            dbconnect.query1(insert);

        }
        public void UpdateNHANVIEN(NHANVIEN nhanvien, string manv)
        {
            string update = "update NHANVIEN set ";

            update += "TENNV=N'" + nhanvien.TENNV1 + "',";
            update += "DIACHI=N'" + nhanvien.DIACHI1 + "', ";
            update += "SDT='" + nhanvien.SDT1 + "', ";
            update += "TK='" + nhanvien.TK1 + "', ";
            update += "MK='" + nhanvien.MK1 + "', ";
            update += "MACHINHANH='" + nhanvien.MACHINHANH1 + "' ";

            update += "where MANV='" + manv + "'";
            dbconnect.query1(update);
        }
        public void DeleteNHANVIEN(string manv)
        {
            string delete = "delete from NHANVIEN where MANV='" + manv + "'";
            dbconnect.query1(delete);
        }
        public bool KTDN(ComboBox cb, string Acc, string MK)
        {
            try
            {
                if (cb.SelectedIndex == 0)
                {

                    dbconnect.ketnoiCN1.Open();
                    string CauLenh = "DECLARE	@return_value int EXEC	@return_value = [dbo].[KTDN] @manv = N'" + Acc + "',@tennv = N'" + MK + "' SELECT	'Return Value' = @return_value";
                    SqlCommand cmd = new SqlCommand(CauLenh, dbconnect.ketnoiCN1);
                    object value = cmd.ExecuteScalar();
                    dbconnect.ketnoiCN1.Close();
                    int kq = int.Parse(value.ToString());
                    if (kq == 1)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else if (cb.SelectedIndex == 1)
                {

                    dbconnect.ketnoiCN2.Open();
                    string CauLenh = "DECLARE	@return_value int EXEC	@return_value = [dbo].[KTDN] @manv = N'" + Acc + "',@tennv = N'" + MK + "' SELECT	'Return Value' = @return_value";
                    SqlCommand cmd = new SqlCommand(CauLenh, dbconnect.ketnoiCN2);
                    object value = cmd.ExecuteScalar();
                    dbconnect.ketnoiCN2.Close();
                    int kq = int.Parse(value.ToString());
                    if (kq == 1)
                    {
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch { return false; }
        }
    }
}
