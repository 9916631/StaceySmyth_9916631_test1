using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my application.");
            Console.WriteLine("Can you guess this equation: 2(x - 3) + x = 12?.");
            int guess = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            


            switch (guess)
            {
                case "45": 
                    Console.WriteLine("You guessed right :)");
                    break;
                default:
                    Console.WriteLine("Your guess was wrong. please re-enter.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
