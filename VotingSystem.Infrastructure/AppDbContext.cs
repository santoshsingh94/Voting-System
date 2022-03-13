using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystem.Entity.Entities;

namespace VotingSystem.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Voter> Voters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    CategoryName = "President"
                }
            );
            
            modelBuilder.Entity<Candidate>().HasData(
                new Candidate
                {
                    Id = 1,
                    CandidateName = "Michael Scott",
                    CategoryID = 1
                    
                }
            );

            modelBuilder.Entity<Voter>().HasData(
                new Voter
                {
                    Id = 1,
                    VoterName = "Voter1",
                    Age = 21,
                    Address = "Ward 12, Gurgaon, Haryana"
                }
            );
        }


    }
}
