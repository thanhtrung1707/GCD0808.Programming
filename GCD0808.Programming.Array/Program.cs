using System;

namespace GCD0808.Programming.Array
{
	class Program
	{
		static void Main(string[] args)
		{
			//int[] numbers = new int[10];

			//Console.WriteLine("Length of numbers: " + numbers.Length);


			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	numbers[i] = i + 2;
			//	Console.WriteLine($"numbers[{i}] has value {numbers[i]}");
			//}


			//string[] days = {
			//	"Monday",
			//	"Tuesday",
			//	"Wednesday",
			//	"Thursday",
			//	"Friday",
			//	"Saturday",
			//	"Sunday"
			//};

			//int input = int.Parse(Console.ReadLine());

			//if (input >= 1 && input <= 7)
			//{
			//	Console.WriteLine($"{days[input - 1]}");
			//}
			//else
			//{
			//	Console.WriteLine("Invalid day");
			//}

			//int n = int.Parse(Console.ReadLine());

			//int[] arr = new int[n];

			//for (int i = 0; i < arr.Length; i++)
			//{
			//	arr[i] = int.Parse(Console.ReadLine());
			//}

			//for (int i = arr.Length - 1; i >= 0; i--)
			//{
			//	Console.Write(arr[i] + " ");
			//}



			int[] arr = { 1, 2, 3, 5, 6 };

			foreach (var number in arr)
			{
				// foreach: read-only
				// number = number + 10;
				Console.WriteLine(number);
			}

			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = arr[i] + 10;
				Console.WriteLine(arr[i]);
			}

			Console.ReadLine();

		}
	}
}
