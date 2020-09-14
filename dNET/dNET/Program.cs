using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dNET
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Calculator.GetNumber();
            var b = Calculator.GetNumber();
            Console.WriteLine(Calculator.Calculate(a,"+",b));
        }
    }
}
