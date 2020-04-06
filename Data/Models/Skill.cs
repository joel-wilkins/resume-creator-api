using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ResumeCreatorApi.Data.Models
{
    [Table("skill")]
    public class Skill : BaseModel
    {
        [Required]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [Column("skill_category_id")]
        public Guid SkillCategoryId { get; set; }

        [Required]
        [Column("skill_level_id")]
        public Guid SkillLevelId { get; set; }

        [Required]
        [Column("user_id")]
        public Guid UserId { get; set; }

        public SkillCategory SkillCategory { get; set; }

        public SkillLevel SkillLevel { get; set; }

        public User User { get; set; }

        public List<JobSkill> JobSkills { get; set; }

        public static void Configure(ModelBuilder builder)
        {
            BaseModel.Configure<Skill>(builder, s =>
            {
                s.HasIndex(s => s.SkillCategoryId);
                s.HasIndex(s => s.SkillLevelId);
                s.HasIndex(s => s.UserId);
            });
        }
    }
}