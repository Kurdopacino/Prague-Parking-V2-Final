using System;
using System.Collections.Generic;

namespace ParkingSystem.Classes_Folder
{
    public class ParkingLot
    {
        private List<ParkingSpot> parkingSpots;
        private Dictionary<string, (int spot, DateTime startTime, VehicleType type)> parkedVehicles;

        public ParkingLot(int totalSpots)
        {
            parkingSpots = new List<ParkingSpot>(totalSpots);
            parkedVehicles = new Dictionary<string, (int spot, DateTime startTime, VehicleType type)>();

            for (int i = 0; i < totalSpots; i++)
            {
                parkingSpots.Add(new ParkingSpot(i + 1));
            }
        }

        public bool ParkVehicle(Vehicle vehicle)
        {
            int availableSpot = FindAvailableSpot(vehicle.Type);
            if (availableSpot == -1) return false;

            var parkingSpotVehicle = new ParkingSpot.Vehicle(vehicle.LicensePlate, (ParkingSpot.VehicleType)vehicle.Type);

            parkingSpots[availableSpot].ParkVehicle(parkingSpotVehicle);
            parkedVehicles[vehicle.LicensePlate] = (availableSpot, DateTime.Now, vehicle.Type);
            return true;
        }

        public bool RetrieveVehicle(string licensePlate)
        {
            if (!parkedVehicles.TryGetValue(licensePlate, out var vehicleInfo)) return false;

            parkingSpots[vehicleInfo.spot].ClearSpot();
            parkedVehicles.Remove(licensePlate);
            return true;
        }

        public (int spot, DateTime startTime, VehicleType type)? FindVehicle(string licensePlate)
        {
            if (parkedVehicles.TryGetValue(licensePlate, out var vehicleInfo))
            {
                return vehicleInfo;
            }
            return null;
        }

        private int FindAvailableSpot(VehicleType type)
        {
            for (int i = 0; i < parkingSpots.Count; i++)
            {
                if (!parkingSpots[i].IsOccupied)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}