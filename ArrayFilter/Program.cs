using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayFilter
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = GenerateArray();
			Print(a);
			var b = FilterArray(a);
			Print(b);
		}

		private static int[] FilterArray(int[] a)
		{
			var size = CountEvens(a);
			var b = new int[size];
			var i = 0;
			foreach (var x in a)
			{
				if (x % 2 == 0)
				{
					b[i] = x;
					i = i + 1;
				}
			}
			return b;
		}

		private static int CountEvens(int[] a)
		{
			var i = 0;
			foreach (var x in a)
			{
				if (x % 2 == 0)
				{
					i = i + 1;
				}
			}
			return i;
		}

		private static void Print(int[] a)
		{
			foreach (var x in a)
			{
				Console.Write(x + " ");
			}
			Console.WriteLine();
		}

		private static int[] GenerateArray()
		{
			var randomGenerator = new Random();

			var size = randomGenerator.Next(5, 10);

			var a = new int[size];
			for (int i = 0; i < a.Length; i++)
			{
				a[i] = randomGenerator.Next(0, 10);
			}
			return a;
		}
	}
}
