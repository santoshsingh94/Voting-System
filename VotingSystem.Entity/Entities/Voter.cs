using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystem.Entity.SeedWorks;

namespace VotingSystem.Entity.Entities
{
    public class Voter : EntityBase
    {
        //Scalar Props
        public string VoterName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        //Navigational Props
        [ForeignKey("Candidate")]
        public int? CandidateID { get; set; }
        public Candidate Candidate { get; set; }
    }
}
