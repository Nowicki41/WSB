using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
       
        {
            Console.WriteLine(Sum(123));
            Console.ReadKey();

        }
        static int Sum(int x)
        {
            int result=0;
                do {
                    result = result+ x%10;
                    x/= 10;
                }
                while(x!=0);
            return result;
                }
        }
    }

//napisz funkcję, która wyświetli sumę cyfr w liczbie 123=1+2+3
