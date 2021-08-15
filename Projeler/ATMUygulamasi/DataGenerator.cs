using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMUygulamasi
{
    public static class DataGenerator
    {
        public static List<Kisi> Kisiler = new List<Kisi>() {
            new Kisi{AdSoyad="Ahmet Torungil",Bakiye=4358.35f,IBAN="400012344321",Sifre="1233",TC="432548757899"},
            new Kisi{AdSoyad="Seda Tek",Bakiye=4.35f,IBAN="400012344322",Sifre="3333",TC="20045874125"},
            new Kisi{AdSoyad="Yeliz Doruk",Bakiye=43538.35f,IBAN="400012344323",Sifre="3434",TC="45678912311"},
            new Kisi{AdSoyad="Osman Saygılı",Bakiye=44324.35f,IBAN="400012344324",Sifre="4444",TC="175123456788"},
        };
    }
}
