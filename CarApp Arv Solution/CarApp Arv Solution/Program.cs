namespace CarApp___Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            FuelCar fuelCar = new FuelCar();
            Console.WriteLine(fuelCar.brand + ", " + fuelCar.model + ", " + fuelCar.licensePlate + ", " + fuelCar.isEngineOn + ", " + fuelCar.odometer + ", " + fuelCar.fuelLevel + ", " + fuelCar.tankCapacity + ", " + fuelCar.kmPerLiter);
            //fuelCar.StartEnigine();
            //fuelCar.StopEngine(false);
            //fuelCar.Refuel(0);
            fuelCar.Drive(0);

            ElectricCar electricCar = new ElectricCar();
            
            //electricCar.StartEnigine();
            //electricCar.StopEngine(false);
            //electricCar.Charge(0);
            electricCar.Drive(0);

            */
            Taxi taxi = new Taxi();
            Console.WriteLine(taxi.brand + ", " + taxi.model + ", " + taxi.licensePlate + ", " + taxi.isEngineOn + ", " + taxi.odometer);
            taxi.CalculateTripPrice(50,5,10);
            Console.WriteLine(taxi.calculateFare);
        }

      
    }
}
