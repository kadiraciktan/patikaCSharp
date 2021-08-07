using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";

            //Sayının parse edilip edilemeyeceğine bakıp ediliyorsa sayıyı out ile gönderir
            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı", outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(2, 3, out int sonucToplama);
            Console.WriteLine(sonucToplama);

            //Metot Aşırı Yükleme

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Kadir","AÇIKTAN");

            


            Console.Read();
        }

        class Metotlar
        {

            public void Topla(int a, int b, out int toplam)
            {
                toplam = a + b;
            }

            public void EkranaYazdir(int veri)
            {
                Console.WriteLine(veri);
            }

            public void EkranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }

            public void EkranaYazdir(int veri, int veri2)
            {
                Console.WriteLine(veri + veri2);
            }


            public void EkranaYazdir(string veri, string veri2)
            {
                Console.WriteLine(veri + veri2);
            }

        }
    }
}
