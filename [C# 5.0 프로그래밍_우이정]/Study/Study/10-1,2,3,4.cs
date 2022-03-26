using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Class10_1234
    {
        public static void Main()
        {
            // 1 번 - 첫번째 것 : 서로의 타입이 맞지 않음
            //int[] array = new string[3] { "안녕", "Hello", "Halo" };
            //int[] array2 = new int[3] { 1, 2, 3 };
            //int[] array3 = new int[] { 1, 2, 3 };
            //int[] array4 = { 1, 2, 3 };


            //2 번
            int[,] A = new int[2, 2] { { 3, 2 }, { 1, 4 } };
            int[,] B = new int[2, 2] { { 9, 2 }, { 1, 7 } };

            int[,] result = MatrixProduct(A, B);

            Console.WriteLine("{0}, {1}\n{2}, {3}", result[0, 0], result[0, 1], result[1, 0], result[1, 1]);
        }


        public static int[,] MatrixProduct(int[,] A, int[,] B)
        {
            int[] first_row = new int[2] { A[0, 0] * B[0, 0] + A[0, 1] * B[1, 0], A[0, 0] * B[0, 1] + A[0, 1] * B[1, 1] };
            int[] second_row = new int[2] { A[1, 0] * B[0, 0] + A[1, 1] * B[1, 0], A[1, 0] * B[0, 1] + A[1, 1] * B[1, 1] };

            int[,] result = new int[2, 2] { { first_row[0], first_row[1] }, { second_row[0], second_row[1] } };

            return result;
        }


        // 3 번 - 예상 출력 결과 = 54321
        //Stack stack = new Stack();
        //stack.Push(1);
        //stack.Push(2);
        //stack.Push(3);
        //stack.Push(4);
        //stack.Push(5);

        //while (stack.Count > 0)
        //    Console.WriteLine(stack.Pop());


        // 4 번 - 예상 출력 결과 = 12345
        //Queue que = new Queue();
        //que.Enqueue(1);
        //que.Enqueue(2);
        //que.Enqueue(3);
        //que.Enqueue(4);
        //que.Enqueue(5);

        //while (que.Count > 0)
        //    Console.WriteLine(que.Dequeue());
    }
}