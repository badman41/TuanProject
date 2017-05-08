using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QLhocsinhgiaovien.controller
{
    class Diemcontroller
    {
        public static DataSet FillDataSetgetDanhSach_spgettbchungByMaHS(string _MaHS)
        {
            try 
            {
                Model.Diemmod _Diem = new Model.Diemmod(_MaHS);
                return _Diem.FillDataSetgetDanhSach_spgettbchungByMaHS();
            }
            catch
            {
                return null;
            }
        }
    }
  
}
