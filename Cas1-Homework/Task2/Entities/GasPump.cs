using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2.Entities
{
    public abstract class GasPump : IGasPump
    {
        public abstract void PumpGas(Vehicle vehicle);

    }
}
