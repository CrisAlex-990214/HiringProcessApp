using AutoMapper;
using HiringProcess.Core.Models;
using HiringProcess.Database;
using Microsoft.AspNetCore.Mvc;

namespace HiringProcess.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository companyRepository;
        private readonly IMapper mapper;

        public CompanyController(ICompanyRepository postulationRepository,
            IMapper mapper)
        {
            this.companyRepository = postulationRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public Company Get(int id = 1)
        {
            var company = mapper.Map<Company>(companyRepository.Get(id));
            return company;
        }
    }
}
