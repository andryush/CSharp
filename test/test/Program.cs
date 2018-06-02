using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, Я программа которая подсчитает индекс массы и тела\n" +
                              "Просто ответь на несколько вопросов");

            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();

            Console.WriteLine("Привет {0} :)\n" +
                              "Сколько ты весишь в килограммах?", name);
            int weight = Convert.ToInt32((Console.ReadLine()));

            Console.WriteLine("Круто {0}\n" +
                              "Тепер напиши мне твой рост в сантиметрах", name);
            int height = Convert.ToInt32((Console.ReadLine()));

            int result = weight / (height * height);
            Console.WriteLine(result);


        }
    }
}
