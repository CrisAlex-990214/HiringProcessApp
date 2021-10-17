using System;
using System.Collections.Generic;
using System.Text;

namespace HiringProcess.Database
{
    public class PostulationDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int SalaryAspiration { get; set; }
        public int RoleId { get; set; }
        public RoleDto Role { get; set; }
        public int CandidateId { get; set; }
        public CandidateDto Candidate { get; set; }
        public int EvaluatorId { get; set; }
        public EvaluatorDto Evaluator { get; set; }
        public List<TestDto> Tests { get; set; }
        public FinalStepDto FinalStep { get; set; }
        public int CompanyId { get; set; }
        public CompanyDto Company { get; set; }
    }
}
