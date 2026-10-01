using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace HanesKMVCApp.Models
{
    public class MembersContext : DbContext
    {
        public MembersContext(DbContextOptions<MembersContext> options) : base(options)
        { }
        public DbSet<Members> Membership { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Members>().HasData(
                new Members
                {
                    ID = 1,
                    FirstName = "Bob",
                    LastName = "Minion",
                    Email = "minionb@geemail.com"
                },
                new Members
                {
                    ID = 2,
                    FirstName = "Kevin",
                    LastName = "Minion",
                    Email = "minionk@geemail.com"
                },
                new Members
                {
                    ID = 3,
                    FirstName = "Stuart",
                    LastName = "Minion",
                    Email = "minions@geemail.com"
                }
            );

        }
    }
}
