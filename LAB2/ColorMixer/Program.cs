using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorMixer
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
            string color1, color2;
            Console.WriteLine("Enter one of the primary colors:");
            color1 = Console.ReadLine();
            color1 = Program.ColorChecker(color1);
            Console.WriteLine("Now enter a second primary color: ");
            color2 = Console.ReadLine();
            color2 = Program.ColorChecker(color2);
            Program.ColorMixer(color1, color2);

            
        }
        
        static string ColorChecker(string color)
        {
            //string[] primeColors = { "BLUE", "RED", "YELLOW" };
            color = color.ToUpper();
            
            while(color != "RED" && color !="BLUE" && color != "YELLOW"){
                Console.WriteLine("You did not enter a primary color...");
                Console.WriteLine("Please enter a primary color: ");
                color = Console.ReadLine();
                color = color.ToUpper();
            }

            return color;
        }

        static void ColorMixer(string color1, string color2)
        {
            if((color1 == "BLUE" && color2 == "RED") || (color1 == "RED" && color2 == "BLUE"))
            {
                Console.WriteLine("\nMixing {0} and {1} you get the color purple!", color1, color2);
            }
            else if((color1 == "BLUE" && color2 == "YELLOW") || (color1 == "YELLOW" && color2 == "BLUE"))
            {
                Console.WriteLine("\nMixing {0} and {1} you get the color green!", color1, color2);
            }
            else
            {
                Console.WriteLine("\nMixing {0} and {1} you get the color orange!", color1, color2);
            }
        }
    }
}
