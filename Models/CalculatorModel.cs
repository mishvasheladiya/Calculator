using System;

namespace CalculatorApp.Models
{
    public class CalculatorModel
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double Result { get; set; }
        public string Operator { get; set; }

        public void Calculate()
        {
            switch (Operator)
            {
                case "+":
                    Result = FirstNumber + SecondNumber;
                    break;
                case "-":
                    Result = FirstNumber - SecondNumber;
                    break;
                case "*":
                    Result = FirstNumber * SecondNumber;
                    break;
                case "/":
                    if (SecondNumber != 0)
                        Result = FirstNumber / SecondNumber;
                    else
                        throw new DivideByZeroException("Cannot divide by zero.");
                    break;
                default:
                    throw new InvalidOperationException("Invalid operator");
            }
        }
    }
}
