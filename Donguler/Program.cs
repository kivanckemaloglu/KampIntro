﻿using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç";
            string kurs3 = "Java";

            //array - dizi

            string[] kurslar = new string[] 
            { 
                "Yazılım Geliştirici Yetiştirme Kampı" , 
                "Programlamaya başlangıç", 
                "Java",
                "Python"
            };




            for (int i =0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");
        }
    }
}
