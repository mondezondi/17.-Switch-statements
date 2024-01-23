using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Switch_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (1-3: ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("You entered '1'");
                    break;
                case 2:
                    Console.WriteLine("You entered '2'");
                    break;
                case 3:
                    Console.WriteLine("You entered '3'");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3. ");
                    break;
            }
            Console.ReadLine();
        }
    }
}

