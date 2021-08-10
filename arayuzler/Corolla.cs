namespace arayuzler{
    public class Corolla : IOtomobil
    {
        public Marka hangiMarkaninAraci()
        {
           return Marka.Toyota;
        }

        public int kacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk standartRengiNe()
        {
           return Renk.Beyaz;
        }
    }
}