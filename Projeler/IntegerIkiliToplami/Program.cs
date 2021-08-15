Console.Write("Kaç Adet Sayı İkilisi Gireceksiniz ?  :");
int count  = int.Parse(Console.ReadLine());
string[] ikililer = new string[count];
for (int i = 0; i < count; i++)
{
    ikililer[i] = Console.ReadLine(); 
}

foreach (var item in ikililer)
{
    int sayi1 = int.Parse(item.Split(' ')[0]);
    int sayi2 = int.Parse(item.Split(' ')[1]);
    if (sayi1!=sayi2)
    {
        Console.WriteLine(sayi1 + sayi2);
    }
    else
    {
        Console.WriteLine(sayi1 * sayi1);
    }
}

Console.Read();

