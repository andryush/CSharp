using System;

namespace for_project
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1+2+3+4...
            //1-2+3-4+5...

            //1-3+5-7+9
            //1+2-3+4+5-6...
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                

                if(i % 2 == 1) 
                {
                    sum += i;
                }
                else if (i % 2 == 0)
                 
                {
                    sum -= i;
                }

                Console.WriteLine(i + "\t " + sum + "\t " + i % 2);

            }
            Console.WriteLine(sum);
            int p = 1;
            for (int i = 1; i <= 10; i++)
            {
                p *= i;
            }
        }
            
    }
}
