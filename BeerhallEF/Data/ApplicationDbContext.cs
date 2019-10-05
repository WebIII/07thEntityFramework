using BeerhallEF.Data.Mapping;
using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;

namespace BeerhallEF.Data
{
    public class ApplicationDbContext : DbContext
    {
        #region DbSets
        public DbSet<Brewer> Brewers { get; set; }
        public DbSet<Beer> Beers { get; set; }
        //(Optional due to type discovery, but it's a good practise to be explicit)
        public DbSet<Location> Locations { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionstring =
                                 @"Server=.;Database=Beerhall;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BrewerConfiguration());
            modelBuilder.ApplyConfiguration(new BeerConfiguration());
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new OnlineCourseConfiguration());
            modelBuilder.ApplyConfiguration(new OnsiteCourseConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryBrewerConfiguration());
        }
    }
}
