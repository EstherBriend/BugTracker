using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SeveritySearch
    {
        public List<String> RetrieveAllSeverityName()
        {
            using (BugTrackerContext context = new BugTrackerContext())
            {
                List<String> severityNameList = new List<String>();
                List<Priority> SeverityList = context.priority.ToList();
                foreach (Priority severityObj in SeverityList)
                {
                    severityNameList.Add(severityObj.name);
                }
                return severityNameList;
            }
        }
    }
}
