using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Homework.Entities
{
    public class Person
    {
        public string FirstName { get; set; } = string.Empty;

        public int Age { get; set; }

        public List<Dog> Dogs { get; set; }

        public Person(string firstName, int age) 
        {
            FirstName = firstName;
            Age = age;
            Dogs = new List<Dog>();
        }
    }
}
