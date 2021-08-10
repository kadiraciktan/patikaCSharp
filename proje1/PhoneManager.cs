using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
    public class PhoneManager : IPhoneBook
    {
        ContactManager cm;
        public static List<Kisi> kisiler = new List<Kisi>();
        public PhoneManager()
        {
            cm = new ContactManager();
            kisiler = cm.DefaultContacts();
        }

        public void Listele()
        {


            Console.Write("Sıralama Yönünü Seçiniz [A/Z] : ");
            string onay = Console.ReadLine();
            while (onay != "A" && onay != "Z")
            {
                Console.Write("Geçerli Bir Kod Girin A veya Z : ");
                onay = Console.ReadLine();
            }
            if (onay == "A")
            {
                kisiler = kisiler.OrderBy(x => x.Ad).ToList();
            }
            else if (onay == "Z")
            {
                kisiler = kisiler.OrderByDescending(x => x.Ad).ToList();
            }

            foreach (var item in kisiler)
            {
                Console.WriteLine($"İsim : {item.Ad}");
                Console.WriteLine($"Soyisim : {item.Soyad}");
                Console.WriteLine($"Numara : {item.Numara}");
                Console.WriteLine("------------------------------------------------");
            }
        }

        public void Bul()
        {
            byte code = 0;
            Kisi item = new Kisi();
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            Console.Write("İşlem Kodu : ");
            while (!byte.TryParse(Console.ReadLine(), out code) && code != 1 && code != 2)
            {
                Console.Write("İşlem Kodu Hatalı Tekrar Giriniz : ");
            }

            if (code == 1)
            {
                Console.Write("İsim Yada Soyisim Giriniz : ");
                string adsoyad = Console.ReadLine();
                item = cm.NumaraBul(adsoyad);
            }
            else if (code == 2)
            {
                Console.Write("Telefon Giriniz : ");
                string tel = Console.ReadLine();
                item = cm.NumaraBulTel(tel);
            }
            Console.Clear();
            if (item != null)
            {
                Console.WriteLine($"İsim : {item.Ad}");
                Console.WriteLine($"Soyisim : {item.Soyad}");
                Console.WriteLine($"Numara : {item.Numara}");
                Console.WriteLine("------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.");
            }

        }

        public void NumaraGuncelle()
        {
            Console.WriteLine("------------------------------------------------");
            Console.Write(" Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz : ");
            string adsoyad = Console.ReadLine();

            Kisi item = cm.NumaraBul(adsoyad);

            if (item != null)
            {
                Console.Write("Yeni Numarayı Giriniz");
                string tel = Console.ReadLine();
                item.Numara = tel;

                Console.Write("{0} İsimli Kayıt Güncellenecek Onaylıyormusunz [Y/N] : ", item.Ad);
                string onay = Console.ReadLine();
                while (onay != "Y" && onay != "N")
                {
                    Console.Write("Geçerli Bir Kod Girin Y veya N : ");
                    onay = Console.ReadLine();
                }
                if (onay == "Y")
                {
                    cm.NumaraSil(item);
                    cm.NumaraKaydet(item);
                    Console.Clear();
                }
                Console.WriteLine("------------------------------------------------");
                Console.Write("Kayıt Güncellendi");
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için      : (2)");
                byte sonuc;
                while (!byte.TryParse(Console.ReadLine(), out sonuc))
                {
                    Console.Write("Geçersiz Kod. Tekrar Giriniz : ");
                }

                if (sonuc == 2)
                {
                    NumaraGuncelle();
                }
            }
        }

        public void NumaraKaydet()
        {
            Console.Clear();
            Console.Write("İsim Giriniz ");
            string isim = Console.ReadLine();
            Console.Write("Soyisim Giriniz ");
            string soyisim = Console.ReadLine();
            Console.Write("Numara Giriniz ");
            string numara = Console.ReadLine();

            if (cm.NumaraKaydet(new Kisi { Ad = isim, Soyad = soyisim, Numara = numara }))
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Kayıt Eklendi");
            }

        }

        public void NumaraSil()
        {

            Console.WriteLine("------------------------------------------------");
            Console.Write(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz : ");
            string adsoyad = Console.ReadLine();

            Kisi item = cm.NumaraBul(adsoyad);

            if (item != null)
            {
                Console.WriteLine($"İsim : {item.Ad}");
                Console.WriteLine($"Soyisim : {item.Soyad}");
                Console.WriteLine($"Numara : {item.Numara}");
                Console.WriteLine("------------------------------------------------");
                Console.Write("{0} İsimli Kayıt Silinecek Onaylıyormusunz [Y/N] : ", item.Ad);
                string onay = Console.ReadLine();
                while (onay != "Y" && onay != "N")
                {
                    Console.Write("Geçerli Bir Kod Girin Y veya N : ");
                    onay = Console.ReadLine();
                }

                if (cm.NumaraSil(item))
                {
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Numara Silindi.");
                    Console.WriteLine("------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("Yeniden denemek için      : (2)");
                byte sonuc;
                while (!byte.TryParse(Console.ReadLine(), out sonuc))
                {
                    Console.Write("Geçersiz Kod. Tekrar Giriniz : ");
                }

                if (sonuc == 2)
                {
                    NumaraSil();
                }
            }


        }
    }
}
