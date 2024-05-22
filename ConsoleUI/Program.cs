using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            var car = new Car() { Year = 2019, Make = "Hondaa", Model ="Galco", HasTrunk = true};


            var motorcycle = new Motorcycle() { Year = 1999, Model = "Harly", Make = "X90", HasSideCar = false};

            Vehicle laurensCar = new Car() { Make = "Kia", Model = "Soul", Year = 2019, HasTrunk = true};

            Motorcycle WheelieModile = new Motorcycle() {  Make = "Who cares", Year = 22222, Model="klk", HasSideCar= false};
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */
            vehicles.Add(car);
            vehicles.Add(motorcycle);
            vehicles.Add(laurensCar);
            vehicles.Add(WheelieModile);

            /*
             * Add the 4 vehicles to the list
             
             
             * Using a foreach loop iterate through the list and display each of the properties
             */
            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"My vehicle is a {vehicle.Year} {vehicle.Make} {vehicle.Model}");
            }

            // Call each of the drive methods for one car and one motorcycle

            car.DriveAbstract();
            car.DriveVirtual();

            motorcycle.DriveAbstract();
            motorcycle.DriveVirtual();
            

            #endregion            
            Console.ReadLine();
        }
    }
}
