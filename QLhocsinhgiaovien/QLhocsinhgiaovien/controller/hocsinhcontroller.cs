using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLhocsinhgiaovien.controller
{
    class hocsinhcontroller
    {
        public static int Insearchhocsinh(string _MaHS, string _Hoten, DateTime _Ngaysinh, string _Gioitinh, string _Diachi, string _Malop)
        {
            try
            {
                Model.Hocsinhmod _hocsinh = new Model.Hocsinhmod(_MaHS, _Hoten, _Ngaysinh, _Gioitinh, _Diachi, _Malop);
                return _hocsinh.Insearchhocsinh();
            }
            catch
            {
                return 0;
            }
        }
        public static int Updatehocsinh(string _MaHS, string _Hoten, DateTime _Ngaysinh, string _Gioitinh, string _Diachi, string _Malop)
        {
            try
            {
                Model.Hocsinhmod _hocsinh = new Model.Hocsinhmod(_MaHS, _Hoten, _Ngaysinh, _Gioitinh, _Diachi, _Malop);
                return _hocsinh.Updatehocsinh();
            }
            catch
            {
                return 0;
            }
        }
        public static int Deletehocsinh(string _MaHS)
        {
            try
            {

                Model.Hocsinhmod _hocsinh = new Model.Hocsinhmod(_MaHS);
                return _hocsinh.Deletehocsinh();
            }
            catch
            {
                return 0;
            }
        }
    }
}
