using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXApplication1.Controller;
using Model;
using DXApplication1.View._Form;
using System.Data.SqlClient;
using DevExpress.XtraCharts;

namespace DXApplication1.View._UC
{
    public partial class chartDoanhThu : DevExpress.XtraEditors.XtraUserControl
    {
        
        BaoCaoController nvC = new BaoCaoController();
        Series sr1;
        Series sr2;
        public chartDoanhThu()
        {
            InitializeComponent();
        }
       

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void tabNhanVien_Click(object sender, EventArgs e)
        {

        }
        public void DoanhThu_Thang(string date1, string date2)
        {
            
            DataTable dt = nvC.LayBDDoanhThu_Thang(date1,date2);
           
            chart1.DataSource = dt;
             sr1 = new Series("Doanh thu trong ngày (VNĐ)", ViewType.Line);
      
            
            foreach(DataRow dr in dt.Rows)
            {
             
                sr1.Points.Add(new SeriesPoint(dr[0].ToString(), dr[1].ToString()));
              
            }
            chart1.Series.Clear();
            chart1.Series.Add(sr1);
            pnlChart.Controls.Add(chart1);

            

        }
        public void DoanhThu_Nam(string Nam)
        {
            DataTable dt = nvC.LayBDDoanhThu_Nam(Nam);

            chart1.DataSource = dt;
             sr2 = new Series("Doanh thu trong tháng (VNĐ)", ViewType.Line);
          

            foreach (DataRow dr in dt.Rows)
            {
             
                sr2.Points.Add(new SeriesPoint(dr[0].ToString(), dr[1].ToString()));
              
            }
            chart1.Series.Clear();
            chart1.Series.Add(sr2);
        
            pnlChart.Controls.Add(chart1);
        }

        private void grC_Click(object sender, EventArgs e)
        {
           
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void grV_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void grV_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           
        }

        private void grC_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void grV_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
          
        }

        private void grV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
         
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbXemTheo.SelectedItem == "Tháng này")
            {              
                cmbNam.Enabled = false;
                cmbThang.Enabled = false;           
            }
            else if (cmbXemTheo.SelectedItem == "Năm nay")
            {
                cmbThang.Enabled = false;
                cmbNam.Enabled = false;
            }
            else if (cmbXemTheo.SelectedItem == "Tháng")
            {
                cmbNam.Enabled = true;
                cmbThang.Enabled = true;
            }
            else if (cmbXemTheo.SelectedItem == "Năm")
            {
                cmbNam.Enabled = true;
                cmbThang.Enabled = false;
            }

        }

        private void btnXem_Click(object sender, EventArgs e)

        {
            if (cmbXemTheo.Text == "")
            {

                XtraMessageBox.Show("Chọn kiểu xem đã!");
            }
           
            else
            {
                string ngayBatDau = "";
                string ngayKetThuc = "";
                if (cmbXemTheo.SelectedItem == "Năm")
                {
                    if (cmbNam.Text == "")
                    {
                        MessageBox.Show("Chưa chọn năm");
                    }
                    else
                    {
                        int nam;
                        int.TryParse(cmbNam.SelectedItem.ToString(), out nam);
                        DoanhThu_Nam(nam.ToString());
                    }                 
                }
                else if (cmbXemTheo.SelectedItem == "Tháng")
                {
                    if (cmbNam.Text == "")
                    {
                        MessageBox.Show("Chưa chọn năm");
                    }
                    else if (cmbThang.Text == "")
                    {
                        MessageBox.Show("Chưa chọn tháng");
                    }               
                    else
                    {
                        int thang;
                        int.TryParse(cmbThang.SelectedItem.ToString(), out thang);
                        if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
                        {
                            ngayBatDau = cmbNam.SelectedItem + "/" + cmbThang.SelectedItem + "/" + "1";
                            ngayKetThuc = cmbNam.SelectedItem + "/" + cmbThang.SelectedItem + "/" + "30";
                        }
                        else
                             if (thang == 2)
                        {
                            ngayBatDau = cmbNam.SelectedItem + "/" + "2" + "/" + "1";
                            ngayKetThuc = cmbNam.SelectedItem + "/" + "2" + "/" + "28";
                        }

                        else
                        {
                            ngayBatDau = cmbNam.SelectedItem + "/" + cmbThang.SelectedItem + "/" + "1";
                            ngayKetThuc = cmbNam.SelectedItem + "/" + cmbThang.SelectedItem + "/" + "31";
                        }


                        DoanhThu_Thang(ngayBatDau, ngayKetThuc);
                    }


                }

                else if (cmbXemTheo.SelectedItem == "Năm nay")
                {
                    string nam = DateTime.Now.Year.ToString();
                    DoanhThu_Nam(nam);


                }
                else if (cmbXemTheo.SelectedItem == "Tháng này")
                {             
                    string thang = DateTime.Now.Month.ToString();
                    string nam = DateTime.Now.Year.ToString();

                    DoanhThu_Thang(nam+"-"+ thang+"-"+"1",DateTime.Now.ToShortDateString());


                }


            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chartHangBan_Load(object sender, EventArgs e)
        {
        
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
