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


