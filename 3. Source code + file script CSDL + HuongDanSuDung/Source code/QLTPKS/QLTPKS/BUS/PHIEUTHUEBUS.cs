using QLTPKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPKS.BUS
{
    class PHIEUTHUEBUS
    {
        connect dbconnect = new connect();

        public DataTable getdata()
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  SOPT as [Số Phiếu Thuê],MAKH as [Mã Khách Hàng],NGAYTHUE as[Ngày Thuê],TIENCOC as[Tiền Cộc] from PHIEUTHUE");
            dbconnect.Closeconnect();
            return table;
        }
        public DataTable getdata1()
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  SOPT as [Số Phiếu Thuê],MAKH as [Mã Khách Hàng],NGAYTHUE as[Ngày Thuê],TIENCOC as[Tiền Cộc] from PHIEUTHUE where maphong Like 'HN%'");
            dbconnect.Closeconnect();
            return table;
        }
        public DataTable getdata2()
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  SOPT as [Số Phiếu Thuê],MAKH as [Mã Khách Hàng],NGAYTHUE as[Ngày Thuê],TIENCOC as[Tiền Cộc] from PHIEUTHUE where maphong Like 'SG%'");
            dbconnect.Closeconnect();
            return table;
        }
        public void InsertPHIEUTHUE(PHIEUTHUE phieuthue)
        {
            string insert = "insert into PHIEUTHUE(SOPT, MAKH,NGAYTHUE,TIENCOC) values(";
            insert += "N'" + phieuthue.SOPT1 + "',";
            insert += "N'" + phieuthue.MAKH1 + "',";
            insert += "N'" + phieuthue.NGAYTHUE1 + "',";
            insert += "N'" + phieuthue.TIENCOC1 + "')";
            dbconnect.query1(insert);

        }
        public void UpdatePHIEUTHUE(PHIEUTHUE phieuthue, string sopt)
        {
            string update = "update PHIEUTHUE set ";

            update += "MAKH='" + phieuthue.MAKH1 + "',";
            update += "NGAYTHUE='" + phieuthue.NGAYTHUE1 + "',";
            update += "TIENCOC='" + phieuthue.TIENCOC1 + "' ";
            update += "where SOPT='" + sopt + "'";
            dbconnect.query1(update);
        }
        public void DeletePHIEUTHUE(string sopt)
        {
            string delete = "delete from PHIEUTHUE where SOPT='" + sopt + "'";
            dbconnect.query1(delete);
        }
    }
}
