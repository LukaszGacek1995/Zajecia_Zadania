using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miasta
{
    public class WprowadzenieDanych
    {
       public List<string> miasta = new List<string>();
        public void Wprowadz()
        {
            Console.WriteLine("Wprowadz poniżej 5 miast, jedno pod drugim");

            for (int i = 0; i < 5; i++)
            {
                miasta.Add(Console.ReadLine());
            }
        }
    }
}
