﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ResumeCreatorApi.Data;

namespace ResumeCreatorApi.Migrations
{
    [DbContext(typeof(ResumeCreatorContext))]
    [Migration("20200406021540_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.Bio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnName("biography")
                        .HasColumnType("character varying(400)")
                        .HasMaxLength(400);

                    b.Property<DateTimeOffset>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("deleted")
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("PhotoUrl")
                        .HasColumnName("photo_url")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("Updated")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("updated")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.HasKey("Id");

                    b.ToTable("bio");
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.Education", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnName("degree")
                        .HasColumnType("character varying(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("deleted")
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<float>("GradePointAverage")
                        .HasColumnName("grade_point_average")
                        .HasColumnType("real");

                    b.Property<string>("Institution")
                        .IsRequired()
                        .HasColumnName("institution")
                        .HasColumnType("character varying(125)")
                        .HasMaxLength(125);

                    b.Property<DateTimeOffset>("Updated")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("updated")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.HasKey("Id");

                    b.ToTable("education");
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.EducationExtra", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("deleted")
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<Guid>("EducationId")
                        .HasColumnName("education_id")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("character varying(250)")
                        .HasMaxLength(250);

                    b.Property<DateTimeOffset>("Updated")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("updated")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.HasKey("Id");

                    b.HasIndex("EducationId");

                    b.ToTable("education_extra");
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.Job", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("deleted")
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Employer")
                        .IsRequired()
                        .HasColumnName("employer")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("EndDate")
                        .HasColumnName("end_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Location")
                        .HasColumnName("location")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnName("role")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("StartDate")
                        .HasColumnName("start_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTimeOffset>("Updated")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("updated")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<Guid>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("job");
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.JobExperience", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("deleted")
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<Guid>("JobId")
                        .HasColumnName("job_id")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Updated")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("updated")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.ToTable("job_experience");
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.JobSkill", b =>
                {
                    b.Property<Guid>("JobId")
                        .HasColumnName("job_id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SkillId")
                        .HasColumnName("skill_id")
                        .HasColumnType("uuid");

                    b.HasKey("JobId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("job_skill");
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.Resume", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("BioId")
                        .HasColumnName("bio_id")
                        .HasColumnType("uuid");

                    b.Property<string>("Career")
                        .IsRequired()
                        .HasColumnName("career")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("deleted")
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<Guid>("DisplayEmailId")
                        .HasColumnName("display_email_id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("DisplayPhoneNumberId")
                        .HasColumnName("display_phone_number_id")
                        .HasColumnType("uuid");

                    b.Property<int>("ExperienceInYears")
                        .HasColumnName("experience_in_years")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("Updated")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("updated")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<Guid>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("BioId")
                        .IsUnique();

                    b.HasIndex("DisplayEmailId");

                    b.HasIndex("DisplayPhoneNumberId");

                    b.HasIndex("UserId");

                    b.ToTable("resume");
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("deleted")
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<Guid>("SkillCategoryId")
                        .HasColumnName("skill_category_id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SkillLevelId")
                        .HasColumnName("skill_level_id")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Updated")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("updated")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<Guid>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SkillCategoryId");

                    b.HasIndex("SkillLevelId");

                    b.HasIndex("UserId");

                    b.ToTable("skill");
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.SkillCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("deleted")
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("Updated")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("updated")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.HasKey("Id");

                    b.ToTable("skill_category");
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.SkillLevel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("deleted")
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<DateTimeOffset>("Updated")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("updated")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.HasKey("Id");

                    b.ToTable("skill_level");
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("deleted")
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .HasColumnName("middle_name")
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("Updated")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("updated")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.HasKey("Id");

                    b.ToTable("user");
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.UserEmail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("deleted")
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnName("email_address")
                        .HasColumnType("character varying(320)")
                        .HasMaxLength(320);

                    b.Property<DateTimeOffset>("Updated")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("updated")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<Guid>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("user_email");
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.UserPhoneNumber", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("uuid");

                    b.Property<int>("AreaCode")
                        .HasColumnName("area_code")
                        .HasColumnType("integer");

                    b.Property<int>("CountryCode")
                        .HasColumnName("country_code")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("created")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<bool>("Deleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("deleted")
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<int>("Extension")
                        .HasColumnName("extension")
                        .HasColumnType("integer");

                    b.Property<int>("PhoneNumber")
                        .HasColumnName("phone_number")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("Updated")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("updated")
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("now() at time zone 'utc'");

                    b.Property<Guid>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("user_phone_number");
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.EducationExtra", b =>
                {
                    b.HasOne("ResumeCreatorApi.Data.Models.Education", "Education")
                        .WithMany("EducationExtras")
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.Job", b =>
                {
                    b.HasOne("ResumeCreatorApi.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.JobExperience", b =>
                {
                    b.HasOne("ResumeCreatorApi.Data.Models.Job", "Job")
                        .WithMany("JobExperiences")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.JobSkill", b =>
                {
                    b.HasOne("ResumeCreatorApi.Data.Models.Job", "Job")
                        .WithMany("JobSkills")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResumeCreatorApi.Data.Models.Skill", "Skill")
                        .WithMany("JobSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.Resume", b =>
                {
                    b.HasOne("ResumeCreatorApi.Data.Models.Bio", "Bio")
                        .WithOne("Resume")
                        .HasForeignKey("ResumeCreatorApi.Data.Models.Resume", "BioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResumeCreatorApi.Data.Models.UserEmail", "UserEmail")
                        .WithMany()
                        .HasForeignKey("DisplayEmailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResumeCreatorApi.Data.Models.UserPhoneNumber", "UserPhoneNumber")
                        .WithMany()
                        .HasForeignKey("DisplayPhoneNumberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResumeCreatorApi.Data.Models.User", "User")
                        .WithMany("Resumes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.Skill", b =>
                {
                    b.HasOne("ResumeCreatorApi.Data.Models.SkillCategory", "SkillCategory")
                        .WithMany("Skills")
                        .HasForeignKey("SkillCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResumeCreatorApi.Data.Models.SkillLevel", "SkillLevel")
                        .WithMany("Skills")
                        .HasForeignKey("SkillLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ResumeCreatorApi.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.UserEmail", b =>
                {
                    b.HasOne("ResumeCreatorApi.Data.Models.User", "User")
                        .WithMany("Emails")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ResumeCreatorApi.Data.Models.UserPhoneNumber", b =>
                {
                    b.HasOne("ResumeCreatorApi.Data.Models.User", "User")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
