using System;

namespace StringAndStringBuilder
{
	class Program
	{
		static void Main(string[] args)
		{
			string hello = "";
			hello = "Hello" + " " + "C#";
			Console.WriteLine(hello);

			Console.WriteLine(hello[0]);
			Console.WriteLine(hello[4]);

			// hello[0] = 'a';

			string str = new String(new char[] { 's', 't', 'r' });
			char[] charArr = str.ToCharArray();

			hello = "Hello ";
			string name = "John Wick";

			Console.WriteLine(string.Concat(hello, name, hello));

			string fruits = "banana, apple, kiwi, banana, apple";
			Console.WriteLine(fruits.IndexOf("nana")); //0
			Console.WriteLine(fruits.IndexOf("orange")); //-1

			Console.WriteLine(fruits.Contains("banana"));
			Console.WriteLine(fruits.Contains("orange"));

			string fruit = "banana";

			Console.WriteLine(fruit.Equals("banana"));    // true
			Console.WriteLine(fruit.Contains("banana"));  // true
			Console.WriteLine(fruit.Contains("anana"));   // true
			Console.WriteLine(fruit.Equals("anana"));     // false

			string card = "10ABC";
			string power = card.Substring(1, 2);
			Console.WriteLine(power); //
			Console.WriteLine(card.Substring(2));

			string text = "Hello, john@softuni.bg, you have been usingjohn@softuni.bg in your registration";
			string[] words = text.Split(new char[] { ',', 'o', 'e' });

			char[] separators = new char[] { ' ', ',', '.' };
			text = "Hello, I am John.";
			words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

			string sample = "123";
			sample = "5555555555555555555555555";







			Console.ReadLine();

		}
	}
}
