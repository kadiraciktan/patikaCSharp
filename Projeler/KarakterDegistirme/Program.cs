Console.Write("Metin Giriniz : ");

string metin = Console.ReadLine();

char[] dizi = metin.ToCharArray();  

char temp = dizi[0];    

char last =  dizi[dizi.Length - 1];

dizi[0] = last;
dizi[dizi.Length - 1] = temp;

foreach (var item in dizi)
{
    Console.Write(item);
}

Console.Read();