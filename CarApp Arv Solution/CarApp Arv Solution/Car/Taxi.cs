using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarApp___Arv
{
    internal class Taxi : Car, IEnergy
    {
        public double startPrice = 50;
        public double pricePerKm = 5;
        public double pricePerMinute = 10;
        public bool meterStarted = false;
        public double kmDriven;
        public double minutesSpend;

        public double calculateFare; //(PricePerKm*kmDriven)+(pricePerMinutes*minutesSpend)+startPrice

        public double EnergyLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double MaxEnergy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Taxi(string Brand, string Model, string LicensePlate, bool IsEngineOn, double Odometer)
        {
            brand = Brand;
            model = Model;
            isEngineOn = IsEngineOn;
            odometer = Odometer;
        }

        public void StartMeter(bool meterStarted)
        {
            if (meterStarted == true)
            {
                Console.WriteLine("The meter is already running.");
            }
            else
            {
                meterStarted = true;
                Console.WriteLine("The meter has now started");
            }
        }

        public void StopMeter(bool meterStarted)
        {
            if (meterStarted == false)
            {
                Console.WriteLine("The meter is already turned off");
            }
            else
            {
                meterStarted = false;
                Console.WriteLine("The meter has now stoped");
            }
        }   
         
        public void CalculateTripPrice(double startPrice, double PricePerKm, double pricePerMinute)
        {
            Console.WriteLine("How far did you drive? ");
            kmDriven= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many minutes did you drive for? ");
            minutesSpend = Convert.ToDouble(Console.ReadLine());
            calculateFare = startPrice + (kmDriven*PricePerKm) + (pricePerMinute*minutesSpend);
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
