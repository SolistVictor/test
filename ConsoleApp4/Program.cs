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
            int[,] arr = new int[5, 5];
            Random rnd = new Random();

            //int dimension = arr.GetUpperBound(0) +1;
            // int dimensionLenghth = arr.GetUpperBound(1) + 1;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(-100, 100);

                    Console.Write($"{arr[i, j]} \t\t"); // Console.Write("{0,5}", arr[i,j]);

                }
                Console.WriteLine();
            }

            Console.WriteLine();
            int minElem = arr[0, 0];
            int maxElem = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (minElem > arr[i, j])
                    {
                        minElem = arr[i, j];
                        Console.Write($"{minElem}\t");
                    }

                    if (maxElem < arr[i, j])
                    {
                        maxElem = arr[i, j];
                        Console.Write($"{maxElem}\t");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
