using System;

namespace types
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int tries = 3;
            while (tries > 0)
            {
                Console.WriteLine("Please enter a number");
                int input = Convert.ToInt32(Console.ReadLine());
                if (num == input)
                {
                    Console.WriteLine("You are right");
                }
                else 
                {
                    Console.WriteLine("Try again");
                }
                tries--;
            }
        }
    }
}
