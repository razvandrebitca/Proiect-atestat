using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Links
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           int  a = int.Parse(textBox1.Text),y=a,o=0;
            while(y!=0)
            {
                o = o * 10 + y % 10;
                y /= 10;
            }
            textBox2.Text = o.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
