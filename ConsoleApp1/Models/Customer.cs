using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        List<Car> RentedCars { get; set; } = new List<Car>();
        

        public Customer(int customerID, string name)
        {
            CustomerID = customerID;
            Name = name;
        }

        public void RentCar(Car car)
        {
            if (car.isAvailable)
            {

                car.isAvailable = false;
                RentedCars.Add(car);
                Console.WriteLine($"{car.LicensePlate} kikölcsönözve!");
            }
        }
        public void ReturnCar(Car car)
        {
            if (RentedCars.Contains(car))
            {
                car.isAvailable = true;
                RentedCars.Remove(car);
                Console.WriteLine($"{car.LicensePlate} sikeresen visszaadva!");
            }
            else
            {
                Console.WriteLine($"{car.LicensePlate} nem volt kikölcsönözve!");
            }
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
