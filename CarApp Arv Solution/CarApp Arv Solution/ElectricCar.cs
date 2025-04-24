using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp___Arv
{
    internal class ElectricCar : Car
    {
        public double batteryLevel = 80;
        public double batteryCapacity = 100;
        public double kmPerKWh = 6;
        public double kWhPrice = 3.0;
        public double chargingAmount;


        public void Charge(double amount)
        {
            Console.WriteLine(batteryLevel);
            Console.WriteLine("You can charge the car " + (batteryCapacity - batteryLevel) + " %, and it wil cost you " + ((batteryCapacity - batteryLevel) * kWhPrice) + " DDK.");

            Console.WriteLine("How much power would you like to charge the battery?: ");
            chargingAmount = Convert.ToDouble(Console.ReadLine());

            if (chargingAmount + batteryLevel > batteryCapacity)
            {
                Console.WriteLine("You can't charge a battery over 100%!!!");
            }
            else
            {
                batteryLevel += chargingAmount;
                Console.WriteLine(batteryLevel);
            }

        }

        public override void Drive(double distance)
        {
            Console.WriteLine("What is the length of your trip?: ");
            distance = Convert.ToDouble(Console.ReadLine());

            if (distance < batteryLevel * kmPerKWh)
            {
                batteryLevel -= distance / kmPerKWh;
                odometer += distance;
            }
            else
            {
                Console.WriteLine("There is not enoght battery to drive the given lenght");
            }


            Console.WriteLine("The battery level is now " + Math.Round(batteryLevel, 2) + "%.");
            Console.WriteLine("your new driven distance is " + odometer + " km.");
        }
    }
        
    
}
