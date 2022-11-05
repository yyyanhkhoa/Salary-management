﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Salary_management.Controller.Infrastructure.Entities.Enums;
using Salary_management.Infrastructure;
using Salary_management.Infrastructure.Entities.Enums;

#nullable disable

namespace Salary_management.Migrations
{
    [DbContext(typeof(SalaryManContext))]
    partial class SalaryManContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresEnum(modelBuilder, "gender", new[] { "male", "female", "other" });
            NpgsqlModelBuilderExtensions.HasPostgresEnum(modelBuilder, "relative_type", new[] { "wife", "husband", "child" });
            NpgsqlModelBuilderExtensions.HasPostgresEnum(modelBuilder, "role", new[] { "accountant", "viewer", "admin" });
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.Auth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<Role>("Role")
                        .HasColumnType("role")
                        .HasColumnName("role");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username");

                    b.HasKey("Id")
                        .HasName("pk_auths");

                    b.HasAlternateKey("Username")
                        .HasName("ak_auths_username");

                    b.ToTable("auths", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "admin",
                            Role = Role.Accountant,
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("address");

                    b.Property<float>("CoefficientAllowance")
                        .HasColumnType("real")
                        .HasColumnName("coefficient_allowance");

                    b.Property<DateTime>("DateCreated")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created")
                        .HasDefaultValueSql("now()");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Ethnic")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("ethnic");

                    b.Property<Gender>("Gender")
                        .HasColumnType("gender")
                        .HasColumnName("gender");

                    b.Property<string>("IdentityCardNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)")
                        .HasColumnName("identity_card_number");

                    b.Property<byte[]>("Image")
                        .HasColumnType("bytea")
                        .HasColumnName("image");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("start_date");

                    b.HasKey("Id")
                        .HasName("pk_employees");

                    b.ToTable("employees", (string)null);
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.EmployeeQualification", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("character varying(255)")
                        .HasColumnName("employee_id");

                    b.Property<int>("QualificationId")
                        .HasColumnType("integer")
                        .HasColumnName("qualification_id");

                    b.Property<DateOnly>("IssueDate")
                        .HasColumnType("date")
                        .HasColumnName("issue_date");

                    b.Property<string>("PlaceOfIssue")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("place_of_issue");

                    b.Property<float>("Score")
                        .HasColumnType("real")
                        .HasColumnName("score");

                    b.HasKey("EmployeeId", "QualificationId")
                        .HasName("pk_employee_qualifications");

                    b.HasIndex("QualificationId")
                        .HasDatabaseName("ix_employee_qualifications_qualification_id");

                    b.ToTable("employee_qualifications", (string)null);
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.Expertise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_expertise");

                    b.ToTable("expertise", (string)null);
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.Family", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasColumnName("employee_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("occupation");

                    b.Property<RelativeType>("RelativeType")
                        .HasColumnType("relative_type")
                        .HasColumnName("relative_type");

                    b.HasKey("Id")
                        .HasName("pk_families");

                    b.HasIndex("EmployeeId")
                        .HasDatabaseName("ix_families_employee_id");

                    b.ToTable("families", (string)null);
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.Position", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("id");

                    b.Property<int>("BaseSalary")
                        .HasColumnType("integer")
                        .HasColumnName("base_salary");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.Property<int>("RankId")
                        .HasColumnType("integer")
                        .HasColumnName("rank_id");

                    b.HasKey("Id")
                        .HasName("pk_positions");

                    b.HasIndex("RankId")
                        .HasDatabaseName("ix_positions_rank_id");

                    b.ToTable("positions", (string)null);
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.PositionHistory", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("character varying(255)")
                        .HasColumnName("employee_id");

                    b.Property<string>("PositionId")
                        .HasColumnType("character varying(255)")
                        .HasColumnName("position_id");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date")
                        .HasColumnName("end_date");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("start_date");

                    b.HasKey("EmployeeId", "PositionId")
                        .HasName("pk_position_histories");

                    b.HasIndex("PositionId")
                        .HasDatabaseName("ix_position_histories_position_id");

                    b.ToTable("position_histories", (string)null);
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.Qualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ExpertiseId")
                        .HasColumnType("integer")
                        .HasColumnName("expertise_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_qualifications");

                    b.HasIndex("ExpertiseId")
                        .HasDatabaseName("ix_qualifications_expertise_id");

                    b.ToTable("qualifications", (string)null);
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.QualificationAllowanceHistory", b =>
                {
                    b.Property<int>("QualificationId")
                        .HasColumnType("integer")
                        .HasColumnName("qualification_id");

                    b.Property<int>("Year")
                        .HasColumnType("integer")
                        .HasColumnName("year");

                    b.Property<int>("Allowance")
                        .HasColumnType("integer")
                        .HasColumnName("allowance");

                    b.HasKey("QualificationId", "Year")
                        .HasName("pk_qualification_allowance_histories");

                    b.ToTable("qualification_allowance_histories", (string)null);
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.Rank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<float>("Coefficient")
                        .HasColumnType("real")
                        .HasColumnName("coefficient");

                    b.Property<int>("Milestone")
                        .HasColumnType("integer")
                        .HasColumnName("milestone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_ranks");

                    b.ToTable("ranks", (string)null);
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.RewardOrDiscipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date")
                        .HasColumnName("date");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasColumnName("employee_id");

                    b.Property<bool>("IsReward")
                        .HasColumnType("boolean")
                        .HasColumnName("is_reward");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("level");

                    b.HasKey("Id")
                        .HasName("pk_reward_or_disciplines");

                    b.HasIndex("EmployeeId")
                        .HasDatabaseName("ix_reward_or_disciplines_employee_id");

                    b.ToTable("reward_or_disciplines", (string)null);
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.Union", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_unions");

                    b.ToTable("unions", (string)null);
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.UnionHistory", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("character varying(255)")
                        .HasColumnName("employee_id");

                    b.Property<string>("UnionId")
                        .HasColumnType("character varying(255)")
                        .HasColumnName("union_id");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date")
                        .HasColumnName("end_date");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("start_date");

                    b.HasKey("EmployeeId", "UnionId")
                        .HasName("pk_union_history");

                    b.HasIndex("UnionId")
                        .HasDatabaseName("ix_union_history_union_id");

                    b.ToTable("union_history", (string)null);
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.Unit", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("address");

                    b.Property<DateOnly>("DateFounded")
                        .HasColumnType("date")
                        .HasColumnName("date_founded");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("phone_number");

                    b.HasKey("Id")
                        .HasName("pk_units");

                    b.ToTable("units", (string)null);
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.UnitHistory", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("character varying(255)")
                        .HasColumnName("employee_id");

                    b.Property<string>("UnitId")
                        .HasColumnType("character varying(255)")
                        .HasColumnName("unit_id");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date")
                        .HasColumnName("end_date");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("start_date");

                    b.HasKey("EmployeeId", "UnitId")
                        .HasName("pk_unit_histories");

                    b.HasIndex("UnitId")
                        .HasDatabaseName("ix_unit_histories_unit_id");

                    b.ToTable("unit_histories", (string)null);
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.EmployeeQualification", b =>
                {
                    b.HasOne("Salary_management.Infrastructure.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_employee_qualifications_employees_employee_id");

                    b.HasOne("Salary_management.Infrastructure.Entities.Qualification", "Qualification")
                        .WithMany()
                        .HasForeignKey("QualificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_employee_qualifications_qualifications_qualification_id");

                    b.Navigation("Employee");

                    b.Navigation("Qualification");
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.Family", b =>
                {
                    b.HasOne("Salary_management.Infrastructure.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_families_employees_employee_id");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.Position", b =>
                {
                    b.HasOne("Salary_management.Infrastructure.Entities.Rank", "Rank")
                        .WithMany()
                        .HasForeignKey("RankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_positions_ranks_rank_id");

                    b.Navigation("Rank");
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.PositionHistory", b =>
                {
                    b.HasOne("Salary_management.Infrastructure.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_position_histories_employees_employee_id");

                    b.HasOne("Salary_management.Infrastructure.Entities.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_position_histories_positions_position_id");

                    b.Navigation("Employee");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.Qualification", b =>
                {
                    b.HasOne("Salary_management.Infrastructure.Entities.Expertise", "Expertise")
                        .WithMany()
                        .HasForeignKey("ExpertiseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_qualifications_expertise_expertise_id");

                    b.Navigation("Expertise");
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.QualificationAllowanceHistory", b =>
                {
                    b.HasOne("Salary_management.Infrastructure.Entities.Qualification", "Qualification")
                        .WithMany()
                        .HasForeignKey("QualificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_qualification_allowance_histories_qualifications_qualificat");

                    b.Navigation("Qualification");
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.RewardOrDiscipline", b =>
                {
                    b.HasOne("Salary_management.Infrastructure.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_reward_or_disciplines_employees_employee_id");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.UnionHistory", b =>
                {
                    b.HasOne("Salary_management.Infrastructure.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_union_history_employees_employee_id");

                    b.HasOne("Salary_management.Infrastructure.Entities.Union", "Union")
                        .WithMany()
                        .HasForeignKey("UnionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_union_history_unions_union_id");

                    b.Navigation("Employee");

                    b.Navigation("Union");
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.UnitHistory", b =>
                {
                    b.HasOne("Salary_management.Infrastructure.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_unit_histories_employees_employee_id");

                    b.HasOne("Salary_management.Infrastructure.Entities.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_unit_histories_units_unit_id");

                    b.Navigation("Employee");

                    b.Navigation("Unit");
                });
#pragma warning restore 612, 618
        }
    }
}
