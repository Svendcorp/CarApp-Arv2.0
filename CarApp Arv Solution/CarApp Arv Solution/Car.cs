using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp___Arv
{
    abstract internal class Car
    {
        public string brand = "Toyota";
        public string model = "Corrola";
        public string licensePlate = "GG53289";
        public bool isEngineOn = false;
        public double odometer = 0;


        public void StartEnigine(bool isEngineOn)
        {
            if (isEngineOn == true)
            {
                Console.WriteLine("The Engine is already on!");
            }
            else
            {
                isEngineOn = true;
                Console.WriteLine("The Engine is now on!");
            }

        }

        public void StopEngine(bool isEngineOn)
        {
            if (!isEngineOn == false)
            {
                Console.WriteLine("The Engine is already turned off!");
            }
            else
            {
                isEngineOn = false;
                Console.WriteLine("The Engine is now off!");
            }
        }

        public virtual void Drive(double distance)
        {

            Console.WriteLine("What is the length of your trip?: ");
            distance = Convert.ToDouble(Console.ReadLine());
            odometer += distance;

        }

    }

}   
    


