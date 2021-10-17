using System;
using System.Collections.Generic;
using System.Text;

namespace HiringProcess.Database
{
    public class TestDto
    {
        public int Id { get; set; }
        public double Score { get; set; }
        public string Comment { get; set; }
        public int QualId { get; set; }
        public QualDto Qual { get; set; }
        public int PostulationId { get; set; }
        public PostulationDto Postulation { get; set; }
    }
}
