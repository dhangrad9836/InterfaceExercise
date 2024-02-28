using InterfaceExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle
    {
        public bool HasTrunk { get; set; }
        public bool HasSunRoof { get; set; }

        //IVehicle
        public int NumOfWheels { get; set; }
        public int NumOfWindows { get; set; }
        public bool IsAutomatic { get; set; }
        public double MaxSpeed { get; set; }

        //ICompany
        public string Logo { get; set; }
        public bool HasCommissionEmployees { get; set; }

        public void VehicleIsDriving()
        {
            Console.WriteLine("The vehicle is Driving");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Has trunk: {HasTrunk},\nSunroof included: {HasSunRoof},\nNumber of wheels: {NumOfWheels},\nNumber of windows: {NumOfWindows},\nAutomatic transmission: {IsAutomatic},\n"+
                $"Maximum speed: {MaxSpeed},\nCompany Logo: {Logo},\nAre employees commissioned: {HasCommissionEmployees},\n");
        }
    }
}
