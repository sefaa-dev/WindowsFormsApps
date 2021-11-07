using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiTanimaListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string tcno = " ", adsoyad = " ", cinsiyet = " ", mezuniyet = " ", diller = " ", uzmanlık = " ";
            tcno = txtTc.Text;
            adsoyad = txtAdSoyad.Text;
            if (rbBay.Checked == true)
            {
                cinsiyet = rbBay.Text;
            }
            else if (rbBayan.Checked == true)
            {
                cinsiyet = rbBay.Text;
            }
            if (rbİlk.Checked == true)
                mezuniyet = rbİlk.Text;
            else if (rbOrta.Checked == true)
                mezuniyet = rbOrta.Text;
            else if (rbLis.Checked == true)
                mezuniyet = rbLis.Text;
            else if (rbYuksek.Checked == true)
                mezuniyet = rbYuksek.Text;

            if (a.Checked == true)
                diller = diller + "," + a.Text;
            if (b.Checked == true)
                diller = diller + "," + b.Text;
            if (c.Checked == true)
                diller = diller + "," + c.Text;
            if (d.Checked == true)
                diller = diller + "," + d.Text;
            if (z.Checked == true)
                diller = diller + "," + z.Text;
            if (f.Checked == true)
                diller = diller + "," + f.Text;
            diller = diller.Substring(1);

            if (g.Checked == true)
                uzmanlık = uzmanlık + "," + g.Text;
            if (h.Checked == true)
                uzmanlık = uzmanlık + "," + h.Text;
            if (j.Checked == true)
                uzmanlık = uzmanlık + "," + j.Text;
            if (k.Checked == true)
                uzmanlık = uzmanlık + "," + k.Text;
            if (l.Checked == true)
                uzmanlık = uzmanlık + "," + l.Text;
            if (m.Checked == true)
                uzmanlık = uzmanlık + "," + m.Text;
            uzmanlık = uzmanlık.Substring(1);

            listBox1.Items.Add("TC NO: " + tcno + " / " + "ADI SOYADI: " + adsoyad + " / " + "CİNSİYET: " + cinsiyet + " / " + "DİLLER: " + diller + " / " + "UZMANLIK: " + uzmanlık);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void btnTumunuSil_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            txtTc.Clear();
            txtAdSoyad.Clear();
        }
    }
}
