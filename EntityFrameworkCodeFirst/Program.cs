using System;
using System.Linq;

namespace EntityFrameworkCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the DbContext session using a using block to ensure proper resource disposal
            using (var db = new SchoolContext())
            {
                // Ensure the database is created. This maps Code-First structures (Student model) 
                // to a database file (students.db) and creates tables if they do not exist.
                Console.WriteLine("Ensuring database is created via Code-First...");
                db.Database.EnsureCreated();

                // Create a new Student object and populate properties
                Console.WriteLine("Instantiating one new student...");
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    EnrollmentDate = DateTime.Now
                };

                // Add the student object to the Students DbSet
                Console.WriteLine("Adding student to the database context...");
                db.Students.Add(student);

                // Save changes to the SQLite database file
                Console.WriteLine("Saving changes to SQLite...");
                db.SaveChanges();
                Console.WriteLine("Student saved successfully!");

                Console.WriteLine("\nRetrieving all students from database:");
                // Query all students from the Students table
                var students = db.Students.ToList();
                foreach (var s in students)
                {
                    Console.WriteLine($"- ID: {s.Id}, Name: {s.FirstName} {s.LastName}, Enrolled: {s.EnrollmentDate}");
                }
            }
        }
    }
}
