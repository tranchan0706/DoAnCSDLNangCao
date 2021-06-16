using QLTPKS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPKS.BUS
{
    class SUDUNGDVBUS
    {
        connect dbconnect = new connect();

        public DataTable getdata(string mahddv)
        {
            dbconnect.Openconnect();
            DataTable table = new DataTable();
            table = dbconnect.returnquery("select  MAHDDV as [Mã Hóa Đơn DV],MADV as [Mã Dịch Vụ],SOLUONG as [Số lượng] from SUDUNGDV where MAHDDV='" + mahddv + "'");
            dbconnect.Closeconnect();
            return table;
        }
        public void InsertSUDUNGDV(SUDUNGDV sudungdv)
        {
            string insert = "insert into SUDUNGDV(MAHDDV, MADV,GIADV,SOLUONG) values(";

            insert += "N'" + sudungdv.MAHDDV1 + "',";
            insert += "N'" + sudungdv.MADV1 + "',";
            insert += "N'" + sudungdv.GIADV1 + "',";
            insert += "N'" + sudungdv.SOLUONG1 + "')";
            dbconnect.query1(insert);

        }
        public void UpdateSUDUNGDV(SUDUNGDV sudungdv, string mahd, string madv)
        {
            string update = "update SUDUNGDV set ";

            update += "GIADV='" + sudungdv.GIADV1 + "', ";
            update += "SOLUONG='" + sudungdv.SOLUONG1 + "' ";
            update += "where MAHDDV='" + mahd + "'and MADV='" + madv + "'";
            dbconnect.query1(update);
        }
        public void DeleteSUDUNGDV(string mahd, string madv)
        {
            string delete = "delete from SUDUNGDV where MAHDDV='" + mahd + "'and MADV='" + madv + "'";
            dbconnect.query1(delete);
        }
    }
}
