using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdresDefteri
{
    class Kisi
    {
        public Kisi()
        {
            this.OlusturulmaZamani = DateTime.Now;
        }
        private string _ad;
        private string _soyad;
        private string _tckn;

        public string Ad
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new FormatException("Kişinin adı boş geçilemez");
                }
                foreach (char harf in value)
                {
                    if (char.IsDigit(harf))
                        throw new Exception("Kişinin adında rakam bulunmaz");
                    if (char.IsSymbol(harf) || char.IsControl(harf) || char.IsPunctuation(harf))
                        throw new Exception("Kişinin adından geçersiz karater bulunmamaktadır");
                }
                if (value.Length > 50)
                    throw new Exception("Girilen ifade 50 karaterden fazla olamaz");
                _ad = value;
            }
            get
            {
                return _ad.Substring(0, 1).ToUpper() + _ad.Substring(1).ToLower();
            }

        }

        public string Soyad
        {
            get
            {
                return _soyad.Substring(0, 1).ToUpper() + _soyad.Substring(1).ToLower();
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new FormatException("Kişinin soyadı boş geçilemez");
                }
                foreach (char harf in value)
                {
                    if (char.IsDigit(harf))
                        throw new Exception("Kişinin soyadında rakam bulunmaz");
                    if (char.IsSymbol(harf) || char.IsControl(harf) || char.IsPunctuation(harf))
                        throw new Exception("Kişinin soyadında geçersiz karaket bulunmamaktadır");
                }
                if (value.Length > 50)
                    throw new Exception("Girilen ifade 50 karakterden fazla olamaz");
                _soyad = value;
            }
        }
        public string Tckn
        {
            set
            {
                if (value.Length != 11)
                    throw new Exception("TCKN 11 Haneli olmalıdır");

                foreach (char harf in value)
                    if (!char.IsDigit(harf))
                        throw new Exception("TCKN sadece rakamlardan oluşur");
                int ilk = int.Parse(value.Substring(0, 1));
                int son = int.Parse(value.Substring(10, 1));

                if (ilk == 0)
                    throw new Exception("TCKN 0 ile başlayamaz !!");
                if(son % 2 ==1)
                    throw new Exception("TCKN son rakamı çift olmalıdır!");
                _tckn = value;
                
            }
            get { return _tckn; }
        }

        public DateTime DogumTarihi { get; set; }
        public int yas
        {
            get
            {
                return DateTime.Now.Year - this.DogumTarihi.Year;
            }
        }

        public DateTime OlusturulmaZamani { get; private set; }
        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad} -- {this.yas}";
        }
    }
}


       







    
