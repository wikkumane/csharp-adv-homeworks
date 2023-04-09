using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2.Entities
{
    public abstract class RepairService : IRepairService
    {
        public abstract void CheckVehicle(Vehicle vehicle);
       
    }
}
