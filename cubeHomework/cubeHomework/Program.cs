using System;

namespace cubeHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 19;
            string symbol = "";


            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    if (column > row)
                    {
                        symbol += "- ";

                    }
                    else 
                    {
                        symbol += "* ";
                    }

                }
                symbol += "\n";

            }
            Console.Write(symbol);
        }
    }
}
