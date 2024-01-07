using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorZadanie
{
    internal class WprowadzenieDanychIObliczenie
    {
        public decimal kwotaStartowa { get; set; }
        public decimal odkładaKwotaCoMiesiac { get; set; }
        public int liczbaMiesiecy { get; set; }

        public void DaneWejsciowe()
        {
            Console.WriteLine("Wprowadź poniżej kwotę startową");
            kwotaStartowa = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Wprowadź poniżej odkładaną kwotę co miesiąc");
            odkładaKwotaCoMiesiac = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Wprowadź poniżej liczbe miesiący");
            liczbaMiesiecy = int.Parse(Console.ReadLine());
        }

        public decimal ObliczanieOszczednosci()
        {
            decimal sumaOdkladana = odkładaKwotaCoMiesiac * liczbaMiesiecy;

            decimal KwotaOstatecznaOszczednosci = kwotaStartowa + sumaOdkladana;

            return kwotaStartowa;
        }
    }
}
