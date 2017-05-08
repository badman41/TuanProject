using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QLhocsinhgiaovien.Model
{
    class Account
    {
        public static bool CheckAccount(String Username, String Pass)
        {
            DataTable dt = connection.FillDataTable("select * from DangNhap where IDdangnhap = '" + Username + "' and DangNhap.Matkhau = '" + Pass + "'");
            if (dt.Rows.Count == 0)
                return false;
            else
                return true;
        }
        public static void UpdatePass(String Username, String Pass)
        {
            connection.FillDataTable("update DangNhap set Matkhau='"+Pass+"' where IDdangnhap='"+Username+"'"); 
        }
    }
}
