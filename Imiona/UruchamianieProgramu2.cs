using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imiona
{
    public class UruchamianieProgramu2
    {
        public static void Uruchom2()
        {
            WprowadzenieIWypisanie wprowadzenieIWypisanie = new WprowadzenieIWypisanie();
            wprowadzenieIWypisanie.DaneWejsciowe();

            List<string> listaImion = wprowadzenieIWypisanie.imiona;

            Console.WriteLine("Wprowadzone imion to:");

            foreach (string s in listaImion)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
