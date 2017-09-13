using System;

namespace ClassWork
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int MAX = 1000;
			int x = 1;
			int y = 1;

			Console.WriteLine(x);
			Console.WriteLine(y);

			while (x + y < MAX)
			{
				int sum = x + y;
				x = y;
				y = sum;
				Console.WriteLine(sum);
			}
        }
    }
}
//this makes you do fibanocci sequance'
// notes for class