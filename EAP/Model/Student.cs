using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAP.Model
{
    [Table("Students")]
    public record Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
