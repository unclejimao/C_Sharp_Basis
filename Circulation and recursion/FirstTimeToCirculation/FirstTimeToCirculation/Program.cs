using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTimeToCirculation
{
    class Program
    {
        static void Main(string[] args)
        {
            //CircularPrinter printer = new CircularPrinter();
            //printer.PrintXTo1(3);

            Calculator calculator = new Calculator();
            calculator.RAdd1ToX(100);
            calculator.CAdd1ToX(100);
        }
    }

    class Calculator
    {
        public void CAdd1ToX(int x)
        {
            int res = 0;
            for (int i = 0; i < x+1; i++)
            {
                res += i;
            }
            Console .WriteLine (res);
        }

        int res = 0;

        public int RAdd1ToX(int x)
        {
            
            if (x == 1)
            {
                res += x;
                Console.WriteLine(res);
            }
            else
            {
                res += x;
                res = RAdd1ToX(x - 1);
            }
            return res;
        }
    }

    class CircularPrinter
    {
        public void PrintXTo1(int x)
        {
            if (x == 1)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(x);
                PrintXTo1(x - 1);
            }
        }
    }
}
