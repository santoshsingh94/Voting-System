using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystem.Entity.SeedWorks;

namespace VotingSystem.Entity.Entities
{
    public class Category : EntityBase
    {
        //Scalar Props
        public string CategoryName { get; set; }

        //Navigational Props
        public IEnumerable<Candidate> Candidates { get; set; }
    }
}
