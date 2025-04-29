using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarApp___Arv
{
    internal class Car : IDrivable
    {
        public string brand {  get; set; }
        public string model { get; set; }
        public int id {  get; set; }
        public bool isEngineOn { get; set; }
        public int odometer { get; set; }


        public string ToFileString()
        {
            return $"{brand} {model}, {id}, {isEngineOn}, Km: {odometer}";
        }

       public static Car FromFileString(string fileString)
        {
            string[] parts = fileString.Split(',');
            return new Car
            {
                brand = parts[0],
                model = parts[1],
                id = int.Parse(parts[2]),
                isEngineOn = bool.Parse(parts[3]),
                odometer = int.Parse(parts[4])
            };
        }


        public override string ToString()
        {
            return $"{brand} {model}, {id}, {isEngineOn}, Km: {odometer}";
        }


        void IDrivable.StopEngine(bool isEngineOn)
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
        void IDrivable.StartEngine(bool isEngineOn)
        {
            if (isEngineOn == true)
            {
                Console.WriteLine("The Engine is already on!");
            }
            else
            {
                isEngineOn = true;
            }

        }

        public virtual void Drive(double distance)
        {

            Console.WriteLine("What is the length of your trip?: ");
            distance = Convert.ToDouble(Console.ReadLine());
            odometer += (int)distance;
        }

    }

}   
    


