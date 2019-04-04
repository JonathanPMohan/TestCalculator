using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new CalculationEngine();
            Console.WriteLine("Give me an addition problem, please");
            var input = Console.ReadLine();

            try
            {
                var result = calculator.DoMath(input);
                Console.WriteLine($"The result of your problem is {result}");
            }
            catch (InvalidInputException )
            {
                Console.WriteLine("This is an invalid input");
            }
        }
    }
}
