using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class MessageSearch
    {
        public List<Message> SearchByBugId(int bugId)
        {
            using (BugTrackerContext context = new BugTrackerContext())
            {
                return context.messages.ToList().Where(m => m.bugId == bugId).ToList();
            }
        }
        /// <summary>
        /// This function return an array with all the message's informations casting as strings
        /// </summary>
        /// <param name="messageId"></param>
        /// <returns>string[] searchedMessageInfos = {id, bugId, personId, creationDate, title, text };</returns>
        public string[]? SearchByMessageId(int messageId)
        {
            using(BugTrackerContext context = new BugTrackerContext())
            {
                Message searchedMessage = context.messages.Find(messageId);
                if (searchedMessage != null)
                {
                    string[] searchedMessageInfos = { searchedMessage.id.ToString(), searchedMessage.bugId.ToString(), searchedMessage.personId.ToString(),
                        searchedMessage.creationDate.ToShortDateString(), searchedMessage.title.ToString(), searchedMessage.text };
                    return searchedMessageInfos;
                }
                else
                {
                    return null;
                }

                 
            }

        }
    }
}
