using CarApp___Arv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp___Arv
{
     public interface ICarRepository
    {
        public IEnumerable<Car> GetAllCars(Car car);

        public Car GetCar(int id);

        public void AddCar(Car car);

        public void UpdateCar(Car car);

        public void DeleteCar(int id);


    }
}
