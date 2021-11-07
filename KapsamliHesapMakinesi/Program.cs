using System;

namespace KapsamliHesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
        BASADON:
            Console.WriteLine("1. Sayıyı Giriniz? ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2. Sayıyı Giriniz? ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
        DORTISLEMSECIM:
            Console.Write("Seçminizi Yapınız? (1:Topla 2:Çıkar 3:Böl 4:Çarp)");
            char dortislemsec = Convert.ToChar(Console.ReadLine());
            switch (dortislemsec)
            {
                case '1':
                    dortİslem toplamaislemi = new dortİslem();
                    double toplam = toplamaislemi.topla(sayi1, sayi2);
                    Console.WriteLine("Toplam Sonucu: {0}", toplam);
                    break;
                case '2':
                    dortİslem cikarmaislemi = new dortİslem();
                    double cıkar = cikarmaislemi.cikar(sayi1, sayi2);
                    Console.WriteLine("Çıkar Sonucu: {0}", cıkar);
                    break;
                case '3':
                    dortİslem bolmeislemi = new dortİslem();
                    double bol = bolmeislemi.bol(sayi1, sayi2);
                    Console.WriteLine("Bol Sonucu: {0}", bol);
                    break;
                case '4':
                    dortİslem carpmaislemi = new dortİslem();
                    double carp = carpmaislemi.carp(sayi1, sayi2);
                    Console.WriteLine("ÇarpSonucu: {0}", carp);
                    break;
                default:
                    Console.Clear();
                    Console.Write("Yanlış Seçim Yaptınız, Tekrar Deneyiniz");
                    goto DORTISLEMSECIM;
            }
        DEVAMSECIM:
            Console.Write("Yeniden işlem yapmak ister misiniz ? (EVET:E HAYIR:H)");
            char devamsec = Convert.ToChar(Console.ReadLine());
            if (devamsec == 'E' || devamsec == 'e')
            {
                Console.Clear();
                goto BASADON;
            }
            else if (devamsec == 'H' || devamsec == 'h')
            {
                Console.Write("İyi Günler");
            }
            else
            {
                Console.Write("Yanlış seçim yaptınız. Tekrar Deneyin");
                goto DEVAMSECIM;
            }
            Console.ReadKey();
        }

        class dortİslem
        {
            public double topla(double s1, double s2)
            {
                return (s1 + s2);
            }
            public double cikar(double s1, double s2)
            {
                return (s1 - s2);
            }
            public double bol(double s1, double s2)
            {
                return (s1 / s2);
            }
            public double carp(double s1, double s2)
            {
                return (s1 * s2);
            }
                    
        }
    }
}
