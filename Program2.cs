using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typy_wartościowe
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b = a;
            a--;
            b++;
            Console.WriteLine(a); //9
            Console.WriteLine(b); // 11

            //typ referencyjny
            int[] tabA = { 1, 2, 3 };
            int[] tabB = tabA;
            tabA[0] = 100;
            tabB[tabB.Length - 1] = 300;
            Console.WriteLine("\ntabA");
            foreach (int y in tabA)
            {
                Console.Write("{0}",y);
            }
            //Kopiowanie tablic
            int[] tab = { 1, 2, 3, 4, 5 };
            int[] tabCopy = new int[7];
            Console.WriteLine("tabCopy");
            foreach (int item in tabCopy)
            {
                Console.Write("{0}", item);
            }
            tab.CopyTo(tabCopy, 0);
            foreach (int item in tabCopy)
            {
                Console.Write("{0}", item);
            }
            Array.Copy(tab, tabCopy, 5);
            foreach (int item in tabCopy)
            {
                Console.Write("{0}", item);
            }


            Console.ReadKey();
        }
    }
}
