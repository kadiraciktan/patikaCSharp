using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMUygulamasi
{
    public static class ATMOperations
    {
        public static Operasyonlar ParaGonder(Kisi fwd,Kisi to,float amount)
        {
            if (amount>0)
            {
                if (amount > fwd.Bakiye)
                {
                    Logger.CreateFile(LogTypes.Fraud, fwd, null, "Para Göndereme Hatası");
                    return Operasyonlar.YetersizBakiye;
                }
                else if (fwd.IBAN == to.IBAN)
                {
                    Logger.CreateFile(LogTypes.Fraud, fwd, null, "Aynı IBAN Hatası");
                    return Operasyonlar.YetersizBakiye;
                }
                else
                {
                    fwd.Bakiye -= amount;
                    to.Bakiye += amount;
                    Logger.CreateFile(LogTypes.Transaction, fwd, to, $"Amount : {amount} /  TRANSFER BAŞARILI");
                    return Operasyonlar.Basarili;
                }
            }
            else
            {
                Logger.CreateFile(LogTypes.Fraud, fwd, null, "Geçersiz Miktar Hatası");
                return Operasyonlar.YetersizBakiye;

            }
            

        }
    }
}
