using QLTPKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPKS.BUS
{
    class THIETBIBUS
    {
        connect dbconnect = new connect();

        public DataTable getdata()
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  MATB as [Mã Thiết Bị],TENTHIETBI as [Tên Thiết Bị],MOTA as[Mô Tả],SOLUONG as[Số Lượng] from THIETBI");
            dbconnect.Closeconnect();
            return table;
        }
        public void InsertTHIETBI(THIETBI thietbi)
        {
            string insert = "insert into THIETBI(MATB, TENTHIETBI,MOTA,SOLUONG) values(";
            insert += "N'" + thietbi.MATB1 + "',";
            insert += "N'" + thietbi.TENTB1 + "',";
            insert += "N'" + thietbi.MOTA1 + "',";
            insert += "N'" + thietbi.SOLUONG1 + "')";
            dbconnect.query1(insert);

        }
        public void UpdateTHIETBI(THIETBI thietbi, string matb)
        {
            string update = "update THIETBI set ";

            update += "TENTHIETBI='" + thietbi.TENTB1 + "',";
            update += "MOTA='" + thietbi.MOTA1 + "',";
            update += "SOLUONG='" + thietbi.SOLUONG1 + "' ";
            update += "where MATB='" + matb + "'";
            dbconnect.query1(update);
        }
        public void DeleteTHIETBI(string matb)
        {
            string delete = "delete from THIETBI where MATB='" + matb + "'";
            dbconnect.query1(delete);
        }
    }
}
