using QLhocsinhgiaovien.Until;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLhocsinhgiaovien
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            if (Model.Account.CheckAccount(txtname.Text, txtpass.Text))
            {
                Static.thread = new Thread(ddd);
                Static.thread.Start();
                Static.account = txtname.Text;
                Static.pass = txtpass.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập lỗi ");
            }
        }
        private static void ddd()
        {
            Tabhienthi tht = new Tabhienthi();
            tht.ShowDialog();
        }
        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_Validating(object sender, CancelEventArgs e)
        {
            if (!txtname.Text.Trim().Equals(""))
            {
                label3.Text = "*";
            }
            else
            {
                label3.Text = "Chưa nhập à ?";
            }
        }

        private void txtpass_Validating(object sender, CancelEventArgs e)
        {
            if (!txtpass.Text.Trim().Equals(""))
            {
                label4.Text = "*";
            }
            else
            {
                label4.Text = "Chưa nhập à ?";
            }
        }
    }
}
