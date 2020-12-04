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

			Console.ReadLine();
		}
	}
}
