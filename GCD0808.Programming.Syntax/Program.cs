using System;

namespace GCD0808.Programming.Syntax
{
	class Program
	{
		static void Main(string[] args)
		{
			//int a = int.Parse(Console.ReadLine());
			//string helloWorld = Console.ReadLine();
			//Console.WriteLine(helloWorld + a + " Hello Earth");
			//Console.WriteLine("a: {0} helloWorld: {1}", a, helloWorld);
			//Console.WriteLine($"a: {a}, helloWorld: {helloWorld}");

			//Console.WriteLine(10 < 20);
			//Console.WriteLine(10 == 5 * 2);
			//Console.WriteLine(2 > 3);

			//double grade = double.Parse(Console.ReadLine());
			//if (grade < 35)
			//{
			//	Console.WriteLine("Failed");
			//}
			//else if (grade < 65)
			//{
			//	Console.WriteLine("Passed");
			//}
			//else if (grade < 80)
			//{
			//	Console.WriteLine("Good");
			//}
			//else
			//{
			//	Console.WriteLine("Excellent");
			//}

			string day = Console.ReadLine();
			int age = int.Parse(Console.ReadLine());

			switch (day)
			{
				case "Weekday":
					if (age >= 0 && age <= 18)
					{
						Console.WriteLine("12$");
					}
					else if (age <= 64)
					{
						Console.WriteLine("18$");
					}
					else if (age <= 122)
					{
						Console.WriteLine("12$");
					}
					else
					{
						Console.WriteLine("Error");
					}
					break;
				case "Weekend":
					if (age >= 0 && age <= 18)
					{
						Console.WriteLine("15$");
					}
					else if (age <= 64)
					{
						Console.WriteLine("20$");
					}
					else if (age <= 122)
					{
						Console.WriteLine("15$");
					}
					else
					{
						Console.WriteLine("Error");
					}
					break;
				case "Holiday":
					if (age >= 0 && age <= 18)
					{
						Console.WriteLine("5$");
					}
					else if (age <= 64)
					{
						Console.WriteLine("12$");
					}
					else if (age <= 122)
					{
						Console.WriteLine("10$");
					}
					else
					{
						Console.WriteLine("Error");
					}
					break;
				default:
					Console.WriteLine("Error");
					break;
			}

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine(Math.PI);



			Console.ReadLine();
		}
	}
}
