using Shared.Enums;
using System;

namespace Shared.Entities
{
	public class Teacher
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public DateTime DateOfBirth { get; set; }

		public int Age { get; set; }

		public string Email { get; set; }

		public string Phone { get; set; }

		public Evaluation Evaluation { get; set; }

		public Gender Gender { get; set; }

		public int CourseId { get; set; }
		public Course Course { get; set; }
	}
}
