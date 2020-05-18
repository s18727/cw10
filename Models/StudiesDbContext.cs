using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD09.Models
{
    public class StudiesDbContext : DbContext
    {
        private DbSet<Studies> studies;

        public DbSet<Studies> GetStudies()
        {
            return studies;
        }

        public void SetStudies(DbSet<Studies> value)
        {
            studies = value;
        }

        public StudiesDbContext() { }

        public StudiesDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
