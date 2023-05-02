using LINQ_Homework.Database;
using LINQ_Homework.Entities;

Person Christopher = new Person("Christopher", 20);
Christopher.Dogs.Add(new Dog("Maks", 1, "Black"));
Christopher.Dogs.Add(new Dog("Zoki", 12, "Gray"));
Database.People.Add(Christopher);

Person Freddy = new Person("Freddy", 30);
Freddy.Dogs.Add(new Dog("Bak", 6, "White"));
Freddy.Dogs.Add(new Dog("Aron", 4, "Black"));
Database.People.Add(Freddy);

Person Nathan = new Person("Nathan", 10);
Nathan.Dogs.Add(new Dog("Paris", 11, "Golden"));
Nathan.Dogs.Add(new Dog("Marko", 3, "White"));
Nathan.Dogs.Add(new Dog("Moskva", 18, "Brown"));

Person Erin = new Person("Erin", 50);
Erin.Dogs.Add(new Dog("Glupco", 3, "Pale White"));
Database.People.Add(Erin);

Person Amelia = new Person("Amelia", 21);
Amelia.Dogs.Add(new Dog("Ami", 2, "Brown"));
Database.People.Add(Amelia);

Person Randolph = new Person("Randolph", 22);
Randolph.Dogs.Add(new Dog("Test", 22, "Yellow"));
Database.People.Add(Randolph);


///People starting with R, sorting by descending age

var personsStartingWithR = Database.People.Where(p => p.FirstName.StartsWith("R")).OrderByDescending(p => p.Age);
foreach(Person person in personsStartingWithR)
{
    Console.WriteLine($"{person.FirstName}({person.Age})");
}


/// All brown dogs namesd and older than 3, ordered by ascending age

var brownDogsOlderThanThree = Database.Dogs.Where(p => p.Color == "Brown" && p.Age > 3).OrderBy(d => d.Age);
foreach(Dog dog in brownDogsOlderThanThree)
{
    Console.WriteLine($"{dog.Name} {dog.Age}");
}

/// All persons with more than two dogs, ordered by name descending order

var personsWithMoreThanTwoDogs = Database.People.Where(p => p.Dogs.Count > 2).OrderByDescending(p =>p.FirstName);
foreach(Person person in personsWithMoreThanTwoDogs)
{
    Console.WriteLine($"{person.FirstName} {person.Dogs.Count}");
}

/// Freddys dogs names older than 1 year

var freddysDogsOlderThanOneYear = Database.People.Where(p => p.FirstName == "Freddy" && p.Age > 1);
foreach(Person freddy in freddysDogsOlderThanOneYear)
{
    Console.WriteLine($"{freddy.Dogs.Count}");
}


//Nathans first dog
var NathansFirstDog = Database.People.Where(p => p.FirstName == "Nathan");
foreach(Person nathan in NathansFirstDog)
{
    Console.WriteLine($"Nathans first{nathan.Dogs.FirstOrDefault()}");
}

//all white dogs

