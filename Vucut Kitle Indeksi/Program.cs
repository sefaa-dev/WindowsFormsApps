using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vucut_Kitle_Indeksi
{
    class Program
    {
        static void Main(string[] args)
        {
            double boy, kilo, bedenKitleIndeksi;
            Console.Write("Boyunuzu metre cinsinden giriniz: ");
            boy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kilonuzu giriniz: ");
            kilo = Convert.ToDouble(Console.ReadLine());

            bedenKitleIndeksi = kilo / (boy * boy);

            Console.WriteLine("Beden Kitle İndeksiniz: {0}",bedenKitleIndeksi);

            Console.WriteLine("");

            if (bedenKitleIndeksi <= 18.5)
            Console.WriteLine("Zayıf"); 
            else if (bedenKitleIndeksi > 18.5 && bedenKitleIndeksi <= 24.9)
                Console.WriteLine("Normal Kilolu");
            else if(bedenKitleIndeksi > 25 && bedenKitleIndeksi <= 30 )
                Console.WriteLine("Fazla Kilolu");
            else
                Console.WriteLine("Obezite");
            
                
                Console.ReadKey();        
                

            



        }
    }
}
