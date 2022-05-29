using MiniSchool.Enums;
using System.Collections.Generic;

namespace MiniSchool.Entities
{
	public class Course
	{ 
		public int Id { get; set; }

		public string Name { get; set; }

		public string Code { get; set; }

		public CourseType CourseType { get; set; }

		public int TeacherId { get; set; }
		public Teacher Teacher { get; set; }

		public List<StudentCourse> StudentCourses { get; set; }
	}
}
