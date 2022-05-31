using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace BarinakTakip.Models
{
    class ApplicationConnectionDb : DbContext
    {
        public DbSet<Barinak> Barinak { get; set; }
        public DbSet<Kullanici> Kullanici{ get; set; }

        public DbSet<Hayvan> Hayvan { get; set; }

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
