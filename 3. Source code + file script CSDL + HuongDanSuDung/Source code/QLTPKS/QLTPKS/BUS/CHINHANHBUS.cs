using QLTPKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPKS.BUS
{
    class CHINHANHBUS
    {
        connect dbconnect = new connect();

        public DataTable getdata()
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  MACHINHANH as [Mã Chi Nhánh],TENCHINHANH as [Tên Chi Nhánh] from CHINHANH");
            dbconnect.Closeconnect();
            return table;
        }
        public void InsertCHINHANH(CHINHANH chinhanh)
        {
            string insert = "insert into CHINHANH(MACHINHANH, TENCHINHANH) values(";
            insert += "N'" + chinhanh.MACHINHANH1 + "',";
            insert += "N'" + chinhanh.TENCHINHANH1 + "')";
            dbconnect.query1(insert);

        }
        public void UpdateCHINHANH(CHINHANH chinhanh, string ma)
        {
            string update = "update CHINHANH set ";

            update += "TENCHINHANH='" + chinhanh.TENCHINHANH1 + "' ";
            update += "where MACHINHANH='" + ma + "'";
            dbconnect.query1(update);
        }
        public void DeleteCHINHANH(string ma)
        {
            string delete = "delete from CHINHANH where MACHINHANH='" + ma + "'";
            dbconnect.query1(delete);
        }
    }
}
