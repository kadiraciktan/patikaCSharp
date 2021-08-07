using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Odev 1-3
            // int count;
            // Console.Write("Kaç Adet  Gireceksiniz : ");

            // while (!int.TryParse(Console.ReadLine(), out count))
            // {
            //     Console.Write("Geçersiz Bir Sayı Girdiniz Tekrar Giriniz  : ");
            // }

            //  Metotlar.Odev1(count);

            //  Metotlar.Odev3(count);
            #endregion


            #region odev 2
            Metotlar.Odev2();
            #endregion


            #region Odev 4
            // Console.Write("Bir Cümle Girimiz : ");
            // string cumle = Console.ReadLine();
            // Metotlar.Odev4(cumle);
            #endregion


            Console.WriteLine("Çıkmak için Enter a Basın");
            Console.Read();

        }

    }


    public static class Metotlar
    {

        public static void Odev1(int count)
        {
            int[] sayilar = SayiGiris(count);
            foreach (var item in sayilar)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine("{0} sayisi çift sayıdır.", item);
                }
            }
        }


        public static void Odev2()
        {
            Console.WriteLine("2 Adet Sayı Giriniz ");
            Console.WriteLine("---------------------");
            int[] sayilar = Metotlar.SayiGiris(2);
            int n = sayilar[0];
            int m = sayilar[1];
            Console.WriteLine("{0} Adet Sayı Giriniz", n);
            int[] girilenSayilar = Metotlar.SayiGiris(n);
            foreach (var item in girilenSayilar)
            {
                if (item % m == 0)
                {
                    Console.WriteLine("Girmiş Olduğunuz {0} Sayısı {1} Sayısına Bölünüyor", item, m);
                }
            }


        }


        public static void Odev3(int count)
        {
            string[] reversed = Metotlar.KelimeGiris(count);
            Array.Reverse(reversed);

            foreach (var item in reversed)
            {
                Console.WriteLine(item);
            }

        }


        public static void Odev4(string cumle)
        {
            char[] harfler = cumle.Replace(" ", "").ToCharArray();
            Console.WriteLine("Toplam Harf Sayısı : {0}", harfler.Length);
            string[] kelimeler = cumle.Split(" ");
            Console.WriteLine("Toplam Kelime Sayısı : {0}", kelimeler.Length);

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



        public static string[] KelimeGiris(int count)
        {
            int[] sayilar = new int[count];
            string[] kelimeler = new string[count];
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("{0}. Kelimeyi Giriniz : ", i + 1);
                string kelime = Console.ReadLine();
                kelimeler[i] = kelime;
            }

            return kelimeler;
        }


    }
}
