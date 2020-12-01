using System;
using System.Collections.Generic;

namespace GCD0808.Programming.Lists
{
	class Program
	{

		static void PrintList(List<string> list)
		{
			Console.WriteLine("=============");

			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
		}
		static void Main(string[] args)
		{
			// Initialize a List with string data type
			List<string> listString = new List<string>();

			listString.Add("One");
			listString.Add("Two");
			listString.Add("Three");
			listString.Add("Four");
			listString.Add("Five");

			PrintList(listString);

			Console.WriteLine($"Length of listString: {listString.Count}");

			listString.Remove("Two");

			PrintList(listString);

			listString.Add("Two");

			PrintList(listString);

			listString.RemoveAt(4);
			PrintList(listString);

			listString.Insert(1, "Six");
			PrintList(listString);

			Console.WriteLine(listString.Contains("One"));
			Console.WriteLine(listString.Contains("Teen"));

			listString.Sort();
			PrintList(listString);

			listString.Reverse();
			PrintList(listString);

			Console.ReadLine();

			// Initialize a List with int data type
			//List<int> listInt = new List<int>();
		}
	}
}
