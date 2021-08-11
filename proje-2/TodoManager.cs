using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_2
{

    public static class TodoManager
    {
        public static void KartEkle()
        {
            Kart kart = new Kart();
            Console.Clear();
            Console.Write("Başlık Giriniz  :");
            kart.Baslik = Console.ReadLine();
            Console.Clear();
            Console.Write("İçerik Giriniz  :");
            kart.Icerik = Console.ReadLine();
            Console.Clear();
            Console.Write("Büyüklük Giriniz XS(1),S(2),M(3),L(4),XL(5)");
            kart.Buyukluk = (Buyukluk)Program.CodeControl();


            Console.Clear();
            Console.WriteLine("Kişi Seçiniz : ");
            Console.WriteLine("---------------");
            foreach (var item in Program.member)
            {
                if (item.Takim == "C#")
                {
                    Console.WriteLine("({0}) {1}", item.Id, item.AdSoyad);
                }

            }
            kart.Kisi = Program.CodeControl();
            while (string.IsNullOrEmpty(TeamManager.GetMember(kart.Kisi)))
            {
                Console.Write("Geçersiz Kişi. Tekrar Giriniz : ");
                kart.Kisi = Program.CodeControl();
            }




            Program.todos.Add(kart);
            Console.Clear();
            Console.WriteLine("Kart Başarıyla Eklendi");
            Console.WriteLine("----------------------");
        }

        public static void KartTasi()
        {
            Console.Write("Lütfen Kart Başlığı Yazınız : ");
            string baslik = Console.ReadLine();

            Kart kart = KartiBul(baslik);

            if (kart == null) { Console.WriteLine("Kart Bulunamadı"); }
            else
            {
                Console.WriteLine("Lütfen Taşımak İstediğiniz Line'ı Seçiniz");
                Console.WriteLine("(1) TODO ");
                Console.WriteLine("(2) IN PROGRESS ");
                Console.WriteLine("(3) DONE");
                byte code = Program.CodeControl();
                if (code==1)
                {
                    Program.todos.Add(kart);
                    Program.progress.Remove(kart);
                    Program.dones.Remove(kart);

                }
                else if (code==2)
                {
                    Program.todos.Remove(kart);
                    Program.progress.Add(kart);
                    Program.dones.Remove(kart);
                }
                else if (code == 3)
                {
                    Program.todos.Remove(kart);
                    Program.progress.Remove(kart);
                    Program.dones.Add(kart);
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim Yaptınız");
                }

                Console.Clear();
                Console.WriteLine("Kart Başarıyla Taşındı");
                Console.WriteLine("----------------------");


            }


        }

        public static Kart KartiBul(string baslik)
        {
            
            Kart k = Program.todos.FirstOrDefault(x => x.Baslik == baslik);
            if (k != null)
            {
                Console.WriteLine("Kart Bilgileri");
                Console.WriteLine($"Başlık      : {k.Baslik}");
                Console.WriteLine($"İçerik      : {k.Icerik}");
                Console.WriteLine($"Atanan Kişi : {TeamManager.GetMember(k.Kisi)}");
                Console.WriteLine($"Büyüklük    : {k.Buyukluk}");
                Console.WriteLine($"Line        : TODO ");
                return k;
            }

            k = Program.progress.FirstOrDefault(x => x.Baslik == baslik);

            if (k != null)
            {
                Console.WriteLine("Kart Bilgileri");
                Console.WriteLine($"Başlık      : {k.Baslik}");
                Console.WriteLine($"İçerik      : {k.Icerik}");
                Console.WriteLine($"Atanan Kişi : {TeamManager.GetMember(k.Kisi)}");
                Console.WriteLine($"Büyüklük    : {k.Buyukluk}");
                Console.WriteLine($"Line        : IN PROGRESS ");
                return k;
            }

            k = Program.dones.FirstOrDefault(x => x.Baslik == baslik);
            if (k != null)
            {
                Console.WriteLine("Kart Bilgileri");
                Console.WriteLine($"Başlık      : {k.Baslik}");
                Console.WriteLine($"İçerik      : {k.Icerik}");
                Console.WriteLine($"Atanan Kişi : {TeamManager.GetMember(k.Kisi)}");
                Console.WriteLine($"Büyüklük    : {k.Buyukluk}");
                Console.WriteLine($"Line        : DONE ");
                return k;
            }

            return null;

        }

        public static void KartSil()
        {
            Console.Write("Lütfen Kart Başlığı Yazınız : ");
            string baslik = Console.ReadLine();
            byte totalDeleted = 0;

            Kart k = Program.todos.FirstOrDefault(x => x.Baslik == baslik);

            if (k != null)
            {

                Program.todos.Remove(k);
                Console.WriteLine("Kart TODO dan silindi");
                totalDeleted++;
            }

            k = Program.progress.FirstOrDefault(x => x.Baslik == baslik);

            if (k != null)
            {

                Program.progress.Remove(k);
                Console.WriteLine("Kart INPROGRESS dan silindi");
                totalDeleted++;
            }

            k = Program.dones.FirstOrDefault(x => x.Baslik == baslik);
            if (k != null)
            {
                Program.dones.Remove(k);
                Console.WriteLine("Kart DONE dan silindi");
                totalDeleted++;
            }

            if (totalDeleted == 0)
            {
                Console.WriteLine("Herhangi bir Kart Bulunamadı");
            }
            else
            {
                Console.WriteLine($"{totalDeleted} adet kart silindi.");
            }

        }

        public static void Listele()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("----------------------");

            if (Program.todos.Count < 1)
            {
                Console.WriteLine("~BOŞ~");
            }
            else
            {
                foreach (var item in Program.todos)
                {
                    Console.WriteLine($"Başlık      : {item.Baslik}");
                    Console.WriteLine($"İçerik      : {item.Icerik}");
                    Console.WriteLine($"Atanan Kişi : {TeamManager.GetMember(item.Kisi)}");
                    Console.WriteLine($"Büyüklük    : {item.Buyukluk}");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("----------------------");

            if (Program.progress.Count < 1)
            {
                Console.WriteLine("~BOŞ~");
            }
            else
            {
                foreach (var item in Program.progress)
                {
                    Console.WriteLine($"Başlık      : {item.Baslik}");
                    Console.WriteLine($"İçerik      : {item.Icerik}");
                    Console.WriteLine($"Atanan Kişi : {TeamManager.GetMember(item.Kisi)}");
                    Console.WriteLine($"Büyüklük    : {item.Buyukluk}");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("DONE Line");
            Console.WriteLine("----------------------");

            if (Program.dones.Count < 1)
            {
                Console.WriteLine("~BOŞ~");
            }
            else
            {
                foreach (var item in Program.dones)
                {
                    Console.WriteLine($"Başlık      : {item.Baslik}");
                    Console.WriteLine($"İçerik      : {item.Icerik}");
                    Console.WriteLine($"Atanan Kişi : {TeamManager.GetMember(item.Kisi)}");
                    Console.WriteLine($"Büyüklük    : {item.Buyukluk}");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("");
        }

    }
}
