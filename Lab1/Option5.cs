using System;
using static System.Math;
/*Lab 1 Option 5*/
namespace Lab1
{
    class Option5
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
            return 1 - 0.25 * Pow(Sin(2 * In), 2) + Cos(2 * In);
        }

        static double CalcZ(double In)
        {
            return Pow(Cos(In), 2) + Pow(Cos(In), 4);
        }
    }
}
