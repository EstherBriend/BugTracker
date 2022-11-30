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
    }
}
