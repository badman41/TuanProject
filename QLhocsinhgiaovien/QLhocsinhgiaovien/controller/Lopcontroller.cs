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
    class Lopcontroller
    {
        public static int Insearchlop(string _Malop, string _Tenlop, string _Magiaovien, int _SoLuong)
        {
            try
            {
                Model.lopmod _gv = new Model.lopmod(_Malop, _Tenlop, _Magiaovien, _SoLuong);
                return _gv.Insearchlop();
            }
            catch
            {
                return 0;
            }
        }
        public static int Updatelop(string _Malop, string _Tenlop, string _Magiaovien, int _SoLuong)
        {
            try
            {
                Model.lopmod _gv = new Model.lopmod(_Malop, _Tenlop, _Magiaovien, _SoLuong);
                return _gv.Updatelop();
            }
            catch
            {
                return 0;
            }
        }
        public static int Deletelop(string _Malop)
        {
            try
            {
                Model.lopmod _gv = new Model.lopmod(_Malop);
                return _gv.Deletelop();
            }
            catch
            {
                return 0;
            }
        }
    }
}
