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
            {


                /*
                 * Użytkownik podaje z klawiatury dane dwóch boków
                 * Oblicz pole prostokąta i obwód
                 * 
                 * Wyświetl w formacie:
                 * Pole prostokąta wynosi: ...
                 * Obwód prostokąta wynosi: ...
                 * 
                 * Sprawdź czy dane z klawiatury są poprawne
                 * W przypadku błędnych danych wyświetl na ekranie komunikat:
                 * "Podałeś błędne dane"
                 */
                
                Console.Write("Podaj bok b:");
                string b = Console.ReadLine();
                int liczba;
                Console.Write("Podaj bok c:");
                int liczba1;
                string c = Console.ReadLine();

                if (int.TryParse(b, out liczba) == false || int.TryParse(c, out liczba1) == false)
                {

                    Console.WriteLine("Podałeś błędne dane");
                }
                else
                {


                    double bokb = double.Parse(b) * double.Parse(c);
                double bokc = 2 * double.Parse(b) + 2 * double.Parse(c);


                //boka = boka * boka
                
                    Console.WriteLine("Pole prostokąta wynosi: " + bokb);
                    Console.WriteLine("Obwód prostokąta wynosi: " + bokc);
                }
            }
        }
    }
}
