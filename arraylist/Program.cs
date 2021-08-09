using System;
using System.Collections.Generic;
using System.Collections;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            // liste.Add("Ayşe");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('a');

            // Console.WriteLine(liste[1]);

            // foreach (var item in liste)
            // {
            //     Console.WriteLine(item);
            // }

            //AddRange

            // string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
            // liste.AddRange(renkler);

            List<int> sayilar = new List<int>() { 1, 2, 3, 4, 5 };

            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(liste);
            }

            // Sort
            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(liste);
            }

            //binary search
            liste.BinarySearch(9);

            foreach (var item in liste)
            {
                Console.WriteLine(liste);
            }


            //reverse 
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(liste);
            }

            liste.Clear();



            Console.Read();
        }
    }
}
