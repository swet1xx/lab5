using System;

namespace Lab5.Model
{
    public class Calculator
    {
        public double Calculate(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    if (num2 != 0)
                        return num1 / num2;
                    else
                        throw new DivideByZeroException("Ділення на нуль!");
                default:
                    throw new ArgumentException("Невідома операція");
            }
        }
    }
}