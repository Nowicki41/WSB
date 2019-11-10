using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjątki1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            uint number = 0;
            while (true)
            {
                Console.Write("Wproadź liczbę całkowitą:");
                x = Console.ReadLine();
                try
                {
                     number = uint.Parse(x);
                    break;
                }
                catch (SystemException e)
                {
                    Console.WriteLine("error:{0}", e.Message);
                }
            }
 
            try
            {
                 number = uint.Parse(x);
            }
            catch (SystemException e)

            
            {
                Console.WriteLine("error:{0}",e.Message);
            }
            Console.ReadKey();
        }
    }
}
