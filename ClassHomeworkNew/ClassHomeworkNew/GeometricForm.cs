using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHomeworkNew
{
   public class GeometricForm
    {
        public double PI { get; set; } = Math.PI;

        private int age;
        public int Age 
        {
            get
            {
                return age;
            }
            set
            {
                if ( value > 0 && value < 145)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Out of range");
                }
            }
        }

        public int Length { get; set; }
        public int Width  { get; set; }
        public int Heigth { get; set; }
        public int Radius { get; set; }

        public void Makeres()
        {
           
        }

    }


}
