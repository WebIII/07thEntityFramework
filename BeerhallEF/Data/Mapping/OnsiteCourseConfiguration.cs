using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeerhallEF.Data.Mapping
{
    class OnsiteCourseConfiguration : IEntityTypeConfiguration<OnsiteCourse>
    {
        public void Configure(EntityTypeBuilder<OnsiteCourse> builder)
        {
            #region Properties
            builder.Property(t => t.StartDate)
                    .HasField("_startDate");
            #endregion
        }
    }
}