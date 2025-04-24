using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp___Arv
{
    abstract internal class Car : IDrivable
    {
        public string brand {  get; set; }
        public string model { get; set; }
        public string licensePlate {  get; set; }
        public bool isEngineOn { get; set; }
        public double odometer { get; set; }


        

        public override string ToString()
        {
            return $"{brand} {model}, {licensePlate}, {isEngineOn}, Km: {odometer}";
        }

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

        public void StartEngine()
        {
            throw new NotImplementedException();
        }

        public void StopEngine()
        {
            throw new NotImplementedException();
        }
    }

}   
    


