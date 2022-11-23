using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.IdentityModel.Tokens;

namespace BusinessLayer
{
    public class BugsSearch
    {

        public List<Bug> RetrieveAllBugs()
        {
            using (BugTrackerContext context = new BugTrackerContext())
            {
                return context.bugs.ToList();
            }
        }

        public List<Bug> SearchBugs(int searchedId, int searchedCreatorId, DateTime searchedCreationDate, DateTime searchedModificationDate, string searchedName, string searchedDesc, int searchedPriority, int searchedSeverity, string isSolved)
        {
            using (BugTrackerContext context = new BugTrackerContext())
            {
                List<Bug> resultList = RetrieveAllBugs();
                if (searchedId > 0)
                {
                    resultList = SearchBugsById(resultList, searchedId);
                }
                if (searchedCreatorId > 0){
                    resultList = SearchBugsByCreatorId(resultList, searchedCreatorId);
                }
                if(searchedCreationDate.Date != DateTime.Now.Date)
                {
                    resultList = SearchBugsByCreationDate(resultList, searchedCreationDate);
                }
                if(searchedModificationDate.Date != DateTime.Now.Date)
                {
                    resultList = SearchBugsByModificationDate(resultList, searchedModificationDate);
                }
                if (!searchedName.IsNullOrEmpty())
                {
                    resultList = SearchBugsByName(resultList, searchedName);
                }
                if (!searchedDesc.IsNullOrEmpty())
                {
                    resultList = SearchBugsByDesc(resultList, searchedDesc);
                }
                if (searchedPriority > 0)
                {
                    resultList = SearchBugsByPriority(resultList, searchedPriority);
                }
                if (searchedSeverity > 0)
                {
                    resultList = SearchBugsBySeverity(resultList, searchedSeverity);
                }
                if (!isSolved.IsNullOrEmpty())
                {
                    resultList = SearchBugsIfSolved(resultList, isSolved);
                }

                return resultList;
            }

        }

        private List<Bug> SearchBugsById(List<Bug> listTosearch, int searchedId)
        {
            using (BugTrackerContext context = new BugTrackerContext())
            {
                return listTosearch.Where(bug => bug.id == searchedId).ToList();
            }
        }

        private List<Bug> SearchBugsByCreatorId(List<Bug> listToSearch, int searchedCreatorId)
        {
            using (BugTrackerContext context = new BugTrackerContext())
            {
                return listToSearch.Where(bug => bug.creatorId == searchedCreatorId).ToList();
            }
        }

        private List <Bug> SearchBugsByCreationDate(List <Bug> listToSearch, DateTime searchedCreationDate)
        {
            return listToSearch.Where(bug => DateTime.Compare(bug.creationDate,searchedCreationDate.Date) >= 0).ToList();
        }
        private List<Bug> SearchBugsByModificationDate(List<Bug> listToSearch, DateTime searchedModificationDate)
        {
            return listToSearch.Where(bug => bug.creationDate != null && DateTime.Compare((DateTime)bug.creationDate.Date, searchedModificationDate.Date) >= 0).ToList();
        }

        private List<Bug> SearchBugsByName(List<Bug> listToSearch, string searchedName)
        {
            using (BugTrackerContext context = new BugTrackerContext())
            {
                return listToSearch.Where(bug => bug.name.ToLower().Contains(searchedName.ToLower())).ToList();
            }
        }

        private List<Bug> SearchBugsByDesc(List<Bug> listToSearch, string searchedDesc)
        {
            using (BugTrackerContext context = new BugTrackerContext())
            {
                return listToSearch.Where(bug => bug.description.ToLower().Contains(searchedDesc.ToLower())).ToList();
            }
        }

        private List<Bug> SearchBugsByPriority(List<Bug> listTosearch, int searchedPriority)
        {
            using (BugTrackerContext context = new BugTrackerContext())
            {
                return listTosearch.Where(bug => bug.priorityId == searchedPriority).ToList();
            }
        }

        private List<Bug> SearchBugsBySeverity(List<Bug> listTosearch, int searchedSeverity)
        {
            using (BugTrackerContext context = new BugTrackerContext())
            {
                return listTosearch.Where(bug => bug.severityId == searchedSeverity).ToList();
            }
        }

        private List<Bug> SearchBugsIfSolved(List<Bug> listToSearch, string isSolved)
        {
            return listToSearch.Where(bug => bug.solved == isSolved).ToList();
        }


    }
}
