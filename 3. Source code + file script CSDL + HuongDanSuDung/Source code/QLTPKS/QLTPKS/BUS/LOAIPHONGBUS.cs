using QLTPKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPKS.BUS
{
    class LOAIPHONGBUS
    {
        connect dbconnect = new connect();

        public DataTable getdata()
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  MALOAIPHONG as [Mã Loại Phòng],MACHINHANH as [Mã Chi Nhánh],GIAPHONG as[Giá Phòng] from LOAIPHONG ");
            dbconnect.Closeconnect();
            return table;
        }
        public DataTable getdata1(string macn)
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  MALOAIPHONG as [Mã Loại Phòng],MACHINHANH as [Mã Chi Nhánh],GIAPHONG as[Giá Phòng] from LOAIPHONG WHERE MACHINHANH='" + macn + "'");
            dbconnect.Closeconnect();
            return table;
        }
        public void InsertLOAIPHONG(LOAIPHONG loaiphong)
        {
            string insert = "insert into LOAIPHONG(MALOAIPHONG,MACHINHANH,GIAPHONG) values(";
            insert += "N'" + loaiphong.MALOAIPHONG1 + "',";
            insert += "N'" + loaiphong.MACHINHANH1 + "',";
            insert += "N'" + loaiphong.GIAPHONG1 + "')";

            dbconnect.query1(insert);

        }
        public void UpdateLOAIPHONG(LOAIPHONG loaiphong, string ma)
        {
            string update = "update LOAIPHONG set ";

            update += "MACHINHANH='" + loaiphong.MACHINHANH1 + "',";
            update += "GIAPHONG='" + loaiphong.GIAPHONG1 + "' ";
            update += "where MALOAIPHONG='" + ma + "'";
            dbconnect.query1(update);
        }
        public void DeleteLOAIPHONG(string ma)
        {
            string delete = "delete from LOAIPHONG where MALOAIPHONG='" + ma + "'";
            dbconnect.query1(delete);
        }
    }
}
