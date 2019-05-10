using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            Console.WriteLine(str1 + str2);
            int x = Convert.ToInt32(str1);
            int y = Convert.ToInt32(str2);
            Console.WriteLine(x + y);
        }
    }
}
