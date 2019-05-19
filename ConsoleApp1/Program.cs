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
            int?[] a = new int?[14];
            int?[] b = new int?[15];
            int?[] c = new int?[14];

            FillArrayWithRandomNumbers(a);
            FillArrayWithRandomNumbers(b);

            var counter = 0;
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < b.Length; j++)
                    if (a[i] == b[j] && !Contains(a[i], c))
                    {
                        c[counter] = a[i];
                        counter++;
                    }


            for (int i = 0; i < c.Length; i++)
                if(c[i] != 0)
                    Console.WriteLine(c[i] + " ");
            

            //int n = 0;
            //int m = 0;
            //for (int i = 0; i < c.Length; i++)
            //{
            //    if (a[n] == b[m])
            //    {
            //        c[i] = a[n];
            //        Console.WriteLine($"{c[n]}");
            //    }
            //    n++; m++;
            //}


            Console.ReadKey();
        }

        private static bool Contains(int? element, int?[] target)
        {
            for (int k = 0; k < target.Length; k++)
                if (target[k] == element)
                    return true;
            
            return false;
        }

        private static void FillArrayWithRandomNumbers(int?[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(10);
            
        }
    }
    }
