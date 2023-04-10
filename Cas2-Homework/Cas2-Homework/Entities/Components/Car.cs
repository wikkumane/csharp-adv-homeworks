using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas2_Homework.Entities.Components
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }

        public List<string> Countries { get; set; }

        public Car(int id, string type, int yearOfProduction, int batchNumber, int fuelTank, List<string> countries) : base(id, type, yearOfProduction, batchNumber)
        {
            FuelTank = fuelTank;
            Countries = countries;
        }

        public void PrintVehicle()
        {
            Console.WriteLine($"{Type} {Countries}");
        }
    }
}
