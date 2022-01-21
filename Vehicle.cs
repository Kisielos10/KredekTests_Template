using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KredekTests_Template
{
    public class Vehicle
    {
        public string manufacturer;
        public string model;
        public int yearOfProduction;
        public int worth;

        public Vehicle()
        {
        }

        public Vehicle(string manufacturer, string model, int yearOfProduction, int worth)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.yearOfProduction = yearOfProduction;
            this.worth = worth;
        }
    }
}
