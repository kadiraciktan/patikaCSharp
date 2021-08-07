using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
             //While 
             // 1 den başlayarak console dan girilen sayıya kadar ortalama hesaplayıp console a yazıran program
             Console.Write("Lütfen bir sayı giriniz: ");
             int sayi = int.Parse(Console.ReadLine());
             int sayac = 1;
             int toplam = 0;

             while(sayac<=sayi){
                 toplam+=sayac;
                 sayac++;
             }
             Console.WriteLine(toplam/sayi);


             // a dan z ye kadar olan tüm harfleri console a yazdır
            char character = 'a';
            while(character<='z'){
                Console.WriteLine(character);
                character++;
            }

            //FOREACH

            string[] arabalar = {"BMW","Ford","Nissan","Toyota"};


            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }






            Console.Read();
        }
    }
}
