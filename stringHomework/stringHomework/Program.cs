using System;

namespace stringHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyText = "This too shall pass";
            MyText = MyText.ToLower();

            string Alphabet = "abcdefghijklmnopqrstuvwxyz";

            Console.WriteLine(MyText.Length);
        }
    }
}
