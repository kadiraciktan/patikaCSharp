using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje1
{
    public abstract class Contact
    {
        public virtual List<Kisi> DefaultContacts()
        {
            List<Kisi> contactList = new List<Kisi>();
            contactList.Add(new Kisi() { Ad = "Ali Osman", Soyad = "ŞEN", Numara = "0555555555" });
            contactList.Add(new Kisi() { Ad = "Vecihi", Soyad = "ŞEN", Numara = "05444444444" });
            contactList.Add(new Kisi() { Ad = "Şaban", Soyad = "SUNAL", Numara = "05333333333" });
            contactList.Add(new Kisi() { Ad = "Mahmut", Soyad = "ÖZKUL", Numara = "05522222222" });
            contactList.Add(new Kisi() { Ad = "Melek", Soyad = "NAŞİT", Numara = "05511111111" });
            return contactList;
        }
    }

    public interface IContact
    {
        public bool NumaraKaydet(Kisi param);
        public bool NumaraSil(Kisi param);
        public bool NumaraGuncelle(Kisi param);
        public Kisi NumaraBul(string adsoyad);
        public Kisi NumaraBulTel(string tel);
    }

    public class ContactManager : Contact, IContact
    {
        public override List<Kisi> DefaultContacts()
        {
            return base.DefaultContacts();
        }

        public Kisi NumaraBul(string adsoyad)
        {
            return PhoneManager.kisiler.FirstOrDefault(x => x.Ad == adsoyad || x.Soyad == adsoyad);
        }

        public Kisi NumaraBulTel(string tel)
        {
            return PhoneManager.kisiler.FirstOrDefault(x => x.Numara == tel);
        }

        public bool NumaraGuncelle(Kisi param)
        {

            return true;
        }

        public bool NumaraKaydet(Kisi param)
        {
            PhoneManager.kisiler.Add(param);
            return true;
        }

        public bool NumaraSil(Kisi param)
        {
            PhoneManager.kisiler.Remove(param);
            return true;
        }
    }
}
