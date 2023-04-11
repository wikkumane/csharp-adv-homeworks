using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Cas3_Homework.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public string Brand { get; set; } = string.Empty;

        public string Model { get; set; } = string.Empty;

        public int MaxSpeed { get; set; }

        public int HorsePower { get; set; }

        public string FuelType { get; set; } = string.Empty;


        public abstract void Drive(string destinationName);
    }
}
