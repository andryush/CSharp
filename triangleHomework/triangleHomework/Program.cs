using System;

namespace triangleHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string sum = "";
            int n = 9;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == n/2 || i == n/2)
                    {
                        sum += "* ";
                    }
                    else
                    {
                        sum += "- ";
                    }
                }
                sum += "\n";
            }
            Console.WriteLine(sum);
        }
    }
}
