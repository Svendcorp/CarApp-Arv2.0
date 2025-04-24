namespace CarApp___Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuelCar fuelCar = new FuelCar();
            Console.WriteLine(fuelCar.brand + ", " + fuelCar.model + ", " + fuelCar.licensePlate + ", " + fuelCar.isEngineOn + ", " + fuelCar.odometer + ", " + fuelCar.fuelLevel + ", " + fuelCar.tankCapacity + ", " + fuelCar.kmPerLiter);
            //fuelCar.StartEnigine();
            //fuelCar.StopEngine(false);
            //fuelCar.Refuel(0);
            fuelCar.Drive(0);

            ElectricCar electricCar = new ElectricCar();
            Console.WriteLine(electricCar.brand + ", " + electricCar.model + ", " + electricCar.licensePlate + ", " + electricCar.isEngineOn + ", " + electricCar.odometer + ", " + electricCar.batteryLevel + ", " + electricCar.batteryCapacity + ", " + electricCar.kmPerKWh);
            //electricCar.StartEnigine();
            //electricCar.StopEngine(false);
            //electricCar.Charge(0);
            electricCar.Drive(0);

        }

        public class Car
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




        class FuelCar : Car
        {
            public double fuelLevel = 30;
            public double tankCapacity = 50;
            public double kmPerLiter = 14.6;
            public double fuelPrice = 10.0;
            public double reFuel;
            

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

                fuelLevel -= distance/kmPerLiter;
                odometer += distance;
                Console.WriteLine("The tank now has " + Math.Round(fuelLevel, 2) + " liters of fuel.");
                Console.WriteLine("your new driven distance is " + odometer + " km.");
            }

        }


        public class ElectricCar : Car
        {
            public double batteryLevel = 80;
            public double batteryCapacity = 100;
            public double kmPerKWh = 6;
            public double kWhPrice = 3.0;
            public double chargingAmount;


            public void Charge(double amount)
            {
                Console.WriteLine(batteryLevel);
                Console.WriteLine("You can charge the car " + (batteryCapacity-batteryLevel) + " %, and it wil cost you " + ((batteryCapacity-batteryLevel)*kWhPrice) + " DDK.");

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

                if (distance < batteryLevel*kmPerKWh)
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




        /*
        Console.WriteLine("Hello, World!");


        FuelCar fuelCar = new FuelCar();

            fuelCar.brand = "Toyota";
            fuelCar.model = "Corrola";
            fuelCar.licensePlate = "GG46738";
            fuelCar.isEngineOn = true;
            fuelCar.odometer = 10000;
            fuelCar.BaseDescription();


        ElectricCar electricCar = new ElectricCar();

            electricCar.brand = "Tesla";
            electricCar.model = "Model Y";
            electricCar.licensePlate = "DU72810";
            electricCar.isEngineOn = true;
            electricCar.odometer = 500;
            electricCar.BaseDescription();
        */

    }
}
