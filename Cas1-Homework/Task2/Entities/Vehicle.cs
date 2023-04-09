using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Entities
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public int ModelYear { get; set; }

        public int FuelTank { get; set; }

        public bool isClean { get; set; }

        public bool isRepaired { get; set; }

        public Vehicle(string brand, string model, int modelYear) 
        {
            Brand = brand;
            Model = model;
            ModelYear = modelYear;
            isClean = false;
            isRepaired = false;
            FuelTank = 50;
        }

        public abstract void Drive();
    }
}
