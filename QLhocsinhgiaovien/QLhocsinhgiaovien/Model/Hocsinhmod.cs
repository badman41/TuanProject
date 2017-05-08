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
    class Hocsinhmod
    {
        // khai bao cac bien ham va thuoc tinh
        protected string MaHS { get; set; }
        protected string Hoten { get; set; }
        protected DateTime Ngaysinh { get; set; }
        protected string Gioitinh { get; set; }
        protected string Diachi { get; set; }
        protected string Malop { get; set; }
        public Hocsinhmod(string _MaHS)
        {
            MaHS = _MaHS;
        }
        public Hocsinhmod() { } // ham khong doi so     
        public Hocsinhmod(string _MaHS, string _Hoten, DateTime _Ngaysinh, string _Gioitinh, string _Diachi, string _Malop)
        {
            MaHS = _MaHS;
            Hoten = _Hoten;
            Ngaysinh = _Ngaysinh;
            Gioitinh = _Gioitinh;
            Diachi = _Diachi;
            Malop = _Malop;
        }
        public static DataSet filldatasethocsinh()
        {
            // goi thu tuc dataset 
            return Model.connection.FillDataSet("spgetHocsinh", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSet_spgetMaHS()
        {
            DataSet ds = new DataSet();
            // goi thu tuc dataset 
            try
            {
                ds = Model.connection.FillDataSet("spgetHocsinh", CommandType.StoredProcedure);
            }
            catch { }

            return ds;
        }
        public static DataSet FillDataSet_spgetMalop()
        {
            DataSet ds = new DataSet();
            // goi thu tuc dataset 
            try
            {
                ds = Model.connection.FillDataSet("spgetMalop", CommandType.StoredProcedure);
            }
            catch { }

            return ds;
        }
        public int Insearchhocsinh()
        {
            int i = 0;
            string[] paras = new string[6] { "@MaHS", "@Hoten", "@Ngaysinh", "@Gioitinh", "@Diachi", "@Malop"};
            object[] values = new object[6] { MaHS, Hoten, Ngaysinh, Gioitinh, Diachi, Malop };
            i = Model.connection.Excute_Sql("spInserthocsinh", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int Updatehocsinh()
        {
            int i = 0;
            string[] paras = new string[6] { "@MaHS", "@Hoten", "@Ngaysinh", "@Gioitinh", "@Diachi", "@Malop" };
            object[] values = new object[6] {MaHS, Hoten, Ngaysinh, Gioitinh, Diachi, Malop };
            i = Model.connection.Excute_Sql("spUpdateHOCSINH", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int Deletehocsinh()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaHS" };
            object[] values = new object[1] { MaHS };
            i = Model.connection.Excute_Sql("spDeleteHOCSINH", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetspgetHocsinh()
        {
            // goi thu tuc dataset 
            return Model.connection.FillDataSet("spgetHocsinh", CommandType.StoredProcedure);
        }
    }
}
