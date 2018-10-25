using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webApp01.Models
{
    public class User {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
    }
}
