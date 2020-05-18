using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD09.Models
{
    public class StudentDbContext : DbContext
    {
        private DbSet<Student> student;

        public DbSet<Student> GetStudent()
        {
            return student;
        }

        public void SetStudent(DbSet<Student> value)
        {
            student = value;
        }

        public StudentDbContext() { }

        public StudentDbContext(DbContextOptions options) : base(options)
        {

        }

    }
}
