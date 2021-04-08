using System;
using System.Text.RegularExpressions;

namespace Lab9
{
    public static class Calculator
    {

        public static string AddToHistory(string mathOp, double first, double result, double second = 0)
        {
            string output = Regex.Replace(mathOp, "[x]", first.ToString());

            if (second == 0)
                return output + " = " + result;
            else
                return first + " " + mathOp + " " + second + " = " + result;

        }
        public static double Calculate(string mathOp, double first, double second = 0)
        {
            double result = 0;

            switch (mathOp)
            {
                case "+":
                    result = first + second;
                    break;
                case "-":
                    result = first - second;
                    break;
                case "×":
                    result = first * second;
                    break;
                case "÷":
                    result = first / second;
                    break;
                case "1/x":
                    result = 1 / first;
                    break;
                case "x²":
                    result = Math.Pow(first, 2);
                    break;
                case "√x":
                    result = Math.Sqrt(first);
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }

    }
}
