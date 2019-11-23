using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe:L");
            int x;
            uint liczba = uint.Parse(Console.ReadLine());
            bool[] tablica = new bool[liczba + 1];
            //wypełnenie tablicy
            for (int i = 1; i <= liczba; i++)
                tablica[i] = true;
            //sito Eratostenesa
            for (int i = 2; i <= liczba; i++)
            {
                if (tablica[i])
                {
                    x = i;
                    x = x + i;
                    while (x <= liczba)
                    {
                        tablica[x] = false;
                        x = x + i;
                    }
                    for ( i = 1; i <= liczba; i++)
                        if(tablica[i])

                        Console.WriteLine(i + "," );
                    if(tablica[liczba])
                    
                        Console.WriteLine("Liczba {0} jest liczbą pierwszą", liczba);
                    else
                        Console.WriteLine("Liczba {0} nie jest liczbą pierwszą", liczba);
                    


                }
            } 


            Console.ReadKey();
        }
    }
}
