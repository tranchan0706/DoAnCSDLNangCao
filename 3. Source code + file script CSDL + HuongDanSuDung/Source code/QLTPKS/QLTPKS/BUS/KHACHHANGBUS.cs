using QLTPKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPKS.BUS
{
    class KHACHHANGBUS
    {
        connect dbconnect = new connect();

        public DataTable getdata()
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  MAKH as [Mã Khách Hàng],TENKH as [Tên Khách Hàng],SDTKH as[Số Điện Thoại Khách Hàng],DIACHI as [Địa Chỉ],CMND,QUOCTICH as [Quốc Tịch] from KHACHHANG");
            dbconnect.Closeconnect();
            return table;
        }
        public void InsertKHACHHANG(KHACHHANG khachhang)
        {
            string insert = "insert into KHACHHANG(MAKH,TENKH,SDTKH,DIACHI,CMND,QUOCTICH) values(";
            insert += "N'" + khachhang.MAKH1 + "',";
            insert += "N'" + khachhang.TENKH1 + "',";
            insert += "N'" + khachhang.SDTKH1 + "',";
            insert += "N'" + khachhang.DIACHI1 + "',";
            insert += "N'" + khachhang.CMND1 + "',";
            insert += "N'" + khachhang.QUOCTICH1 + "')";

            dbconnect.query1(insert);

        }
        public void UpdateKHACHHANG(KHACHHANG khachhang, string makh)
        {
            string update = "update KHACHHANG set ";

            update += "TENKH=N'" + khachhang.TENKH1 + "',";
            update += "SDTKH='" + khachhang.SDTKH1 + "', ";
            update += "DIACHI=N'" + khachhang.DIACHI1 + "', ";
            update += "CMND='" + khachhang.CMND1 + "', ";
            update += "QUOCTICH=N'" + khachhang.QUOCTICH1 + "' ";

            update += "where MAKH='" + makh + "'";
            dbconnect.query1(update);
        }
        public void DeleteKHACHHANG(string makh)
        {
            string delete = "delete from KHACHHANG where MAKH='" + makh + "'";
            dbconnect.query1(delete);
        }
    }
}
