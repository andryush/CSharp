using System;
namespace classhomework
{
    public class Student
    {
        public string firstName;
        public string lastName;
        public int age;
        public char grade;

        public static string university = "XXX";

        public Student()
        {

        }

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Student(string XfirstName, string XlastName, int xage)
        {
            firstName = XfirstName;
            lastName = XfirstName;
            age = xage;
        }



        public string FullName()
        {
            return firstName + " " + lastName;
        }

        public void printParams()
        {
            Console.Write(firstName + lastName + " " + age + " " + grade + " " + university);
        }
    }
}
