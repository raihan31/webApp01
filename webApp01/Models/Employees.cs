using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApp01.Models;

namespace webApp01.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
    }
}
