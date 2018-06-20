using System;
using System.Collections.Generic;
using System.Text;

namespace ClassHomework2
{
    class Auto
    {
        public string brand;
        public string model;
        public string fuelType;
        public string transmission;

        public double engineSize;

        public int year;
        public int doorsCount;
        public int horsePower;
        public int topSpeed;
        public int length;
        public int width;
        public int heigth;

        public void GeneralSpecs()
        {
            Console.WriteLine(this.brand + " " + this.model + " " + this.engineSize);
        }
        
        public string GetKuzov(int year)
        {
            this.year = year;
            if (this.model == "3 SERIES" && this.year >= 1975 && this.year <= 1983)
            {
                return "E21";
            }
            else if (this.model == "3 SERIES" && this.year >= 1984 && this.year <= 1994)
            {
                return "E30";
            }


        }

        public Auto(string brand, string model, double engineSize)
        {
            this.brand = brand;
            this.model = model;
            this.engineSize = engineSize;
        }

    }
}
