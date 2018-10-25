using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace webApp01.Models
{
    public class AttendanceDbContext  : DbContext{
        public AttendanceDbContext(DbContextOptions<AttendanceDbContext> options) : base(options) {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
    }
}
