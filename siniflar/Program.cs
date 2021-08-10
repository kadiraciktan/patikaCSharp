using System;

namespace siniflar
{
    //
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan
            {
                Ad = "Ayşe",
                Soyad = "Yılmaz",
                No = 23452343,
                Departman = "İnsan Kaynakları"
            };

            calisan1.CalisanBilgieri();

            Calisan calisan2 = new Calisan("Kadir", "AÇIKTAN", 112391, "Yazılım");
            calisan2.CalisanBilgieri();

            Calisan calisan3 = new Calisan("Kadir", "AÇIKTAN");
            calisan3.CalisanBilgieri();

            Console.Read();

        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan()
        {

        }
        public Calisan(string ad, string soyad, int no, string departaman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Departman = departaman;
            this.No = no;
        }


        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;

        }

        public void CalisanBilgieri()
        {

            Console.WriteLine("----------------------------");
            Console.WriteLine("Çalışan Adı : {0}", Ad);
            Console.WriteLine("Çalışan Soyadı : {0}", Soyad);
            Console.WriteLine("Çalışan Numarası : {0}", No);
            Console.WriteLine("Çalışan Departmanı : {0}", Departman);
        }
    }
}
