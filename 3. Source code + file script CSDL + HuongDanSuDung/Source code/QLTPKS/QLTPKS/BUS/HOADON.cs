using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPKS.BUS
{
    class HOADON
    {
        string SOHD, SOPT;

        public string SOPT1
        {
            get { return SOPT; }
            set { SOPT = value; }
        }

        public string SOHD1
        {
            get { return SOHD; }
            set { SOHD = value; }
        }
        DateTime NGAYTT;

        public DateTime NGAYTT1
        {
            get { return NGAYTT; }
            set { NGAYTT = value; }
        }
        int SOTIEN;

        public int SOTIEN1
        {
            get { return SOTIEN; }
            set { SOTIEN = value; }
        }
    }
}
