using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    public class Class5
    {
        public static void Main()
        {
            // 1 번
            Console.WriteLine("1번");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 2 번
            Console.WriteLine("2번");
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 3 번
            Console.WriteLine("3번");
            int a = 0;
            int b = 0;
            do
            {
                a++;
                b = 0;
                while(b < a)
                { 
                    Console.Write("*");
                    b++;
                }
                Console.WriteLine();
            }while (a < 5) ;

            Console.WriteLine();

            a = 6;
            b = 0;
            do
            {
                a--;
                b = 0;
                while (b < a)
                {
                    Console.Write("*");
                    b++;
                }
                Console.WriteLine();
            } while (a > 0) ;


                // 4 번
                Console.WriteLine("4번");
            Console.Write("반복 횟수를 입력하세요 : ");
            int input = Int32.Parse(Console.ReadLine());

            if (input <= 0)
            {
                Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
                return;
            }
            else
            {
                for (int i = 0; i < input; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            
        }
    }
}
