using System;

namespace cube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a size ");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a symbol ");
            string symbol = Console.ReadLine();

            string table = "";

            for (int i = 1; i < size; i++)
            {
                
                for (int j = 1; j < size; j++)
                {
                    table += symbol + " ";
                    //table += Convert.ToString(i * j) + "\t";
                }
                table += "\n";

            }
            Console.Write(table);
        }
    }
}
