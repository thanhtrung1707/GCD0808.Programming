using System;

namespace SimpleApp
{
	class UI
	{
		public static void ShowStudentInfo(Student student)
		{
			student.ShowInfo();
			Console.WriteLine("========");
		}

		public static void ShowBatchInfo(Batch batch)
		{
			Console.WriteLine($"Batch name: {batch.Name}");
			Console.WriteLine($"Number students in batch: {batch.Students.Count} student");
			Console.WriteLine("========");
		}

		public static string EnterStudentId()
		{
			Console.WriteLine("Please enter student Id: ");
			return Console.ReadLine();
		}
		public static string EnterStudentFullName()
		{
			Console.WriteLine("Please enter student Full Name: ");
			return Console.ReadLine();
		}
		public static int EnterStudentAge()
		{
			Console.WriteLine("Please enter student Age: ");
			return int.Parse(Console.ReadLine());
		}

	}
}
