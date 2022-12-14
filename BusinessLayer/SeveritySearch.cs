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

                List<Severity> SeverityList = context.severity.ToList();
                foreach (Severity severityObj in SeverityList)
                {
                    severityNameList.Add(severityObj.name);
                }
                return severityNameList;
            }
        }

        /// <summary>
        /// This function create the list for the combo Box Severity on the Selection Form
        /// </summary>
        public List<String> RetrievAllSeveritiesPlusAny()
        {
            List<String> severityNameList = new List<String>();
            severityNameList.Add("Any");
            severityNameList.AddRange(RetrieveAllSeverityName());
            return severityNameList;

        }
    }
}
