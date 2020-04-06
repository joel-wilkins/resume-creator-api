using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using ResumeCreatorApi.Data.Models;

namespace ResumeCreatorApi.Data
{
    public class ResumeCreatorContext : DbContext
    {
        public DbSet<Bio> Bios { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<EducationExtra> EducationExtras { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobExperience> JobExperiences { get; set; }
        public DbSet<JobSkill> JobSkills { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillCategory> SkillCategories { get; set; }
        public DbSet<SkillLevel> SkillLevels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserEmail> UserEmails { get; set; }
        public DbSet<UserPhoneNumber> UserPhoneNumbers { get; set; }

        public ResumeCreatorContext([NotNull] DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            Bio.Configure(builder);
            Education.Configure(builder);
            EducationExtra.Configure(builder);
            Job.Configure(builder);
            JobExperience.Configure(builder);
            JobSkill.Configure(builder);
            Resume.Configure(builder);
            Skill.Configure(builder);
            SkillCategory.Configure(builder);
            SkillLevel.Configure(builder);
            User.Configure(builder);
            UserEmail.Configure(builder);
            UserPhoneNumber.Configure(builder);
        }
    }
}