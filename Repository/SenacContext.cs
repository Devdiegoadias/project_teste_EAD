using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using testando.Models;

namespace testando.Repository
{
    public class TestePosContext : DbContext
    {

        public DbSet<Pie> Pies { get; set; }

        public TestePosContext(DbContextOptions<TestePosContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            ILoggerFactory factory = LoggerFactory.Create(l => l.AddConsole());
            optionsBuilder.UseLoggerFactory(factory);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PieMapping());

            base.OnModelCreating(modelBuilder);
        }

    }
}