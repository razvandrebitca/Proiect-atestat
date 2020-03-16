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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
             Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
               int n = int.Parse(textBox1.Text);
            bool ok = true;
            for (int i = 2; i <= n / i; i++)
                if (n % i == 0)
                    ok = false;
            if (ok == true && n!=1 && n!=0)
                textBox2.Text="Numarul este prim";
            else
                textBox2.Text="Numarul nu este prim";
        }
    }
}
