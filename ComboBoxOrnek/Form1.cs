﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("AUDI");
            comboBox1.Items.Add("FORD");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "AUDI")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("A1");
                comboBox2.Items.Add("A2");
                comboBox2.Items.Add("A3");

            }
            else if (comboBox1.Text == "FORD") 
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("TRANSIT");
                comboBox2.Items.Add("CORNET");
                comboBox2.Items.Add("MUSTANG");

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "A1")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1.4 TFSI");
                comboBox3.Items.Add("1.6 TDI");

            }
            else if (comboBox2.Text == "A2")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1.6FSI");

            }
            else if (comboBox2.Text == "A3")
            {
                comboBox3.Items.Clear();
                string[] a3_version = { "CABRİO", "HATCBACK", "SEDAN", "SPORTBACK" };
                comboBox3.Items.AddRange(a3_version);
            }
            else if (comboBox2.Text == "TRANSIT")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("0.8 GL");
                comboBox3.Items.Add("1.0");
                comboBox3.Items.Add("1.3");

            }
            else if (comboBox2.Text == "CORNET")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1.5");
                comboBox3.Items.Add("1.6");
                

            }
            else if (comboBox2.Text == "MUSTANG")
            {
                comboBox3.Items.Clear();
                comboBox3.Items.Add("1.6 GLX");
                comboBox3.Items.Add("1.0");
                comboBox3.Items.Add("1.3");
                            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("MARKA:" + comboBox1.Text +  "  MODEL:" + comboBox2.Text +  "   VERSİON:" + comboBox3.Text);
        }
    }
}
