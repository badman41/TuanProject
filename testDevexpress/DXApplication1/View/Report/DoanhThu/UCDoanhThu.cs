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

namespace DXApplication1.View._UC
{
    public partial class UCDoanhThu : DevExpress.XtraEditors.XtraUserControl
    {
        
        BaoCaoController nvC = new BaoCaoController();
        public UCDoanhThu()
        {
            InitializeComponent();
        }
        public void InDSDaBan(string date1,string date2 )
        {
            grC.DataSource = nvC.LayDSHangDaBan(date1, date2);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void tabNhanVien_Click(object sender, EventArgs e)
        {

        }
        public void loadData()
        {
            
            grC.DataSource = nvC.LayDSHangDaBan(DateTime.Now.ToShortDateString(), DateTime.Now.ToShortDateString());
            

        }
        public void DoanhThu_Thang(string date1, string date2)
        {

            DataTable dt = nvC.LayBDDoanhThu_Thang(date1, date2);

            grV.Columns.Clear();
            grC.DataSource = dt;



        }
        public void DoanhThu_Nam(string Nam)
        {
            DataTable dt = nvC.LayBDDoanhThu_Nam(Nam);
            grV.Columns.Clear();
            grC.DataSource = dt;
            
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

                    DoanhThu_Thang(nam + "-" + thang + "-" + "1", DateTime.Now.ToShortDateString());


                }


            }

        }
    }
}
