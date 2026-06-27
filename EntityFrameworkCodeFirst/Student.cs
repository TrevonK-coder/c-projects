using System;

namespace EntityFrameworkCodeFirst
{
    // The Student model class which maps Code-First to a table in the database
    public class Student
    {
        // Primary key property (EF Core automatically detects "Id" as PK)
        public int Id { get; set; }

        // Student's first name
        public string FirstName { get; set; } = string.Empty;

        // Student's last name
        public string LastName { get; set; } = string.Empty;

        // Student's enrollment date
        public DateTime EnrollmentDate { get; set; }
    }
}
