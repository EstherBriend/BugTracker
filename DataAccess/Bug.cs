using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Bug
    {
        public int id { get; set; }
        public string name { get; set; }
        public string? description { get; set; } // Description can be null
        public int creatorId { get; set; }
        public int priorityId { get; set; }
        public int severityId { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime? lastUpdateDate { get; set; } // Last Update Time can be null
        public string solved { get; set; }


        // Navigation property:
        public Person creator { get; set; }
        public Priority priority { get; set; }
        public Severity severity { get; set; }
        public List<Message> messages { get; set; }
        public List<Logs> logs { get; set; }


    }
}
