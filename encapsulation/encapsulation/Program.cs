using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student andrey = new Student();
            andrey.name = "Andrey";
            andrey.surname = "Arakelyan";
            andrey.SetAge(0);
            Console.WriteLine(andrey.GetAge());

            Adress imhascen = new Adress("Armenia", "Yerevan", "Kievyan", "59");
            andrey.hasce = imhascen;
            //Console.WriteLine(andrey.hasce.street);


            Mard adam = new Mard();
            adam.Xosal();
        }
    }
}
