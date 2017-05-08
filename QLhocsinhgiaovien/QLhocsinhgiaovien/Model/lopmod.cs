using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QLhocsinhgiaovien.Model
{
    class lopmod
    {
        public static DataSet filldatasetlop()
        {
            // goi thu tuc dataset 
                return Model.connection.FillDataSet("spgetdanhsachlop", CommandType.StoredProcedure);
         //   return Model.connection.FillDataTable("spgetdanhsachlop");
        }
        // khai bao cac bien ham va thuoc tinh
        protected string Malop { get; set; }
        protected string Tenlop { get; set; }
        protected string Magiaovien { get; set; }
        protected int SoLuong { get; set; }
        public lopmod(string _Malop)
        {
            Malop = _Malop;
        }
        public lopmod() { } // ham khong doi so     
        public lopmod(string _Malop, string _Tenlop,string _Magiaovien,int _SoLuong)
        {
            Malop = _Malop;
            Tenlop = _Tenlop;
            Magiaovien = _Magiaovien;
            SoLuong = _SoLuong;
        }
        public int Insearchlop()
        {
            int i = 0;
            string[] paras = new string[] { "@Malop", "@Tenlop","@Magiaovien","@SoLuong" };
            object[] values = new object[] { Malop, Tenlop,Magiaovien,SoLuong };
            i = Model.connection.Excute_Sql("spInsertLop", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int Updatelop()
        {
            int i = 0;
            string[] paras = new string[] { "@Malop", "@Tenlop", "@Magiaovien", "@SoLuong" };
            object[] values = new object[] { Malop, Tenlop, Magiaovien, SoLuong };
            i = Model.connection.Excute_Sql("spUpdateLop", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int Deletelop()
        {
            int i = 0;
            string[] paras = new string[1] { "@Malop" };
            object[] values = new object[1] { Malop };
            i = Model.connection.Excute_Sql("spDeleteLop", CommandType.StoredProcedure, paras, values);
            return i;
        }

    }
}
