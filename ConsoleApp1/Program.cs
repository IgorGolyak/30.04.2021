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
            //6.31
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            int n = 0;
            int b = a;
            while (a != 0)
            {
                int a1 = a % 10;
                a = a / 10;
                if (a1 > max)
                {
                    max = a1;
                }
            }
            while (b != 0)
            {
                int b1 = b % 10;
                b = b / 10;
                if (b1 == max)
                {
                    n++;
                }
            }
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
