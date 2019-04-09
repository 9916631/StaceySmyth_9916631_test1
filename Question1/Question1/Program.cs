using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my app, it will give you the result of base exponents.");
            Console.Write("Please enter a base value: ");
            double Base = double.Parse(Console.ReadLine());
            Console.Write("Please enter a exponent number: ");
            int expo = int.Parse(Console.ReadLine());
            double total;

            total = Base * expo; 
            Console.WriteLine("{0}^{1} = {2}",Base, expo, total); 

            Console.WriteLine("Press enter to quit.");

            Console.ReadLine();
           

        }
    }
}
