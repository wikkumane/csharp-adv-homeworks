using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Entities;

namespace Task2.Interfaces
{
    public interface ICarWash
    {
        public void WashCar(Car car);

        public void WashTrailer(Truck truck);
    }
}
