﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int minim = a;
            if (b < minim)
                minim = b;

            textBox3.Text=minim.ToString() ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
         
        }
    }
}
