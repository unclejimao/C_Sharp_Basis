using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace ConsoleHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,World");
            double result = Calculator.Div(3, 0);
            Console.WriteLine(result);
        }
    }
}
