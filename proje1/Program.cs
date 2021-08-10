using System;

namespace proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoş Geldiniz!");
            PhoneManager pm = new PhoneManager();
            byte code;
            do
            {
                Console.WriteLine("Lütfen Yapmak İstediğinniz İşlemi Seçiniz: ");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncellemek");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                Console.WriteLine("(0) Çıkış Yapmak");
                Console.WriteLine("------------------------------------------------");
                Console.Write("İşlem Kodu : ");
                while (!byte.TryParse(Console.ReadLine(), out code))
                {
                    Console.WriteLine("Geçersiz Kod Girdiniz. Tekrar Deneyiniz...");
                    Console.Write("İşlem Kodu : ");
                    
                }
                Console.Clear();
                if (code == 1)
                {
                    pm.NumaraKaydet();
                }
                else if (code == 2)
                {
                    pm.NumaraSil();
                }
                else if (code == 3)
                {
                    pm.NumaraGuncelle();
                }
                else if (code == 4)
                {
                    pm.Listele();
                }
                else if (code == 5)
                {
                    pm.Bul();
                }
                else if(code!=0)
                {
                    Console.WriteLine("Geçersiz Kod Girdiniz. Tekrar Deneyiniz...");
                }
            } while (code != 0);






        }
    }
}
