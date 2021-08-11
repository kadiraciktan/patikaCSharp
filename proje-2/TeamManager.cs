using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_2
{
    public static class TeamManager
    {
        public static List<Kisi> DefaultTeam()
        {
            return new List<Kisi>() { 
            new Kisi() { AdSoyad="Kadir AÇIKTAN",Id=1,Takim="C#" },
            new Kisi() { AdSoyad="Ali Osman TEK",Id=2,Takim="PHP" },
            new Kisi() { AdSoyad="Ayşe SOYLU",Id=3,Takim="C#" },
            new Kisi() { AdSoyad="Okan VURGUN",Id=4,Takim="NODE" },
            new Kisi() { AdSoyad="Kerem ÇİÇEK",Id=5,Takim="C#" }
            };
        }

        public static string GetMember(int member)
        {
            Kisi k = Program.member.FirstOrDefault(x => x.Id == member);
            if (k!=null)
            {
                return k.AdSoyad;
            }
            else
            {
                return "";
            }
        
        }

    }
}
