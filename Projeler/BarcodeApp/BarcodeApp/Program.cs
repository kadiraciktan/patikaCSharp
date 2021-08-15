using IronBarCode;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace BarcodeApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = Environment.CurrentDirectory;
          
            string barkodAd, barkodIcerik;
            Dictionary<int, string> menu = new Dictionary<int, string>();
            menu.Add(1, "Barkod Oluştur");
            menu.Add(2, "Barkodu Göster");
        APoint:
            Console.WriteLine("----------------------------------------");

            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            byte code = 0;
            byte.TryParse(Console.ReadLine(), out code);

            if (code == 1)
            {

                Console.Write("Barkodunuzun Adını Giriniz : ");
                barkodAd = Console.ReadLine();
                Console.Write("Barkodun İçeriğini Giriniz : ");
                barkodIcerik = Console.ReadLine();
                BarcodeWriter.CreateBarcode(barkodIcerik, BarcodeWriterEncoding.QRCode).SaveAsJpeg($"{path}\\{barkodAd}.jpg");
                Console.WriteLine("Barkod Oluşturuldu");
                Process.Start("mspaint.exe", $"{path}\\{barkodAd}.jpg");
                goto APoint;
            }
            else if (code == 2)
            {

                Console.Write("Barkodunuzun Adını Giriniz : ");
                barkodAd = Console.ReadLine();
            
                BarcodeResult Result = BarcodeReader.QuicklyReadOneBarcode($"{path}\\{barkodAd}.jpg");
        
                if (Result != null )
                {
                    Console.Clear();
                    Process.Start("mspaint.exe", $"{path}\\{barkodAd}.jpg");
                    Console.WriteLine("Barkodunuzun İçindeki : {0}", Result.Text);
                    goto APoint;
                }
                else
                {
                    Console.WriteLine("Barkod Bulunamadı");
                    goto APoint;
                }

            }
            else
            {
                Console.WriteLine("Hatalı İşlem");
                goto APoint;
            }
        }
    }
}
