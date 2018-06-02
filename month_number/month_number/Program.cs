using System;

namespace month_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number in range 1 - 12");
            int number = Convert.ToInt32(Console.ReadLine());

            string month = "";
            //begin:
            switch (number)
            {
                case 1:
                    month = "January";
                    Console.WriteLine("Winter");
                    break;

                case 2:
                    Console.WriteLine("February");
                    Console.WriteLine("Winter");
                    //Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("March");
                    Console.WriteLine("Spring");
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("April");
                    Console.WriteLine("Spring");
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine("May");
                    Console.WriteLine("Spring");
                    Console.ReadLine();
                    break;

                case 6:
                    Console.WriteLine("June");
                    Console.WriteLine("Summer");
                    Console.ReadLine();
                    break;

                case 7:
                    Console.WriteLine("July");
                    Console.WriteLine("Summer");
                    Console.ReadLine();
                    break;

                case 8:
                    Console.WriteLine("August");
                    Console.WriteLine("Summer");
                    Console.ReadLine();
                    break;

                case 9:
                    Console.WriteLine("September");
                    Console.WriteLine("Autumn");
                    Console.ReadLine();
                    break;

                case 10:
                    Console.WriteLine("October");
                    Console.WriteLine("Autumn");
                    Console.ReadLine();
                    break;

                case 11:
                    Console.WriteLine("November");
                    Console.WriteLine("Autumn");
                    Console.ReadLine();
                    break;

                case 12:
                    Console.WriteLine("December");
                    Console.WriteLine("Winter");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Wrong number\nPlease enter number in range 1 - 12");
                    break;
                    //goto begin;
                   


            }
        }
    }
}
