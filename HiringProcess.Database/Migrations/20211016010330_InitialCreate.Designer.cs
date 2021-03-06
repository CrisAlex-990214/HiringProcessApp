// <auto-generated />
using System;
using HiringProcess.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HiringProcess.Database.Migrations
{
    [DbContext(typeof(HiringDBContext))]
    [Migration("20211016010330_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HiringProcess.Database.CandidateDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Candidates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            Name = "Cristian Duque"
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 1,
                            Name = "Valeria Moreno"
                        },
                        new
                        {
                            Id = 3,
                            CompanyId = 1,
                            Name = "Pablo Perez"
                        });
                });

            modelBuilder.Entity("HiringProcess.Database.CompanyDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Devco"
                        });
                });

            modelBuilder.Entity("HiringProcess.Database.EvaluatorDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Evaluators");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            Name = "Natalia Torres"
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 1,
                            Name = "Paula Dorado"
                        });
                });

            modelBuilder.Entity("HiringProcess.Database.FinalStepDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgreedSalary")
                        .HasColumnType("int");

                    b.Property<double>("AvgScore")
                        .HasColumnType("float");

                    b.Property<int>("PostulationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PostulationId")
                        .IsUnique();

                    b.ToTable("FinalSteps");
                });

            modelBuilder.Entity("HiringProcess.Database.PostulationDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("EvaluatorId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("SalaryAspiration")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("EvaluatorId");

                    b.HasIndex("RoleId");

                    b.ToTable("Postulations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CandidateId = 1,
                            CompanyId = 1,
                            Date = new DateTime(2021, 10, 15, 20, 3, 29, 697, DateTimeKind.Local).AddTicks(5950),
                            EvaluatorId = 1,
                            RoleId = 1,
                            SalaryAspiration = 5500000
                        },
                        new
                        {
                            Id = 2,
                            CandidateId = 2,
                            CompanyId = 1,
                            Date = new DateTime(2021, 10, 15, 20, 3, 29, 698, DateTimeKind.Local).AddTicks(3284),
                            EvaluatorId = 2,
                            RoleId = 2,
                            SalaryAspiration = 5000000
                        },
                        new
                        {
                            Id = 3,
                            CandidateId = 3,
                            CompanyId = 1,
                            Date = new DateTime(2021, 10, 15, 20, 3, 29, 698, DateTimeKind.Local).AddTicks(3360),
                            EvaluatorId = 1,
                            RoleId = 1,
                            SalaryAspiration = 4500000
                        });
                });

            modelBuilder.Entity("HiringProcess.Database.QualDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Quals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Theoretical"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Technical"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Psychological"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Medical"
                        });
                });

            modelBuilder.Entity("HiringProcess.Database.RoleDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            Name = "Development engineer"
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 1,
                            Name = "QA Automation engineer"
                        });
                });

            modelBuilder.Entity("HiringProcess.Database.TestDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostulationId")
                        .HasColumnType("int");

                    b.Property<int>("QualId")
                        .HasColumnType("int");

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PostulationId");

                    b.HasIndex("QualId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("HiringProcess.Database.CandidateDto", b =>
                {
                    b.HasOne("HiringProcess.Database.CompanyDto", "Company")
                        .WithMany("Candidates")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HiringProcess.Database.EvaluatorDto", b =>
                {
                    b.HasOne("HiringProcess.Database.CompanyDto", "Company")
                        .WithMany("Evaluators")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HiringProcess.Database.FinalStepDto", b =>
                {
                    b.HasOne("HiringProcess.Database.PostulationDto", "Postulation")
                        .WithOne("FinalStep")
                        .HasForeignKey("HiringProcess.Database.FinalStepDto", "PostulationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HiringProcess.Database.PostulationDto", b =>
                {
                    b.HasOne("HiringProcess.Database.CandidateDto", "Candidate")
                        .WithMany()
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HiringProcess.Database.CompanyDto", "Company")
                        .WithMany("Postulations")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HiringProcess.Database.EvaluatorDto", "Evaluator")
                        .WithMany()
                        .HasForeignKey("EvaluatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HiringProcess.Database.RoleDto", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HiringProcess.Database.RoleDto", b =>
                {
                    b.HasOne("HiringProcess.Database.CompanyDto", "Company")
                        .WithMany("Roles")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HiringProcess.Database.TestDto", b =>
                {
                    b.HasOne("HiringProcess.Database.PostulationDto", "Postulation")
                        .WithMany("Tests")
                        .HasForeignKey("PostulationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HiringProcess.Database.QualDto", "Qual")
                        .WithMany()
                        .HasForeignKey("QualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
