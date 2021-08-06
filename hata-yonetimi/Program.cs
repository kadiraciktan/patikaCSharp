using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı  : " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata : " + ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("işlem tamamlandı");
            }



            try
            {
                // int a = int.Parse("test");
                // int a = int.Parse(null);
                int a = int.Parse("111111111111");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş Değer Girdiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Değer çok küçük yada çok büyük");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("işlem tamamlandı");
            }



            Console.Read();
        }
    }
}
