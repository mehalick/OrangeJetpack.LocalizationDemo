using System.Data.Entity;

namespace OrangeJetpack.LocalizationDemo.Models
{
    public class PlanetsContext : DbContext
    {
        public DbSet<Planet> Planets { get; set; }
    }
}