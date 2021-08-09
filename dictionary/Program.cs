using System;
using System.Collections.Generic;


namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections.Generic
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(10, "Ayşe Yılmaz");
            kullanicilar.Add(12, "Ahmet Yılmaz");
            kullanicilar.Add(18, "Deniz Arda");
            kullanicilar.Add(20, "Özcan Coşar");

            //Elemanlara erişim
            Console.WriteLine("--Elemanlara Erişim--");
            Console.WriteLine(kullanicilar[12]);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(kullanicilar.Count);
            Console.WriteLine("--Contains--");
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Kadir AÇIKTAN"));
            Console.WriteLine("--Remove--");
            kullanicilar.Remove(12);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--KEYS--");
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--values--");
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }

            Console.Read();



        }
    }
}
