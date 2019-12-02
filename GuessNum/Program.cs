using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numarGhicit = 30;
            int user = 0;

            while (user != numarGhicit)
            {
                Console.Write("Introduceti un numar: ");
                int.TryParse(Console.ReadLine(), out user);

                if (user > numarGhicit)
                {
                    Console.WriteLine("{0} este prea mare!", user);
                }
                else if (user < numarGhicit)
                {
                    Console.WriteLine("{0} este prea mic!", user);
                }
                else
                {
                    Console.WriteLine("{0} este numarul corect. Felicitari!", user);
                }
            }
        }
    }
}
