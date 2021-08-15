Console.Write("Sayı Giriniz : ");
Ucgen.Ciz(int.Parse(Console.ReadLine()));




static class Ucgen
{
    public static void Ciz(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            for (int l = i - 1; l >= 1; l--)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}