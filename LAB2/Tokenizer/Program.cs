using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tokenizer
{
    class Program
    {
        static void Main(string[] args)
        {
            int     accNo;
            double  bal;
            string  name;
            char    accType;
            
            string str = "12345,Jacob T Loncar,A,1000.00";
            string[] words = str.Split(',');

            accNo = int.Parse(words[0]);
            bal = double.Parse(words[3]);
            name = words[1];
            accType = char.Parse(words[2]);

            Console.WriteLine(accNo);
            Console.WriteLine(name);
            Console.WriteLine(accType);
            Console.WriteLine(bal);
        }
    }
}
