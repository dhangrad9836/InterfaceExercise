using InterfaceExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle
    {
        //properties/fields
        public bool HasExtendedCab { get; set; }
        public bool HasTowingPackage { get; set; }

        //IVehicle
        public int NumOfWheels { get; set; }
        public int NumOfWindows { get; set; }
        public bool IsAutomatic { get; set; }
        public double MaxSpeed { get; set; }

        //ICompany
        public string Logo { get; set; }
        public bool HasCommissionEmployees { get; set; }
        public Truck() { }

        //constructor with parameters
        public Truck(bool hasExtendedCab, bool hasTowingPackage, int numOfWheels, int numOfWindows, bool isAutomatic,
            double maxSpeed, string logo, bool hasCommissionEmployee) 
        {
            this.HasExtendedCab = hasExtendedCab;
            this.HasTowingPackage = hasTowingPackage;
            this.NumOfWheels = numOfWheels;
            this.NumOfWindows = numOfWindows;
            this.IsAutomatic = isAutomatic;
            this.MaxSpeed = maxSpeed;
            this.Logo = logo;
            this.HasCommissionEmployees = hasCommissionEmployee;
        }

        public void VehicleIsDriving()
        {
            Console.WriteLine("The truck is driving");
        }

        public void DisplayDetails()
        {            
            Console.WriteLine($"Has extended cab: {HasExtendedCab},\nTowing package included: {HasTowingPackage},\nNumber of wheels: {NumOfWheels},\nNumber of windows: {NumOfWindows},\nAutomatic transmission: {IsAutomatic},\n"+
                $"Maximum speed: {MaxSpeed},\nCompany Logo: {Logo},\nAre employees commissioned: {HasCommissionEmployees},\n");
        }
    }
}
