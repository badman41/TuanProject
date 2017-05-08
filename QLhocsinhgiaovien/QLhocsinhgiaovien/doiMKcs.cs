using QLhocsinhgiaovien.Model;
using QLhocsinhgiaovien.Until;
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
    public partial class doiMKcs : Form
    {
        public doiMKcs()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!textBox1.Text.Equals(Static.pass))
            {
                label6.Text = "Sai rồi";
                textBox2.Enabled = false;
            }
            else
            {
                label6.Text = "*";
                textBox2.Enabled = true;
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text.Trim().Equals(""))
                label4.Text = "Sai rồi";
            else
                label4.Text = "*";
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (!textBox3.Text.Equals(textBox2.Text))
                label5.Text = "Sai rồi";
            else
                label5.Text = "*";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(Static.pass))
            {
                label6.Text = "Sai rồi";
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
            else
            {
                label6.Text = "*";
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!textBox3.Text.Equals(textBox2.Text))
            {
                label5.Text = "Sai rồi";
                btnok.Enabled = false;
            }
            else
            {
                label5.Text = "*";
                btnok.Enabled = true;
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Account.UpdatePass(Static.account, textBox3.Text);
            Static.pass = textBox3.Text;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
