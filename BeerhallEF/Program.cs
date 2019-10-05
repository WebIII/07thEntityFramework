using BeerhallEF.Data;
using System;

namespace BeerhallEF
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                Console.WriteLine("Database created");
            }
        }
    }
}
