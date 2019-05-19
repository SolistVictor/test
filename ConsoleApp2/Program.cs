using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //палиндром


            //string str = Console.ReadLine();
            //char[] reverse = str.ToCharArray();
            //Array.Reverse(reverse);
            //string rts = new string(reverse);
            //if (str == rts)
            //{
            //    Console.Write("Палиндром");
            //}
            //else
            //    Console.Write("No");
            ////
            //Console.WriteLine();
            ////Подсчитать кол-во слов в строке
            string text = Console.ReadLine();
            var a = text.Split(' ');
            var b = a.Count();
            //int count = 1;
            //foreach (char item in text)
            //{
            //    if (item == ' ')
            //    {
            //        count++;
            //    }

            //}
            //Console.Write(count);
        }
    }
}