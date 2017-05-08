using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLhocsinhgiaovien.views
{
    public partial class ThongkesoluongHS : UserControl
    {
        public ThongkesoluongHS()
        {
            InitializeComponent();
        }
        public static ThongkesoluongHS ucttk = new ThongkesoluongHS();
        public void hienthidanhsachhocsinh()
        {
            // tro toi data     
            dgvLop.DataSource = Model.lopmod.filldatasetlop().Tables[0];
            dgvLop.BorderStyle = BorderStyle.Fixed3D;
            dgvLop.RowHeadersVisible = false;

        }
        public void loadchart()
        {       
            DataTable tb = new DataTable();
          tb = Model.lopmod.filldatasetlop().Tables[0];
          //  MessageBox.Show(tb.Columns[0].ColumnName + "ffff" + tb.Columns[1].ColumnName);
           //   chart1.Series["Soluong"].;
            chart1.DataSource = Model.lopmod.filldatasetlop();
            chart1.Series["Soluong"].XValueMember = tb.Columns[1].ColumnName;
            chart1.Series["Soluong"].YValueMembers = tb.Columns[3].ColumnName;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên Lớp";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng HS";
    
            // chart1.Series.Add("ex");
      //for (int i = 0; i < tb.Rows.Count; i++)
      //  {
      //       chart1.Series["Soluong"].Points.AddXY(tb.Rows[i]["tenlop"], tb.Rows[i]["soluong"]);
      //        // chart1.Series["ex"].points.addxy(tb.Rows[i]["malop"], tb.Rows[i]["soluong"]);
      //      }      
      }
        private void ThongkesoluongHS_Load(object sender, EventArgs e)
        {
            hienthidanhsachhocsinh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            loadchart();
            // chart1.ChartAreas.Clear();
          //btncapnhat.Enabled = false;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ThongkesoluongHS_Load(sender, e);

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
