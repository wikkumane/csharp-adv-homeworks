using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas2_Homework.Entities
{
    public class Vehicle
    {
        public int Id { get; set; } 

        public string Type { get; set; }

        public int YearOfProduction { get; set; }

        public int BatchNumber { get; set; }

        public Vehicle(int id, string type, int yearOfProduction, int batchNumber) 
        {
            Id = id;
            Type = type;
            YearOfProduction = yearOfProduction;
            BatchNumber = batchNumber;
        }

        public void PrintVehicle()
        {
            Console.WriteLine($"{Id} {Type} {YearOfProduction}");
        }
    }
}
