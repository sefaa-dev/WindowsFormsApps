using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///STRİNG BİRLEŞTİRME///

            //string ogrno = "58";
            //string ad = "sefaa";
            //string soyad = "yılmaz";
            //Console.Write("Öğrenci No:{0} ADI:{1} SOYAD:{2}",ogrno, ad, soyad);
            //Console.ReadKey();
            //*********************************************************************************************
            //string tcno = "1234578412";
            //string adsoyad = "Sefa Yılmaz";
            //string gorevi = "Satın Alma Müdürü";
            //double maas = 2560.86;
            //Console.WriteLine("TC KİMLİK NUMARASI:" + tcno + "-" + "Adı Soyadı:" + adsoyad);
            //Console.Write("Görevi:{0} - Maaşı:{1}", gorevi, maas);
            //Console.ReadKey();
            //*********************************************************************************************

            ///KLAVYEDEN GİRİŞ///

            //int sayi1, sayi2, sonuc;
            //Console.WriteLine ("1. sayıyı giriniz: ");
            //sayi1 = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine ("2. sayıyı giriniz: ");
            //sayi2 = Convert.ToInt16(Console.ReadLine());

            //sonuc = sayi1 + sayi2;

            //Console.Write("Sayıların toplamı; {0}", sonuc);
            //Console.ReadKey();
            //*********************************************************************************************

            ////CONSTANT ((SABİT))

            ////herhangi bir ismin önünde yer aldığında o isim artık değiştirilemiyor,sabitt
            //const double pi = 3.14;
            //double yaricap, alan;
            //Console.Write("Yarıçap değerini giriniz: ");
            //yaricap = Convert.ToDouble(Console.ReadLine());
            //alan = pi * (yaricap * yaricap);
            //Console.Write("Alan: {0}", alan);
            //Console.ReadKey();
            //*********************************************************************************************

            //İF - ELSE

            //double sayi1, sayi2, sonuc;
            //char secim;


            //while (true)
            //{

            //    Console.WriteLine(" ");
            //    Console.Write("1. sayıyı giriniz: ");
            //    sayi1 = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("2. sayıyı giriniz: ");
            //    sayi2 = Convert.ToDouble(Console.ReadLine());

            //    Console.WriteLine("1-Toplama 2-Çıkarma 3-Çarpma 4-Bölme Seçimini giriniz: ");

            //    secim = Convert.ToChar(Console.ReadLine());

            //    if (secim == '1')
            //    {
            //        sonuc = sayi1 + sayi2;
            //        Console.WriteLine("Toplama sonucu: {0}", sonuc);
            //    }
            //    if (secim == '2')
            //    {
            //        sonuc = sayi1 - sayi2;
            //        Console.WriteLine("Çıkarma sonucu: {0}", sonuc);

            //    }
            //    if (secim == '3')
            //    {
            //        sonuc = sayi1 * sayi2;
            //        Console.WriteLine("Çarpımın sonucu: {0}", sonuc);

            //    }
            //    if (secim == '4')
            //    {
            //        sonuc = sayi1 / sayi2;
            //        Console.WriteLine("Bölümün sonucu: {0}", sonuc);

            //    } 
            //}
            //Console.ReadKey();
            //*********************************************************************************************


            ////SWİTCH - CASE

            //char secim;
            //Console.WriteLine("1- Batı Karedeniz Turu");
            //Console.WriteLine("2- İç Anadolu Turu");
            //Console.WriteLine("Seçiminizi Yapınız [1,2]?");
            //secim = Convert.ToChar(Console.ReadLine());
            //switch (secim)
            //{
            //    case '1':
            //        Console.WriteLine("Batı Karadeniz Turu");
            //        Console.WriteLine("Tarih Aralığı:30.01.2017 - 02.02.2017");
            //        Console.WriteLine("Karabük ,Kastamonu, Sinop, Bartin");             
            //        break;

            //       case '2':
            //        Console.WriteLine("İç Anadolu Turu");
            //        Console.WriteLine("Tarih Aralığı:01.02.2017 - 03.02.2017");
            //        Console.WriteLine("Ankara ,Konya, Eskişehir");
            //        break;
            //    default:
            //        Console.WriteLine("1,2 dışında hatalı seçim yaptınız !!");
            //        break;
            //}
            //Console.ReadKey();

            //*********************************************************************************************


            //WHİLE

            //int x = 1;
            //while (x <= 100)
            //{
            //    if (x % 4 == 0)
            //    {
            //        Console.WriteLine(x);

            //    }
            //    x++;

            //}
            //Console.ReadKey();

            //int sayac = 1, adet = 0, sayi = 0;
            //double ortalama = 0, toplam = 0;
            //Console.Write("Kaç adet sayı gireceksin? ");
            //adet = Convert.ToInt32(Console.ReadLine());
            //while (sayac<=adet)
            //{
            //    Console.Write("Sayı Giriniz? ");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam = toplam + sayi;
            //    sayac++;
            //}
            //ortalama = toplam / adet;


            //Console.Write("Sayıların Ortalaması:{0}", ortalama);

            //Console.ReadKey();
            //*********************************************************************************************


            ////DO - WHİLE

            //string kulAd = "admin", kulSifre = "123";
            //string kullaniciAd, kullaniciSifre;
            //int hak = 3;
            //do
            //{
            //    Console.Write("Kullanıcı adını giriniz? ");
            //    kullaniciAd = Console.ReadLine();
            //    Console.Write("Şifreniz giriniz? ");
            //    kullaniciSifre = Console.ReadLine();

            //    if (kullaniciAd==kulAd && kullaniciSifre==kulSifre)
            //    {
            //        Console.Write("Hoşgeldiniz...");
            //    }
            //    else
            //    {
            //        hak--;
            //        if (hak == 0)
            //        {
            //            Console.Write("3 tür kullanıcı adı ve şifre giremediniz. Müşterii hizmetlerini arayınız");
            //        }
            //    }
            //} while ((kullaniciAd != kulAd || kullaniciSifre != kulSifre) && hak != 0);
            //Console.ReadKey();

            //Random rnd = new Random();
            //int uretilenSayi = rnd.Next(20, 35);
            //int sayi, hak = 50;

            //do
            //{
            //    Console.Write("Bir tahminde bulunun? ");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    hak--;
            //    if (sayi == uretilenSayi)
            //    {
            //        Console.Write("Tebrikler...");
            //    }
            //    else if(sayi < uretilenSayi)
            //    {
            //        Console.Write("Sayı Büyütünüz!");
            //    }
            //    else if(sayi > uretilenSayi)
            //    {
            //        Console.Write("Sayıyı Küçültünüz");
            //    }
            //    if (hak == 0)
            //    {
            //        Console.Write("Hakkınız Tükenmiştir!");
            //    }

            //} while (sayi != uretilenSayi && hak != 0);
            //Console.ReadKey();

            //*********************************************************************************************

            ////FOR

            //for (int i = 0; i <= 12; i=i+2)
            //{
            //    Console.SetCursorPosition(i,0);
            //    Console.Write("*");
            //}
            //for (int j = 1; j <= 5; j++)
            //{
            //    Console.SetCursorPosition(6,j);
            //    Console.Write("* ");

            //}
            //for (int k = 18; k <= 26; k=k+2)
            //{
            //    Console.SetCursorPosition(k, 0);
            //    Console.Write("*");

            //}
            //for (int l = 1; l <= 4; l++)
            //{
            //    Console.SetCursorPosition(18, l);
            //    Console.Write("*");               
            //}
            //for (int n = 18; n <= 26; n = n + 2) 
            //{
            //    Console.SetCursorPosition(n, 5);
            //    Console.Write("*");
            //}
            //Console.ReadKey();

            //*********************************************************************************************

            ////RANDOM

            //Random rnd = new Random();
            //int üretilenSayi = rnd.Next();
            //Console.Write("Üretilen sayi: {0}", üretilenSayi);
            //Console.ReadKey();

            //Random ogrenci = new Random();
            //int s1 = ogrenci.Next(1, 50);
            //int s2 = ogrenci.Next(1, 50);
            //int s3 = ogrenci.Next(1, 50);
            //int s4 = ogrenci.Next(1, 50);
            //int s5 = ogrenci.Next(1, 50);
            //Console.Write(" 1. Öğrenci: {0}\n 2. Öğrenci: {1}\n 3. Öğrenci: {2}\n 4. Öğrenci: {3}\n 5. Öğrenci: {4}\n", s1,s2,s3,s4,s5);
            //Console.ReadKey();

            //    Random rnd = new Random();
            //    int rastgeleSayi = rnd.Next(10, 20);
            //    Console.Write("Üretilen Sayı: {0}", rastgeleSayi);
            //    int hak = 5;
            //BASADON:
            //    Console.Write("\nBir tahminde bulunun; ");
            //    int tahmin = Convert.ToInt32(Console.ReadLine());

            //    if (tahmin == rastgeleSayi)
            //    {
            //        Console.WriteLine("Tebrik Ederim...Puan: {0}",hak * 20);
            //    }
            //    else if (tahmin < rastgeleSayi)
            //    {
            //        hak--;
            //        if (hak == 0)
            //        {
            //            Console.WriteLine("Kaybbettiniz..");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Tahmininizi Büyütünüz");
            //            goto BASADON;
            //        }
            //    }
            //    else if (tahmin > rastgeleSayi)
            //    {
            //        hak--;
            //        if (hak == 0)
            //        {
            //            Console.WriteLine("Kaybettiniz..");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Tahminizi Küçültünüz");
            //            goto BASADON;
            //        }
            //    }
            //    Console.ReadKey();


            //*********************************************************************************************

            ////DALLANMA

            //BASADON:
            //    Console.Clear();
            //    Console.WriteLine("1. Yazılı Notunu Gir: ");
            //    int y1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("2. Yazılı Notunu Gir: ");
            //    int y2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("3. Yazılı Notunu Gir: ");
            //    int y3 = Convert.ToInt32(Console.ReadLine());

            //    int ort = (y1 + y2 + y3) / 3;
            //    Console.WriteLine("ORTALAMA: {0}",ort);
            //SECIMYAP:
            //    Console.WriteLine("Yeniden işlem yapmak ister misiniz? (e veya h)");
            //    char secim = Convert.ToChar(Console.ReadLine());
            //    if (secim == 'e' || secim == 'E')
            //    {
            //        goto BASADON;
            //    }
            //    else if (secim == 'h' || secim == 'H')
            //    {
            //        Console.WriteLine("İyi Günler..");
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Yanlış seçim yaptınız, tekrar deneyiniz ");
            //        goto SECIMYAP;
            //    }
            //    Console.ReadLine();

            //*********************************************************************************************

            ////DİZİLER

            //int[] array1 = new int[12];

            //int[] dzi = new int[5] { 1, 2, 3, 4, 5 };

            //string[] gunler = new string[7];
            //gunler[0] = "Pazartesi";
            //gunler[1] = "Salı";
            //gunler[2] = "Çarşamba";
            //gunler[3] = "Perşembe";
            //gunler[4] = "Cuma";
            //gunler[5] = "Cumartesi";
            //gunler[6] = "Pazar";
            ////ya daaaa
            //string[] gunlerr = new string[7] {"Pazartesi","salı","çarşamba"...}

            //string[] ogrenciler = new string[5] { "101", "102", "103", "104", "105" };
            //int[,] notlar = new int[5, 3] { { 50, 60, 70 }, { 50, 45, 84 }, { 87, 48, 95 }, { 15, 100, 98 }, { 15, 78, 98 } };
            //int j = 0;

            //for (int i = 0; i <=4; i++)

            //{
            //    double ort = (notlar[i, j] + notlar[i, j + 1] + notlar[i, j + 2]) / 3;
            //    Console.WriteLine("Öğrenci No: {0} ---  Ort:{1}",ogrenciler[i],ort);
            //}
            //Console.ReadKey();

            //*********************************************************************************************

            ////TIMER

            //    Timer zamanlayici = new Timer();
            //    zamanlayici.Interval = 2000;
            //    zamanlayici.Elapsed += zamanlanmısGorev;
            //    zamanlayici.Start();
            //    Console.ReadKey();
            //}
            //private static void zamanlanmısGorev(Object source, System.Timers.ElapsedEventArgs e)
            //{
            //    Console.WriteLine("Ömür hazinesinden 2 sn daha azaldı.");


            // int toplam = 0, adet = 0;
            // for (int i = 1; i < 1001; i++)
            // {
            //     if ((i % 5 == 0) && (i % 7 != 0))

            //     {
            //         Console.WriteLine(i);
            //         toplam += i;
            //         adet++;
            //     }
            //}
            // Console.WriteLine("{0} sayı bulundu",adet);
            // Console.WriteLine("Toplamları = {0}",toplam);

            // Console.ReadKey();

            //int adet = 0;
            //for (int i = 0; i <= 100; i += 5)
            //{
            //    if (adet % 6 == 0)
            //        Console.WriteLine();
            //    Console.Write("{0,4}", i);
            //    adet++;

            //}
            //Console.WriteLine("\n");
            //Console.ReadKey();                    

        }
    }
}
