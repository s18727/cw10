using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD09.Models
{
    public class EnrollmentDbContext : DbContext
    {
        private DbSet<Enrollment> enrolment;

        public DbSet<Enrollment> GetEnrolment()
        {
            return enrolment;
        }

        public void SetEnrolment(DbSet<Enrollment> value)
        {
            enrolment = value;
        }

        public EnrollmentDbContext() { }

        public EnrollmentDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
