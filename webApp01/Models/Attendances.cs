using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApp01.Models
{
    public class Attendance
    {
        public string Id { get; set; }
        public DateTime EventDateTime { get; set; }
        public string EventType { get; set; }
        public Employee Employee { get; set; }
    }
}
