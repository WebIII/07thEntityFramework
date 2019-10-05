using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeerhallEF.Data.Mapping
{
    class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            #region Table
            builder.ToTable("Location");
            #endregion

            #region Keys and Indices
            builder.HasKey(t => t.PostalCode);
            #endregion

            #region Properties
            builder.Property(t => t.PostalCode)
                    .HasMaxLength(5);

            builder.Property(t => t.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            #endregion
        }
    }
}