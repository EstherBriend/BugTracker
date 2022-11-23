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
        /// <summary>
        /// This function create the list for the combo Box Priority on the Selection Form
        /// </summary>
        public List<String> RetrieveAllPriorityName()
        {
            using (BugTrackerContext context = new BugTrackerContext())
            {
                List<String> priorityNameList = new List<String>();
                priorityNameList.Add("Any");
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
