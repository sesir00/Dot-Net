using Microsoft.EntityFrameworkCore;

namespace EFCodeNCCS.Models
{
    // This class is responsible for creating objects of server and setting the columns in the table by using properties from the Student class.
    public class StudentContext : DbContext
    {
        // Creating object of server by using constructor
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }

        // Creating DbSet for Student entity. This will be used to interact with the "Students" table.
        public DbSet<Student> Students { get; set; }
    }
}
