using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0_프로그래밍
{
    class _12_1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
                arr[i] = i;

            for (int i = 0; i < 11; i++)
                try
                {
                    Console.WriteLine(arr[i]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
        }
    }
}
