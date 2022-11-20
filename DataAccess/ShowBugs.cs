using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class ShowBugs
    {
        BugTrackerContext context = new BugTrackerContext();

        public List<Bug> showAllBugs()
        {
            using(var context = new BugTrackerContext())
            {
                return context.bugs.ToList();
            }
        }
    }
}
