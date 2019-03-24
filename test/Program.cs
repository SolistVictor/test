using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число в диапозоне от 100 до 500 : ");
            String str = Console.ReadLine();
            Int32 number = Convert.ToInt32(str);                                                   
            if (number < 100)
                asfasfaf
            {
                Console.WriteLine("Читай внимательнее паскуда! Написанно же от 100 до 500.");
            }
            else if (number > 500)
            {
                Console.WriteLine("Oops! Too many.");
            }
            switch (number / 100)
            {
                case 1: str = " сто";
                    break;
                case 2: str = " двести";
                    break;
                case 3: str = " тристо";
                    break;
                case 4: str = " четыресто";
                    break;
                case 5: str = " пятьсот";
                    break;
            }
            switch ((number % 100)/10) 
            {
                case 1: str += " десять";
                    break;
                case 2: str += " двадцать";
                    break;
                case 3: str += " тридцать";
                    break;
                case 4: str += " сорок";
                    break;
                case 5: str += " пятьдесят";
                    break;
                case 6: str += " шестьдесят";
                    break;
                case 7: str += " семьдесят";
                    break;
                case 8: str += " восемьдесят";
                    break;
                case 9: str += " девяносто";
                    break;
            }
            switch (number % 10)
            {
                case 1: str += " один";
                    break;
                case 2: str += " два";
                    break;
                case 3: str += " три";
                    break;
                case 4: str += " четыре";
                    break;
                case 5:
                    str += " пять";
                    break;
                case 6:
                    str += " шесть";
                    break;
                case 7:
                    str += " семь";
                    break;
                case 8:
                    str += " восемь";
                    break;
                case 9:
                    str += " девять";
                    break;
            }
            Console.WriteLine(number + str);
            Console.ReadKey();
        }
    }
}
