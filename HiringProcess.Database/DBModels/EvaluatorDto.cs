using System;
using System.Collections.Generic;
using System.Text;

namespace HiringProcess.Database
{
    public class EvaluatorDto : PersonDto 
    {
        public int CompanyId { get; set; }
        public CompanyDto Company { get; set; }
    }
}
