using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class CalculationEngine  
    {
        public int DoMath(string stuffToCalculate)
        {
            //throw new NotImplementedException(); // Placeholder // ex] We want a failing test // 
            // return 4;
            //var splitNumbers = stuffToCalculate.Split('+');
            //int firstNumber = int.Parse(splitNumbers[0]);
            //int secondNumber = int.Parse(splitNumbers[1]);

            //return firstNumber + secondNumber;

            try
            {
                var splitNumbers = stuffToCalculate
                                        .Split('+')
                                        .Select(int.Parse);

                return splitNumbers.Sum();
            }
            // creating varable called [ex]
            catch(FormatException ex)
            {
                throw new InvalidInputException();
            }

            //var splitNumbers = stuffToCalculate.Split('+')
                //.Select(int.Parse).ToArray();

            //return splitNumbers[0] + splitNumbers[1];

        }
    }
}
