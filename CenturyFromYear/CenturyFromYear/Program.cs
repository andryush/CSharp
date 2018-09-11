using System;

namespace CenturyFromYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Garibun ZIN");
            Console.ReadKey();
            Console.WriteLine("ASUM EIR CHEM KARUM DAR HASHVEM???");
            Console.ReadKey();
            Console.Write("DE HIMA TIV@ DU KGRES ES DAR@ KASEM GRI TIV@:> ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            CenturyFromYear(year);
            Console.WriteLine();
            Console.WriteLine("TAK CHTO 'CICAXUM E NA OV ASHXATI NA KUTI'");
        }

        public static void CenturyFromYear(int year)
        {
            if (year % 100 == 0)
            {
                Console.WriteLine($"***GRACT TIV@ {year / 100} DARNA ZINAIDA***");
            }
            else 
            {
                Console.WriteLine($"***GRACT TIV@ {year / 100 + 1} DARNA ZINAIDA***");
            }
        }
    }
}
