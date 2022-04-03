using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0_프로그래밍
{
    class _14_2
    {
        static void Main(string[] args)
        {
            int[] array = { 11, 22, 33, 44, 55 };

            foreach (int a in array)
            {
                //Action action = new Action
                //(
                //    delegate ()
                //    {
                //        Console.WriteLine(a * a);

                //    }
                //);

                Action action = () => Console.WriteLine(a * a);
                action.Invoke();
            }
        }
    }
}

//https://afsdzvcx123.tistory.com/entry/C-%EB%AC%B8%EB%B2%95-C-Action-%EB%8C%80%EB%A6%AC%EC%9E%90-%EC%82%AC%EC%9A%A9%EB%B0%A9%EB%B2%95