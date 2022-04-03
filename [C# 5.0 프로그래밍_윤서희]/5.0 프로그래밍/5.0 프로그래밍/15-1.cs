using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0_프로그래밍
{
    class _15_1
    {
        static void Main(string[] args)
        {
            Car[] cars =
           {
        new Car(){Cost=56, MaxSpeed=120},
        new Car(){Cost=70, MaxSpeed=150},
        new Car(){Cost=45, MaxSpeed=180},
        new Car(){Cost=32, MaxSpeed=200},
        new Car(){Cost=82, MaxSpeed=280},
            };

            var selected = from Car in cars
                           where Car.Cost >= 50 && Car.MaxSpeed >= 150
                           select new { Car.Cost, Car.MaxSpeed };

            foreach (var Carcost in selected)
            {
                Console.WriteLine(Carcost);
            }
        }
    }

    class Car
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }
}
