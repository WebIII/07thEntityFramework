using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeerhallEF.Data.Mapping
{
    internal class BrewerConfiguration : IEntityTypeConfiguration<Brewer>
    {
        public void Configure(EntityTypeBuilder<Brewer> builder)
        {
            #region Table 
            builder.ToTable("Brewer");
            builder.Property(t => t.BrewerId).ValueGeneratedOnAdd();
            #endregion

            #region Keys and Indices
            builder.HasKey(t => t.BrewerId);
            #endregion

            #region Properties
            builder.Property(t => t.Name)
                .HasColumnName("BrewerName")
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(t => t.ContactEmail)
                .HasMaxLength(100);

            builder.Property(t => t.Street)
                .HasMaxLength(100);
            #endregion Properties

            #region associations
            builder.HasMany(t => t.Beers)
                  .WithOne()
                  .IsRequired()
                  .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(t => t.Location)
                .WithMany()
                .HasForeignKey(nameof(Location.PostalCode))
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(t => t.Courses)
                .WithOne(t => t.Brewer)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}