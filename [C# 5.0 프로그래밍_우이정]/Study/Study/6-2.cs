using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Class6_2
    {
        public static void Main(string[] args)
        {
            double mean = 0;

            Mean(1, 2, 3, 4, 5, ref mean);  // 기존의 double mean 이었던 것을 ref 키워드를 사용함

            Console.WriteLine("평균 : {0}", mean);
        }

        public static void Mean(
            double a, double b, double c,
            double d, double e, ref double mean)    // 기존의 double mean 이었던 것을 ref 키워드를 사용함
        {
            mean = (a + b + c + d + e) / 5;
        }
    }
}
