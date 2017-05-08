using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLhocsinhgiaovien.controller
{
    class giaoviencontroller
    {
        public static int Insearchgiaovien(string _Magiaovien, string _Hoten, DateTime _Ngaysinh, string _Gioitinh, string _Quequan, string _MaMon, string _Hocham, string _Sdt, string _MaCV, string _Tinhtrang)
        {
            try
            {
                Model.Giaovienmod _gv = new Model.Giaovienmod(_Magiaovien, _Hoten, _Ngaysinh, _Gioitinh, _Quequan, _MaMon, _Hocham, _Sdt, _MaCV, _Tinhtrang);
                return _gv.Insearchgiaovien();
            }
            catch
            {
                return 0;
            }
        }
        public static int Updategiaovien(string _Magiaovien, string _Hoten, DateTime _Ngaysinh, string _Gioitinh, string _Quequan, string _MaMon, string _Hocham, string _Sdt, string _MaCV, string _Tinhtrang)
        {
            try
            {
                Model.Giaovienmod _gv = new Model.Giaovienmod(_Magiaovien, _Hoten, _Ngaysinh, _Gioitinh, _Quequan, _MaMon, _Hocham, _Sdt, _MaCV, _Tinhtrang);
                return _gv.Updategiaovien();
            }
            catch
            {
                return 0;
            }
        }
        public static int Deletegiaovien(string _Magiaovien)
        {
            try
            {
                Model.Giaovienmod _gv = new Model.Giaovienmod(_Magiaovien);
                return _gv.Deletegiaovien();
            }
            catch
            {
                return 0;
            }
        }
        public static int timkiemgiaovien(string _keyword)
        {
            try
            {
                Model.Giaovienmod _gv = new Model.Giaovienmod(_keyword);
                return _gv.timkiemgiaovien(_keyword);
            }
            catch
            {
                return 0;
            }
        }
        
        
    }
}
