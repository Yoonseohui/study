using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0_프로그래밍
{
    class _14_1
    {
        static void Main(string[] args)
        {
            Func<int> func_1 = () => 10;
            Func<int, int> func_2 = (a) => a * 2;

            Console.WriteLine(func_1() + func_2(30));
        }
    }
}

//답 : 70