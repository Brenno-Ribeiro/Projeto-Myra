using Microsoft.EntityFrameworkCore;
using StationAPI.Models;

namespace StationAPI.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DataContext()
        {
        }

        public DbSet<Auth> Auths { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Auth>().HasData(
                new Auth { Id = 1, userName = "Admin", password = "Admin" }
            );
        }

    }
}
