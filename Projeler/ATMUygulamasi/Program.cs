using ATMUygulamasi;


public class Program
{
    public static List<Kisi> kisiler = new List<Kisi>();

    public static void Main(string[] args)
    {

        kisiler = DataGenerator.Kisiler;
    APoint:
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Malum Bank -- Hoşgeldiniz");
        Console.WriteLine("--------------------------------");

        Console.Write("Lütfen TC Numaranızı Giriniz : ");
        string tc = Console.ReadLine().Trim();
        Kisi kisi = kisiler.FirstOrDefault(x => x.TC == tc);
        if (kisi is null)
        {
            Console.WriteLine("Geçersiz TC Girişi!");
            goto APoint;
        }
        Console.Clear();
        Console.Write("Lütfen 4 Haneli Şifrenizi Giriniz : ");
        string pwd = Console.ReadLine().Trim();
        if (kisi.Sifre != pwd)
        {
            Console.WriteLine("Geçersiz Şifre Girişi!");
            goto APoint;
        }

        Console.Clear();
    BPoint:

        Console.WriteLine("--------------------------------");
        Console.WriteLine("Malum Bank -- Hoşgeldiniz");
        Console.WriteLine("--------------------------------");
        byte code = Menu.MainMenu();

        //Para Çek
        if (code == 1)
        {
            float amount = 0f;

            Console.Write("Çekmek İstediğiniz Miktarı Belirtiniz : ");
            float.TryParse(Console.ReadLine(), out amount);

            if (amount > 0 && amount <= kisi.Bakiye)
            {
                kisi.Bakiye -= amount;
                Console.WriteLine("Lütfen Paranızı Ve Kartınızı Alınız");
            }
            else
            {
                Logger.CreateFile(LogTypes.Fraud, kisi, null, "Geçersiz Miktar Hatası");
                Console.WriteLine("Geçersiz Miktar");
                goto BPoint;
            }
        }
        //Bakiye Sorgula
        if (code == 2)
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            Console.WriteLine("Mevcut Bakiyeniz : {0}", kisi.Bakiye);
            Console.WriteLine("----------------------");
            goto BPoint;
        }
        //Para Yatırma
        if (code == 3)
        {
            Console.Clear();
            Console.WriteLine("Yatırmak İstediğiniz Miktarı Giriniz : ");
            float amount = 0f;
            float.TryParse(Console.ReadLine(), out amount);

            if (amount>0)
            {
                kisi.Bakiye += amount;
                Console.WriteLine("Paranız Sayılıyor. Lütfen Bekleyin");
                Console.WriteLine("Paranız Yatırıldı");

                Logger.CreateFile(LogTypes.Deposit, kisi, null, $"Value:{amount}  / İşlem Başarılı");
            }
            else
            {
                Logger.CreateFile(LogTypes.Fraud, kisi, null, "Geçersiz Miktar Hatası");
                Console.WriteLine("Geçersiz Miktar");
            }

        }
        //Para Gönder
        if (code == 4)
        {
            var to = Menu.ParaGonderMenu();
            if (to is null)
            {
                Console.Clear();
                Console.WriteLine("IBAN GEÇERSİZ");
                goto BPoint;
            }
            else
            {
                Console.WriteLine("Miktar Giriniz : ");
                float.TryParse(Console.ReadLine(), out float amount);
                if (amount > 0)
                {
                    if (ATMOperations.ParaGonder(kisi, to, amount) == Operasyonlar.Basarili)
                    {
                        Console.WriteLine("Para Gönderildi. İşlem Tamamlandı.");
                        goto BPoint;
                    }
                    else
                    {
                        Console.WriteLine("Miktar Hesabınızda Mevcut Değil.");
                        goto BPoint;
                    }
                }
                else
                {
                    Console.WriteLine("Miktar GEÇERSİZ. Lütfen Kartınızı Alınız. ");
                }

            }
        }

        Console.Read();

    }
}

