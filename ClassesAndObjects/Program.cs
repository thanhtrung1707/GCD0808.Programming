using System;

namespace ClassesAndObjects
{
	class Program
	{
		static void Main(string[] args)
		{
			Student huy = new Student();

			//Console.WriteLine(huy.ID);
			//Console.WriteLine(huy.Age);
			//Console.WriteLine(huy.Name);
			//Console.WriteLine(huy.DoB.ToString("d"));
			//huy.ShowInfo();


			huy.Name = "Ngoc Huy";
			huy.Age = 20;
			huy.ID = "GCD191347";
			huy.DoB = new DateTime(2000, 11, 20);

			//Console.WriteLine(huy.ID);
			//Console.WriteLine(huy.Age);
			//Console.WriteLine(huy.Name);
			//Console.WriteLine(huy.DoB.ToString("f"));
			//huy.ShowInfo();

			Student john = new Student("GCD081023", "John Wick", 30, 1995, 12, 26);

			//Console.WriteLine(john.ID);
			//Console.WriteLine(john.Age);
			//Console.WriteLine(john.Name);
			//Console.WriteLine(john.DoB.ToString("f"));
			//john.ShowInfo();

			//huy.Talk(john);

			//john.Talk(huy);

			Batch GCD0808 = new Batch("GCD0808");
			GCD0808.Add(huy);
			GCD0808.Add(john);
			GCD0808.ShowAllStudents();


			Console.ReadLine();

		}
	}
}
