using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    class Car
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }
    internal class Class15_1
    {
        static void Main(string[] args)
        {
            Car[] cars =
            {
                new Car(){Cost = 56, MaxSpeed = 120 },
                new Car(){Cost = 70, MaxSpeed = 150 },
                new Car(){Cost = 45, MaxSpeed = 180 },
                new Car(){Cost = 32, MaxSpeed = 200 },
                new Car(){Cost = 82, MaxSpeed = 280 }
            };

            // 메소드식 표현
            var selected = cars.Where(car => car.Cost >= 50 && car.MaxSpeed >= 150);

            // 쿼리 표현
            //var selected = (
            //    from car in cars
            //    where car.Cost >= 50 && car.MaxSpeed >= 150
            //    select car);

            foreach (Car car in selected)
                Console.WriteLine(car.Cost);
        }
    }
}
