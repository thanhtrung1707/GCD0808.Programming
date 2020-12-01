using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassesAndObjects
{
	class Batch
	{
		List<Student> Students;
		public string Name;

		public Batch(string name)
		{
			Name = name;
			Students = new List<Student>();
		}

		public void Add(Student student)
		{
			if (Students.Any(s => s.ID.Contains(student.ID)))
			{
				return;
			}

			Students.Add(student);
		}

		public void Remove(Student student)
		{
			if (!Students.Any(s => s.ID.Contains(student.ID)))
			{
				return;
			}
			Students.Remove(student);
		}

		public Student FindStudentById(string id)
		{
			var result = Students.SingleOrDefault(s => s.ID.Contains(id));

			if (result == null)
			{
				Console.WriteLine("Student Not Found");
				return null;
			}

			return result;
		}

		public void ShowAllStudents()
		{
			Console.WriteLine($"Batch: {Name}");
			Console.WriteLine("==========");

			foreach (var student in Students)
			{
				student.ShowInfo();
			}
		}
	}
}
