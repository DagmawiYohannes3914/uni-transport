using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uni_transport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("enter username");
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("enter password");
                textBox2.Focus();
            }
            else
            {
                Hide();
                new menu().Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
