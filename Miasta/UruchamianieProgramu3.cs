using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miasta
{
    public class UruchamianieProgramu3
    {
        public static void Uruchom()
        {
            WprowadzenieDanych wprowadzenieDanychIWypisanie3 = new WprowadzenieDanych();
            List<string> listaMiast = wprowadzenieDanychIWypisanie3.miasta;

            wprowadzenieDanychIWypisanie3.Wprowadz();

            int liczbaMiast = listaMiast.Count;

            Console.WriteLine(liczbaMiast);
            Console.ReadKey();
        }
    }
}
