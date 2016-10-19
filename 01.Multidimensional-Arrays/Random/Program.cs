using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Power(5, 5));
        }

        static int Power(int number, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            else if (power == 1)
            {
                return number;
            }
            else
            {
                power--;
                return number * Power(number, power);
            }
        }
    }
}
