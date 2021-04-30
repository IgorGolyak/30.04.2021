using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.49 a
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            while (a != 0)
            {
                int a1 = a % 10;
                a = a / 10;
                if (a == 3)
                {
                    n++;
                }
            }
            if (n != 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.ReadKey();
        }
    }
}
