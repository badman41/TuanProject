using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLhocsinhgiaovien.Model
{
    class chucvuMod
    {
        // khai bao cac bien ham va thuoc tinh
        protected string MaCV { get; set; }
        protected string TenCV { get; set; }
        public chucvuMod(string _MaCV)
        {
            MaCV = _MaCV;
        }
        public chucvuMod() { } // ham khong doi so     
        public chucvuMod(string _MaCV, string _TenCV)
        {
            MaCV = _MaCV;
            TenCV = _TenCV;          
        }
        public int Insearchchucvu()
        {
            int i = 0;
            string[] paras = new string[] { "@MaCV", "@TenCV" };
            object[] values = new object[] { MaCV, TenCV };
            i = Model.connection.Excute_Sql("spInsertChucvu", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int Updatechucvu()
        {
            int i = 0;
            string[] paras = new string[] { "@MaCV", "@TenCV" };
            object[] values = new object[] { MaCV, TenCV };
            i = Model.connection.Excute_Sql("spUpdateChucvu", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int Deletechucvu()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaCV" };
            object[] values = new object[1] { MaCV };
            i = Model.connection.Excute_Sql("spDeleteChucVu", CommandType.StoredProcedure, paras, values);
            return i;
        }
    }
   
}
