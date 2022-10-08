using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal struct Car
    {
        private string model;
        private int year;
        private string colour;
        private string brand;

        public Car(string model, string brand, int year, string colour)
        {
            this.model = model;
            this.brand = brand; 
            this.year = year;   
            this.colour = colour;
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public override string ToString()
        {
            return $"{model} {brand} {year} {colour}";
        }

    }
}
