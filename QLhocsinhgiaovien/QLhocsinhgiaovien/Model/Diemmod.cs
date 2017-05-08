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
    class Diemmod
    {
        protected string MaHS { get; set; }
        protected string TenThucDon { get; set; }
        protected decimal DonGiaTon { get; set; }
        protected int SoLuong { get; set; }
        protected DateTime ThoiGian { get; set; }
        protected decimal ThanhTien { get; set; }
        public Diemmod(string _MaHS)
        {
            MaHS = _MaHS;
        }

        public Diemmod() { } // ham khong doi so     
        public Diemmod(string _MaHS, string _TenThucDon, decimal _DonGiaTon, int _SoLuong, DateTime _ThoiGian, decimal _ThanhTien)
        {
            this.MaHS = _MaHS;
            this.TenThucDon = _TenThucDon;
            this.DonGiaTon = _DonGiaTon;
            this.SoLuong = _SoLuong;
            this.ThoiGian = _ThoiGian;
            this.ThanhTien = _ThanhTien;

        }
        public DataSet FillDataSetgetDanhSach_spgettbchungByMaHS()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@MaHS" };
            object[] values = new object[1] { MaHS };
            ds = Model.connection.FillDataSet("spgettbchungByMaHS", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
