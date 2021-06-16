using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPKS.BUS
{
    class PHIEUTHUE
    {
        string SOPT, MAKH;

        public string MAKH1
        {
            get { return MAKH; }
            set { MAKH = value; }
        }

        public string SOPT1
        {
            get { return SOPT; }
            set { SOPT = value; }
        }
        DateTime NGAYTHUE;

        public DateTime NGAYTHUE1
        {
            get { return NGAYTHUE; }
            set { NGAYTHUE = value; }
        }
        int TIENCOC;

        public int TIENCOC1
        {
            get { return TIENCOC; }
            set { TIENCOC = value; }
        }
    }
}
