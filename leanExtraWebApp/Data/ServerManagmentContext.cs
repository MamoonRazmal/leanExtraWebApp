using leanExtraWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace leanExtraWebApp.Data
{
    public class ServerManagmentContext : DbContext
    {
        public ServerManagmentContext(DbContextOptions<ServerManagmentContext> options) : base(options)
        { }
        public DbSet<Server> Servers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Server>().HasData(
                    new Server { ServerId = 1, Name = "Server1", City = "Toronto" },
                    new Server { ServerId = 2, Name = "Server2", City = "Toronto" },
                    new Server { ServerId = 3, Name = "Server3", City = "Toronto" },
                    new Server { ServerId = 4, Name = "Server4", City = "Montreal" },
                    new Server { ServerId = 5, Name = "Server5", City = "Montreal" },
                    new Server { ServerId = 6, Name = "Server6", City = "Ottawa" },
                    new Server { ServerId = 7, Name = "Server7", City = "Ottawa" },
                    new Server { ServerId = 8, Name = "Server8", City = "Calgary" },
                    new Server { ServerId = 9, Name = "Server9", City = "Calgary" },
                    new Server { ServerId = 10, Name = "Server10", City = "Halifax" }



            );
        }
    }

}