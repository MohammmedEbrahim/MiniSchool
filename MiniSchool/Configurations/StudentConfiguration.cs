using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniSchool.Entities;

namespace MiniSchool.Configurations
{
	public class StudentConfiguration : IEntityTypeConfiguration<Student>
	{
		public void Configure(EntityTypeBuilder<Student> builder)
		{
			builder.HasMany(x => x.StudentCourses)
				.WithOne(x => x.Student);
		}
	}
}
