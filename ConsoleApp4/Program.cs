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
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(-100, 100);

                    Console.Write($"{arr[i, j]} \t\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int indexIMin = 0; int indexJMin = 0; int indexIMax = 0; int indexJMax = 0;
            int minElem = 0;
            int maxElem = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (minElem > arr[i, j])
                    {
                        minElem = arr[i, j];                                              
                            indexIMin = i;
                            indexJMin = j;                                         
                    }
                    if (maxElem < arr[i, j])
                    {
                        maxElem = arr[i, j];
                        indexIMax = i;
                        indexJMax = j;
                    }
                }
            Console.WriteLine(minElem);
            Console.WriteLine(maxElem +"\n");
            Console.WriteLine($"{indexIMin} {indexJMin}");
            Console.WriteLine($"{indexIMax} {indexJMax} \n");
            int sum = 0;
            bool solution = false;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i == indexIMin && j == indexJMin) || (i == indexIMax && j == indexJMax))
                    {
                        solution = !solution;
                        continue;
                    }
                    if (solution)
                        sum += arr[i, j];
                }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
