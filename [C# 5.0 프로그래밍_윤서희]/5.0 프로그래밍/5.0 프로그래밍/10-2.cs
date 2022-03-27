using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0_프로그래밍
{
    class _10_2
    {
        static void Main(string[] args)
        {
            int[,] A = new int[2, 2];
            A[0, 0] = 3;
            A[0, 1] = 2;
            A[1, 0] = 1;
            A[1, 1] = 4;

            int[,] B = new int[2, 2];
            B[0, 0] = 9;
            B[0, 1] = 2;
            B[1, 0] = 1;
            B[1, 1] = 7;

            int[,] result = new int[2, 2];
            result[0, 0] = A[0, 0] * B[0, 0] + A[0, 1] * B[1, 0];
            result[0, 1] = A[0, 0] * B[0, 1] + A[0, 1] * B[1, 1];
            result[1, 0] = A[1, 0] * B[0, 0] + A[1, 1] * B[1, 0];
            result[1, 1] = A[1, 0] * B[0, 1] + A[1, 1] * B[1, 1];

            for(int i=0; i<result.GetLength(0); i++)
            {
                for(int j=0; j<result.GetLength(1); j++)
                {
                    Console.WriteLine(result[i,j]);
                }
            }
        }
    }
}
