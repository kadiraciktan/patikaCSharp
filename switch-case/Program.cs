using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] aylar = new string[] { "", "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };
            int month = DateTime.Now.Month;

            //Easy Mode : 
            // Console.WriteLine(aylar[month] + " Ayındasınız"); 


            switch (month)
            {
                case 1:
                    Console.WriteLine(aylar[month] + "  Ayındasınız");
                    break;
                case 2:
                    Console.WriteLine(aylar[month] + " Ayındasınız");
                    break;
                case 3:
                    Console.WriteLine(aylar[month] + " Ayındasınız");
                    break;
                case 4:
                    Console.WriteLine(aylar[month] + " Ayındasınız");
                    break;
                case 5:
                    Console.WriteLine(aylar[month] + " Ayındasınız");
                    break;
                case 6:
                    Console.WriteLine(aylar[month] + " Ayındasınız");
                    break;
                case 7:
                    Console.WriteLine(aylar[month] + " Ayındasınız");
                    break;
                case 8:
                    Console.WriteLine(aylar[month] + " Ayındasınız");
                    break;
                default:
                    Console.WriteLine("Uzaydasınız!");
                    break;
            }


            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    // 12 1 2 ise yaz : 
                    Console.WriteLine("Kış");
                    break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar");
                    break;


                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar");
                    break;
                default:
                    break;
            }

            Console.Read();
        }
    }
}
