namespace arayuzler{
    public class Focus : IOtomobil
    {
        public Marka hangiMarkaninAraci()
        {
           return Marka.Ford;
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