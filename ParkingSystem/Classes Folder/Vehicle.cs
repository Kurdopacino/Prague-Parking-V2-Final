using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Classes_Folder
{
    public class Vehicle
    {
        public string LicensePlate { get; set; }
        public VehicleType Type { get; set; }

        public Vehicle(string licensePlate, VehicleType type)
        {
            LicensePlate = licensePlate;
            Type = type;
        }
    }

    public enum VehicleType
    {
        Car,
        Motorcycle,
        Bus,
        Bicycle,
        Helicopter
    }
}
