using DatabaseModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace DatabaseContext
{
    public class DatabaseContexts : DbContext
    {
        public DbSet<Follower> Follower { get; set; }
        public DbSet<Subscription> Subscription { get; set; }
        public DbSet<Party> Party { get; set; }

        public DatabaseContexts()
        { }
        public DatabaseContexts(DbContextOptions<DatabaseContexts> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString: "User ID=postgres; Password=123; Server=localhost; Port=5432; Database=AppVK"); //Database=StudentsDb;
        }

    }
}
