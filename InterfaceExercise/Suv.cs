using InterfaceExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Suv : IVehicle
    {
        public int NumberOfSeats { get; set; }
        public bool HasFourWheelDrive { get; set; }

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
            Console.WriteLine("The Suv is driving");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Number of Seats: {NumberOfSeats},\n4 wheel drive: {HasFourWheelDrive},\nNumber of Wheels: {NumOfWheels},\nNumber of Windows: {NumOfWindows},\nAutomatic? {IsAutomatic},\n"+
                $"Maximum speed: {MaxSpeed},\nCompany Logo: {Logo},\nAre employees commissioned: {HasCommissionEmployees},\n");
        }
    }
}
