using QLTPKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPKS.BUS
{
    class DICHVUBUS
    {
        connect dbconnect = new connect();

        public DataTable getdata()
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  MADV as [Mã Dịch Vụ],TENDV as [Tên Dịch Vụ],GIADV as[Giá DV] from DICHVU");
            dbconnect.Closeconnect();
            return table;
        }
        public void InsertDICHVU(DICHVU dichvu)
        {
            string insert = "insert into DICHVU(MADV, TENDV,GIADV) values(";
            insert += "N'" + dichvu.MADV1 + "',";
            insert += "N'" + dichvu.TENDV1 + "',";
            insert += "N'" + dichvu.GIADV1 + "')";
            dbconnect.query1(insert);

        }
        public void UpdateDICHVU(DICHVU dichvu, string ma)
        {
            string update = "update DICHVU set ";

            update += "TENDV='" + dichvu.TENDV1 + "',";
            update += "GIADV='" + dichvu.GIADV1 + "'";

            update += "where MADV='" + ma + "'";
            dbconnect.query1(update);
        }
        public void DeleteDICHVU(string ma)
        {
            string delete = "delete from DICHVU where MADV='" + ma + "'";
            dbconnect.query1(delete);
        }
    }
}
