using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PrioritySearch
    {

        public List<String> RetrieveAllPriorityName()
        {
            using (BugTrackerContext context = new BugTrackerContext())
            {
                List<String> priorityNameList = new List<String>();
                List<Priority> PriorityList = context.priority.ToList();
                foreach (Priority priorityObj in PriorityList)
                {
                    priorityNameList.Add(priorityObj.name);
                }
                return priorityNameList;
            }
        }
    }
}
