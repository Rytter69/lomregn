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
            bool mere = true;

            while (mere)
            {
                string hahah;
                int svar;
                Console.WriteLine("Velkommen til lommeregner. Vil du gerne *(gange), +(plusse), -(minus) eller /(dividere)?");

                string Regneart = Console.ReadLine();

                Console.WriteLine("Vælg dit første tal");

                int tal1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Vælg dit andet tal");

                int tal2 = Convert.ToInt32(Console.ReadLine());

                hahah = "Hjælp mig ";

                if (Regneart == "-")
                {
                    svar = tal1 - tal2;
                    Console.WriteLine("Svaret er " + svar);
                    Console.WriteLine(hahah);
                }

                if (Regneart == "*")
                {
                    svar = tal1 * tal2;
                    Console.WriteLine("Svaret er " + svar);
                }

                if (Regneart == "+")
                {
                    svar = tal1 + tal2;
                    Console.WriteLine("Svaret er " + svar);
                }

                if (Regneart == "/")
                {
                    svar = tal1 / tal2;
                    Console.WriteLine("Svaret er " + svar);
                }


                Console.WriteLine("Igen (Ja) (Nej)");
                string igen = Console.ReadLine();

                if (igen == "Ja")
                {
                    Console.WriteLine("Jeg vil ud");
                }

                else if (igen == "Nej")
                {
                    mere = false;
                }

            }
        }
    }
}