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
<<<<<<< HEAD
<<<<<<< HEAD
            bool mere = true;

            while (mere)
            {
                string hahah;
                int svar;
                Console.WriteLine("Velkommen til lommeregner. Vil du gerne *(gange), +(plusse), -(minus) eller /(dividere)?");

                string d = Console.ReadLine();

                Console.WriteLine("Vælg dit første tal");

                int tal1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Vælg dit andet tal");
                 
                int tal2 = Convert.ToInt32(Console.ReadLine());

                hahah = "Hjælp mig ";

                if (d == "-")
                {
                    svar = tal1 - tal2;
                    Console.WriteLine("Svaret er " + svar);
                    Console.WriteLine(hahah);
                }

                if (d == "*")
                {
                    svar = tal1 * tal2;
                    Console.WriteLine("Svaret er " + svar);
                }

                if (d == "+")
                {
                    svar = tal1 + tal2;
                    Console.WriteLine("Svaret er " + svar);
                }

                if (d == "/")
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
=======
            Console.WriteLine("Hello, World!");
            Thread.Sleep(10000);
            Console.WriteLine("Rytter er fed og sutter bearnaise");
>>>>>>> parent of 15dbe5b (gange)
=======
            Console.WriteLine("Hello, World!");
            Thread.Sleep(10000);
            Console.WriteLine("Rytter er fed og sutter bearnaise");
>>>>>>> parent of 15dbe5b (gange)
        }
    }
}
