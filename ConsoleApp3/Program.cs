using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i,j] = random.Next(100);
                    Console.Write($"{array[i,j]}\t\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int max = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (max < array[j,i])
                    {
                        max = array[j,i];
                    }
                }
               Console.WriteLine(max);
            }
            Console.ReadKey();
        }
    }
}
