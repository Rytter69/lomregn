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
                int svar;
                Console.WriteLine("Velkommen til lommeregner. Vil du gerne *(gange), +(plusse), -(minus) eller /(dividere)?");

                string Regneart = Console.ReadLine();

                Console.WriteLine("Vælg dit første tal");

                int tal1;
                try
                {
                    tal1 = Int32.Parse(Regneart);
                }
                catch
                {
                    Console.WriteLine("Venligst brug et tal i stedet for et bogstav");
                    tal1 = 900;
                }

                Console.WriteLine("Vælg dit andet tal");

                string input2 = Console.ReadLine();
                int tal2;
                try
                {
                    tal2 = Convert.ToInt32(input2);
                }
                catch
                {
                    Console.WriteLine("Du skrev ikke et tal jeg vægler 20");
                    tal2= 20;
                }

                if (Regneart == "-")
                {
                    svar = tal1 - tal2;
                    Console.WriteLine("Svaret er " + svar);
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
                    Console.Clear();
                }

                else if (igen == "Nej")
                {
                    mere = false;
                }
            }
        }
    }
}
