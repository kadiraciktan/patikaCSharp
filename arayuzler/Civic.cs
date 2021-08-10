namespace arayuzler{
    public class Civic : IOtomobil
    {
        public Marka hangiMarkaninAraci()
        {
           return Marka.Honda;
        }

        public int kacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk standartRengiNe()
        {
           return Renk.Gri;
        }
    }
}