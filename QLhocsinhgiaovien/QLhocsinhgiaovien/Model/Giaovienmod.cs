using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QLhocsinhgiaovien.Model
{
    class Giaovienmod
    {
        // khai bao cac bien ham va thuoc tinh
        protected string Magiaovien { get; set; }
        protected string Hoten { get; set; }
        protected DateTime Ngaysinh { get; set; }
        protected string Gioitinh { get; set; }
        protected string Quequan { get; set; }
        protected string MaMon { get; set; }
        protected string Hocham { get; set; }
        protected string Sdt { get; set; }
        protected string MaCV { get; set; }
        protected string Tinhtrang { get; set; }
        public Giaovienmod(string _Magiaovien)
        {
            Magiaovien = _Magiaovien;         
        }
        public Giaovienmod() { } // ham khong doi so     
        public Giaovienmod(string _Magiaovien, string _Hoten, DateTime _Ngaysinh, string _Gioitinh, string _Quequan, string _MaMon, string _Hocham, string _Sdt, string _MaCV, string _Tinhtrang)
        {
            Magiaovien = _Magiaovien;
            Hoten = _Hoten;
            Ngaysinh = _Ngaysinh;
            Gioitinh = _Gioitinh;
            Quequan = _Quequan;
            MaMon = _MaMon;
            Hocham = _Hocham;
            Sdt = _Sdt;
            MaCV = _MaCV;
            Tinhtrang = _Tinhtrang;
        }
        public static DataSet filldatasetGiaovien()
        {
            // goi thu tuc dataset 
            return Model.connection.FillDataSet("spgetGiaovien", CommandType.StoredProcedure);
        }      
        public static DataSet filldatasetChucVu()
        {
            // goi thu tuc dataset 
            return Model.connection.FillDataSet("spgetChucvu", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSet_spgetMaMon()
        {
            DataSet ds = new DataSet();
            // goi thu tuc dataset 
            try
            {
                ds = Model.connection.FillDataSet("spgetMaMon", CommandType.StoredProcedure);
            }
            catch { }

            return ds;
        }
        public static DataSet FillDataSet_spgetMaGV()
        {
            DataSet ds = new DataSet();
            // goi thu tuc dataset 
            try
            {
                ds = Model.connection.FillDataSet("spgetGiaovien", CommandType.StoredProcedure);
            }
            catch { }

            return ds;
        }
        public static DataSet FillDataSet_spgetMaCV()
        {
            DataSet ds = new DataSet();
            // goi thu tuc dataset 
            try
            {
                ds = Model.connection.FillDataSet("spgetMaCV", CommandType.StoredProcedure);
            }
            catch { }

            return ds;
        }
        public int Insearchgiaovien()
        {
            int i = 0;
            string[] paras = new string[] { "@Magiaovien", "@Hoten", "@Ngaysinh", "@Gioitinh", "@Quequan", "@MaMon", "@Hocham", "@Sdt", "@MaCV", "@Tinhtrang" };
            object[] values = new object[] { Magiaovien, Hoten,Ngaysinh, Gioitinh,Quequan,MaMon, Hocham,Sdt, MaCV,Tinhtrang };
            i = Model.connection.Excute_Sql("spInsertGiaovien", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int Updategiaovien()
        {
            int i = 0;
            string[] paras = new string[] { "@Magiaovien", "@Hoten", "@Ngaysinh", "@Gioitinh", "@Quequan", "@MaMon", "@Hocham", "@Sdt", "@MaCV", "@Tinhtrang" };
            object[] values = new object[] { Magiaovien, Hoten, Ngaysinh, Gioitinh, Quequan, MaMon, Hocham, Sdt, MaCV, Tinhtrang };
            i = Model.connection.Excute_Sql("spUpdateGiaovien", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int Deletegiaovien()
        {
            int i = 0;
            string[] paras = new string[1] { "@Magiaovien" };
            object[] values = new object[1] { Magiaovien };
            i = Model.connection.Excute_Sql("spDeleteGiaovien", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int timkiemgiaovien(string Hoten)
        {
            int i = 0;
            string[] paras = new string[1] { "@Hoten" };
            object[] values = new object[1] { Hoten };
            i = Model.connection.Excute_Sql("timkiemgv", CommandType.StoredProcedure, paras, values);
            return i;
        }
      

    }
}
