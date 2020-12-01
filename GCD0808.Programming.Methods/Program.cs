using System;

namespace GCD0808.Programming.Methods
{
	class Program
	{

		static void PrintHelloWorld()
		{
			Console.WriteLine("Hello World");
		}

		static void Hello(string name)
		{
			Console.WriteLine($"Hello {name}, Welcome!!!");
		}

		static int FirstDegreeFunction(int a, int x, int b)
		{
			return a * x + b;
		}

		static int FindRootOfFirstDegreeFunction(int y, int b, int a)
		{
			if (a == 0)
			{
				Console.WriteLine("No Root");
				return 0;
			}
			return (y - b) / a;
		}

		static string HelloWorld(string name)
		{
			Hello(name);
			return $"Hello{name}, Welcome!!!";
		}

		static void PrintNumbers(int i)
		{
			for (int idx = 0; idx <= i; idx++)
			{
				Console.WriteLine(idx);
				if (idx == 10)
				{
					return;
				}
			}
		}

		static string PrintString(string input)
		{
			string result = "";
			for (int i = 0; i < 10; i++)
			{
				if (input == "abc")
				{
					return "NULL";
				}
				result = input + i + result;

			}

			return result;
		}

		static void Print(string name)
		{
			Console.WriteLine(name);
		}

		static void Print(string name, int number)
		{
			Print(name);
			Console.WriteLine($"{name}, {number}");
		}
		static string Print(int number)
		{
			return $"{number}";
		}

		static int Sum(int a, int b)
		{
			return a + b;
		}

		static int Sum(int a, int b, int c)
		{
			return a + b + c;
		}

		static int Sum(int[] array)
		{
			int res = 0;
			foreach (int number in array)
			{
				res = res + number;
			}

			return res;
		}



		static void Main(string[] args)
		{
			Print("abc", 123);

			Print("abc");

			Print(123);

			PrintHelloWorld();

			Hello("John Wick");

			Hello("Paul");

			Hello("Donald Trump");

			string helloWorld = HelloWorld("George Clooney");
			Console.WriteLine(helloWorld);

			Console.WriteLine(HelloWorld("Bill Clinton"));

			Hello(HelloWorld("Mike Brant"));

			PrintNumbers(5);

			PrintNumbers(20);

			Console.ReadLine();
		}
	}
}
