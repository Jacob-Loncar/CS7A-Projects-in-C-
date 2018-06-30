using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            List<Accounts> listOfAccounts = new List<Accounts>();
            StreamReader inFile = new StreamReader(@"C:\Users\jtlon\Desktop\test.csv");
            line = inFile.ReadLine();

            while(!inFile.EndOfStream)
            {
                Accounts acc;
                acc = new Accounts();
                string[] words = line.Split(',');
                acc.MyAccountNumber = words[0];
                acc.MyName = words[1];
                acc.MyBal = words[2];
                listOfAccounts.Add(acc);
                line = inFile.ReadLine();
            }

            foreach (Accounts listOfAccount in listOfAccounts)
            {
                Console.WriteLine("{0,10} {1,25} {2, 25}", listOfAccount.MyAccountNumber, listOfAccount.MyName, listOfAccount.MyBal);
            }

            //////////////////////////////////////////////////////////////////////////////
            string[] lines = File.ReadAllLines(@"C:\Users\jtlon\Desktop\test.csv");

            for (int i = 0; i < lines.Length; i++)
            {
                //First line is the header line
                if (i == 0)
                {
                    continue;
                }

                string[] columns = line.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

                Accounts account = new Accounts
                {
                    MyAccountNumber = columns[0],
                    MyName = columns[1],
                    MyBal = columns[2]
                };

                listOfAccounts.Add(account);
            }

        }
    }
    
}
