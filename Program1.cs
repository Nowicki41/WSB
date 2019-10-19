using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   float a, b;
              Console.WriteLine("Podaj liczbę a:");
              if
                  (!float.TryParse(Console.ReadLine(), out a))
                  Console.WriteLine("Wprowadzono nieprawidłowo");

              else                      // jeśli parsownie OK to wprowadzenie liczby b
              {
                  Console.WriteLine("Podaj liczbę b:");
                  if (!float.TryParse(Console.ReadLine(), out b))
                      Console.WriteLine("Wprowadzono nieprawidłowo");

                  else //obie liczby są poprawne 
                  { if (a == -b) Console.WriteLine("Próba dzielenia przez zero");
                    else
                      {
                          Console.WriteLine("Wartość wyrażenia wynosi" + ((a * a + b) / ((a + b) * (a + b))));
                      }

                  }
              }
              */


            double a;
            double b;
            double c;

            Console.WriteLine("Podaj liczbę a:");
            if
                (!double.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Wprowadzono nieprawidłowo");

            else                      // jeśli parsownie OK to wprowadzenie liczby b
            {
                Console.WriteLine("Podaj liczbę b:");
                if (!double.TryParse(Console.ReadLine(), out b))
                    Console.WriteLine("Wprowadzono nieprawidłowo");

                else
                {

                    Console.WriteLine("Podaj liczbę c:");
                    if (!double.TryParse(Console.ReadLine(), out c))
                        Console.WriteLine("Wprowadzono nieprawidłowo");




                    else
                    {
                        if (c > 0)
                        {
                            Console.WriteLine("Wartość wyrażenia wynosi" + (a * a + b));
                        }
                    }
                    if (c < 0)
                    {
                        Console.WriteLine("Wartość wyrażenia wynosi" + (a - b * b));
                    }
                    if (a == b)
                    {
                        Console.WriteLine("Wprowadzono nieprawidłowo");


                    }
                    else
                    {
                        if (c == 0)

                        {

                            Console.WriteLine("Wartość wyrażenia wynosi" + 1 / (a - b));

                        }
                    }
                    Console.ReadKey();
                }







            }


        }
    }
}

