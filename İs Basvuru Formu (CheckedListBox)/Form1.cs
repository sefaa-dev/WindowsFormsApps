using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İs_Basvuru_Formu__CheckedListBox_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] diller = { "Türkçe", "İngilizce", "Almanca", "Arapça", "Fransızca", "Çince", "İtalyanca", "İspanyolca", "Farsça" };
            checkedListBox1.Items.AddRange(diller);
            checkedListBox1.MultiColumn = true;
            checkedListBox1.CheckOnClick = true;
            button1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (checkedListBox1.Items.Contains(textBox2.Text) == false)
                    checkedListBox1.Items.Add(textBox2.Text);
                else
                    MessageBox.Show("Belirtilen Dil Zaten Eklidir !!");
                textBox2.Text = "";
                               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            while (checkedListBox1.CheckedIndices.Count > 0)
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text;
            string diller = "", mezuniyeti = "";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                diller += ", " + checkedListBox1.CheckedItems[i];
            }
            diller = diller.Substring(2);
            label6.Text = diller;

            if (radioButton1.Checked)
                mezuniyeti = radioButton1.Text;
            else if(radioButton2.Checked)
                mezuniyeti = radioButton2.Text;
            else if (radioButton3.Checked)
                mezuniyeti = radioButton3.Text;
            else if (radioButton4.Checked)
                mezuniyeti = radioButton4.Text;
            label8.Text = mezuniyeti;

            textBox1.Text = "";textBox2.Text = "";

        }
    }
}
