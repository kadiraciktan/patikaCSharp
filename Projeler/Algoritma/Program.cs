Console.Write("Yazı Giriniz : ");
string[] yazi = Console.ReadLine().Split(',');

if (yazi.Length==2)
{
    string metin = yazi[0];
    int.TryParse(yazi[1],out int sira);
    if (sira<=metin.Length && sira>0)
    {
        metin = metin.Remove(sira,1);
       
    }
    Console.WriteLine("Sonuc : {0}", metin);
}
