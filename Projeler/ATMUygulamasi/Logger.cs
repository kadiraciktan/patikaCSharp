using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMUygulamasi
{
    public enum LogTypes
    {
        Transaction=1,
        Fraud,
        Deposit

    }
    public static class Logger
    {
        public  static void CreateFile(LogTypes type,Kisi kisi,Kisi toTransaction,string islem)
        {
            string fileName = $"Logs/{type}_{DateTime.Now.ToShortDateString().Replace(".","")}.txt";

            string logString = "";
            if (type==LogTypes.Fraud)
            {
                logString = $"[{type}] [{DateTime.Now.ToShortDateString()} - {DateTime.Now.ToShortTimeString()}] {kisi.AdSoyad}  {islem}";

            }
            if (type==LogTypes.Transaction)
            {
                logString = $"[{type}] [{DateTime.Now.ToShortDateString()} - {DateTime.Now.ToShortTimeString()}]  {kisi.AdSoyad} to {toTransaction.AdSoyad}  - {islem}";
            }
            if (logString=="")
            {
                logString = $"Loglama Hatası : {DateTime.Now} Tarihinde Oluştu";
            }

            if (!File.Exists(fileName))
            {
                // Creating the same file if it doesn't exist
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine(logString);
                   
                }
            }

            // Appending the given texts
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(logString);
            
            }



            //Process.Start("notepad.exe", fileName);

        }
    }
}
