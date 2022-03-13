using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystem.Entity.SeedWorks;

namespace VotingSystem.Entity.Entities
{
    public class Candidate : EntityBase
    {
        //Scalar Props
        public string CandidateName { get; set; }

        //Navigational Props
        [ForeignKey("Category")]
        public int? CategoryID { get; set; }        
        public Category Category { get; set; }
        public IEnumerable<Voter> Voters { get; set; }
    }
}
