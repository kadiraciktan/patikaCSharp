using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            byte b = 5; // 1 byte
            sbyte sb = 5; // 1byte

            short s = 5; //2 byte
            ushort us = 5; //2 byte

            Int16 i16 = 2; //2 byte
            int i = 2;  // 4 byte
            Int32 i32 = 2; //4 byte

            Int64 i64 = 2; // 8 byte

            uint ui = 2; // 4 byte
            long l = 4; // 8 byte
            ulong ul = 4; //8 byte

            // - reel sayılar
            float f = 5; // 4 byte 
            double d = 5; //8 byte
            decimal de = 5; // 16 byte

            char c = '2'; // 2 byte
            string st = ""; // Sınırsız

            bool bl = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            //string ifadeler

            string str1 = string.Empty;
            str1 = "Kadir";
            string str2 = "Açıktan";
            string fullName = str1 + str2;



            //integer ifadeler
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;


            //boolean

            bool boolean1 = 10 > 2;

            //Değişken dönüşümleri 

            string str20 = "20";
            int int20 = 20;
            string yenideger = str20 + int20.ToString();

            Console.WriteLine(yenideger);


            //datetime 


            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);


            string hour  = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);







        }
    }
}
