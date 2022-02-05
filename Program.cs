using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calculator
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Welcome to Random Number Generator");
            Console.WriteLine("Select your range");
            Console.WriteLine("Enter range minimum:");
            int mini = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter range maximum:");
            int maxi = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int rng = rand.Next(mini, maxi);
            Console.WriteLine($"Your random number is: {rng}");
            



        }
    }
}