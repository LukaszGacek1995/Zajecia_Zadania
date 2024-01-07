using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorZadanie
{
    public class Uruchamianie
    {
        public static void Uruchom()
        {
            WprowadzenieDanychIObliczenie wprowadzenieDanych = new WprowadzenieDanychIObliczenie();
            wprowadzenieDanych.DaneWejsciowe();

            decimal wynik = wprowadzenieDanych.ObliczanieOszczednosci();

            Console.WriteLine($"Łączna kwota oszczednosci to: {wynik}");
            Console.ReadKey();
        }
    }
}
