Console.Write("Yazı Giriniz : ");
string metin = Console.ReadLine();
char[] dizi = metin.ToCharArray();
foreach (var item in dizi.Reverse())
{
    Console.Write(item);
}