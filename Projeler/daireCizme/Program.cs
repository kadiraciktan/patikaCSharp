Console.Write("Sayı Giriniz : ");
Daire.Ciz(int.Parse(Console.ReadLine()));

public static class Daire
{

    public static void Ciz(int x)
    {
        int i, j;
        int N = x;
        for (i = 1; i <= N; i++)
        {
            for (j = 1; j <= N; j++)
            {
                if ((i == 1 || i == N) && (j == 1 || j == N))
                {
                    Console.Write(" ");
                }
                else if (i == 1 || i == N || j == 1 || j == N)
                {

                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.Write("\n");
        }
    }
}