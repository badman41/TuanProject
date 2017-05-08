using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLhocsinhgiaovien.views
{
    public partial class uctDiem : UserControl
    {
        public uctDiem()
        { 
            InitializeComponent();
        }
        public static uctDiem UctDiem = new uctDiem();
        private void lvDsHS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDsHS.SelectedItems.Count == 0)
            {   
            }
            else
                return;
        }

        private void lvDsHS_Click(object sender, EventArgs e)
        {
           string _MaHS = lvDsHS.SelectedItems[0].SubItems[1].Text;
           dgvdiemtbchung.DataSource = controller.Diemcontroller.FillDataSetgetDanhSach_spgettbchungByMaHS(_MaHS).Tables[0];
           string _TenHS = lvDsHS.SelectedItems[0].SubItems[0].Text;
            txtMaHS.Text = _MaHS.ToString();
            TinhtbChung();
        }
        public void TinhtbChung()
        {
            try
            {
                int tb = dgvdiemtbchung.Rows.Count;
                decimal diemtbchung = 0;
                for (int i = 0; i < tb; i++)
                {
                    diemtbchung += decimal.Parse(dgvdiemtbchung.Rows[i].Cells["tbChung"].Value.ToString());
                }
                txttbChung.Text = diemtbchung.ToString() ;
                txttbChung.ForeColor = SystemColors.HotTrack;
            }
            catch
            {
            }

        }
        public DataTable HSclick()
        {
            DataTable dt = new DataTable();
            dt = Model.Hocsinhmod.FillDataSetspgetHocsinh().Tables[0];
            dgvdiemtbchung.DataSource = dt;
            return dt;
        }
        public void showlistview()
        {
            lvDsHS.Items.Clear();
            DataTable dt = new DataTable();
            dt = HSclick();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["MaHS"].ToString());
                ListViewItem.ListViewSubItem SubItem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
               // ListViewItem status = new ListViewItem(dt.Rows[i]["MaHS"].ToString());
                item.SubItems.Add(SubItem);
                lvDsHS.Items.Add(item);
            }
        }
       
        private void uctDiem_Load(object sender, EventArgs e)
        {
            showlistview();
            dgvdiemtbchung.BorderStyle = BorderStyle.Fixed3D;
            dgvdiemtbchung.RowHeadersVisible = false;
            dis_enddiem(true);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //string _MaHS = lvDsHS.SelectedItems[0].SubItems[1].Text;
            //dgvdiemtbchung.DataSource = controller.Diemcontroller.FillDataSetgetDanhSach_spgettbchungByMaHS(_MaHS).Tables[0];
            //string _TenHS = lvDsHS.SelectedItems[0].SubItems[0].Text;
            //DataTable dt = new DataTable();
            //dgvdiemtbchung.DataSource = dt;
            //chart1.ChartAreas["ChartArea1"].AxisX.Title = "MaHS";
            //chart1.ChartAreas["ChartArea1"].AxisY.Title = "Điểm TB Chung";
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    chart1.Series["Series1"].Points.AddXY(_MaHS.ToString(), _TenHS.ToString());
            //}
        }
        public void nhung(Control ctr)
        {
            panel1.Controls.Clear();
            panel1.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            panel1.Controls.Add(ctr);
            panel1.Show();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            uctdiemchitiet uctdct = new uctdiemchitiet();
            nhung(uctdct);
            uctDiem_Load(sender, e);
            

        }

        private void btnhuy_Click_1(object sender, EventArgs e)
        {
            uctDiem_Load(sender, e);
            panel1.Controls.Clear();
            txtMaHS.Clear();
            txttbChung.Clear();
        }
        void dis_enddiem(bool e)
        {
            btnDiem.Enabled = e;
            btnhuy.Enabled =e;
            btnxeploai.Enabled = e;
            txtMaHS.Enabled = !e;
            txttbChung.Enabled = !e;
        }

        private void btnxeploai_Click(object sender, EventArgs e)
        {
            try
            {
                int tb = dgvdiemtbchung.Rows.Count;
                float diemtbchung = 0;
                for (int i = 0; i < tb; i++)
                {
                    diemtbchung += float.Parse(dgvdiemtbchung.Rows[i].Cells["tbChung"].Value.ToString());
                }
                txttbChung.Text = diemtbchung.ToString();
                txttbChung.ForeColor = SystemColors.HotTrack;

                if(diemtbchung >=8)
                {
                    MessageBox.Show(" Điểm Trung Bình Chung Của Bạn Là : " + " [ " + txttbChung.Text + " ] " + "Xếp Loại :Giỏi" , "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else
                {
                    if(diemtbchung >= 6.5 &&diemtbchung<8)
                   {
                        MessageBox.Show(" Điểm Trung Bình Chung Của Bạn Là : " + " [ " + txttbChung.Text + " ] " + "Xếp Loại :Khá", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                else
                    {
                        if (diemtbchung <6.5 && diemtbchung >=4)
                        {
                            MessageBox.Show(" Điểm Trung Bình Chung Của Bạn Là : " + " [ " + txttbChung.Text + " ] " + "Xếp Loại :Trung Bình", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                        else
                        {
                            if (diemtbchung < 4)
                            {
                                MessageBox.Show(" Điểm Trung Bình Chung Của Bạn Là : " + " [ " + txttbChung.Text + " ] " + "Xếp Loại :yếu", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            }

                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show(" lỗi. Vui lòng chọn học sinh ở bên trái !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            btnDiem.Enabled = false;


        }

    }
}
