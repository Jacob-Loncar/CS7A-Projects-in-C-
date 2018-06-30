using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThousandSeperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.PartOne();
            Program.PartTwo();
        }
        
        static void PartOne()
        {
            int num, thou, hund, ten, one;
            string str;

            Console.WriteLine("Pick a number between 1000 and 999999:");
            str = Console.ReadLine();
            num = int.Parse(str);
            num = Program.InputVal(num);

            Console.WriteLine("The number you picked was {0}", num);

            thou = num / 1000;
            hund = (num - (thou * 1000)) / 100;
            ten = (num - ((thou * 1000) + (hund * 100))) / 10;
            one = num % 10;

            Console.WriteLine("The number with a comma {0},{1}{2}{3}", thou, hund, ten, one);
        }

        static void PartTwo()
        {
            string str, newStr;
            int num;

            Console.WriteLine("Now pick a new number in between 1000 - 999999");
            str = Console.ReadLine();
            num = Program.InputVal(num = int.Parse(str));

            str = num.ToString();
            if(str.Length == 4)
            {
                newStr = str.Insert(1, ",");
            }
            else if(str.Length == 5)
            {
                newStr = str.Insert(2, ",");
            }
            else
            {
                newStr = str.Insert(3, ",");
            }
            

            Console.WriteLine("The number you picked is {0}.", str);
            Console.WriteLine("The number with a comma " + newStr + ".");
            
        }

        static int InputVal(int num)
        {
            while (num < 1000 || num > 999999)
            {
                Console.WriteLine("You did not enter a number in the range of 1000 and 999999");
                Console.WriteLine("Please enter a valid number:");
                string input = Console.ReadLine();
                num = int.Parse(input);
            }
            return num;
        }
    }
}
