using System;

namespace enumlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 32;
            if(sicaklik <=(int)HavaDurumu.Normal){
                Console.WriteLine("Havanın biraz daha ısınmasını bekleyebilirsiniz");
            }else if(sicaklik>=(int)HavaDurumu.Sıcak){
                Console.WriteLine("Dışarıya Çıkmak İçin Çok Sıcak");
            }else if(sicaklik>=(int)HavaDurumu.Normal && sicaklik<(int)HavaDurumu.CokSıcak) {
                Console.WriteLine("Hava dışarı çıkmaya uygun");
            }

            Console.Read();
        }
    }

    enum Gunler{
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu{
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        CokSıcak = 30
    }
}
