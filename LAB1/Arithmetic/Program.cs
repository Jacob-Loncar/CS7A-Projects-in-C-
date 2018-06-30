using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    class Program
    {
        static void Main()
        {
            int     sum, diff, prod, modu, av;
            double  x, y, div, pw;
            Console.WriteLine("\n\n\n");
            Console.WriteLine("ARITHMETIC\n");
            Console.WriteLine("Enter in two numbers:");
            string line = Console.ReadLine();
            int a = int.Parse(line);
            line = Console.ReadLine();
            int b = int.Parse(line);

            sum = a + b;
            diff = a - b;
            prod = a * b;
            x = (double)a;
            y = (double)b;
            div = x / y;
            modu = a % b;
            pw = Math.Pow(a, b);
            av = Math.Abs(a - b);

            Console.WriteLine("\n");
            Console.WriteLine("The numbers you entered were {0} and {1}", a, b);
            Console.WriteLine("The sum is {0}.", sum);
            Console.WriteLine("The difference is {0}.", diff);
            Console.WriteLine("The product is {0}.", prod);
            Console.WriteLine("The quotient is {0}.", div);
            Console.WriteLine("The modulus is {0}.", modu);
            Console.WriteLine("{0} raised to {1} equals {2}.", a, b, pw);
            Console.WriteLine("The absolute value of {0} minus {1} is {2}.", a, b, av);
            Console.WriteLine("\n\n\n");
        }
    }
}
