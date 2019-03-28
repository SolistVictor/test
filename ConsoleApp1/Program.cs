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
            Int32 x, y;
            Console.Write("Введите длину - ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину - ");
            y = Convert.ToInt32(Console.ReadLine());
            if (x <= y)
            {
                Console.Write("Error");
                Console.ReadKey();
            }
            for (int i = 1; i <= y; i++)
            {
                for (int j = 1; j <= x; j++)
                {
                    if (i > 1 && j > 1 && i < y  && j < x )
                    {
                        Console.Write("1");
                    }
                    else
                        Console.Write("0");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        
    }
}
