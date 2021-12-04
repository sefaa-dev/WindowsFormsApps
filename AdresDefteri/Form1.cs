using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdresDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kisi kisi = new Kisi();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private List<Kisi> kisiler = new List<Kisi>();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kisi yeniKisi = new Kisi();
            try
            {
                yeniKisi.Ad = txtAd.Text;
                yeniKisi.Soyad = txtSoyad.Text;
                yeniKisi.DogumTarihi = dateTimePicker1.Value;
                yeniKisi.Tckn = txtTckn.Text;

                kisiler.Add(yeniKisi);
                ListeyiDoldur();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListeyiDoldur()
        {
            lstKisiler.Items.Clear();
            foreach (Kisi kisi1 in kisiler)
            {
                lstKisiler.Items.Add(kisi1);
            }
        }
        private Kisi seciliKisi;
        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;
            seciliKisi = lstKisiler.SelectedItem as Kisi;

            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            txtTckn.Text = seciliKisi.Tckn;
            dateTimePicker1.Value = seciliKisi.DogumTarihi;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliKisi == null) return;

            seciliKisi.Ad = txtAd.Text;
            seciliKisi.Soyad = txtSoyad.Text;
            seciliKisi.DogumTarihi = dateTimePicker1.Value;
            seciliKisi.Tckn = txtTckn.Text;
            ListeyiDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)        
        {
            if (seciliKisi == null) return;

            DialogResult cevap = MessageBox.Show($"{seciliKisi} yi silmek istiyor musunuz? ", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                kisiler.Remove(seciliKisi);
                ListeyiDoldur();
            }

        }
    }
}
