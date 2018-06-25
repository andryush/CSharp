using System;
namespace encapsulation
{
    public class Adress
    {
        public string country;
        public string city;
        public string street;
        public string appartament;

        public Adress()
        {
            
        }

        public Adress(string country, string city, string street, string appartament)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.appartament = appartament;
        }
    }
}
