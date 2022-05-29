using Shared.Enums;
using System;
using System.Collections.Generic;

namespace Shared.Entities
{
	public class Student
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public DateTime DateOfBirth { get; set; }

		public int Age { get; set; }

		public Gender Gender { get; set; }

		public string Email { get; set; }

		public string Phone { get; set; }

		public List<StudentCourse> StudentCourses { get; set; }
	}
}
