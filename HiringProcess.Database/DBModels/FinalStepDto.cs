using System;

namespace HiringProcess.Database
{
    public class FinalStepDto
    {
        public int Id { get; set; }
        public double AvgScore { get; set; }
        public int AgreedSalary { get; set; }
        public DateTime StartDate { get; set; }
        public int PostulationId { get; set; }
        public PostulationDto Postulation { get; set; }
    }
}
