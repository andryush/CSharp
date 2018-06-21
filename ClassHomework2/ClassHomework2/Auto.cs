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

        private int x;
        public int y;
        public int speed;

        private bool isEngineOn;

        public int GetX()
        {
            return x;
        }

        public void SetX(int x)
        {
            if(x > 0 && x < 100)
            {
                this.x = x;
            }
        }

        public void engineOn()
        {
            if (!isEngineOn)
            {
                isEngineOn = true;
            }
        }

        public void moveTo(int dx, int dy)
        {
            if(isEngineOn)
            {
                this.x += dx;
                this.y += dy;   
            }
            else
            {
                Console.WriteLine("Can't move because engine is OFF");    
            }

        }

        public void printPosition()
        {
            Console.WriteLine(x + " " + y + " " + speed);
        }



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
            else
            {
                return "";   
            }


        }

        public Auto(string brand, string model, double engineSize)
        {
            this.brand = brand;
            this.model = model;
            this.engineSize = engineSize;
        }

        public Auto(string brand, string model, double engineSize, bool isEngineOn)
        {
            this.brand = brand;
            this.model = model;
            this.engineSize = engineSize;
            this.isEngineOn = isEngineOn;
        }


        public Auto(int x, int y, int speed, bool isEngineOn)
        {
            this.x = x;
            this.y = y;
            this.speed = speed;
            this.isEngineOn = isEngineOn;
        }

    }
}
