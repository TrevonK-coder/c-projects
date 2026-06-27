using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCodeFirst
{
    // The DbContext represents a session with the database, allowing querying and saving of data
    public class SchoolContext : DbContext
    {
        // DbSet maps the Student entity to the Students table in the database
        public DbSet<Student> Students { get; set; }

        // Configure the DbContext to use a local SQLite database file
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Set up connection string pointing to local SQLite database file (students.db)
            optionsBuilder.UseSqlite("Data Source=students.db");
        }
    }
}
