using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu asdasdasdd");
                var choice = Console.ReadLine(); // user choice
                switch (choice)
                {
                    case "do smth":
                        {
                            //some action 
                            break;
                        }
                    case "do smth 2":
                        {
                            //some action 
                            break;
                        }
                    case "exit":
                        {
                            var key = Console.ReadKey();
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong input.");
                            Console.ReadKey();
                            break;
                        }
                }
                // some action
                Console.Clear();
            }

            try
            {
                throw new MyException();
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
            Console.WriteLine("Programm Success");
            Console.ReadLine();
        }
    }
}
