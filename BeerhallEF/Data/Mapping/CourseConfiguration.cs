using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeerhallEF.Data.Mapping
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            #region Table
            builder.ToTable("Course");

            // Table-per-Hierarchy Strategy (https://docs.microsoft.com/en-us/ef/core/modeling/relational/inheritance)
            builder.HasDiscriminator<string>("Type")
                    .HasValue<OnlineCourse>("Online")
                    .HasValue<OnsiteCourse>("Onsite");
            #endregion

            #region Properties
            builder.Property(t => t.Title)
                    .HasMaxLength(100)
                    .IsRequired();
            #endregion
        }
    }
}