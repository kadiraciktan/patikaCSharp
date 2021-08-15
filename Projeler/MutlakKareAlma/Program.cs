
int count;
Console.Write("Kaç Adet  Gireceksiniz : ");

while (!int.TryParse(Console.ReadLine(), out count))
{
    Console.Write("Geçersiz Bir Sayı Girdiniz Tekrar Giriniz  : ");
}

int[] sayilar = SayiGiris(count);
List<int> kucukler = new List<int>();   
List<int> buyukler = new List<int>();
int farklar = 0;
double mutlak = 1;
foreach (var item in sayilar)
{
    if (item>=68)
    {
        buyukler.Add(item);
    }
    if (item<67)
    {
       kucukler.Add(item);
    }
}
foreach (var item in buyukler)
{
    mutlak -= item;
}
foreach (var item in kucukler)
{
    farklar = farklar - item;
}



Console.WriteLine(Math.Abs(mutlak*mutlak));

Console.WriteLine(Math.Abs(farklar));

static int[] SayiGiris(int count)
{
    int[] sayilar = new int[count];
    for (int i = 0; i < sayilar.Length; i++)
    {
        Console.Write("{0}. Sayıyı Giriniz : ", i + 1);
        int sayi = 0;
        while (!int.TryParse(Console.ReadLine(), out sayi))
        {
            Console.Write("Geçersiz Bir Sayı Girdiniz {0}. Sayıyı Tekrar Giriniz  : ", i + 1);
        }
        while (sayi < 0)
        {
            Console.Write("Geçersiz Bir Sayı Girdiniz {0}. Sayıyı Pozitif Giriniz  : ", i + 1);
            while (!int.TryParse(Console.ReadLine(), out sayi))
            {
                Console.Write("Geçersiz Bir Sayı Girdiniz {0}. Sayıyı Tekrar Giriniz  : ", i + 1);
            }
        }
        sayilar[i] = sayi;
    }
    return sayilar;
}

