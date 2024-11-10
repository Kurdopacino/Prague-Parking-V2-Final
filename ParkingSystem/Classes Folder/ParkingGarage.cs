using System;
using ParkingSystem.Classes_Folder;
using System.Text.Json;
using System.IO;

namespace ParkingSystem.Classes_Folder
{
    

    public class ParkingGarage
    {
        private ParkingLot parkingLot;
        private ConfigData config;

        public ParkingGarage(ParkingLot parkingLot, ConfigData config)
        {
            this.parkingLot = parkingLot ?? throw new ArgumentNullException(nameof(parkingLot));
            this.config = config ?? throw new ArgumentNullException(nameof(config));
            InitializeGarage();
        }

        private void InitializeGarage()
        {
            
        }

        public void SaveParkingDataToFile(string filePath)
        {
            
        }
    }
}
