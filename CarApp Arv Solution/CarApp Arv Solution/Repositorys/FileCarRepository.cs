using CarApp___Arv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp___Arv
{
    public class FileCarRepository : ICarRepository
    {

        private readonly string _CarFilePath;

        public FileCarRepository(string carFilePath)
        {
            _CarFilePath = carFilePath;
            if (!File.Exists(_CarFilePath))
            {
                File.Create(_CarFilePath).Close();
            }
        }

        Car ICarRepository.GetCar(int id)
        {
            return GetCar().FirstOrDefault(p => p.id == id);
        }
        IEnumerable<Car> ICarRepository.GetAllCars(Car car)
        {
            try
            {
                return File.ReadAllLines(_CarFilePath)
                        .Where(line => !string.IsNullOrEmpty(line))
                        .Select(Car.FromFileString)
                        .ToList();
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Fejl ved læsning af fil: {ex.Message}");
                return new List<Car>();
            }
        }

        void ICarRepository.AddCar(Car car)
        {
            List<Car> cars = GetAllCars().ToList();
            car.id = cars.Any() ? cars.Max(p => p.id) + 1 : 1;
            try
            {
                File.AppendAllText(_CarFilePath, car.ToFileString() + Environment.NewLine);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Fejl ved skrivning til fil: {ex.Message}");
            }
        }
        void ICarRepository.UpdateCar(Car car)
        {
            List<Car> cars = GetAllCars().ToList();
            int index = cars.FindIndex(p => p.id == car.id);
            if (index != -1)
            {
                cars[index] = car;
                RewriteFile(cars);
            }
        }
        void ICarRepository.DeleteCar(int id)
        {
            List<Car> cars = GetAllCars().ToList();
            cars.RemoveAll(p => p.id == id);
            RewriteFile(cars);
        }

        private void RewriteFile(List<Car> cars)
        {
            try
            {
                File.WriteAllLines(_CarFilePath, cars.Select(p => p.ToFileString()));
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Fejl ved skrivning til fil: {ex.Message}");
            }
        }




        /*
        IEnumerable<Car> ICarRepository.GetAllCars()
        {
            throw new NotImplementedException();
        }

        Car ICarRepository.GetCar(int id)
        {
            return _car.FirstOrDefault(p => p.id == id);
        }

        void ICarRepository.AddCar(Car car)
        {
            throw new NotImplementedException();
        }

        void ICarRepository.UpdateCar(Car car)
        {
            var existingCar = _car.FirstOrDefault(p => p.id == Car.id);
            if (existingCar != null)
            {
                existingCar.brand = car.brand;
                existingCar.model = car.model;
            }
        }

        void ICarRepository.DeleteCar(int id)
        {
            throw new NotImplementedException();
        }*/
    }
}
