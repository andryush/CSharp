using System;
//using Student;

namespace classhomework
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Student andrey = new Student();
            //andrey.firstName = "Andrey";
            //andrey.printParams();
            Student garegin = new Student("NSOTT", "GG");

           // Student.university = "EPH";
            garegin.printParams();
            //andrey.printParams();
            Console.ReadKey();
        }

    }



}
