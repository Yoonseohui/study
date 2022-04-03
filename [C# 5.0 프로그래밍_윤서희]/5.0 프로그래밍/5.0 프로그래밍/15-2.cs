using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0_프로그래밍
{
    class _15_2
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

            // var selected = cars.Where(c => c.Cost < 60).OrderBy(c => c.Cost);

            var selected = from C in cars
                           where C.Cost < 60
                           orderby C.Cost
                           select C.Cost;

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
