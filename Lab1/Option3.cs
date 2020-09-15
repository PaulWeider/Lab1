using System;
using static System.Math;
/*Lab 1 Option 3*/
namespace Lab1
{
    class Option3
    {
        static void Main(string[] args)
        {
            string userInput;

            Console.Write("Input a value here -> ");

            userInput = Console.ReadLine();

            Console.WriteLine($"Your Y is: {CalcY(double.Parse(userInput))}");
            Console.WriteLine($"Your Z is: {CalcZ(double.Parse(userInput))}");
        }

        static double CalcY(double In)
        {
            double numerator = (Sin(2 * In) + Sin(5 * In) - Sin(3 * In));   //числитель
            double denominator = (Cos(In) + 1 - (2 * Pow(Sin(2 * In), 2))); //знаменатель

            return numerator / denominator;
        }

        static double CalcZ(double In)
        {
            return 2 * Sin(In);
        }
    } 
}
