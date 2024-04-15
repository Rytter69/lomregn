using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lomregn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool mere = true;
            bool loop = true;

            while (mere)
            {
                int svar;
                Console.WriteLine("Velkommen til lommeregner. Vil du gerne *(gange), +(plusse), -(minus) eller /(dividere)?");

                string Regneart = Console.ReadLine();

                int tal1;
                while (true)
                {
                    Console.WriteLine("Vælg dit første tal");

                    string input1 = Console.ReadLine();

                    if (!Int32.TryParse(input1, out tal1))
                    {
                        Console.WriteLine("Du skrev et bogstav prøv igen");
                        tal1 = 0;
                    }
                    else
                    {
                        break;
                    }
                }

                int tal2;
                while (true)
                {
                    Console.WriteLine("Vælg dit andet tal");

                    string input2 = Console.ReadLine();

                    if (!Int32.TryParse(input2, out tal2))
                    {
                        Console.WriteLine("Du skrev et bogstav prøv igen");
                        tal2= 0;
                    }
                    else
                    {
                        break;
                    }
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


                while (loop == true)
                { 
                    Console.WriteLine("Igen (Ja) (Nej)");
                    string igen = Console.ReadLine();

                    if (igen == "Ja")
                    {
                        Console.Clear();
                        loop = false;
                    }

                    else if (igen == "Nej")
                    {
                        Console.WriteLine("Lukker");
                    }                        

                    else if (igen != "Ja" && igen != "Nej")
                    {
                        Console.WriteLine("Skriv venligst et (Ja) eller (Nej)");
                    }
                }
            }
        }
    }
}