using System;

public class Program
{
	public static void Main()
	{
		// 1번 - ++ 연산의 순서가 다름
		Console.WriteLine("1번");
		int i = 0;
		Console.WriteLine(i++);	// 0이 출력되며, 다음에 i가 호출되면 그 때 +1 연산을 수행함
		i = 0;
		Console.WriteLine(++i); // 1이 출력되며, 바로 +1 연산을 수행함
		Console.WriteLine();


		// 2번 - 2번의 출력 결과가 다름
		Console.WriteLine("2번");
		i = 0;
		Console.WriteLine(i=i+1);   // 출력 = 1
		i = 0;
		Console.WriteLine(i++);     // 출력 = 0
		i = 0;
		Console.WriteLine(++i);     // 출력 = 1
		i = 0;
		Console.WriteLine(i+=1);    // 출력 = 1
		Console.WriteLine();


		// 3번 - >> (시프트 연산)
		Console.WriteLine("3번");
		int a = 8 >> 1;     // 출력 = 4
		Console.WriteLine(a);
		int b = a >> 2;     // 출력 = 1
		Console.WriteLine(b);
		Console.WriteLine();

		// 4번 - | (or 연산) (사진이 잘 안보임)
		Console.WriteLine("4번");
		int c = 0xF0 | 0x0F;    // 출력 = 0xFF => 252
		Console.WriteLine(c);
		Console.WriteLine();

		// 5번 - : ? 연산
		Console.WriteLine("5번");
		int d = 10;
		string e = d == 10 ? "가나다" : "ABC";	// 출력 = 가나다
		Console.WriteLine(e);
		Console.WriteLine();
	}
}