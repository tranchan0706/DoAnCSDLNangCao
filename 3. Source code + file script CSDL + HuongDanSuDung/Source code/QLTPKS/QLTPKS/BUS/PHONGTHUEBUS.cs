using QLTPKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPKS.BUS
{
    class PHONGTHUEBUS
    {
        connect dbconnect = new connect();

        public DataTable getdata(string sopt)
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select SOPT as [Số PT],MAPHONG as [Mã Phòng],NGAYDEN as[Ngày đến],NGAYDI as[Ngày đi] from PHONGTHUE where SOPT='" + sopt + "'");
            dbconnect.Closeconnect();
            return table;
        }
        public DataTable getdata1()
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select SOPT as [Số PT],MAPHONG as [Mã Phòng],NGAYDEN as[Ngày đến],NGAYDI as[Ngày đi] from PHONGTHUE where MAPHONG LIKE 'HN%'");
            dbconnect.Closeconnect();
            return table;
        }
        public DataTable getdata11(string sopt)
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select SOPT as [Số PT],MAPHONG as [Mã Phòng],NGAYDEN as[Ngày đến],NGAYDI as[Ngày đi] from PHONGTHUE where sopt='"+sopt+"' and MAPHONG LIKE 'HN%'");
            dbconnect.Closeconnect();
            return table;
        }
        public DataTable getdata2()
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select SOPT as [Số PT],MAPHONG as [Mã Phòng],NGAYDEN as[Ngày đến],NGAYDI as[Ngày đi] from PHONGTHUE where MAPHONG LIKE 'SG%'");
            dbconnect.Closeconnect();
            return table;
        }
        public DataTable getdata22(string sopt)
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select SOPT as [Số PT],MAPHONG as [Mã Phòng],NGAYDEN as[Ngày đến],NGAYDI as[Ngày đi] from PHONGTHUE where sopt='" + sopt + "' and MAPHONG LIKE 'SG%'");
            dbconnect.Closeconnect();
            return table;
        }
        public void InsertPHONGTHUE(PHONGTHUE phongthue)
        {
            string insert = "insert into PHONGTHUE(SOPT, MAPHONG,NGAYDEN,NGAYDI) values(";
            insert += "N'" + phongthue.SOPT1 + "',";
            insert += "N'" + phongthue.MAPHONG1 + "',";
            insert += "N'" + phongthue.NGAYDEN1 + "',";
            insert += "N'" + phongthue.NGAYDI1 + "')";

            dbconnect.query1(insert);

        }
        public void UpdatePHONGTHUE(PHONGTHUE phongthue, string sopt, string map)
        {
            string update = "update PHONGTHUE set ";


            update += "NGAYDEN='" + phongthue.NGAYDEN1 + "',";
            update += "NGAYDI='" + phongthue.NGAYDI1 + "' ";

            update += "where SOPT='" + sopt + "'and MAPHONG='" + map + "'";
            dbconnect.query1(update);
        }
        public void DeletePHONGTHUE(string sopt, string map)
        {
            string delete = "delete from PHONGTHUE where SOPT='" + sopt + "'and MAPHONG='" + map + "'";
            dbconnect.query1(delete);
        }
    }
}
