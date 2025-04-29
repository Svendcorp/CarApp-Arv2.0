using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp___Arv
{

    internal class FuelCar : Car, IEnergy
    {
        public double fuelLevel = 30;
        public double tankCapacity = 50;
        public double kmPerLiter = 14.6;
        public double fuelPrice = 10.0;
        public double reFuel;

        public double EnergyLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MaxEnergy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public FuelCar(string Brand, string Model, int Id, bool IsEngineOn, int Odometer)
        {
            brand = Brand;
            model = Model;
            id = Id;
            isEngineOn = IsEngineOn;
            odometer = Odometer;
        }


        public void Refuel(double amount)
        {
            Console.WriteLine(fuelLevel);
            Console.WriteLine("How many liters of fuel would you like to buy?: ");
            reFuel = Convert.ToDouble(Console.ReadLine());

            if (reFuel < 50)
            {
                fuelLevel += reFuel;
            }

            else
            {
                Console.WriteLine("Tank is already full!!!");
            }

            Console.WriteLine(fuelLevel);

        }


        public override void Drive(double distance)
        {
            Console.WriteLine("What is the length of your trip?: ");
            distance = Convert.ToDouble(Console.ReadLine());

            fuelLevel -= distance / kmPerLiter;
            odometer += (int)distance;
            Console.WriteLine("The tank now has " + Math.Round(fuelLevel, 2) + " liters of fuel.");
            Console.WriteLine("your new driven distance is " + odometer + " km.");
        }

        public void Refill(double amount)
        {
            throw new NotImplementedException();
        }

        public void UseEnergy(double distance)
        {
            throw new NotImplementedException();
        }
    }
}
