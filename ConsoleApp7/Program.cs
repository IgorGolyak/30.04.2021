using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.36
            int a = 100;
            int n = 0;
            while (n <= 10)
            {
                if (a%10 == 7 & a%9==0)
                {
                    n++;
                    Console.WriteLine(a);
                }
                a = a + 1;
            }
            Console.WriteLine(n);
            Console.ReadKey();

        }
    }
}
