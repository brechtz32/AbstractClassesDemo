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
             * DONE - Create an abstract class called Vehicle
             * DONE - The vehicle class shall have three string properties: Year, Make, and Model
             * DONE - Set the defaults of the properties to something generic in the Vehicle class
             * DONE - Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * DONE - Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * DONE - Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE - Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE - Provide the implementations for the abstract methods
             * DONE - Only in the Motorcycle class will you override the virtual drive method
            */

            // DONE - Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * DONE - Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * DONE - Set the properties values with object initializer syntax
             */
            Car myCar = new Car() { Make = "Chevy", Model = "Malibu", Year = "2020", HasTrunk = true };
            Motorcycle myMotorcycle = new Motorcycle() { Make = "Honda", Model = "Zoom Zoom", Year = "2015", HasSideCart = false };

            Vehicle truck = new Car() { Make = "Chevy", Model = "Silverado", Year = "1996", HasTrunk = false};
            Vehicle van = new Car() { Make = "Toyota", Model = "Mini Van", Year = "2024", HasTrunk= false };

            /*
             * DONE - Add the 4 vehicles to the list
             * DONE - Using a foreach loop iterate through the list and display each of the properties
             */
            vehicles.Add(myCar);
            vehicles.Add(myMotorcycle);
            vehicles.Add(truck);
            vehicles.Add(van);

            foreach(var myVehicles in  vehicles)
            {
                Console.WriteLine($"Make={myVehicles.Make}   Model={myVehicles.Model}  Year={myVehicles.Year}");
                myVehicles.DriveAbstract();
                myVehicles.DriveVirtual();
                Console.WriteLine($"----------------------------------------");
            }
            


            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
