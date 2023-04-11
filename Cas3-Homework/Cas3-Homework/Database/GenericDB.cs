using Cas3_Homework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cas3_Homework.Database
{
    public class GenericDB<T> where T : BaseEntity
    {
        public static List<T> DataBase;

        static GenericDB() 
        {
            DataBase = new List<T>();
        }

        public static void InsertCar (T car) 
        {
            DataBase.Add(car);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor= ConsoleColor.Gray;
            Console.WriteLine($"The item {car.GetType()} has been added to the database");
            Console.ResetColor();
        }

        public static void PrintAllCars()
        {
            foreach(T car in DataBase)
            {
                Console.WriteLine(car);
            }
        }

        public static void GetCarId(int id)
        {
            DataBase.FirstOrDefault(x => x.Id == id);
        }



    }
}
 