using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imiona
{
    internal class WprowadzenieIWypisanie
    {
        public List<string> imiona = new List<string>();
        public void DaneWejsciowe()
        {
            Console.WriteLine("Wprowadź poniżej liczbę imion jaką chcesz wprowadzić");
            int liczbaImion = int.Parse(Console.ReadLine());

            Console.WriteLine("Wprowadz imiona jedno pod drugim");
            for (int i = 0; i < liczbaImion; i++)
            {
                imiona.Add(Console.ReadLine());
            }
        }
    }
}
