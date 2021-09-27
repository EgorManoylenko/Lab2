using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Adress
    {
        public int index, house, apartment;
        public string country, city, street;

        private int Index
        {
            get { return index; }
            set { Index = value; }
        }

        private int House
        {
            get { return house; }
            set { House = value; }
        }

        private int Apartment
        {
            get { return apartment; }
            set { Apartment = value; }
        }

        private string Country
        {
            get { return country; }
            set { Country = value; }
        }

        private string City
        {
            get { return city; }
            set { City = value; }
        }

        private string Street
        {
            get { return street; }
            set { Street = value; }
        }

        public void GetInfo()
        {
            Console.WriteLine($"index: {index} country: {country} city: {city} street: {street} house: {house} apartment: {apartment}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Adress a = new Adress();

            a.index = 04522;
            a.country = "Ukraine";
            a.city = "Kyiv";
            a.street = "Miloslavska";
            a.house = 23;
            a.apartment = 666;

            a.GetInfo();

            Console.ReadKey();
        }
    }
}

