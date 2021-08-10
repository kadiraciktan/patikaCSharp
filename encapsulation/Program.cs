using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci("kadir", "açıktan", 3, 14);
            ogrenci.OgrenciBilgileriGetir();
            Console.Read();
        }

    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif; set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf En Az 1 Olabilir");
                    sinif = 1;
                }
                else
                {
                    sinif = value;
                }
            }
        }

        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci() { }

        public void OgrenciBilgileriGetir()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Adı : {0}", this.Isim);
            Console.WriteLine("Soyadı : {0}", this.Soyisim);
            Console.WriteLine("Öğrenci No : {0}", this.OgrenciNo);
            Console.WriteLine("Sınıfı : {0}", this.Sinif);

        }

    }
}
