using System;

namespace ClassHomework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto bmw = new Auto("BMW", "3 SERIES", 2.5F);
            bmw.GeneralSpecs();
            Console.ReadKey();
        }
    }
}
