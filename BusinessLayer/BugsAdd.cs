using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BugsAdd
    {
        public void addBugInDb(int creatorId, string bugName, string bugDesc, int priorityId, int severityId)
        {
            using(BugTrackerContext context = new BugTrackerContext())
            {
                Bug bugToAdd = new Bug();
                bugToAdd.creatorId = creatorId;
                bugToAdd.name = bugName;
                bugToAdd.description = bugDesc;
                bugToAdd.priorityId = priorityId;
                bugToAdd.severityId = severityId;
                bugToAdd.creationDate = DateTime.Now;
                bugToAdd.solved = "false";
                context.bugs.Add(bugToAdd);
                context.SaveChanges();
            }
        }

        public void updateBug(int bugId, string bugName, string bugDesc, int priorityId, int severityId, bool solved)
        {
            using(BugTrackerContext context = new BugTrackerContext())
            {
                // Retrieve bug to update from the db
                Bug bugToUpdate = context.bugs.Find(bugId);


                // Modify the updated values
                bugToUpdate.name = bugName;
                bugToUpdate.description = bugDesc;
                bugToUpdate.priorityId = priorityId;
                bugToUpdate.severityId = severityId ;
                bugToUpdate.lastUpdateDate = DateTime.Now;
                if (solved)
                {
                    bugToUpdate.solved = "true";
                }
                else
                {
                    bugToUpdate.solved = "false";
                }

                // Save the modifications in the db
                context.Update(bugToUpdate);
                context.SaveChanges();
            }
        }
    }
}
