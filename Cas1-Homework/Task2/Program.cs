using Task2.Entities;

Car bemwe = new Car("BMW", "535d", 2009);

Truck scania = new Truck("Scania", "Neshto", 2022);

CarCenter carCenter = new CarCenter();

carCenter.WashCar(bemwe);

carCenter.WashTrailer(scania);