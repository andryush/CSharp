using System;
namespace encapsulation
{
    public class Student
    {
        
         public string name = "";
         public string surname = "";
         private int age;
         public Adress hasce;

        public Student(string name, string surname, int age, Adress hasce)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.hasce = hasce;
        }

        public Student()
        {

        }

        public void SetAge(int age)
        {
            if (age > 0 && age <= 150)

            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("Not valid age");
            }
        }

        public int GetAge()
        {
            return age;
        }

        public void Tpel()
        {
            Console.WriteLine(" ");
        }

        public void Tpel(string name)
        {
            Console.WriteLine(name);
        }

        public void Tpel(string name, string surname)
        {
            Console.WriteLine(name, surname);
        }


        }
}




