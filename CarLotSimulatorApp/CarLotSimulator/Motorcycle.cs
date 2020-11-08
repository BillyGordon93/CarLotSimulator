using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
   public class Motorcycle : Vehicle
    {
        public int NumberOfWheels { get; set; }
        public double FuelCapacity { get; set; }


        public Motorcycle(int numberOfWheels, double fuelCapacity, int year, string make, string model)
        {
            NumberOfWheels = numberOfWheels;
            FuelCapacity = fuelCapacity;
            Year = year;
            Make = make;
            Model = model;

            CarLot.numberOfCars++;
            
            
        }
    }
    
}
