using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //list<T> class
            //system.collections.generic
            //T->Object türü

            List<int> sayiListesi= new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);


            List<string> renkListesi =  new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);


            foreach (var item in sayiListesi)
            {
                Console.WriteLine(item);
            }

            foreach (var item in renkListesi)
            {
                Console.WriteLine(item);
            }

            sayiListesi.ForEach(item=>Console.WriteLine(item));
            renkListesi.ForEach(item=>Console.WriteLine(item));


            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(item=>Console.WriteLine(item));
            renkListesi.ForEach(item=>Console.WriteLine(item));

            //Liste içerisinde arama
            if(sayiListesi.Contains(10)){
                Console.WriteLine("10 Bulundu");
            }
            
            //Eleman ile index e erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //Diziyi list e çevirme

            string[] hayvanlar = {"kedi","köpek","kuş"};

            List<string> hayvanListesi = new List<string>(hayvanlar);

            hayvanListesi.Clear();

            List<Kullanicilar> kullaniciListesi  =new List<Kullanicilar>();
            kullaniciListesi.Add(new Kullanicilar{
                Isim="Ali",
                Soyisim="Taş",
                Yas=23
            });

            foreach (var item in kullaniciListesi)
            {
                    Console.WriteLine(item.Isim + " " + item.Soyisim);
            }

            kullaniciListesi.Clear();

            Console.ReadLine();

        }

        public class Kullanicilar{
            private string isim;
            private string soyisim;
            private int yas;


            public string Isim{get=>isim;set=>isim=value;}
            public string Soyisim{get=>isim;set=>isim=value;}
            public int Yas{get=>isim;set=>isim=value;}
        }


        
        //Generic 
        private static void PrintArray<T>(T[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(param[0]);
            }
        }
    }
}
