using System;
using System.Collections;

namespace koleksiyonlar_soru_1
{
    class Program
    {
       static void Main(string[] args)
        {
            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayanlar = new ArrayList();


            int[] sayilar = SayiGiris(20);
            int asalToplam = 0;
            int asalOlmayanToplam = 0;

            foreach (var sayi in sayilar)
            {
                if (sayi % 2 > 0 && sayi % 1 == 0)
                {
                    asalToplam += sayi;
                    asalSayilar.Add(sayi);
                }
                else
                {
                    asalOlmayanToplam += sayi;
                    asalOlmayanlar.Add(sayi);
                }
            }

            Console.WriteLine("Girdiğiniz Sayılardan Asal Olanlar :");
            asalSayilar.Sort();
            asalSayilar.Reverse();
            for (int i = 0 ; i<asalSayilar.Count; i++)
            {
                Console.WriteLine(asalSayilar[i]);
            }

            Console.WriteLine("Girdiğiniz Sayılardan Asal Olmayanlar :");
            asalOlmayanlar.Sort();
            asalOlmayanlar.Reverse();
         
            for (int i =0 ; i <asalOlmayanlar.Count; i++)
            {
               
                Console.WriteLine(asalOlmayanlar[i]);
            }

            Console.WriteLine("------------------------------------------");

            Console.WriteLine(" Asal Sayılar : {0} Adet ve Ortalaması : {1} ",asalSayilar.Count,(asalToplam/asalSayilar.Count));
            Console.WriteLine(" Asal Olmayan Sayılar : {0} Adet ve Ortalaması : {1} ", asalOlmayanlar.Count, (asalOlmayanToplam / asalOlmayanlar.Count));

            Console.Read();
        }

        public static int[] SayiGiris(int count)
        {
            int[] sayilar = new int[count];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("{0}. Sayıyı Giriniz : ", i + 1);
                int sayi = 0;
                while (!int.TryParse(Console.ReadLine(), out sayi))
                {
                    Console.Write("Geçersiz Bir Sayı Girdiniz {0}. Sayıyı Tekrar Giriniz  : ", i + 1);
                }
                while (sayi < 0)
                {
                    Console.Write("Geçersiz Bir Sayı Girdiniz {0}. Sayıyı Pozitif Giriniz  : ", i + 1);
                    while (!int.TryParse(Console.ReadLine(), out sayi))
                    {
                        Console.Write("Geçersiz Bir Sayı Girdiniz {0}. Sayıyı Tekrar Giriniz  : ", i + 1);
                    }
                }
                sayilar[i] = sayi;
            }
            return sayilar;
        }

    }
}
