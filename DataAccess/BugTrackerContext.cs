using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BugTrackerContext : DbContext
    {
        public DbSet<Bug> bugs { get; set; }
        public DbSet<Logs> logs { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Person> person { get; set; }
        public DbSet<Priority> priority { get;set; }
        public DbSet<Severity> severity { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=DESKTOP-KCHTEAG\\SQL2019EXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; initial catalog=BugTracker");
        }


    }
}
