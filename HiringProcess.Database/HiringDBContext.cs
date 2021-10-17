using Microsoft.EntityFrameworkCore;

namespace HiringProcess.Database
{
    public class HiringDBContext : DbContext
    {
        public HiringDBContext(DbContextOptions<HiringDBContext> options): base(options)
        {
        }

        public DbSet<CandidateDto> Candidates { get; set; }
        public DbSet<RoleDto> Roles { get; set; }
        public DbSet<EvaluatorDto> Evaluators { get; set; }
        public DbSet<QualDto> Quals { get; set; }
        public DbSet<CompanyDto> Companies { get; set; }
        public DbSet<PostulationDto> Postulations { get; set; }
        public DbSet<TestDto> Tests { get; set; }
        public DbSet<FinalStepDto> FinalSteps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyDto>()
            .HasData(
                new CompanyDto
                {
                    Id = 1,
                    Name = "Devco",
                });

            modelBuilder.Entity<CandidateDto>()
            .HasData(
                new CandidateDto
                {
                    Id = 1,
                    Name = "Cristian Duque",
                    CompanyId = 1
                },
                new CandidateDto
                {
                    Id = 2,
                    Name = "Valeria Moreno",
                    CompanyId = 1
                }, new CandidateDto
                {
                    Id = 3,
                    Name = "Pablo Perez",
                    CompanyId = 1
                });

            modelBuilder.Entity<RoleDto>()
            .HasData(
                new RoleDto
                {
                    Id = 1,
                    Name = "Development engineer",
                    CompanyId = 1
                },
                new RoleDto
                {
                    Id = 2,
                    Name = "QA Automation engineer",
                    CompanyId = 1
                });

            modelBuilder.Entity<EvaluatorDto>()
            .HasData(
                new EvaluatorDto
                {
                    Id = 1,
                    Name = "Natalia Torres",
                    CompanyId = 1
                },
                new EvaluatorDto
                {
                    Id = 2,
                    Name = "Paula Dorado",
                    CompanyId = 1
                });

            modelBuilder.Entity<QualDto>()
            .HasData(
                new QualDto
                {
                    Id = 1,
                    Name = "Theoretical"
                },
                new QualDto
                {
                    Id = 2,
                    Name = "Technical"
                },
                new QualDto
                {
                    Id = 3,
                    Name = "Psychological"
                },
                new QualDto
                {
                    Id = 4,
                    Name = "Medical"
                });

            modelBuilder.Entity<PostulationDto>()
            .HasData(
                new PostulationDto
                {
                    Id = 1,
                    Date = System.DateTime.Now,
                    SalaryAspiration = 5500000,
                    RoleId = 1, 
                    CandidateId = 1,
                    EvaluatorId = 1,
                    CompanyId = 1
                },
                new PostulationDto
                {
                    Id = 2,
                    Date = System.DateTime.Now,
                    SalaryAspiration = 5000000,
                    RoleId = 2,
                    CandidateId = 2,
                    EvaluatorId = 2,
                    CompanyId = 1
                }, new PostulationDto
                {
                    Id = 3,
                    Date = System.DateTime.Now,
                    SalaryAspiration = 4500000,
                    RoleId = 1,
                    CandidateId = 3,
                    EvaluatorId = 1,
                    CompanyId = 1
                });
        }
    }
}
