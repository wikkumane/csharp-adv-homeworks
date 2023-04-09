using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2.Entities
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        public void CheckVehicle(Vehicle vehicle)
        {
            vehicle.isRepaired = true;
            Console.WriteLine($"The {vehicle} is now serviced");
        }

        public void PumpGas(Vehicle vehicle)
        {
            if (vehicle.FuelTank > 100)
            {
                Console.WriteLine("Your tank is full!");
            } else
            {
                Console.WriteLine("Fuel tank +10");
                vehicle.FuelTank += 10;

            }      
        }

        public void WashCar(Car car)
        {
            car.isClean = true;
            Console.WriteLine($"The {car} is now washed");
        }

        public void WashTrailer(Truck truck)
        {
            truck.isClean = true;
            Console.WriteLine($"The {truck} is now washed");
        }

    }
}
