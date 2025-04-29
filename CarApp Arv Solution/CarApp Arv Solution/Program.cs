namespace CarApp___Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuelCar fuelCar = new FuelCar();
            Console.WriteLine(fuelCar.brand + ", " + fuelCar.model + ", " + fuelCar.id + ", " + fuelCar.isEngineOn + ", " + fuelCar.odometer + ", " + fuelCar.fuelLevel + ", " + fuelCar.tankCapacity + ", " + fuelCar.kmPerLiter);

            fuelCar.Refuel(20);


            ElectricCar electricCar = new ElectricCar();
            Console.WriteLine(electricCar.brand + ", " + electricCar.model + ", " + electricCar.id + ", " + electricCar.isEngineOn + ", " + electricCar.odometer + ", " + electricCar.batteryLevel + ", " + electricCar.batteryCapacity + ", " + electricCar.kmPerKWh);
            electricCar.Charge(20);
        }
    }
}
