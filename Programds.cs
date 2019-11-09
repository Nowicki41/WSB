using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, j, k;
            Console.WriteLine("Podaj rozmiar tabliczki mnozenia: ");
            a = int.Parse(Console.ReadLine());
            for (j = 1; j <= a; j++)
            {
                if (j == 1)
                {
                    Console.Write("");
                    Console.Write("\t{0}", j);
                }
                else
                {
                    Console.Write("\t{0}", j);

                }
            }
            for (i = 1; i <= a; i++)
            {
                Console.Write("\n {0}", i);
                for (k = 1; k <= a; k++)
                {
                    b = i * k;
                    Console.Write("\t{0}", b);
                }

            }
            Console.ReadKey();
        }
    }
}
