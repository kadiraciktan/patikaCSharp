using System;

namespace koleksiyonlar_soru_3
{
    class Program
    {
          static void Main(string[] args)
        {
            char[] sesliHarfler = { 'A', 'E','I','İ', 'O', 'Ö', 'U', 'Ü' };

            string metin = Console.ReadLine().ToUpper();

            List<char> includes = new List<char>();


            for (int i = 0; i < sesliHarfler.Length; i++)
            {
                if (metin.Contains(sesliHarfler[i]))
                {
                    includes.Add(sesliHarfler[i]);
                }
            }
            includes.Sort();

            char[] sortedList = includes.ToArray();

            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

    }
}
