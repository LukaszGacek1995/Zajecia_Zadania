using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiKalkulator
{
    public class UruchamianieProgramu4
    {
        public static void Uruchom()
        {
            Console.WriteLine("Kalkulator BMI");

            double masa = WprowadzanieDanych.WprowadzMase();
            double wzrost = WprowadzanieDanych.WprowadzWzrost();

            double bmi = ObliczBmi(masa, wzrost);

            WyswietlWynik(bmi);

            Console.ReadKey();
        }
        private static double ObliczBmi(double masa, double wzrost)
        {
            return masa / (wzrost * wzrost);
        }

        private static void WyswietlWynik(double bmi)
        {
            Console.WriteLine($"Twoje BMI wynosi: {bmi:F2}");

            Console.WriteLine("Klasyfikacja masy ciała:");

            if (bmi < 16.0)
            {
                Console.WriteLine("Wygłodzenie - niedowaga");
            }
            else if (bmi >= 16.0 && bmi < 16.99)
            {
                Console.WriteLine("Wychudzenie - niedowaga");
            }
            else if (bmi >= 17.0 && bmi < 18.49)
            {
                Console.WriteLine("Niedowaga");
            }
            else if (bmi >= 18.5 && bmi < 24.99)
            {
                Console.WriteLine("Pożądana masa ciała - optimum");
            }
            else if (bmi >= 25.0 && bmi < 29.99)
            {
                Console.WriteLine("Nadwaga");
            }
            else if (bmi >= 30.0 && bmi < 34.99)
            {
                Console.WriteLine("Otyłość I stopnia");
            }
            else if (bmi >= 35.0 && bmi < 39.99)
            {
                Console.WriteLine("Otyłość II stopnia (duża)");
            }
            else
            {
                Console.WriteLine("Otyłość III stopnia (chorobliwa)");
            }
        }
    }
}
