using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LogSearch
    {
        public string SearchLogByBugId(int searchedBugId)
        {
            string result = "";
            using(BugTrackerContext context = new BugTrackerContext())
            {
                List<Logs> logForThisBug = context.logs.ToList().Where(l => l.bugId == searchedBugId).ToList();

                foreach (Logs log in logForThisBug)
                {
                    result += $"Log {log.id} created on the {log.creationDate.ToShortDateString()} :\n{log.text}\n\n";
                }

                return result;
            }
             
        }
    }
}
