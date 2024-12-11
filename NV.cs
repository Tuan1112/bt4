using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt4
{
    public class NV
    {
        public int MSNV { get; set; }
        public string TenNV { get; set; }
        public double LuongCB { get; set; }

        public NV() { }

        // Constructor với 3 tham số
        public NV(int msnv, string tenNV, double luongCB)
        {
            MSNV = msnv;
            TenNV = tenNV;
            LuongCB = luongCB;
        }
    }
}
