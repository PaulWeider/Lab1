using System;
using static System.Math;
/*Lab 1 Option 4*/
namespace Lab1
{
    class Option4
    {
        /*static void Main(string[] args)
        {
            string userInput;

            Console.Write("Input a value here -> ");

            userInput = Console.ReadLine();

            Console.WriteLine($"Your Y is: {CalcY(double.Parse(userInput))}");
            Console.WriteLine($"Your Z is: {CalcZ(double.Parse(userInput))}");
        }*/

        static double CalcY(double In)
        {
            double numerator = (Sin(2 * In) + Sin(5 * In) - Sin(3 * In));
            double denominator = (Cos(In) - Cos(3 * In) + Cos(5 * In));

            return numerator / denominator;
        }

        static double CalcZ(double In)
        {
            return Tan(3 * In);
        }
    }
}
