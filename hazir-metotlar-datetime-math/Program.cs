using System;

namespace hazir_metotlar_datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddMinutes(4));
            Console.WriteLine(DateTime.Now.AddSeconds(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(40));

            Console.WriteLine(DateTime.Now.ToString("dd")); // 23
            Console.WriteLine(DateTime.Now.ToString("ddd")); //sat
            Console.WriteLine(DateTime.Now.ToString("dddd")); //saturday

            Console.WriteLine(DateTime.Now.ToString("MM")); //04
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // april

            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));


            //Math Kütüphanesi 
            Console.WriteLine(Math.Abs(-25)); // MUTLAK DEĞER
            Console.WriteLine(Math.Sin(-25)); // Sinüs
            Console.WriteLine(Math.Cos(-25)); //kosinüs
            Console.WriteLine(Math.Tan(-25)); // tanjant


            Console.WriteLine(Math.Ceiling(22.3)); // yukarı yuvarlar
            Console.WriteLine(Math.Floor(22.7));   // aşağı yuvarlar
            Console.WriteLine(Math.Round(22.3));   // hangisine yakınsa

            Console.WriteLine(Math.Max(2, 6));
            Console.WriteLine(Math.Min(2, 6));

            Console.WriteLine(Math.Pow(3, 4)); // 3 üssü 4
            Console.WriteLine(Math.Sqrt(9));  // karekök
            Console.WriteLine(Math.Log(9));  // 9 un e tabanundaki logaritmik karşılığı
            Console.WriteLine(Math.Exp(3)); // e üzeri 3
            Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşılığı
            







            Console.Read();
        }
    }
}
