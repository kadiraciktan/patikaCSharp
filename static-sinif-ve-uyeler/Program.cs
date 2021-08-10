using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı  : {0}", Calisan.CalisanSayisi);
            Calisan calisan = new Calisan("kadir","açıktan","IK");
            Console.WriteLine("Çalışan sayısı  : {0}", Calisan.CalisanSayisi);

            Islemler.Topla(100,200);

        }
    }

    class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }

    }
    static class Islemler{
        public static long Topla(int sayi1,int sayi2){
            return sayi1+sayi2;
        }
    }
}
