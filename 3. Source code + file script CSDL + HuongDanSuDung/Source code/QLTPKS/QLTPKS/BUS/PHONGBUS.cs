using QLTPKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPKS.BUS
{
    class PHONGBUS
    {
        connect dbconnect = new connect();

        public DataTable getdata()
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  MAPHONG as [Mã Phòng],MALOAIPHONG as [Mã Loại Phòng],TINHTRANG as[Tình Trạng],SDTPHONG as[Số ĐT Phòng] from PHONG");
            dbconnect.Closeconnect();
            return table;
        }
        public DataTable getdata1()
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  MAPHONG as [Mã Phòng],MALOAIPHONG as [Mã Loại Phòng],TINHTRANG as[Tình Trạng],SDTPHONG as[Số ĐT Phòng] from PHONG where MAPHONG LIKE 'HN%'");
            dbconnect.Closeconnect();
            return table;
        }
        public DataTable getdata2()
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  MAPHONG as [Mã Phòng],MALOAIPHONG as [Mã Loại Phòng],TINHTRANG as[Tình Trạng],SDTPHONG as[Số ĐT Phòng] from PHONG where MAPHONG LIKE 'SG%'");
            dbconnect.Closeconnect();
            return table;
        }
        public void InsertPHONG(PHONG phong)
        {
            string insert = "insert into PHONG(MAPHONG, MALOAIPHONG,TINHTRANG,SDTPHONG) values(";
            insert += "N'" + phong.MAPHONG1 + "',";
            insert += "N'" + phong.MALOAIPHONG1 + "',";
            insert += "N'" + phong.TINHTRANG1 + "',";
            insert += "N'" + phong.SDTPHONG1 + "')";
            dbconnect.query1(insert);

        }
        public void UpdatePHONG(PHONG phong, string ma)
        {
            string update = "update PHONG set ";

            update += "MALOAIPHONG='" + phong.MALOAIPHONG1 + "',";
            update += "TINHTRANG='" + phong.TINHTRANG1 + "',";
            update += "SDTPHONG='" + phong.SDTPHONG1 + "' ";
            update += "where MAPHONG='" + ma + "'";
            dbconnect.query1(update);
        }
        public void DeletePHONG(string ma)
        {
            string delete = "delete from PHONG where MAPHONG='" + ma + "'";
            dbconnect.query1(delete);
        }
    }
}
