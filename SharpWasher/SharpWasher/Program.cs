using System;
using System.Collections.Generic;
using System.Dynamic;

namespace SharpWasher
{
    class Program
    {
        static void Task1()
        {
            int amount = 10;
            Garage garage = new Garage(amount);
            foreach (Car car in garage.Cars)
            {
                Washer.Wash(car);
            }
            Console.WriteLine($"\nDone!");
        }

        static void Main(string[] args)
        {
            savepoint:
            Console.WriteLine("1 - Task 1;");

            int key = Int32.Parse(Console.ReadLine());

            switch (key)
            {
                case 1: Task1();
                    break;
                default: Console.WriteLine("\nTry again!\n"); goto savepoint;
            }
        }
    }
}
