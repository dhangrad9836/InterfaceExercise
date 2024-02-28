using InterfaceExercise.Interfaces;
using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            //Car
            var toyotaCar = new Car()
            {
                HasTrunk = true,
                HasSunRoof = false,
                NumOfWheels = 4,
                NumOfWindows = 6,
                IsAutomatic = true,
                MaxSpeed = 180,
                Logo = "Long lasting Toyota Car",
                HasCommissionEmployees= true,
            };

            //Suv
            var lexusSuv = new Suv();
            lexusSuv.NumberOfSeats = 9;
            lexusSuv.HasFourWheelDrive = true;
            lexusSuv.NumOfWheels = 4;
            lexusSuv.NumOfWindows = 8;
            lexusSuv.IsAutomatic = true;
            lexusSuv.MaxSpeed = 180;
            lexusSuv.Logo = "Like a Rock";
            lexusSuv.HasCommissionEmployees = true;

            //truck object
            var fordTruck = new Truck(true, false, 5, 5, true, 200, "Ford is the Best", false);


            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

            //***************************************/////////////////////////////////////
            //Note that we can use the Interface as a data type and only since in our IVehicle interface
            //is also implementing or extending the ICompany interface all those properties will be included
            //Store our vehicles in the Interface and display below using foreach loop
            List<IVehicle> vehicles = new List<IVehicle>()
            {
                toyotaCar,
                lexusSuv,
                fordTruck
            };

            foreach (var vehicle in vehicles)
            {
                vehicle.VehicleIsDriving();
                Console.WriteLine(vehicle.GetType());
                vehicle.DisplayDetails();
                
            }


            Console.ReadLine();
        }
    }
}
