using System;

namespace GenelTekrar
{
    class Program
    {
        static void Main(string[] args)
        {

            //TAD - Tip Ad = Değer
            //Tam sayı değişken tipleri
            // camelCase PascalCase
            // degisken ne için kullanılıyorsa onu ifade edecek şekilde isimlenidirin

            /*
             * degiskenler sayi ile başlayamaz
             * _ harici hiçbir özel karakteri kullanamazsınız
             * boşluk kullanamazsınız
             * özel anahtar kelimeleri kullanamazsınız
             * büyükharf-küçük harf duyarlıdır.
             
                              // implicity convert

            short sayi = 32;
            int sayi2 = 32;
            sayi = Convert.ToInt16(sayi2);
            sayi = (short)sayi2;

                                                  //ondalıklı sayılar
            double degiskenDouble = Double.MinValue;
            float degiskenFloat = float.MaxValue;
            decimal degiskenDecimal = decimal.MaxValue;

            degiskenDouble = 3.14d;
            degiskenFloat = 3.14F;
            degiskenDecimal = 3.14m;

             /*
             * Kullanıcı girişleri
             * Veritabanı istekleri (CRUD)
             * Dosya işlemleri
             * Sunucu istekleri
             * Tür dönüşümleri            
             * Try - Catch | Error Handling
             

         NOT : Metodun kullanım amacı gönderilen değerin ilgili türe dönüşüp dönüşemeyeğini belirlemektir. TryParse metodu geriye bool tipinde değer döndürmektedir. Eğer parametre olarak gönderilen değer dönüştürülmek istenilen değere dönüşürse out parametresi ile gönderilen parametreye sonucu aktarmaktadır.

               Console.WriteLine("1-6 arası bir sayı giriniz");
            int sayi2 = 0;
            string girilen = Console.ReadLine();
            if (int.TryParse(girilen, out sayi2))
            {                
                Console.WriteLine(sayi2 * sayi2 * sayi2);
            }
            else
            {
                Console.WriteLine("Bir sayı girmeyi beceremedin");
            }
 

                                //ternary if 
            int ortalama = 60;
          
            // degisken = ifade ? true olduğunda yapılacak : false olduğunda yapılacak

            string sonuc = ortalama > 50 ? "Geçtiniz" : "Kaldınız";
            Console.WriteLine(sonuc);

                                                  //RANDOM
            Random rnd = new Random(); //instance

            //0-100 arası rastgele bir sayı 
            int sayi1 = rnd.Next(0, 100);
            sayi1 = rnd.Next(100);

            //-10 ile 20 arasında rastgele sayı
            int sayi2 = rnd.Next(-10, 20);

            //rastgele 1 int sayisi 
            int sayi3 = rnd.Next();

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(rnd.Next(1, 50));
            }


            Console.Write("Uzunluk : ");
            int kenarUzunlugu = Convert.ToInt32(Console.ReadLine());
            int ortaNokta = kenarUzunlugu - 1;
            int taban = kenarUzunlugu * 2 - 1;
            for (int i = 0; i < kenarUzunlugu; i++)
            {
                for (int k = 0; k < taban; k++)
                {
                    if ((i + k >= ortaNokta && k - i <= ortaNokta))
                    {
                        Console.Write("*");
                    }
                    else if (i == ortaNokta)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();


            */


            
        } 
       

    }
}

