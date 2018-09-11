using System;

namespace recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Factorial(9));
            //Console.WriteLine(FactorialF(4));

            //Console.WriteLine(FibonacciF(6));
            //Console.WriteLine(Fibonacci(33) / Fibonacci(32));
            Console.WriteLine(X(30));



        }
        public static float X(int n)
        {
            if (n == 1) return 1;
            return 1 + 1 / X(n - 1);
        }

        public static int Factorial(int n)
        {
           if(n == 1)
            {
                return 1;
            }            
           
            return n * Factorial(n - 1);
        }


        public static int FactorialF(int n)
        {
            int artadryal = 1;
            for (int i = 1; i < 5; i++)
            {
               artadryal *= i;
            }
            return artadryal;
        }

        public static int FibonacciF(int n)
        {
            int f1 = 0;
            int f2 = 1;
            int f3 = 0;
            for (int i = 0; i < n; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }
            return f3;

        }

        public static int Fibonacci(int n)
        {
            if (n == 1)
                return 0;
            if (n == 2)
                return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
