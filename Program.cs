using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Switch_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 3");
            int number = int.Parse(Console.ReadLine());

            switch(number)
            {
                case 1: Console.WriteLine("you have entered 1");
                        break;
                case 2:
                    Console.WriteLine("you have entered 2");
                    break;
                case 3:
                    Console.WriteLine("you have entered 3");
                    break;

                    default: Console.WriteLine("Invalid, please enter number between 1 and 3");
                    break;
            }
            Console.ReadLine();
        }
    }
}
