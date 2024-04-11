using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lomregn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int svar;
            Console.WriteLine("Velkommen til lommeregner. Vil du gerne *(gange), +(plusse), -(minus) eller /(dividere)?");
            string d = Console.ReadLine();
            Console.WriteLine("Vælg dit første tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vælg dit andet tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            if (d == "*")
            {
                svar = tal1 * tal2;
                Console.WriteLine("Svaret er " + svar);
            }
            Console.ReadKey();
        }
    }
}
