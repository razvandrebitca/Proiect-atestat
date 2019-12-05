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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            int a = int.Parse(textBox1.Text);
            for (int i = 2; i <= a / 2; i++)
                if (a % i == 0)
                    textBox2.AppendText(i.ToString() + " ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            
        }
    }
}
