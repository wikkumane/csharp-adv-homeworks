using Cas1_Homework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas1_Homework.Entities
{
    public class Cat : Animal, ICat
    {
        public Cat(string name, int age, string color, string breed) : base(name, age, color, breed)
        {
        }

        public void Eat(string food)
        {
            Console.WriteLine($"The cat loves to eat {food}, *eats*");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"{Name} {Age} {Color} {Breed}");
        }
    }
}
