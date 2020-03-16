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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            int a = int.Parse(textBox1.Text),s=0,y=a;
            for (int i = 1; i <= a / 2; i++)
                if (a % i == 0)
                    s += i;


            if (s == y)
                textBox2.Text = "Numarul este perfect";
            else

                textBox2.Text = "Numarul nu este perfect";
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
