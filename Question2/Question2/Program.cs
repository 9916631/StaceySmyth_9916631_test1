using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my application.");
            Console.WriteLine("This app will total up 5 of your items that you select.");
            Console.WriteLine("Please select out of Playstation, Xbox, Pc, Nintendo, laptop or Arcade machine ");

            string hard = Console.ReadLine().ToLower();
            string input = Console.ReadLine();
            //i know it says for loop but i have no clue////

            string total = Console.ReadLine();
            switch (hard)
            {
                case "Playstation":
                    input = "\nPlaystation:\t $2";
                    break;
                case "Xbox":
                    input = "\nXbox:\t $198";
                    break;
                case "Pc":
                    input = "\nPc:\t $546";
                    break;
                case "Nintendo":
                    input = "\nNintendo:\t $76";
                    break;
                case "Laptop":
                    input = "\nLaptop:\n $998";
                    break;
                case "Arcade machine":
                    input = "\nAracde machine:\t $2987";
                    break;
                default:
                    Console.WriteLine("You entry was invalid, please re-enter.");
                    break;
            }


            Console.WriteLine($"{0} + {1} + {2} + {3} + {4} + {5} = {total}");

            Console.ReadLine();
        }
    }
}
