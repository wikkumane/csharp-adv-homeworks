using Cas2_Homework.Entities;
using Cas2_Homework.Entities.Components;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

foreach (var vehicle in VehiclesDB.Vehicles)
{
    Console.WriteLine($"Id: {vehicle.Id}, Type: {vehicle.Type}, Model Year: {vehicle.YearOfProduction} ");
}

VehiclesDB.Validator(VehiclesDB.Vehicles[1]);

VehiclesDB.Vehicles[1].PrintVehicle();