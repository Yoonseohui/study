using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class Class12
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for(int i = 0; i < 10; i++)
                arr[i] = i;

            try
            {
                for (int i = 0; i < 11; i++)
                    Console.WriteLine(arr[i]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n*exception 발생");
                Console.WriteLine(ex.ToString());
                return;
            }
        }
    }
}
