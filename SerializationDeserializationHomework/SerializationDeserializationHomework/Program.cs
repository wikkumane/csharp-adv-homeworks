using Newtonsoft.Json;
using SerializationDeserializationHomework.Entities;
using System.Text.Json.Serialization;

Console.WriteLine("Enter your dogs name:");
string name = Console.ReadLine();

Console.WriteLine("Enter your dogs age:");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your dogs color:");
string color = Console.ReadLine();

Dog newDog = new Dog(name, age, color);
Console.WriteLine(newDog.Name);

string serializingDog = JsonConvert.SerializeObject(new List<Dog>() { newDog });
string filePath = "../../../test";
File.WriteAllText(filePath, serializingDog);

