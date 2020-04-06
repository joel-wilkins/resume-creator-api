using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ResumeCreatorApi.Data.Models
{
    [Table("job")]
    public class Job : BaseModel
    {
        [Required]
        [MaxLength(100)]
        [Column("employer")]
        public string Employer { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("role")]
        public string Role { get; set; }

        [MaxLength(100)]
        [Column("location")]
        public string Location { get; set; }

        [Required]
        [Column("start_date")]
        public DateTime StartDate { get; set; }

        [Column("end_date")]
        public DateTime EndDate { get; set; }

        [Required]
        [Column("user_id")]
        public Guid UserId { get; set; }

        public User User { get; set; }

        public List<JobSkill> JobSkills { get; set; }

        public List<JobExperience> JobExperiences { get; set; }

        public static void Configure(ModelBuilder builder)
        {
            BaseModel.Configure<Job>(builder, j =>
            {
                j.HasIndex(j => j.UserId);
            });
        }
    }
}