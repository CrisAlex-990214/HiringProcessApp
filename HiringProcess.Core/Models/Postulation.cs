using System;
using System.Collections.Generic;
using System.Text;

namespace HiringProcess.Core.Models
{
    public class Postulation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int SalaryAspiration { get; set; }
        public Role Role { get; set; }
        public Candidate Candidate { get; set; }
        public Evaluator Evaluator { get; set; }
        public List<Test> Tests { get; set; }
        public FinalStep FinalStep { get; set; }
    }
}
