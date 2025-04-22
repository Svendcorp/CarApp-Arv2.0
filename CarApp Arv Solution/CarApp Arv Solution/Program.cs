namespace CarApp___Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuelCar fuelCar = new FuelCar();
            Console.WriteLine(fuelCar.brand + ", " + fuelCar.model + ", " + fuelCar.licensePlate + ", " + fuelCar.isEngineOn + ", " + fuelCar.odometer + ", " + fuelCar.fuelLevel + ", " + fuelCar.tankCapacity + ", " + fuelCar.kmPerLiter);

            ElectricCar electricCar = new ElectricCar();
            Console.WriteLine(electricCar.brand + ", " + electricCar.model + ", " + electricCar.licensePlate + ", " + electricCar.isEngineOn + ", " + electricCar.odometer + ", " + electricCar.batteryLevel + ", " + electricCar.batteryCapacity + ", " + electricCar.kmPerKWh);

        }

        class Car
        {
            public string brand = "Toyota";
            public string model = "Corrola";
            public string licensePlate = "GG53289";
            public bool isEngineOn = false;
            public double odometer = 0;


            public void StartEnigine()
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

            public void StopEngine()
            {
                if (!isEngineOn == false)
                {
                    Console.WriteLine("The Engine is already turned off!");
                }
                else
                {
                    isEngineOn = false;
                }
            }

            public virtual void Drive(double distance)
            {

            }

        }




        class FuelCar : Car
        {
            public double fuelLevel = 30;
            public double tankCapacity = 50;
            public double kmPerLiter = 14.6;

            //Contructor


            public void Refuel(double amount)
            {

            }


            public override void Drive(double distance)
            {
                odometer += distance;

            }

        }


        class ElectricCar : Car
        {
            public double batteryLevel = 80;
            public double batteryCapacity = 100;
            public double kmPerKWh = 6;


            public void Charge(double amount)
            {

            }

            public override void Drive(double distance)
            {
                odometer += distance;
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
