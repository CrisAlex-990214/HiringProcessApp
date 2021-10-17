using AutoMapper;
using HiringProcess.Core.InputModels;
using HiringProcess.Core.Models;
using HiringProcess.Database;
using HiringProcess.Emails;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiringProcess.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ITestRepository testRepository;
        private readonly IMapper mapper;
        private readonly IEmailService emailService;

        public TestController(ITestRepository testRepository,
            IMapper mapper, IEmailService emailService)
        {
            this.testRepository = testRepository;
            this.mapper = mapper;
            this.emailService = emailService;
        }

        [HttpPost]
        public async Task<bool> Post([FromBody] InputTest test)
        {
            try
            {
                var testDto = mapper.Map<TestDto>(test);
                var added = testRepository.Add(testDto);

                //EMAIL
                var qualInfo = testRepository.GetQuals(test.QualId).FirstOrDefault();
                if (added && qualInfo != null)
                {
                    await emailService.SendTestEmail(
                        new UserEmailOptions
                        {
                            Subject = $"{qualInfo.Name} Test Finished!",
                            Body = $"Score: {test.Score} <br/> Comments: {test.Comment}.",
                            ToEmails = new List<string> { "cads.14alex@gmail.com" }
                        });
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }

        }

        [HttpPost("FinalStep")]
        public bool Post([FromBody] InputFinalStep finalStep)
        {
            try
            {
                var finalStepDto = mapper.Map<FinalStepDto>(finalStep);
                return testRepository.AddFinalStep(finalStepDto);
            }
            catch
            {
                return false;
            }

        }

        [HttpGet("Quals")]
        public List<Qual> Get()
        {
            var quals = mapper.Map<List<Qual>>(testRepository.GetQuals());
            return quals;
        }
    }
}
