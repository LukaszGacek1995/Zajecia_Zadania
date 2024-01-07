using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiKalkulator
{
    public class WprowadzanieDanych
    {
        public static double WprowadzMase()
        {
            double masa;

            Console.Write("Podaj wagę w kg: ");
            while (!double.TryParse(Console.ReadLine(), out masa) || masa <= 0)
            {
                Console.WriteLine("Nieprawidłowa waga. Podaj ponowenie");
            }

            return masa;
        }

        public static double WprowadzWzrost()
        {
            double wzrost;

            Console.Write("Podaj wzrost w metrach: ");
            while (!double.TryParse(Console.ReadLine(), out wzrost) || wzrost <= 0)
            {
                Console.WriteLine("Nieprawidłowa wartość. Podaj wzrost ponownie.");
            }

            return wzrost;
        }
    }
}
