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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text), y = a, o = 0;
            while (y != 0)
            {
                o = o * 10 + y % 10;
                y /= 10;
            }
            if (a == o)
                textBox2.Text = "Numarul este palindrom!";
            else

                textBox2.Text = "Numarul nu este palindrom!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            
        }
    }
}
