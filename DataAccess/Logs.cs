using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Logs
    {
        public int id { get; set; }
        public int bugId { get; set; }
        public string text { get; set; }
        public DateTime creationDate { get; set; }

        // Navigation property:
        public Bug bug { get; set; }
    }
}
