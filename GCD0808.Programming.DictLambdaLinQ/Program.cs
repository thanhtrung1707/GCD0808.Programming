using System;
using System.Collections.Generic;
using System.Linq;

namespace GCD0808.Programming.DictLambdaLinQ
{
	class Program
	{
		static void Main(string[] args)
		{
			var fruits = new Dictionary<string, double>();
			fruits.Add("banana", 2.20);
			fruits.Add("apple", 3.40);
			fruits.Add("baaaa", 3.40);

			foreach (var fruit in fruits)
			{
				Console.WriteLine(fruit);
				Console.WriteLine($"Key: {fruit.Key}");
				Console.WriteLine($"Value: {fruit.Value}");

			}

			Console.WriteLine("==========");

			var sortedFruits = new SortedDictionary<string, double>();
			sortedFruits.Add("kiwi", 2.25);
			sortedFruits.Add("orange", 2.39);
			sortedFruits.Add("apple", 2.21);

			foreach (var fruit in sortedFruits)
			{
				Console.WriteLine(fruit);
			}

			Console.WriteLine(sortedFruits.ContainsKey("kiwi"));
			Console.WriteLine(sortedFruits.ContainsValue(2.25));
			Console.WriteLine(sortedFruits.ContainsValue(1));


			sortedFruits.Remove("kiwi");

			Console.WriteLine(sortedFruits.ContainsKey("kiwi"));

			Console.WriteLine(42);

			Action<string> greet = name =>
			{
				string greeting = $"Hello {name}!";
				Console.WriteLine(greeting);
			};
			greet("World");

			Func<double, double> cube = x => x * x * x;

			Console.WriteLine(cube(20));

			Func<int, int, bool> testForEquality = (x, y) => x == y;

			Console.WriteLine(testForEquality(1, 2));

			List<int> listInt = new List<int>()
			{
				1,2,3,4,5,6,7,8,9,10
			};

			Console.WriteLine("===LINQ===");
			Console.WriteLine(listInt.Sum());
			Console.WriteLine(listInt.Min());
			Console.WriteLine(listInt.Max());
			Console.WriteLine(listInt.Average());

			Console.WriteLine("===List With LINQ");

			List<string> words = new List<string>()
			{
				"abc",
				"abc",
				"xyz"
			};

			var result = words.Select(w => w + "x");

			foreach (var word in result)
			{
				Console.WriteLine(word);
			}

			Console.WriteLine(words.SingleOrDefault(w => w.Contains("xyz")));


			int[] nums = { 100, -1, 2, 4, 5, 6, 10, 22, 3 };

			var numsResult = nums
				//.OrderBy(n => n)
				.OrderByDescending(n => n)
				.Where(n => n > 4)
				.ToArray();

			foreach (var num in numsResult)
			{
				Console.WriteLine(num);
			}

			Console.WriteLine("===ThenByFruit");

			var resultFruits = fruits
				.OrderByDescending(f => f.Value)
				.ThenBy(f => f.Key)
				.ToList();

			foreach (var fruit in resultFruits)
			{
				Console.WriteLine(fruit);
			}

			Console.ReadLine();


		}


	}
}
