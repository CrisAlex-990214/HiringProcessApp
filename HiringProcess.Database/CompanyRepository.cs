using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HiringProcess.Database
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly HiringDBContext hiringDBContext;

        public CompanyRepository(HiringDBContext hiringDBContext)
        {
            this.hiringDBContext = hiringDBContext;
        }
        public CompanyDto Get(int id)
        {
            return hiringDBContext.Companies
                    .Include(x => x.Postulations).ThenInclude(x => x.Candidate)
                    .Include(x => x.Postulations).ThenInclude(x => x.Evaluator)
                    .Include(x => x.Postulations).ThenInclude(x => x.Role)
                    .Include(x => x.Postulations).ThenInclude(x => x.Tests).ThenInclude(x=> x.Qual)
                    .Include(x => x.Postulations).ThenInclude(x => x.FinalStep)
                .SingleOrDefault(x => x.Id == id);
        }
    }
}
