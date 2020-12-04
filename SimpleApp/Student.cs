using System;

namespace SimpleApp
{
	class Student
	{
		public string Id;
		public string FullName;
		public int Age;

		public Student()
		{
			Id = "N/A";
			FullName = "N/A";
			Age = -1;
		}

		public Student(string id, string fullName, int age)
		{
			Id = id;
			FullName = fullName;
			Age = age;
		}

		public void ShowInfo()
		{
			Console.WriteLine($"Id: {Id}");
			Console.WriteLine($"Full Name: {FullName}");
			Console.WriteLine($"Age: {Age}");
		}
	}
}
