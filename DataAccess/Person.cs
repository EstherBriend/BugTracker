using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Person
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string? jobTitle { get; set; } // Job Title can be null
        public float salary { get; set; }
        public int yearsOfExperience { get; set; }
        public DateTime hiredDate { get; set; }
        public string address { get; set; }
        public string? email { get; set; } // Email can be null
        public DateTime dateOfBirth { get; set; }

        // Navigation property
        public List<Bug> bugs { get; set; }
        public List<Message> messages { get; set; }
    }
}
