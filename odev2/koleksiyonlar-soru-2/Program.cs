using System;

namespace koleksiyonlar_soru_2
{
    class Program
    {
       
        static void Main(string[] args)
        {

            int[] sayilar = SayiGiris(20);
            Array.Sort(sayilar);

            float enKucukToplam = 0;
            for (int i = 0; i < 3; i++)
            {
                enKucukToplam += sayilar[i];
            }

            Array.Reverse(sayilar);
            float enBuyukToplam = 0;
            for (int i = 0; i < 3; i++)
            {
                enBuyukToplam += sayilar[i];
            }

            float enBuyukOrt = enBuyukToplam / 3;
            float enKucukOrt = enKucukToplam / 3;

            Console.WriteLine("En Küçük Sayıların Ortalaması :{0}", enKucukOrt);

            Console.WriteLine("En Büyük Sayıların Ortalaması :{0}", enBuyukOrt);

            Console.WriteLine("Ortalamaların Toplamı : {0}", enBuyukOrt + enKucukOrt);


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
