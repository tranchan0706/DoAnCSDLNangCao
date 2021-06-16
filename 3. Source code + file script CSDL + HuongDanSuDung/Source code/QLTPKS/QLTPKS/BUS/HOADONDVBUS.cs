using QLTPKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPKS.BUS
{
    class HOADONDVBUS
    {
        connect dbconnect = new connect();

        public DataTable getdata()
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  MAHDDV as [Mã Hóa Đơn DV], SOPT as [Số Phiếu Thuê],SOTIENDV as[Số Tiền DV] from HOADONDV");
            dbconnect.Closeconnect();
            return table;
        }
        public void InsertHOADONDV(HOADONDV hoadondv)
        {
            string insert = "insert into HOADONDV(MAHDDV,SOPT,SOTIENDV) values(";
            insert += "N'" + hoadondv.MAHDDV1 + "',";

            insert += "N'" + hoadondv.SOPT1 + "',";
            insert += "N'" + hoadondv.SOTIENDV1 + "')";
            dbconnect.query1(insert);

        }
        public void UpdateHOADONDV(HOADONDV hoadondv, string ma)
        {
            string update = "update HOADONDV set ";

            update += "SOPT='" + hoadondv.SOPT1 + "',";
            update += "SOTIENDV='" + hoadondv.SOTIENDV1 + "' ";
            update += "where MAHDDV='" + ma + "'";
            dbconnect.query1(update);
        }
        public void DeleteHOADONDV(string ma)
        {
            string delete = "delete from HOADONDV where MAHDDV='" + ma + "'";
            dbconnect.query1(delete);
        }
    }
}
