using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Classes_Folder
{
    public class ParkingManager
    {
        private ParkingLot parkingLot;

        public ParkingManager(int totalSpots)
        {
            parkingLot = new ParkingLot(totalSpots);
        }

        public bool ParkVehicle(string licensePlate, VehicleType type)
        {
            var vehicle = new Vehicle(licensePlate, type);
            return parkingLot.ParkVehicle(vehicle);
        }

        public int CalculateFee(string licensePlate)
        {
            var vehicleInfo = parkingLot.FindVehicle(licensePlate);
            if (vehicleInfo == null) return 0;

            var (spot, startTime, type) = vehicleInfo.Value;
            var duration = DateTime.Now - startTime;

            return ParkingRateCalculator.Calculate(type, duration);
        }
    }
}