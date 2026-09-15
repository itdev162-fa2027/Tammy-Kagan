using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public string DbPath { get; }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public DataContext()
        {
            DbPath = Path.Join(AppContext.BaseDirectory, "weather.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }
    }
}