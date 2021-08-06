using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve İşlemli Atama 
            int x = 3;
            int y = 3;
            y += 2;
            y /= 1;
            x *= 2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            // Mantıksal operatorler 

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect");
            }


            if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great");
            }

            if (!isCompleted && isSuccess)
            {
                Console.WriteLine("Fine");
            }


            //İlişkisel Operatörler 
            int a = 3;
            int b = 4;

            bool sonuc = a > b;
            Console.WriteLine(sonuc);

            sonuc = a >= b;
            Console.WriteLine(sonuc);

            sonuc = a < b;
            Console.WriteLine(sonuc);

            sonuc = a <= b;
            Console.WriteLine(sonuc);

            sonuc = a == b;
            Console.WriteLine(sonuc);

            sonuc = a != b;
            Console.WriteLine(sonuc);

            //aritmetik operatörler

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;

            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 * sayi2;

            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 + sayi2;

            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 - sayi2;

            Console.WriteLine(sonuc1);

            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1--;
            Console.WriteLine(sonuc1);

            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);

        }
    }
}
