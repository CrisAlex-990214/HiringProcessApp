using System;

namespace HiringProcess.Core.InputModels
{
    public class InputFinalStep
    {
        public double AvgScore { get; set; }
        public int AgreedSalary { get; set; }
        public DateTime StartDate { get; set; }
        public int PostulationId { get; set; }
    }
}
