using System;

namespace triangleHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string sum = "";
            int n = 9;
            bool first;
            bool second;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // first  if (j >= (n/2 - i) && j <= (n/2 + i) && i <= n / 2 )
                    // second if (j >= (i - n/2) && j < (n + n/2 - i) && i >= n / 2)
                    first = (j >= (n / 2 - i) && j <= (n / 2 + i) && i <= n / 2);
                    second = (j >= (i - n / 2) && j < (n + n / 2 - i) && i >= n / 2);
                    if (first || second)
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
