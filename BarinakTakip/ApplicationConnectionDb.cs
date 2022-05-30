using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BarinakTakip.Models
{
    public class ApplicationConnectionDb : DbContext
    {
        public DbSet<Personel> Personel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySql("server=localhost;port=3306;user=root;password=;database=barinak-takip")
                .UseLoggerFactory(LoggerFactory.Create(b => b
                .AddFilter(level => level >= LogLevel.Information)))
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
    }
}