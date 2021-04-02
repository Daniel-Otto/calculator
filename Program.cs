using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // User Story "addition": As user I will input 2 numbers to calculate the sum.
            Console.Write("Please insert first summand! ... "); // user input, first summand for the addition
            string firstSummand = Console.ReadLine(); // wait for the user input save it in variable

            Console.Write("Please insert second summand! ... "); // user input, second summand for the addition
            string secondSummand = Console.ReadLine(); // wait for the user input and save it in variable


            Console.WriteLine("The result of the addition from {0} and {0} is: "); // program output, the result of the addition of the first and second summand
        }
    }
}
