using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ogrno = "58";
            //string ad = "sefa";
            //string soyad = "yılmaz";
            //Console.Write("Öğrenci No:{0} ADI:{1} SOYAD:{2}",ogrno, ad, soyad);
            //Console.ReadKey();

            string tcno = "1234578412";
            string adsoyad = "Sefa Yılmaz";
            string gorevi = "Satın Alma Müdürü";
            double maas = 2560.86;
            Console.WriteLine("TC KİMLİK NUMARASI:" + tcno + "-" + "Adı Soyadı:" + adsoyad);
            Console.Write("Görevi:{0} - Maaşı:{1}", gorevi, maas);
            Console.ReadKey();







        }
    }
}
