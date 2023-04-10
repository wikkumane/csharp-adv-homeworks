using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas2_Homework.Entities.Components
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }

        public Bike(int id, string type, int yearOfProduction, int batchNumber, string color) : base(id, type, yearOfProduction, batchNumber)
        {
            Color = color;
        }

        public void PrintVehicle()
        {
            Console.WriteLine($"{YearOfProduction} {Color}");
        }
    }
}
