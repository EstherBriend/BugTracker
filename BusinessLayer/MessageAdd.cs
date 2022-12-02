using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MessageAdd
    {
        public void addMessageInDb(int bugId, DateTime creationDate, int creatorId, string messageTitle, string messageText)
        {
            using (BugTrackerContext context = new BugTrackerContext())
            {
                Message messageToAdd = new Message();
                messageToAdd.bugId = bugId;
                messageToAdd.creationDate = creationDate;
                messageToAdd.personId = creatorId;
                messageToAdd.title = messageTitle;
                messageToAdd.text = messageText;
                context.messages.Add(messageToAdd);
                context.SaveChanges();
            }
        }
    }
}
