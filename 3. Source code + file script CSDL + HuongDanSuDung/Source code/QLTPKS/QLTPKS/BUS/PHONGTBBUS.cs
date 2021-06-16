using QLTPKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPKS.BUS
{
    class PHONGTBBUS
    {
        connect dbconnect = new connect();

        public DataTable getdata()
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  MATB as [Mã TB],MAPHONG as [Mã Phòng],TINHTRANG as[Tình Trạng PTB],GHICHU as[Ghi Chú] from PHONGTB");
            dbconnect.Closeconnect();
            return table;
        }
        public DataTable getdata1()
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  MATB as [Mã TB],MAPHONG as [Mã Phòng],TINHTRANG as[Tình Trạng PTB],GHICHU as[Ghi Chú] from PHONGTB where maphong like 'HN%'");
            dbconnect.Closeconnect();
            return table;
        }
        public DataTable getdata2()
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  MATB as [Mã TB],MAPHONG as [Mã Phòng],TINHTRANG as[Tình Trạng PTB],GHICHU as[Ghi Chú] from PHONGTB where maphong like 'SG%'");
            dbconnect.Closeconnect();
            return table;
        }
        public void InsertPHONGTB(PHONGTB phongtb)
        {
            string insert = "insert into PHONGTB(MATB, MAPHONG,TINHTRANG,GHICHU) values(";
            insert += "N'" + phongtb.MATB1 + "',";
            insert += "N'" + phongtb.MAPHONG1 + "',";
            insert += "N'" + phongtb.TINHTRANGPTB1 + "',";
            insert += "N'" + phongtb.GHICHU1 + "')";
            dbconnect.query1(insert);

        }
        public void UpdatePHONGTB(PHONGTB phongtb, string matb, string map)
        {
            string update = "update PHONGTB set ";


            update += "TINHTRANG='" + phongtb.TINHTRANGPTB1 + "',";
            update += "GHICHU='" + phongtb.GHICHU1 + "' ";
            update += "where MATB='" + matb.ToString() + "'AND MAPHONG='" + map.ToString() + "'";
            dbconnect.query1(update);
        }
        public void DeletePHONGTB(string matb, string map)
        {
            string delete = "delete from PHONGTB where MATB='" + matb + "'and MAPHONG='" + map + "'";
            dbconnect.query1(delete);
        }
    }
}
