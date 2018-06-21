using System;

namespace ClassHomework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto bmw = new Auto("BMW", "3 SERIES", 2.5F, false);
            bmw.year = 1980;
            bmw.GeneralSpecs();
            //Console.WriteLine(bmw.GetKuzov(bmw.year));
            //Console.ReadKey();
            //Console.WriteLine(bmw);

            Auto nissan = new Auto(0, 0, 0, false);
            nissan.printPosition();
            nissan.engineOn();
            nissan.moveTo(50, 50);
            nissan.printPosition();

            Auto toyota = new Auto(100, 100, 73, true);


            toyota.moveTo(-50, -50);
            Console.WriteLine(H(nissan, toyota));



        }

        static int H(Auto a1, Auto a2)
        {
            int distanceX = a1.x - a2.x;
            int distanceY = a1.y - a2.y;


            int h = (int)Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2));
            Console.WriteLine(h);
            return h;
        }
    }
}
