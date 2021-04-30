using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.34
            int a = 144;
            int n = 1;
            while (n < 15)
            {
                Console.WriteLine(a);
                a = a + 19;
                n = n + 1;
            }
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
