﻿namespace Sealed_Struct_Nullable_Enum.Services
{
    internal class CalculatorService
    {
        public string Calculation(double num1, string operation, double num2)
        {
            if (num2 == 0 && operation == "/")
            {
                return "Can't divide by zero";
            }

            switch (operation)
            {
                case "+":
                    return (num1 + num2).ToString();
                case "-":
                    return (num1 - num2).ToString();
                case "*":
                    return (num1 * num2).ToString();
                case "/":
                    return (num1 / num2).ToString();
                default:
                    return "Operation is wrong";
            }
        }
    }
}
