using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Message
    {
        public int id { get; set; }
        public int bugId { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public DateTime creationDate { get; set; }
        public int personId { get; set; }

        // Navigation property
        [Browsable(false)] public Person person{ get; set; }
        [Browsable(false)] public Bug bug { get; set; }

    }
}
