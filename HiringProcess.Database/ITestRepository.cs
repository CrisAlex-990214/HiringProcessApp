using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiringProcess.Database
{
    public interface ITestRepository
    {
        bool Add(TestDto test);
        bool AddFinalStep(FinalStepDto finalStep);
        IEnumerable<QualDto> GetQuals(int? qualId = null);
    }
}
