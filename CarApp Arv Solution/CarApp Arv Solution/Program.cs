using System;

namespace CarApp___Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            FuelCar fuelCar = new FuelCar("Toyota", "Corolla", "AB12345", false, 0);
            Console.WriteLine(fuelCar.brand + ", " + fuelCar.model + ", " + fuelCar.licensePlate + ", " + fuelCar.isEngineOn + ", " + fuelCar.odometer + ", " + fuelCar.fuelLevel + ", " + fuelCar.tankCapacity + ", " + fuelCar.kmPerLiter);
            //fuelCar.StartEnigine();
            //fuelCar.StopEngine(false);
            //fuelCar.Refuel(0);
            fuelCar.Drive(0);

            ElectricCar electricCar = new ElectricCar("Tesla", "Y", "TE12345", false, 0);
            
            //electricCar.StartEnigine();
            //electricCar.StopEngine(false);
            //electricCar.Charge(0);
            electricCar.Drive(0);

            
            Taxi taxi = new Taxi("Audi", "A3", "AU12345", false, 0);
            Console.WriteLine(taxi.brand + ", " + taxi.model + ", " + taxi.licensePlate + ", " + taxi.isEngineOn + ", " + taxi.odometer);
            taxi.CalculateTripPrice(50,5,10);
            Console.WriteLine(taxi.calculateFare);
        }

      
    }
}
