using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Browsable(false)] public Person creator { get; set; } //[Browsable(false)] -> make the variable non accessible in the data grid view
        [Browsable(false)] public Priority priority { get; set; }
        [Browsable(false)] public Severity severity { get; set; }
        [Browsable(false)] public List<Message> messages { get; set; }
        [Browsable(false)] public List<Logs> logs { get; set; }


    }
}
