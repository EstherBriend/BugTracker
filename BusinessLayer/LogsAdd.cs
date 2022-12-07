using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LogsAdd
    {
        public void addBugCreationLog(int bugId)
        {
            using(BugTrackerContext context = new BugTrackerContext())
            {
                // Create new log
                Logs creationLog = new Logs();
                creationLog.creationDate = DateTime.Now;
                creationLog.text = "Bug creation";
                creationLog.bugId = bugId;

                // Save the modifications in the db
                context.logs.Add(creationLog);
                context.SaveChanges();
            }
        }

        public void addBugUpdateLog(int bugId)
        {
            using(BugTrackerContext context = new BugTrackerContext())
            {
                // Create new log
                Logs updateLog = new Logs();
                updateLog.creationDate = DateTime.Now;
                updateLog.text = "Bug updated";
                updateLog.bugId = bugId;

                // Save the modifications in the db
                context.logs.Add(updateLog);
                context.SaveChanges();

            }

        }

        public void addNewMessageLog(int bugId)
        {
            using(BugTrackerContext context = new BugTrackerContext())
            {
                //Create new log
                Logs newMessageLog = new Logs();
                newMessageLog.creationDate = DateTime.Now;
                newMessageLog.text = "New message";
                newMessageLog.bugId = bugId;

                // Save the modification in the db
                context.logs.Add(newMessageLog);
                context.SaveChanges();
            }
        }
    }
}
