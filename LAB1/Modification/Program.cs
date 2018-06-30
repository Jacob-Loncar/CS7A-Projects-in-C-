using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, thou, hund, ten, one;
            string str;

            Console.WriteLine("Enter a 4 digit number");
            str = Console.ReadLine();
            num = int.Parse(str);

            Console.WriteLine("The number you chose was {0}\n", num);

            thou = num / 1000;
            hund = (num - (thou * 1000)) / 100;
            ten = (num - ((thou * 1000) + (hund * 100))) / 10;
            one = num % 10;

            Console.WriteLine("Heres your number backwards:");
            Console.WriteLine("{0} {1} {2} {3}", one, ten, hund, thou);

        }
    }
}
