using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLhocsinhgiaovien.controller
{
    class chucvucontroller
    {
        public static int Insearchchucvu(string _MaCV, string _TenCV)
        {
            try
            {
                Model.chucvuMod _gv = new Model.chucvuMod(_MaCV, _TenCV);
                return _gv.Insearchchucvu();
            }
            catch
            {
                return 0;
            }
        }
        public static int Updatechucvu(string _MaCV, string _TenCV)
        {
            try
            {
                Model.chucvuMod _gv = new Model.chucvuMod(_MaCV, _TenCV);
                return _gv.Updatechucvu();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteChucvu(string _MaCV)
        {
            try
            {
                Model.chucvuMod _gv = new Model.chucvuMod(_MaCV);
                return _gv.Deletechucvu();
            }
            catch
            {
                return 0;
            }
        }

    }
}
