using Cas1_Homework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas1_Homework.Entities
{
    public class Dog : Animal, IDog
    {
        public Dog(string name, int age, string color, string breed) : base(name, age, color, breed)
        {
        }

        public void Bark()
        {
            Console.WriteLine("woof woof");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"{Name} {Age} {Color} {Breed}");
        }
    }
}
