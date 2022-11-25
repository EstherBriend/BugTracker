using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class PersonSearch
    {
        /// <summary>
        /// This function return an array with all the creator's informations casting as strings
        /// </summary>
        /// <param name="personId"></param>
        /// <returns>string [] persondData</returns>
        public string[] SearchById(int personId)
        {

            Person searchedPerson = new Person();
            using (BugTrackerContext context = new BugTrackerContext())
            {
                searchedPerson = context.person.Find(personId);
            }
            if(searchedPerson != null)
            {
                string[] personData = {searchedPerson.firstName, searchedPerson.lastName, searchedPerson.address, searchedPerson.email, searchedPerson.dateOfBirth.ToShortDateString(), searchedPerson.jobTitle, searchedPerson.yearsOfExperience.ToString(), searchedPerson.salary.ToString(), searchedPerson.hiredDate.ToShortDateString() };
                return personData;
            }
            else
            {
                return null;
            }
            
        }
    }
}
