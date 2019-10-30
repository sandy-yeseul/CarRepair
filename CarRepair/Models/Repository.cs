using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRepair.Models
{
    public class Repository
    {
        private static List<Car> cars = new List<Car>();
        public static IEnumerable<Car> Cars
        {
            get
            {
                return cars;
            }
        }
        public static void AddCar(Car car)
        {
            cars.Add(car);
        }
    }
}
