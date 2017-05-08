using QLhocsinhgiaovien.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLhocsinhgiaovien.controller
{
    class PhancongdayController
    {
        public  List<Tiet> lstLichDay = new List<Tiet>();
        public List<Tiet2> lstLichDay2 = new List<Tiet2>();
        public PhancongdayController()
        {
            for(int i = 1; i <= 12; i++)
            {
                Tiet t = new Tiet() {Tiết=i.ToString(), T2 = "_", T3 = "_", T4 = "_", T5 = "_", T6 = "_", T7 = "_" };

                Tiet2 t2 = new Tiet2() { Tiết = i.ToString(), T2 = false, T3 = false, T4 = false, T5 = false, T6 = false, T7 = false };
                lstLichDay.Add(t);
                lstLichDay2.Add(t2);
            }
        }
        public DataSet LayDSlichDay(string maGV)
        {
            
            string[] paras = new string[1] { "@MaGv" };
            object[] values = new object[1] { maGV };
            DataSet ds= Model.connection.FillDataSet("xem_lichday_byGiaoVienID", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        public DataSet LayDSlichDay2(string maGV,string maLop)
        {

            string[] paras = new string[2] { "@MaGv" ,"@MaLop"};
            object[] values = new object[2] { maGV,maLop };
            DataSet ds = Model.connection.FillDataSet("xem_lichday", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        public int ThemLichday(Phancongdaymod pc)
        {

            string[] paras = new string[3] { "@MaGV", "@MaLop","@lichday" };
            object[] values = new object[3] { pc.Magiaovien.ToString(), pc.Malop.ToString(), pc.Lichday.ToString() };
            int ds = Model.connection.Excute_Sql("them_lichday", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        public DataSet XoalichDay(string maGV, string lichDay)
        {

            string[] paras = new string[2] { "@MaGv", "@lichday" };
            object[] values = new object[2] { maGV, lichDay };
            DataSet ds = Model.connection.FillDataSet("xoa_lichday", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        public int SuaLichday(Phancongdaymod pc)
        {

            string[] paras = new string[3] { "@MaGV", "@MaLop", "@lichday" };
            object[] values = new object[3] { pc.Magiaovien.ToString(), pc.Malop.ToString(), pc.Lichday.ToString() };
            int ds = Model.connection.Excute_Sql("sua_lichday", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
