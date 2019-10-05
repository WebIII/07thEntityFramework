using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeerhallEF.Data.Mapping
{
    internal class BeerConfiguration : IEntityTypeConfiguration<Beer>
    {
        public void Configure(EntityTypeBuilder<Beer> builder)
        {
            #region Table
            builder.ToTable("Beer");
            #endregion

            #region Properties
            builder.Property(t => t.Name)
                    .HasMaxLength(100)
                    .IsRequired();
            #endregion
        }
    }
}