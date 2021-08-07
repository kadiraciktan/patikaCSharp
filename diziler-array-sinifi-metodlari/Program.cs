using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = { 23, 12, 4, 84, 72, 3, 11, 17 };
            Console.WriteLine("Sırasız Dizi");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("Sıralı Dizi");

            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("Array Clear ");
            //dizideki elemanlardan verilen indexten başlayıp verilen sayıya kadar 0 lar
            Array.Clear(sayiDizisi, 2, 2);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //Reverse
            Console.WriteLine("Array Reverse ");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            //İndex of
            Console.WriteLine("Array İndexOf ");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            //Resize
            Console.WriteLine("Array Resize ");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;
             foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.Read();

        }
    }
}
