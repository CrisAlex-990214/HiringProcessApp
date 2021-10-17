using System.Collections.Generic;

namespace HiringProcess.Core.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Postulation> Postulations { get; set; }
        public List<Role> Roles { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Evaluator> Evaluators { get; set; }
    }
}
