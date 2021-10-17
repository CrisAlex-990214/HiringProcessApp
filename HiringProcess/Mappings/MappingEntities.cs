using AutoMapper;
using HiringProcess.Core.InputModels;
using HiringProcess.Core.Models;
using HiringProcess.Database;

namespace HiringProcess.Mappings
{
    public class MappingEntities : Profile
    {
        public MappingEntities()
        {
            CreateMap<CandidateDto, Candidate>();
            CreateMap<CompanyDto, Company>();
            CreateMap<EvaluatorDto, Evaluator>();
            CreateMap<FinalStepDto, FinalStep>();
            CreateMap<PersonDto, Person>();
            CreateMap<PostulationDto, Postulation>();
            CreateMap<QualDto, Qual>();
            CreateMap<RoleDto, Role>();
            CreateMap<TestDto, Test>();

            CreateMap<InputTest, TestDto>();
            CreateMap<InputFinalStep, FinalStepDto>();
        }
    }
}
