using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(4,6);
            Console.ReadKey();
            Add(1, 2, 3);
            Console.WriteLine(SquareArea(5));
            Console.WriteLine(Add(1, 2, 3, 4));
            Data("Janusz");
            Console.ReadKey();

           
        }
        static void Add(int a, int b)
        {
             Console.WriteLine("Wynik dodawania: {0}",a+b);
         


        }
        static void Add(int a , int b, int c)
        {
            Console.WriteLine("Wynik dodawania: {0}", a+b+c);

        }
        static int SquareArea (int a)
        {
            return a * a;

        }
        static int Add(int a, int c,int d,int b=2)
        {
            return a * b * c;
        }
        static void Data(string name, string surname = "Nowak", int age = 20)
        {
            Console.WriteLine("Imię:{0}, nazwisko: {1}, wiek {2},", name, surname, age);
        }
    }
}
