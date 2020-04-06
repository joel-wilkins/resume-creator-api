using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ResumeCreatorApi.Data.Models
{
    [Table("skill_level")]
    public class SkillLevel : BaseModel
    {
        [Required]
        [MaxLength(50)]
        [Column("name")]
        public string Name { get; set; }

        public List<Skill> Skills { get; set; }

        public static void Configure(ModelBuilder builder)
        {
            BaseModel.Configure<SkillLevel>(builder);
        }
    }
}