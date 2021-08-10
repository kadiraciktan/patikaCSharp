using System;

namespace arayuzler
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.hangiMarkaninAraci().ToString());
            Console.WriteLine(focus.kacTekerlektenOlusur().ToString());
            Console.WriteLine(focus.standartRengiNe().ToString());

            Civic civic = new Civic();
            Console.WriteLine(civic.hangiMarkaninAraci().ToString());
            Console.WriteLine(civic.kacTekerlektenOlusur().ToString());
            Console.WriteLine(civic.standartRengiNe().ToString());

            Console.Read();
        }
    }
}
