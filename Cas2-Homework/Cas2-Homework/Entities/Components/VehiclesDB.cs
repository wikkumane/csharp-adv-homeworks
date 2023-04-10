using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas2_Homework.Entities.Components
{
    public static class VehiclesDB
    {
        public static List<Vehicle> Vehicles;

         static VehiclesDB()
        {
            Vehicles = new List<Vehicle>()
            {
                new Car(1, "BMW", 2022, 19012, 60, new List<string>(){"Germany, Poland, USA"}),
                new Car(2, "Audi", 2022, 18011, 80, new List<string>(){"Germany, Hungary"}),
                new Car(3, "Renault", 2023, 20001, 60, new List<string>(){"France, Turkey"}),
                new Car(4, "Land Rover", 2024, 23010, 85, new List<string>(){"UK, India"}),
                new Bike(5, "Mountain Bike", 2009, 1002, "White")
            };

        }

        public static void Validator(Vehicle vehicle)
        {
            if (vehicle.Id == 0 && vehicle.YearOfProduction == 0)
            {
                Console.WriteLine("Invalid Car Entered!");
            }
            else if (vehicle.Type == "")
            {
                Console.WriteLine("Enter a valid car type!");
            }
            else { Console.WriteLine("Everything checks out!"); }
        }
    }
}
