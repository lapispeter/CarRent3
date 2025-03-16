using CarRent.Models;

RentalService gitkolcsonzo = new RentalService();

gitkolcsonzo.AddCar(new Car("ABC-123", "Volvo", "Kombi", 2015, true, 15000));

gitkolcsonzo.ListAvailableCars();
Console.WriteLine();