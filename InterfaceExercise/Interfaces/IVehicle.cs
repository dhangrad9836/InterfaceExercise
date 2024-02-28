using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise.Interfaces
{
    //we are implementing the ICompany directly in the IVehicle interface
    //so everytime we implement the IVehicle in derived classes the ICompany will implemented too...save less code to write
    public interface IVehicle : ICompany
    {
        //properties of that all vehicles have in common
        public int NumOfWheels { get; set; }
        public int NumOfWindows { get; set; }
        public bool IsAutomatic { get; set; }
        public double MaxSpeed { get; set; }

        //instant method
        public void VehicleIsDriving();

        public void DisplayDetails()
        {
            Console.WriteLine("Add content here");
        }
    }
}
