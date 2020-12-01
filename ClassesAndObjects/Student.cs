using System;

namespace ClassesAndObjects
{
	class Student
	{
		// Properties
		public string ID;
		public string Name;
		public int Age;
		public DateTime DoB;

		// Constructor without parameters
		public Student()
		{
			ID = "N/A";
			Name = "N/A";
			Age = -1;
			DoB = new DateTime(2008, 3, 1);
		}

		// Constructor with params

		public Student(string id, string name, int age, int year, int month, int day)
		{
			ID = id;
			Name = name;
			Age = age;
			DoB = new DateTime(year, month, day);
		}

		// Methods
		public void ShowInfo()
		{
			Console.WriteLine($"ID: {ID}");
			Console.WriteLine($"Name: {Name}");
			Console.WriteLine($"Age: {Age}");
			Console.WriteLine($"Date of Birth: {DoB.ToString("f")}");
			Console.WriteLine("===========");
		}

		public void Talk(Student student)
		{
			Console.WriteLine($"My Name is: {Name}");
			Console.WriteLine($"Your name is: {student.Name}");
		}

	}
}
