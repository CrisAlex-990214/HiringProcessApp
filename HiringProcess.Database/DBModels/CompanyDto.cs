using System.Collections.Generic;

namespace HiringProcess.Database
{
    public class CompanyDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PostulationDto> Postulations { get; set; }
        public List<RoleDto> Roles { get; set; }
        public List<CandidateDto> Candidates { get; set; }
        public List<EvaluatorDto> Evaluators { get; set; }
    }
}
