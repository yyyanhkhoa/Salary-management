﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Salary_management.Infrastructure;
using Salary_management.Infrastructure.Entities.Enums;

#nullable disable

namespace Salary_management.Migrations
{
    [DbContext(typeof(SalaryManContext))]
    [Migration("20220918163414_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresEnum(modelBuilder, "gender", new[] { "male", "female", "other" });
            NpgsqlModelBuilderExtensions.HasPostgresEnum(modelBuilder, "relative_type", new[] { "wife", "husband", "child" });
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

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

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.Position", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("id");

                    b.Property<int>("BaseSalary")
                        .HasColumnType("integer")
                        .HasColumnName("base_salary");

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
                    b.Property<string>("StaffId")
                        .HasColumnType("character varying(255)")
                        .HasColumnName("staff_id");

                    b.Property<string>("PositionId")
                        .HasColumnType("character varying(255)")
                        .HasColumnName("position_id");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date")
                        .HasColumnName("end_date");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("start_date");

                    b.HasKey("StaffId", "PositionId")
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

                    b.Property<int>("Allowance")
                        .HasColumnType("integer")
                        .HasColumnName("allowance");

                    b.Property<int>("ExpertiseId")
                        .HasColumnType("integer")
                        .HasColumnName("expertise_id");

                    b.Property<DateOnly>("IssueDate")
                        .HasColumnType("date")
                        .HasColumnName("issue_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.Property<string>("PlaceOfIssue")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("place_of_issue");

                    b.Property<float>("Score")
                        .HasColumnType("real")
                        .HasColumnName("score");

                    b.Property<string>("StaffId")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasColumnName("staff_id");

                    b.HasKey("Id")
                        .HasName("pk_qualifications");

                    b.HasIndex("ExpertiseId")
                        .HasDatabaseName("ix_qualifications_expertise_id");

                    b.HasIndex("StaffId")
                        .HasDatabaseName("ix_qualifications_staff_id");

                    b.ToTable("qualifications", (string)null);
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
                        .HasName("pk_rank");

                    b.ToTable("rank", (string)null);
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.Relative", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("occupation");

                    b.Property<RelativeType>("RelativeType")
                        .HasColumnType("relative_type")
                        .HasColumnName("relative_type");

                    b.Property<string>("StaffId")
                        .IsRequired()
                        .HasColumnType("character varying(255)")
                        .HasColumnName("staff_id");

                    b.HasKey("Id")
                        .HasName("pk_relatives");

                    b.HasIndex("StaffId")
                        .HasDatabaseName("ix_relatives_staff_id");

                    b.ToTable("relatives", (string)null);
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.Staff", b =>
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

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text")
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
                        .HasName("pk_staffs");

                    b.ToTable("staffs", (string)null);
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
                        .HasName("pk_union");

                    b.ToTable("union", (string)null);
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.UnionHistory", b =>
                {
                    b.Property<string>("StaffId")
                        .HasColumnType("character varying(255)")
                        .HasColumnName("staff_id");

                    b.Property<string>("UnionId")
                        .HasColumnType("character varying(255)")
                        .HasColumnName("union_id");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date")
                        .HasColumnName("end_date");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("start_date");

                    b.HasKey("StaffId", "UnionId")
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
                        .HasName("pk_unit");

                    b.ToTable("unit", (string)null);
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.UnitHistory", b =>
                {
                    b.Property<string>("StaffId")
                        .HasColumnType("character varying(255)")
                        .HasColumnName("staff_id");

                    b.Property<string>("UnitId")
                        .HasColumnType("character varying(255)")
                        .HasColumnName("unit_id");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date")
                        .HasColumnName("end_date");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date")
                        .HasColumnName("start_date");

                    b.HasKey("StaffId", "UnitId")
                        .HasName("pk_unit_histories");

                    b.HasIndex("UnitId")
                        .HasDatabaseName("ix_unit_histories_unit_id");

                    b.ToTable("unit_histories", (string)null);
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.Position", b =>
                {
                    b.HasOne("Salary_management.Infrastructure.Entities.Rank", "Rank")
                        .WithMany()
                        .HasForeignKey("RankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_positions_rank_rank_id");

                    b.Navigation("Rank");
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.PositionHistory", b =>
                {
                    b.HasOne("Salary_management.Infrastructure.Entities.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_position_histories_positions_position_id");

                    b.HasOne("Salary_management.Infrastructure.Entities.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_position_histories_staffs_staff_id");

                    b.Navigation("Position");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.Qualification", b =>
                {
                    b.HasOne("Salary_management.Infrastructure.Entities.Expertise", "Expertise")
                        .WithMany()
                        .HasForeignKey("ExpertiseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_qualifications_expertise_expertise_id");

                    b.HasOne("Salary_management.Infrastructure.Entities.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_qualifications_staffs_staff_id");

                    b.Navigation("Expertise");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.Relative", b =>
                {
                    b.HasOne("Salary_management.Infrastructure.Entities.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_relatives_staffs_staff_id");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.UnionHistory", b =>
                {
                    b.HasOne("Salary_management.Infrastructure.Entities.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_union_history_staffs_staff_id");

                    b.HasOne("Salary_management.Infrastructure.Entities.Union", "Union")
                        .WithMany()
                        .HasForeignKey("UnionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_union_history_union_union_id");

                    b.Navigation("Staff");

                    b.Navigation("Union");
                });

            modelBuilder.Entity("Salary_management.Infrastructure.Entities.UnitHistory", b =>
                {
                    b.HasOne("Salary_management.Infrastructure.Entities.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_unit_histories_staffs_staff_id");

                    b.HasOne("Salary_management.Infrastructure.Entities.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_unit_histories_unit_unit_id");

                    b.Navigation("Staff");

                    b.Navigation("Unit");
                });
#pragma warning restore 612, 618
        }
    }
}
