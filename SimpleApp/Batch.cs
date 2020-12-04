using System.Collections.Generic;
using System.Linq;

namespace SimpleApp
{
	class Batch
	{
		public string Name;
		public List<Student> Students;

		public Batch()
		{
			Name = "N/A";
		}

		public Batch(string name)
		{
			Name = name;
			Students = new List<Student>();
		}

		public Student FindStudentById(string id)
		{
			return Students.SingleOrDefault(s => s.Id.Equals(id));
		}

		public bool Add(Student student)
		{
			if (FindStudentById(student.Id) != null)
			{
				return false;
			}

			Students.Add(student);
			return true;
		}

		public bool DeleteStudentById(string id)
		{
			var studentInBatch = FindStudentById(id);

			if (studentInBatch == null) return false;

			Students.Remove(studentInBatch);
			return true;
		}

		public bool EditStudentById(string id, string fullName, int age)
		{
			var studentInBatch = FindStudentById(id);

			if (studentInBatch == null) return false;

			studentInBatch.FullName = fullName;
			studentInBatch.Age = age;

			return true;

		}
	}
}
