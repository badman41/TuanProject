using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
  public  class KhoModel
    {
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public string ViTri { get; set; }
        public string MaNV { get; set; }

        public KhoModel(string ma,string ten,string vt,string manv)
        {
            MaKho = ma;
            TenKho = ten;
            ViTri = vt;
            MaNV = manv;
        }
        public KhoModel() { }
    }
}
