using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    public class NumberCounter
    {
        public static int CountDivisibleByFive(int strart, int end, int expected)
        {
            int counter = 0;
            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0) counter++;
            }
            Console.WriteLine("{0} numbers found.", counter);
            return counter;
        }
    }
}
