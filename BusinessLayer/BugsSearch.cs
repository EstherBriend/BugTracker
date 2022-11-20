using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLayer
{
    public class BugsSearch
    {

        public List<Bug> RetrieveAllBugs()
        {
            using(BugTrackerContext context = new BugTrackerContext())
            {
                return context.bugs.ToList();
            }
        }
    }
}
