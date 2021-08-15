Console.Write("Metin Giriniz : ");
string metin = Console.ReadLine().ToUpper();

char[] sesliler = new char[] { 'A','E','I','İ','O','Ö','U','Ü' };


int sessizSayi = 0;
foreach (var item in metin)
{
    if (!sesliler.Contains(item))
    {
        sessizSayi++;
    }
    else if (sessizSayi==2)
    {
        Console.WriteLine(true);
    }
    else
    {
        sessizSayi--;
        if (sessizSayi<=0)
        {
            sessizSayi = 0;
        }
    }
}
if (sessizSayi<2)
{
    Console.WriteLine(false);
}

Console.Read();
