using System;
using System.Collections.Generic;

namespace proje_2
{
    class Program
    {
        public static List<Kart> todos = new List<Kart>();
        public static List<Kart> progress = new List<Kart>();
        public static List<Kart> dones = new List<Kart>();
        public static List<Kisi> member = new List<Kisi>();
        public static byte code;
        static void Main(string[] args)
        {
            member = TeamManager.DefaultTeam();

            do
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz : ");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                code = CodeControl();

                if (code == 1)
                {
                    TodoManager.Listele();
                }
                else if (code == 2)
                {
                    TodoManager.KartEkle();
                }
                else if (code == 3)
                {
                    TodoManager.KartSil();
                }
                else if (code == 4)
                {
                    TodoManager.KartTasi();
                }

            } while (code != 0);
        }



        public static byte CodeControl()
        {
            byte code = 0;
            Console.Write("İşlem Kodu : ");
            while (!byte.TryParse(Console.ReadLine(), out code) || code < 0)
            {
                Console.Write("İşlem Kodu Geçersiz! Tekrar Giriniz: ");
            }
            return code;

        }
    }
}
