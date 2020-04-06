using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ResumeCreatorApi.Data.Models
{
    [Table("job_skill")]
    public class JobSkill
    {
        [Column("job_id")]
        public Guid JobId { get; set; }

        [Column("skill_id")]
        public Guid SkillId { get; set; }

        public Job Job { get; set; }
        public Skill Skill { get; set; }

        public static void Configure(ModelBuilder builder)
        {
            builder.Entity<JobSkill>(js =>
            {
                js.HasKey(js => new { js.JobId, js.SkillId });
            });
        }
    }
}