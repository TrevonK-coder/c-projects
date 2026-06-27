using Microsoft.EntityFrameworkCore;
using CarInsurance.Models;

namespace CarInsurance.Data
{
    // DbContext class that manages connection and operations on the database
    public class InsuranceDbContext : DbContext
    {
        // Constructor that accepts context configuration options
        public InsuranceDbContext(DbContextOptions<InsuranceDbContext> options)
            : base(options)
        {
        }

        // DbSet representing the Insurees table in SQLite database
        public DbSet<Insuree> Insurees { get; set; }
    }
}
