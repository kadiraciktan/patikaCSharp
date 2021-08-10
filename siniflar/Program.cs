using System;

namespace siniflar
{
//
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan{
                    Ad="Ayşe",
                    Soyad="Yılmaz",
                    No=23452343,
                    Departman="İnsan Kaynakları"
            };

            calisan1.CalisanBilgieri();


            Console.Read();

        }
    }
    class Calisan{
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgieri(){
            Console.WriteLine("Çalışan Adı : {0}",Ad);
            Console.WriteLine("Çalışan Soyadı : {0}",Soyad);
            Console.WriteLine("Çalışan Numarası : {0}",No);
            Console.WriteLine("Çalışan Departmanı : {0}",Departman);
        }
    }
}
