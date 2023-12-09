using System;
using System.Collections.Generic;
using System.Text;

namespace SharpWasher
{
    public class Car
    {
        private static readonly List<string> carList = new List<string> {
            "Mercedes","BMW","Rolls Royce","Lamborghini",
            "Honda","Toyota","Daewoo","Audi","McLaren","Bumblebee"
        };

        public string Mark { get; }
        public int CarId { get; }
        public bool DirtyStatus { set; get; }
         
        public Car()
        {
            Random rnd = new Random();
            Mark = carList[rnd.Next(carList.Count)];
            CarId = rnd.Next(1000, 10000);
            DirtyStatus = Convert.ToBoolean(rnd.Next(0, 2));
        }

    }

    public class Garage
    {
        public List<Car> Cars { get; }

        public Garage(int amount)
        {
            Cars = new List<Car>(amount);
            for (int i = 0; i < amount; i++)
            {
                Cars.Add(new Car());
            }
        }
    }

    public class Washer
    {
        public static void Wash(Car car)
        {
            if (!car.DirtyStatus)
            {
                Random rnd = new Random();
                if (rnd.Next(0, 100) > 10)
                {
                    car.DirtyStatus = true;
                    Console.WriteLine($"\nCar {car.Mark} : CA{car.CarId}CI - is washed!");
                }
                else
                {
                    Console.WriteLine($"\n Unfortunately! Car {car.Mark} : CA{car.CarId}CI - failed to wash!");
                    Wash(car);
                }
            }
            else
            {
                Console.WriteLine($"\nCar {car.Mark} : CA{car.CarId}CI - already washed");
            }
        }
    }
}
