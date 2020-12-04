using System;

namespace SimpleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Student student = new Student("111", "ABC", 19);
			UI.ShowStudentInfo(student);

			Batch batch = new Batch("GCD0808");
			batch.Add(student);

			UI.ShowBatchInfo(batch);

			string studentId = UI.EnterStudentId();

			string fullName = UI.EnterStudentFullName();

			int age = UI.EnterStudentAge();

			batch.Add(new Student(studentId, fullName, age));

			UI.ShowBatchInfo(batch);

			UI.ShowMenuControl();
			var option = UI.EnterOption();

			switch (option)
			{
				case 1:
					studentId = UI.EnterStudentId();

					fullName = UI.EnterStudentFullName();

					age = UI.EnterStudentAge();
					batch.Add(new Student(studentId, fullName, age));
					break;
				case 2:
					studentId = UI.EnterStudentId();
					if (batch.FindStudentById(studentId) != null)
						UI.ShowStudentInfo(batch.FindStudentById(studentId));
					else
						Console.WriteLine("Student not found");
					break;
				case 3:
					// Todo
					break;
				case 4:
					// Todo
					break;
				case 5:
					break;
			}

			Console.ReadLine();
		}
	}
}
