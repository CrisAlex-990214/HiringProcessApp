using HiringProcess.Database;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Xunit;

namespace HiringProcess1.Tests
{
    public class UnitTest : DbContext
    {
        private readonly TestRepository testRepository;
        private readonly CompanyRepository companyRepository;

        public UnitTest()
        {
        }

        [Fact]
        public void VerifyIfCandidate1HasPostulationInDevco()
        {
            //arrange
            var companyId = 1;
            var candidateId = 1;
            var expectedCandidateName = "Cristian Duque";

            //act
            var candidateName = companyRepository.Get(companyId)?.Candidates?.FirstOrDefault(x => x.Id == candidateId)?.Name;

            //assert
            Assert.Equal(expectedCandidateName, candidateName);
        }
    }
}
