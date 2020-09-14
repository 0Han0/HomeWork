using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dNET
{
    static class Calculator
    {
        public static int GetNumber()
        {
            var a = int.Parse(Console.ReadLine());
            return a;
        }
        public static int Calculate(int num1, string operation, int num2)
        {
            switch (operation)
            {
                case "+": return num1 + num2;
                case "-": return num1 - num2;
                case "/": return num1 / num2;
                case "*": return num1 * num2;
                default: throw new ArgumentException("invalid operation");
            }
        }
    }
}
