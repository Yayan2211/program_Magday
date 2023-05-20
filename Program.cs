using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramMagday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a 6-digit number: ");
            string userInput = Console.ReadLine();

            if (userInput.Length == 6 && int.TryParse(userInput, out int number))
            {
                int originalNumber = number;
                int lastDigit = number % 10;
                number /= 10;

                int remainder = number % 7;

                Console.WriteLine(remainder == lastDigit ? "true" : "false");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a 6-digit number.");
            }

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
