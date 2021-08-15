Console.Write("Sayı Giriniz : ");
int sayi = int.Parse(Console.ReadLine());
float sayi1 = 0;
float sayi2 = 1;
float sayi3 = 0;
for (int i = 0; i < sayi; i++)
{
    sayi3 = sayi1 + sayi2;
    sayi1 = sayi2;
    sayi2 = sayi3;
}

Console.WriteLine("Girdiğiniz Sayının Fibonacci Ortalaması : {0}", sayi3 / sayi);
