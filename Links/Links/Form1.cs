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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                Form3 form3 = new Form3();
                this.Hide();
                form3.Show();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                Form4 form4 = new Form4();
                this.Hide();
                form4.Show();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                Form5 form5 = new Form5();
                this.Hide();
                form5.Show();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                Form6 form6 = new Form6();
                this.Hide();
                form6.Show();
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton6.Checked == true)
            {
                Form7 form7 = new Form7();
                this.Hide();
                form7.Show();
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                Form8 form8 = new Form8();
                this.Hide();
                form8.Show();
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                Form9 form9 = new Form9();
                this.Hide();
                form9.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                Form10 form10 = new Form10();
                this.Hide();
                form10.Show();
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                Form11 form11 = new Form11();
                this.Hide();
                form11.Show();
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                Form12 form12 = new Form12();
                this.Hide();
                form12.Show();
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true)
            {
                Form13 form13 = new Form13();
                this.Hide();
                form13.Show();
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked == true)
            {
                Form14 form14 = new Form14();
                this.Hide();
                form14.Show();
            }
        }
    }
    }

