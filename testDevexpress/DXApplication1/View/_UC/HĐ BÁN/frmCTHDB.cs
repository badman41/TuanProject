using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Model;
using COMExcel = Microsoft.Office.Interop.Excel;
using DXApplication1.Controller;

namespace DXApplication1.View._UC.Phiếu_nhập
{
    public partial class frmCTHDB : DevExpress.XtraEditors.XtraForm
    {
        public frmCTHDB()
        {
            InitializeComponent();
        }
        private string mahh;
        ChiTietHoaDonBanController ctc = new ChiTietHoaDonBanController();
        public void loadData(HOADONBAN HDB,string ten )
        {
            lblHDB.Text = HDB.MaHDB;
            cmbNhanVien.Text = ten;
            dtpNgayBan.Text = HDB.NgayBan;
            lblTongTienNhap.Text = HDB.TongTien.ToString();
            grC.DataSource = ctc.XemCTHDB(HDB.MaHDB);
        }
        public void loadGR()
        {
           
            grC.DataSource = ctc.XemCTHDB(lblHDB.Text);
        }
        public void loadTongTien()
        {
            HoaDonBanController HDBc = new HoaDonBanController();
            lblTongTienNhap.Text=HDBc.getDataById(lblHDB.Text.Trim(),0).Rows[0][4].ToString();
        }
        private void btnSua_Click(object sender, EventArgs e)

        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn sửa?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DataRow dr;
                
                for (int i = 0; i <= grV.RowCount - 1; i++)
                {
                    dr = grV.GetDataRow(i);
                    if(dr.RowState==DataRowState.Modified)
                    {
                        try
                        {
                            CHITIETHOADONBAN ct1 = new CHITIETHOADONBAN();
                            ct1.MaHDB = lblHDB.Text.Trim();
                            ct1.MaHH = dr["MaHH"].ToString().Trim();
                            ct1.SoLuong = int.Parse(dr["SoLuong"].ToString().Trim());
                            ct1.DonGia = dr["DonGia"].ToString().Trim();

                            ctc.Update(ct1);
                         

                        }
                        catch (Exception exx)
                        {
                            MessageBox.Show(exx.ToString());
                        }
                    }
                    




                }
                loadGR();
                loadTongTien();
                MessageBox.Show("Sửa thành công");
            }
            

        }

        private void btnXoa_Click(object sender, EventArgs e)

        {

            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa hàng hóa "+mahh+" ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    //ChiTietHoaDonBanBanModel ct2 = new ChiTietPhieuBanModel();
                
                    ctc.XoaCTHDB(lblHDB.Text.Trim(),mahh);
                    XtraMessageBox.Show("Xóa thành công");
                    loadGR();
                    loadTongTien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }


        }

        private void grV_Click(object sender, EventArgs e)
        {
              mahh = grV.GetFocusedRowCellValue(MaHH).ToString().Trim();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemCTHDB frmThem = new frmThemCTHDB();
            frmThem.layMaHDB(lblHDB.Text.Trim());
            frmThem.ShowDialog();
            loadGR();
            loadTongTien();

        }

        private void button2_Click(object sender, EventArgs e)

        {

            //khởi tạo excel
            COMExcel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Khởi tạo workbook
            COMExcel._Workbook workBook = app.Workbooks.Add(Type.Missing);
            //Khoiwr tao worksheet
            COMExcel._Worksheet workSheet = null;
            workSheet = workBook.Sheets["Sheet1"];
            workSheet = workBook.ActiveSheet;
            //Do du lieu vao sheet
            workSheet.Cells[1, 1] = "CHI TIẾT HÓA ĐƠN BÁN";
            workSheet.Cells[3, 2] = "HDB : " + lblHDB.Text;
            workSheet.Cells[4, 2] = "Nhân viên bán : " + cmbNhanVien.Text;
            workSheet.Cells[5, 2] = "Ngày bán : " + dtpNgayBan.Value.ToShortDateString();
            workSheet.Cells[7, 1] = "MaHH";
            workSheet.Cells[7, 2] = "Tên HH";
            workSheet.Cells[7, 3] = "Số lượng";
            workSheet.Cells[7, 4] = "Đơn giá";
            workSheet.Cells[7, 5] = "Thành tiền";

            for (int i = 0; i < grV.RowCount; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    workSheet.Cells[i + 8, j + 1] = grV.GetDataRow(i)[j].ToString();
                }
            }
            workSheet.Cells[ grV.RowCount  - 1 + 9, 4] = "Tổng tiền: " + lblTongTienNhap.Text + " VNĐ";
            string[] str = dtpNgayBan.Value.ToShortDateString().Split('/');
            workSheet.Cells[ grV.RowCount  - 1 + 11, 4] = "Ngày " + str[0] + ", tháng " + str[1] + ", năm" + str[2];
            workSheet.Cells[ grV.RowCount  - 1 + 12, 4] = "Nhân viên ( Chữ ký )";
            //Định dạng trang
            workSheet.PageSetup.Orientation = COMExcel.XlPageOrientation.xlPortrait;
            workSheet.PageSetup.PaperSize = COMExcel.XlPaperSize.xlPaperA4;
            workSheet.PageSetup.LeftMargin = 0;
            workSheet.PageSetup.RightMargin = 0;
            workSheet.PageSetup.TopMargin = 0;
            workSheet.PageSetup.BottomMargin = 0;

            //Din dang cot
            workSheet.Range["A1"].ColumnWidth = 14;
            workSheet.Range["B1"].ColumnWidth = 34;
            workSheet.Range["C1"].ColumnWidth = 15;
            workSheet.Range["D1"].ColumnWidth = 15;
            workSheet.Range["E1"].ColumnWidth = 15;
            //dinh dang font
            workSheet.Range["A1", "E100"].Font.Name = "Times New Roman";
            workSheet.Range["A1", "E1"].Font.Size = 18;
            workSheet.Range["A2", "E100"].Font.Size = 14;
            workSheet.Range["A1", "E1"].MergeCells = true;
            workSheet.Range["A1", "E1"].Font.Color = Color.Red;
            workSheet.Range["A1", "E1"].Font.Bold = true;
            workSheet.Range["A7", "E7"].Font.Bold = true;
            workSheet.Range["C" + ( grV.RowCount   + 11), "E" + ( grV.RowCount   + 12)].Font.Italic = true;
            //workSheet.Range[ grV.RowCount  - 1 + 12, 4].Font.Italic = true;
            //ke bang
            workSheet.Range["A7", "E" + (( grV.RowCount ) + 7)].Borders.LineStyle = 1;
            //dinh dang center
            workSheet.Range["A1", "E1"].HorizontalAlignment = 3;
            workSheet.Range["A7", "E7"].HorizontalAlignment = 3;

            workSheet.Range["A8", "A" + ( grV.RowCount ) + 6].HorizontalAlignment = 3;

            workSheet.Range["C8", "C" + ( grV.RowCount ) + 6].HorizontalAlignment = 3;
            workSheet.Range["D8", "D" + ( grV.RowCount  ) + 6].HorizontalAlignment = 3;
            workSheet.Range["E8", "E" + ( grV.RowCount  ) + 6].HorizontalAlignment = 3;
            app.Visible = true;
        }
    }
}