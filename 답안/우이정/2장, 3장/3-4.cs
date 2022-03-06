using System;

namespace RectArea
{
	public class MainApp
	{
		public static void Main()
		{
			Console.WriteLine("사각형의 너비를 입력하세요.");
			string width = Console.ReadLine();
			
			Console.WriteLine("사각형의 높이를 입력하세요.");
			string height = Console.ReadLine();
			
			Console.WriteLine("사각형의 넓이는 {0} 입니다.", Int32.Parse(width) * Int32.Parse(height));
		}
	}
}