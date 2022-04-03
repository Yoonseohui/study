using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class Class14_1
    {
        static void Main(string[] args)
        {
            Func<int> func_1 = () => 10;
            Func<int, int> func_2 = (a) => a * 2;

            // 예상 출력 결과 = 70
            Console.WriteLine(func_1() + func_2(30));
        }
    }
}
