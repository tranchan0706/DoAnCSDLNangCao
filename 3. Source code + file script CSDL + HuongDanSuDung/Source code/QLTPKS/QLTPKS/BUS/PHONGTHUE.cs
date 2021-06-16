using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPKS.BUS
{
    class PHONGTHUE
    {
        string SOPT, MAPHONG;

        public string MAPHONG1
        {
            get { return MAPHONG; }
            set { MAPHONG = value; }
        }

        public string SOPT1
        {
            get { return SOPT; }
            set { SOPT = value; }
        }
        DateTime NGAYDEN, NGAYDI;

        public DateTime NGAYDI1
        {
            get { return NGAYDI; }
            set { NGAYDI = value; }
        }

        public DateTime NGAYDEN1
        {
            get { return NGAYDEN; }
            set { NGAYDEN = value; }
        }
    }
}
