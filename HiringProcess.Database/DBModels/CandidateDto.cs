using System;
using System.Collections.Generic;
using System.Text;

namespace HiringProcess.Database
{
    public class CandidateDto: PersonDto
    {
        public int CompanyId { get; set; }
        public CompanyDto Company { get; set; }
    }
}
