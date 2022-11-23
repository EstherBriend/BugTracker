using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CreatorSearch
    {
        /// <summary>
        /// This function create the list for the combo Box Creator on the Selection Form
        /// </summary>
        public List<String> RetrieveCreatorIdAndName()
        {
            using(BugTrackerContext context = new BugTrackerContext())
            {
                List<String> creatorIdAndName = new List<String>();
                //Create the option any
                creatorIdAndName.Add("Any");

                List<Person> personList = context.person.ToList();
                List<Bug> bugList = context.bugs.ToList();
                string tempIdAndName = "";
                Person tempPerson = new Person();

                //Match the Creator ID from the Bug Table with First Name and Last Name in the table Person
                foreach (Bug bug in bugList)
                {
                    tempIdAndName = bug.creatorId.ToString();
                    tempPerson = personList.Where(p => p.id == bug.creatorId).ToList()[0];
                    tempIdAndName += $" {tempPerson.firstName} {tempPerson.lastName}";
                    creatorIdAndName.Add(tempIdAndName);
                }
                
                //Distinct() -> Remove duplicates from the list 
                return creatorIdAndName.Distinct().ToList(); ;
            }
        }
    }
}
