﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TDTU.API.Data;

#nullable disable

namespace TDTU.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240807114128_database-v7")]
    partial class databasev7
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("InternshipJobSkill", b =>
                {
                    b.Property<Guid>("InternshipJobsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SkillsId")
                        .HasColumnType("uuid");

                    b.HasKey("InternshipJobsId", "SkillsId");

                    b.HasIndex("SkillsId");

                    b.ToTable("InternshipJobSkill");
                });

            modelBuilder.Entity("RegularJobSkill", b =>
                {
                    b.Property<Guid>("RegularJobsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SkillsId")
                        .HasColumnType("uuid");

                    b.HasKey("RegularJobsId", "SkillsId");

                    b.HasIndex("SkillsId");

                    b.ToTable("RegularJobSkill");
                });

            modelBuilder.Entity("TDTU.API.Data.ApplicationStatus", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("LastModifiedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tb_application_status");
                });

            modelBuilder.Entity("TDTU.API.Data.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("LastModifiedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TaxCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tb_companies");
                });

            modelBuilder.Entity("TDTU.API.Data.InternshipJob", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("InternshipTermId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("LastModifiedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("InternshipTermId");

                    b.ToTable("tb_internship_jobs");
                });

            modelBuilder.Entity("TDTU.API.Data.InternshipJobApplication", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CV")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Company")
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("boolean");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Introduce")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("JobId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("LastModifiedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .HasColumnType("text");

                    b.Property<string>("StatusId")
                        .HasColumnType("text");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.HasIndex("StatusId");

                    b.HasIndex("StudentId");

                    b.ToTable("tb_internship_job_applications");
                });

            modelBuilder.Entity("TDTU.API.Data.InternshipOrder", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("LastModifiedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("RegistrationId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("StatusId")
                        .HasColumnType("text");

                    b.Property<string>("TaxCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RegistrationId");

                    b.HasIndex("StatusId");

                    b.ToTable("tb_internship_orders");
                });

            modelBuilder.Entity("TDTU.API.Data.InternshipRegistration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("InternshipTermId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("LastModifiedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("StatusId")
                        .HasColumnType("text");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("InternshipTermId");

                    b.HasIndex("StatusId");

                    b.HasIndex("StudentId");

                    b.ToTable("tb_internship_registrations");
                });

            modelBuilder.Entity("TDTU.API.Data.InternshipTerm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsExpired")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("LastModifiedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("tb_internship_terms");
                });

            modelBuilder.Entity("TDTU.API.Data.Media", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("boolean");

                    b.Property<string>("Extension")
                        .HasColumnType("text");

                    b.Property<Guid?>("LastModifiedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("OriginalName")
                        .HasColumnType("text");

                    b.Property<string>("PublicId")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tb_medias");
                });

            modelBuilder.Entity("TDTU.API.Data.OrderStatus", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("LastModifiedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tb_order_status");
                });

            modelBuilder.Entity("TDTU.API.Data.RegistrationStatus", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("LastModifiedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tb_registration_status");
                });

            modelBuilder.Entity("TDTU.API.Data.RegularJob", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid?>("LastModifiedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("SalaryMax")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SalaryMin")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("tb_regular_jobs");
                });

            modelBuilder.Entity("TDTU.API.Data.RegularJobApplication", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CV")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Company")
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("boolean");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Introduce")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("JobId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("LastModifiedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .HasColumnType("text");

                    b.Property<decimal?>("SalaryMax")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("SalaryMin")
                        .HasColumnType("numeric");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.HasIndex("StudentId");

                    b.ToTable("tb_regular_job_applications");
                });

            modelBuilder.Entity("TDTU.API.Data.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("LastModifiedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tb_roles");
                });

            modelBuilder.Entity("TDTU.API.Data.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("LastModifiedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sort")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tb_skills");
                });

            modelBuilder.Entity("TDTU.API.Data.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("boolean");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("LastModifiedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Major")
                        .HasColumnType("text");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("tb_students");
                });

            modelBuilder.Entity("TDTU.API.Data.StudentProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CreatedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("LastModifiedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uuid");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("tb_student_profiles");
                });

            modelBuilder.Entity("TDTU.API.Data.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("CreatedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("DeleteFlag")
                        .HasColumnType("boolean");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("LastModifiedApplicationUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("tb_users");
                });

            modelBuilder.Entity("InternshipJobSkill", b =>
                {
                    b.HasOne("TDTU.API.Data.InternshipJob", null)
                        .WithMany()
                        .HasForeignKey("InternshipJobsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TDTU.API.Data.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RegularJobSkill", b =>
                {
                    b.HasOne("TDTU.API.Data.RegularJob", null)
                        .WithMany()
                        .HasForeignKey("RegularJobsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TDTU.API.Data.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TDTU.API.Data.Company", b =>
                {
                    b.HasOne("TDTU.API.Data.User", "User")
                        .WithOne("Company")
                        .HasForeignKey("TDTU.API.Data.Company", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TDTU.API.Data.InternshipJob", b =>
                {
                    b.HasOne("TDTU.API.Data.Company", "Company")
                        .WithMany("InternshipJobs")
                        .HasForeignKey("CompanyId");

                    b.HasOne("TDTU.API.Data.InternshipTerm", "InternshipTerm")
                        .WithMany("Jobs")
                        .HasForeignKey("InternshipTermId");

                    b.Navigation("Company");

                    b.Navigation("InternshipTerm");
                });

            modelBuilder.Entity("TDTU.API.Data.InternshipJobApplication", b =>
                {
                    b.HasOne("TDTU.API.Data.InternshipJob", "Job")
                        .WithMany("Applications")
                        .HasForeignKey("JobId");

                    b.HasOne("TDTU.API.Data.ApplicationStatus", "Status")
                        .WithMany("InternshipJobApplications")
                        .HasForeignKey("StatusId");

                    b.HasOne("TDTU.API.Data.Student", "Student")
                        .WithMany("InternshipJobApplications")
                        .HasForeignKey("StudentId");

                    b.Navigation("Job");

                    b.Navigation("Status");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("TDTU.API.Data.InternshipOrder", b =>
                {
                    b.HasOne("TDTU.API.Data.InternshipRegistration", "Registration")
                        .WithMany("Orders")
                        .HasForeignKey("RegistrationId");

                    b.HasOne("TDTU.API.Data.OrderStatus", "Status")
                        .WithMany("Orders")
                        .HasForeignKey("StatusId");

                    b.Navigation("Registration");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("TDTU.API.Data.InternshipRegistration", b =>
                {
                    b.HasOne("TDTU.API.Data.InternshipTerm", "InternshipTerm")
                        .WithMany("Registrations")
                        .HasForeignKey("InternshipTermId");

                    b.HasOne("TDTU.API.Data.RegistrationStatus", "Status")
                        .WithMany("Registrations")
                        .HasForeignKey("StatusId");

                    b.HasOne("TDTU.API.Data.Student", "Student")
                        .WithMany("Registrations")
                        .HasForeignKey("StudentId");

                    b.Navigation("InternshipTerm");

                    b.Navigation("Status");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("TDTU.API.Data.RegularJob", b =>
                {
                    b.HasOne("TDTU.API.Data.Company", "Company")
                        .WithMany("RegularJobs")
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("TDTU.API.Data.RegularJobApplication", b =>
                {
                    b.HasOne("TDTU.API.Data.RegularJob", "Job")
                        .WithMany("Applications")
                        .HasForeignKey("JobId");

                    b.HasOne("TDTU.API.Data.Student", "Student")
                        .WithMany("RegularJobApplications")
                        .HasForeignKey("StudentId");

                    b.Navigation("Job");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("TDTU.API.Data.Student", b =>
                {
                    b.HasOne("TDTU.API.Data.User", "User")
                        .WithOne("Student")
                        .HasForeignKey("TDTU.API.Data.Student", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TDTU.API.Data.StudentProfile", b =>
                {
                    b.HasOne("TDTU.API.Data.Student", "Student")
                        .WithMany("Profiles")
                        .HasForeignKey("StudentId");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("TDTU.API.Data.User", b =>
                {
                    b.HasOne("TDTU.API.Data.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("TDTU.API.Data.ApplicationStatus", b =>
                {
                    b.Navigation("InternshipJobApplications");
                });

            modelBuilder.Entity("TDTU.API.Data.Company", b =>
                {
                    b.Navigation("InternshipJobs");

                    b.Navigation("RegularJobs");
                });

            modelBuilder.Entity("TDTU.API.Data.InternshipJob", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("TDTU.API.Data.InternshipRegistration", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("TDTU.API.Data.InternshipTerm", b =>
                {
                    b.Navigation("Jobs");

                    b.Navigation("Registrations");
                });

            modelBuilder.Entity("TDTU.API.Data.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("TDTU.API.Data.RegistrationStatus", b =>
                {
                    b.Navigation("Registrations");
                });

            modelBuilder.Entity("TDTU.API.Data.RegularJob", b =>
                {
                    b.Navigation("Applications");
                });

            modelBuilder.Entity("TDTU.API.Data.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("TDTU.API.Data.Student", b =>
                {
                    b.Navigation("InternshipJobApplications");

                    b.Navigation("Profiles");

                    b.Navigation("Registrations");

                    b.Navigation("RegularJobApplications");
                });

            modelBuilder.Entity("TDTU.API.Data.User", b =>
                {
                    b.Navigation("Company");

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
