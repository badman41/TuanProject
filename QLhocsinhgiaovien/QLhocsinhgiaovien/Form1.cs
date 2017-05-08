using QLhocsinhgiaovien.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLhocsinhgiaovien
{
    public partial class Tabhienthi : Form
    {
        public Tabhienthi()
        {
            InitializeComponent();
        }
        internal static List<Byte> typepages = new List<Byte>();// tạo 1 danh sách tabpage
        public void themtabpages(UserControl uct, Byte typeControl, string tentab)
        {
            //kiểm tra đã tồn tại trang hay chưa?
            for (int i = 0; i < tabControl1.TabPages.Count; i++)
            {
                if (tabControl1.TabPages[i].Contains(uct) == true)
                {
                    tabControl1.SelectedTab = tabControl1.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();//khai báo 1 new tabpage
            typepages.Add(typeControl);// add typeControl vào typepages (ném tab vừa tạo vào trong danh sách tab)
            tab.Name = uct.Name;// tên của tab là tên của uct (vd : uctNhanVien)
            tab.Size = tabControl1.Size;// độ rộng của tab mới tạo bằng với kích thước của danh sách tab
            tab.Text = tentab;// tên của tab "string tentab"
            tabControl1.TabPages.Add(tab);
            tabControl1.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;//đổ tab mới tạo vừa khít size danh sách tab
            tab.Controls.Add(uct);
            uct.Focus();
        }
        private void giáoViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            themtabpages(views.Giaovien.uctGiaovien, 4, "Giáo Viên");
        }

        private void họcSinhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            themtabpages(views.uctHocSinh.uctHS, 4, "Học Sinh");
        }
        // tạo đồng hồ : sử dụng timer
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Tabhienthi_Load(object sender, EventArgs e)
        {
            DateTime tn = DateTime.Now;
            lbtime.Text = tn.ToString("dd/MM/yyyy/tt ");
            lbHH.Text = tn.ToString("HH");
            lbmm.Text = tn.ToString("mm");
            lbss.Text = tn.ToString("ss");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = Int32.Parse(lbss.Text);
            int b = Int32.Parse(lbmm.Text);
            int c = Int32.Parse(lbHH.Text);
            a++;
            if (c > 23)
            {
                c = 0;
                if (a > 59)
                {
                    a = 0;
                    b = b + 1;
                }
                if (a < 10)
                    lbss.Text = "0" + a;
                else
                    lbss.Text = a + "";
                if (b < 10)
                    lbmm.Text = "0" + b;
                else
                    lbmm.Text = b + "";
                if (b > 59)
                {
                    b = 0;
                    c = c + 1;
                }
                if (b < 10)
                    lbmm.Text = "0" + b;
                else
                    lbmm.Text = b + "";
                if (c < 10)
                    lbHH.Text = "0" + c;
                else
                    lbHH.Text = c + "";
            }
            else
            {
                if (a > 59)
                {
                    a = 0;
                    b = b + 1;
                }
                if (a < 10)
                    lbss.Text = "0" + a;
                else
                    lbss.Text = a + "";
                if (b < 10)
                    lbmm.Text = "0" + b;
                else
                    lbmm.Text = b + "";
                if (b > 59)
                {
                    b = 0;
                    c = c + 1;
                }
                if (b < 10)
                    lbmm.Text = "0" + b;
                else
                    lbmm.Text = b + "";
                if (c < 10)
                    lbHH.Text = "0" + c;
                else
                    lbHH.Text = c + "";

            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn có muốn thoát không? ", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                return;
        }
        public void dongtabhientai()
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }

        private void đổiMKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doiMKcs dn = new doiMKcs();//gọi form đăng nhap
            dn.ShowDialog();// cho form đăng nhập hiển thị
        }

        private void thốngKêĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themtabpages(views.uctDiem.UctDiem, 4, "Thống Kê Điểm");
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themtabpages(views.ThongkesoluongHS.ucttk, 4, "Thống Kê Số Lượng HS");
        }

        private void dongtabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dongtabhientai();
            
        }

        private void bảngĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            themtabpages(views.uctdiemchitiet.uctdct, 4, "Bảng Điểm Chi Tiết");
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalo c = new Catalo();
            c.ShowDialog();
        }

        private void lịchGiảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCPhanCongDay pc = new UCPhanCongDay();
            themtabpages(pc, 4, "Xem lịch giảng dạy");
        }

        private void đàoTạoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
