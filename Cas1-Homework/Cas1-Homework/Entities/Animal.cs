using Cas1_Homework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas1_Homework.Entities
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }

        public int Age  { get; set; }

        public string Color { get; set; }

        public string Breed { get; set; }


        public Animal(string name, int age, string color, string breed) 
        {
            Name = name;
            Age = age;
            Color = color;
            Breed = breed;
        }

        protected Animal(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public abstract void PrintAnimal();
        
            
        
    }
}
