using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2.Entities
{
    public abstract class CarWash : ICarWash
    {
        public abstract void WashCar(Car car);


        public abstract void WashTrailer(Truck truck);
      
    }
}
