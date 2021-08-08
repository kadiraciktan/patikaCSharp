using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken =  "Dersimiz CSharp, Hoşgeldiniz";
            string degisken2  = "Dersimiz CSharp";

            //Length;
            Console.WriteLine(degisken.Length);

            //ToUpper ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            //Birleştirme yapar...
            Console.WriteLine(string.Concat(degisken," Merhaba"));


            // Compare, CompareTo
        
            Console.WriteLine(degisken.CompareTo(degisken2)); // 1==2 return 0 1>2 return 1 1<2 return -1
            Console.WriteLine(string.Compare(degisken,degisken2,true)); // true büyük küçük duyarlı false : duyarsız

            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));


            //indexOf
            Console.WriteLine(degisken.IndexOf("CS"));

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba! "));
            Console.WriteLine(degisken.LastIndexOf("i"));
            
            //padleft padright

            Console.WriteLine(degisken+degisken2.PadLeft(30,'*')); // degiskenin soluna 30 a tamamlanana kadar karakter ekler
            Console.WriteLine(degisken+degisken2.PadRight(50,'*')); // degiskenin sağına 50 ye tamamlanana kadar karakter ekler


            //Remove

            Console.WriteLine(degisken.Remove(5,3)); // 5 dan basla 3 tane sil

            //Replace

            Console.WriteLine(degisken.Replace("CSharp","C#"));

            //Split

            Console.WriteLine(degisken.Split(" ")[1]);


            //Substring
            Console.WriteLine(degisken.Substring(4,6)); // 4 den basla 6 tane al
            






            Console.ReadKey();
        }
    }
}
