using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMUygulamasi
{
    public static class Menu
    {

        private static Dictionary<int, string> mainMenu = new Dictionary<int, string>();
        public static byte MainMenu()
        {
            if (mainMenu.Count<4)
            {
                mainMenu.Add(1, "Para Çekme");
                mainMenu.Add(2, "Bakiye Sorgulama");
                mainMenu.Add(3, "Para Yatırma");
                mainMenu.Add(4, "Para Gönderme");
            }
            foreach (var item in mainMenu)
            {
                Console.WriteLine("({0}) {1}", item.Key, item.Value);
            }
            byte code = 0;
            Console.WriteLine("İşlem Kodu : ");
            while (!byte.TryParse(Console.ReadLine(),out code))
            {
                Console.WriteLine("Hatalı Giriş! ");
                Console.WriteLine("--------------");
                Console.Write("İşlem Kodu : ");      
            }
            while (!mainMenu.ContainsKey(code))
            {
                Console.WriteLine("Hatalı Giriş! ");
                Console.WriteLine("--------------");
                Console.Write("İşlem Kodu : ");
                code = byte.Parse(Console.ReadLine());  
            }

            return code;
        }

        public static Kisi ParaGonderMenu()
        {
            Console.Clear();
            Console.Write("Göndermek İstediğiniz IBAN Numarasını Giriniz");
            string iban = Console.ReadLine().Trim();
            return Program.kisiler.FirstOrDefault(x => x.IBAN == iban);
        }



    }
}

