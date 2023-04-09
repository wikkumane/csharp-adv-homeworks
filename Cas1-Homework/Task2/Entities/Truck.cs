using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Entities
{
    public class Truck : Vehicle
    {

        public Truck(string brand, string model, int modelYear) : base(brand, model, modelYear)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("vozicka");
        }
    }
}
