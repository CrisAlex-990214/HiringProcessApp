using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HiringProcess.Database
{
    public class TestRepository : ITestRepository
    {
        private readonly HiringDBContext hiringDBContext;

        public TestRepository(HiringDBContext hiringDBContext)
        {
            this.hiringDBContext = hiringDBContext;
        }
        public bool Add(TestDto test)
        {
            if (test.Score < 0 && test.Score > 100) return false;

            hiringDBContext.Tests.Add(test);
            hiringDBContext.SaveChanges();
            return true;
        }
        public bool AddFinalStep(FinalStepDto finalStep)
        {
            if (finalStep.AgreedSalary < 3000000 || finalStep.AgreedSalary > 6000000
                || finalStep.AvgScore < 0 || finalStep.AvgScore > 100) return false;

            hiringDBContext.FinalSteps.Add(finalStep);
            hiringDBContext.SaveChanges();
            return true;
        }

        public IEnumerable<QualDto> GetQuals(int? qualId = null)
        {
            return qualId == null ? 
                hiringDBContext.Quals : hiringDBContext.Quals.Where(x=> x.Id == qualId);
        }
    }
}
