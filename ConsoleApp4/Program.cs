using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.33 b
            int b = 13;
            while (b < 100)
            {
                Console.WriteLine(b);
                b = b + 13;
            }
            Console.ReadKey();
        }
    }
}
