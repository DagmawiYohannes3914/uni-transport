using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace uni_transport
{
    
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
