using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace CarRent.Models
{
    public class RentalService
    {
        public List<Car> Cars { get; set; } = new List<Car>();
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public void AddMember(Customer customer)
        {
            Customers.Add(customer);
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void RemoveCar(string licensePlate)
        {

            Cars.Remove(FindCar(licensePlate));

        }

        public Car FindCar(string licensePlate)
        {

            return Cars.FirstOrDefault(p => p.LicensePlate == licensePlate);

        }

        public Car FindCarBrand(string brand) //a feladat azt írja vagy rendszán, vagy márka. de nem engedi duplikálni. 
        {

            return Cars.FirstOrDefault(b => b.Brand == brand);

        }


        public void ListAvailableCars()
        {
            var availabeCars = Cars.Where(p => p.isAvailable);
            if (availabeCars.Any())
            {
                foreach (Car item in availabeCars)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Nincs elérhető gépjármű!");
            }

        }

    }
}