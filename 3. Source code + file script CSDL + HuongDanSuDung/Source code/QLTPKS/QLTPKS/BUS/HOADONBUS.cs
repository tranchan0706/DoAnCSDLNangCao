using QLTPKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPKS.BUS
{
    class HOADONBUS
    {
        connect dbconnect = new connect();

        public DataTable getdata()
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  SOHD as [Số Hóa Đơn],SOPT as [Số Phiếu Thuê],NGAYTT as[Ngày Thanh Toán],SOTIEN as[Số Tiền] from HOADON");
            dbconnect.Closeconnect();
            return table;
        }
        public void InsertHOADON(HOADON hoadon)
        {
            string insert = "insert into HOADON(SOHD, SOPT,NGAYTT,SOTIEN) values(";
            insert += "N'" + hoadon.SOHD1 + "',";
            insert += "N'" + hoadon.SOPT1 + "',";
            insert += "N'" + hoadon.NGAYTT1 + "',";
            insert += "N'" + hoadon.SOTIEN1 + "')";
            dbconnect.query1(insert);

        }
        public void UpdateHOADON(HOADON hoadon, string sohd)
        {
            string update = "update HOADON set ";

            update += "SOPT='" + hoadon.SOPT1 + "',";
            update += "NGAYTT='" + hoadon.NGAYTT1 + "',";
            update += "SOTIEN='" + hoadon.SOTIEN1 + "' ";
            update += "where SOHD='" + sohd + "'";
            dbconnect.query1(update);
        }
        public void DeleteHOADON(string sohd)
        {
            string delete = "delete from HOADON where SOHD='" + sohd + "'";
            dbconnect.query1(delete);
        }
    }
}
